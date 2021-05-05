using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMelody_
{
    static class GuessMelody
    {
        public static List<string> songs = new List<string>();
        public static int gameDuration = 0;
        public static int songDuration = 0;
        public static string lastFolder = string.Empty;
        public static bool randomStart = false;
        public static bool scanInnerDirectories = false;

        const string regKeyName = "Software\\MyCompanyName\\GuessMelody";


        public static void ReadMusic()
        {
            string[] musicFiles = Directory.GetFiles(lastFolder, "*.mp3", scanInnerDirectories ? System.IO.SearchOption.AllDirectories : System.IO.SearchOption.TopDirectoryOnly);

            songs.Clear();
            songs.AddRange(musicFiles);
        }

        public static void WriteParams()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null)
                    return;

                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("RandomStart", randomStart);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("SongDuration", songDuration);
                rk.SetValue("ScanInnerDirectories", scanInnerDirectories);
            }
            finally
            {
                if (rk != null)
                    rk.Close();
            }
        }

        public static void ReadParams()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk == null)
                    return;

                lastFolder = (string)rk.GetValue("LastFolder");
                randomStart = (bool)rk.GetValue("RandomStart");
                gameDuration = (int)rk.GetValue("GameDuration");
                songDuration = (int)rk.GetValue("SongDuration");
                scanInnerDirectories = (bool)rk.GetValue("ScanInnerDirectories");
            }
            finally
            {
                if (rk != null)
                    rk.Close();
            }
        }

    }
}
