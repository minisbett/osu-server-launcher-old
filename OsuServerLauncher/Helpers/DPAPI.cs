using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OsuServerLauncher.Helpers
{
  public class DPAPI
  {
    [DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    private static extern bool CryptProtectData(ref DATA_BLOB pPlainText, string szDescription, ref DATA_BLOB pEntropy, IntPtr pReserved, ref CRYPTPROTECT_PROMPTSTRUCT pPrompt, int dwFlags, ref DATA_BLOB pCipherText);

    [DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern bool CryptUnprotectData(ref DPAPI.DATA_BLOB pCipherText, ref string pszDescription, ref DPAPI.DATA_BLOB pEntropy, IntPtr pReserved, ref DPAPI.CRYPTPROTECT_PROMPTSTRUCT pPrompt, int dwFlags, ref DPAPI.DATA_BLOB pPlainText);

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct DATA_BLOB
    {
      public int cbData;
      public IntPtr pbData;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct CRYPTPROTECT_PROMPTSTRUCT
    {
      public int cbSize;
      public int dwPromptFlags;
      public IntPtr hwndApp;
      public string szPrompt;
    }

    private const int CRYPTPROTECT_UI_FORBIDDEN = 0x1;
    private const int CRYPTPROTECT_LOCAL_MACHINE = 0x4;

    public enum KeyType
    {
      UserKey = 1,
      MachineKey
    }

    private static void InitPrompt(ref CRYPTPROTECT_PROMPTSTRUCT ps)
    {
      ps.cbSize = Marshal.SizeOf(typeof(CRYPTPROTECT_PROMPTSTRUCT));
      ps.dwPromptFlags = 0;
      ps.hwndApp = IntPtr.Zero;
      ps.szPrompt = null;
    }

    private static void InitBLOB(byte[] data, ref DATA_BLOB blob)
    {
      if (data == null)
        data = new byte[0];

      blob.pbData = Marshal.AllocHGlobal(data.Length);

      if (blob.pbData == IntPtr.Zero)
        throw new Exception("Unable to allocate data buffer for BLOB structure.");

      blob.cbData = data.Length;
      Marshal.Copy(data, 0, blob.pbData, data.Length);
    }

    public static string Encrypt(KeyType key, string plain, string entropy, string description)
    {
      plain = plain ?? "";
      entropy = entropy ?? "";

      return Convert.ToBase64String(Encrypt(key, Encoding.UTF8.GetBytes(plain), Encoding.UTF8.GetBytes(entropy), description));
    }
 
    public static byte[] Encrypt(KeyType key, byte[] plain, byte[] entropy, string description)
    {
      plain ??= new byte[0];
      entropy ??= new byte[0];
      description ??= "";

      DATA_BLOB plainBlob = new DATA_BLOB();
      DATA_BLOB cipherBlob = new DATA_BLOB();
      DATA_BLOB entropyBlob = new DATA_BLOB();
      CRYPTPROTECT_PROMPTSTRUCT prompt = new CRYPTPROTECT_PROMPTSTRUCT();
      InitPrompt(ref prompt);

      try
      {
        InitBLOB(plain, ref plainBlob);
      }
      catch (Exception ex)
      {
        throw new Exception("Cannot initialize plaintext BLOB.", ex);
      }

      try
      {
        InitBLOB(entropy, ref entropyBlob);
      }
      catch (Exception ex)
      {
        throw new Exception("Cannot initialize entropy BLOB.", ex);
      }

      try
      {
        int flags = key == KeyType.MachineKey ? CRYPTPROTECT_UI_FORBIDDEN | CRYPTPROTECT_LOCAL_MACHINE : CRYPTPROTECT_UI_FORBIDDEN;
        bool success = CryptProtectData(ref plainBlob, description, ref entropyBlob, IntPtr.Zero, ref prompt, flags, ref cipherBlob);

        if (!success)
          throw new Exception("CryptProtectData failed.", new Win32Exception(Marshal.GetLastWin32Error()));

        byte[] cipher = new byte[cipherBlob.cbData];

        Marshal.Copy(cipherBlob.pbData, cipher, 0, cipherBlob.cbData);

        return cipher;
      }
      catch (Exception ex)
      {
        throw new Exception("DPAPI was unable to encrypt data.", ex);
      }
      finally
      {
        if (plainBlob.pbData != IntPtr.Zero)
          Marshal.FreeHGlobal(plainBlob.pbData);

        if (cipherBlob.pbData != IntPtr.Zero)
          Marshal.FreeHGlobal(cipherBlob.pbData);

        if (entropyBlob.pbData != IntPtr.Zero)
          Marshal.FreeHGlobal(entropyBlob.pbData);
      }
    }
  }
}
