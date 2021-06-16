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
        public static int gameDuration;
        public static int songDuration;
        public static string lastFolder;
        public static bool randomStart = false;
        public static bool scanInnerDirectories = false;
        public static bool voicePlayerName = false;
        public static bool instructionWasShown = false;
        public static bool bonusForAnswers = false;
        public static bool reducePoints = false;

        public static string player1AnswerKey;
        public static string player2AnswerKey;
        public static string player1Name;
        public static string player2Name;

        public static string answer;

        const string regKeyName = "Software\\MyCompanyName\\GuessMelody";


        public static void ReadMusic()
        {
            songs.Clear();

            if (!string.IsNullOrEmpty(lastFolder))
            {
                string[] musicFiles = Directory.GetFiles(lastFolder, "*.mp3", scanInnerDirectories ? System.IO.SearchOption.AllDirectories : System.IO.SearchOption.TopDirectoryOnly);
                songs.AddRange(musicFiles);
            }
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
                rk.SetValue("InstructionWasShown", true);
                rk.SetValue("AnswerBonus", bonusForAnswers);
                rk.SetValue("ReducePoints", reducePoints);                
                rk.SetValue("VoicePlayerName", voicePlayerName);
                rk.SetValue("Player1Name", player1Name);
                rk.SetValue("Player2Name", player2Name);
                rk.SetValue("Player1AnswerKey", player1AnswerKey);
                rk.SetValue("Player2AnswerKey", player2AnswerKey);

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
                randomStart = Convert.ToBoolean(rk.GetValue("RandomStart"));
                gameDuration = (int)rk.GetValue("GameDuration");
                songDuration = (int)rk.GetValue("SongDuration");
                scanInnerDirectories = Convert.ToBoolean(rk.GetValue("ScanInnerDirectories"));
                instructionWasShown = Convert.ToBoolean(rk.GetValue("InstructionWasShown"));
                voicePlayerName = Convert.ToBoolean(rk.GetValue("VoicePlayerName"));
                bonusForAnswers = Convert.ToBoolean(rk.GetValue("AnswerBonus"));
                reducePoints = Convert.ToBoolean(rk.GetValue("ReducePoints"));
                player1Name = (string)rk.GetValue("Player1Name") ?? "Игрок 1";
                player2Name = (string)rk.GetValue("Player2Name") ?? "Игрок 2";
                player1AnswerKey = (string)rk.GetValue("Player1AnswerKey") ?? "A";
                player2AnswerKey = (string)rk.GetValue("Player2AnswerKey") ?? "L";

                ReadMusic();
            }
            finally
            {
                if (rk != null)
                    rk.Close();
            }
        }

    }
}
