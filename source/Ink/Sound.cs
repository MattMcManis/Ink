/* ----------------------------------------------------------------------
Ink
Copyright (C) 2018 Matt McManis
http://github.com/MattMcManis/Ink

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.If not, see <http://www.gnu.org/licenses/>. 
---------------------------------------------------------------------- */

using System;
using System.Windows.Input;
using NAudio.Wave;

namespace Ink
{
    public partial class Sound
    {
        // Media
        public static WaveFileReader wav = null;
        public static WaveOutEvent output = null;

        // Volume
        public static double volume = 0;

        // -------------------------
        // Sounds
        // -------------------------
        private static string wavTab = "Sounds\\tab.wav";

        // Characters
        private static string wavKey = string.Empty;
        private static string wavKey1 = "Sounds\\key_1.wav";
        private static string wavKey2 = "Sounds\\key_2.wav";
        private static string wavKey3 = "Sounds\\key_3.wav";
        private static string wavKey4 = "Sounds\\key_4.wav";
        private static string wavKey5 = "Sounds\\key_5.wav";
        private static string wavKey6 = "Sounds\\key_6.wav";
        private static string wavKey7 = "Sounds\\key_7.wav";
        private static string wavKey8 = "Sounds\\key_8.wav";
        private static string wavKey9 = "Sounds\\key_9.wav";
        private static string wavKey10 = "Sounds\\key_10.wav";
        private static string wavKey11 = "Sounds\\key_11.wav";
        private static string wavKey12 = "Sounds\\key_12.wav";
        private static string wavKey13 = "Sounds\\key_13.wav";
        private static string wavKey14 = "Sounds\\key_14.wav";
        private static string wavKey15 = "Sounds\\key_15.wav";
        private static string wavKey16 = "Sounds\\key_16.wav";
        private static string wavKey17 = "Sounds\\key_17.wav";
        private static string wavKey18 = "Sounds\\key_18.wav";

        private static string[] arrWavChar = new string[]
        {
            wavKey1,
            wavKey2,
            wavKey3,
            wavKey4,
            wavKey5,
            wavKey6,
            wavKey7,
            wavKey8,
            wavKey9,
            wavKey10,
            wavKey11,
            wavKey12,
            wavKey13,
            wavKey14,
            wavKey15,
            wavKey16,
            wavKey17,
            wavKey18,
        };


        // Modifiers
        private static string wavMod = string.Empty;
        private static string wavMod1 = "Sounds\\mod_1.wav";
        private static string wavMod2 = "Sounds\\mod_2.wav";
        private static string wavMod3 = "Sounds\\mod_3.wav";

        private static string[] arrWavMod = new string[]
        {
            wavMod1,
            wavMod2,
            wavMod3,
        };


        // Spacebar
        private static string wavSpace = string.Empty;
        private static string wavSpace1 = "Sounds\\space_1.wav";
        private static string wavSpace2 = "Sounds\\space_2.wav";
        private static string wavSpace3 = "Sounds\\space_3.wav";
        private static string wavSpace4 = "Sounds\\space_4.wav";
        private static string wavSpace5 = "Sounds\\space_5.wav";

        private static string[] arrWavSpace = new string[]
        {
            wavSpace1,
            wavSpace2,
            wavSpace3,
            wavSpace4,
            wavSpace5,
        };


        // Return
        private static string wavEnter = string.Empty;
        private static string wavEnter1 = "Sounds\\enter_1.wav";
        private static string wavEnter2 = "Sounds\\enter_2.wav";
        private static string wavEnter3 = "Sounds\\enter_3.wav";

        private static string[] arrWavEnter = new string[]
        {
            wavEnter1,
            wavEnter2,
            wavEnter3,
        };


        // Escape
        private static string wavEscape = string.Empty;
        private static string wavEscape1 = "Sounds\\esc_1.wav";
        private static string wavEscape2 = "Sounds\\esc_2.wav";

        private static string[] arrWavEscape = new string[]
        {
            wavEscape1,
            wavEscape2,
        };



        // -------------------------
        // Play Sounds
        // -------------------------
        public static void PlaySound(string sound)
        {
            wav = new WaveFileReader(sound);

            output = new WaveOutEvent();
            output.PlaybackStopped -= new EventHandler<StoppedEventArgs>(Media_Ended);
            output.NumberOfBuffers = 3;
            output.DesiredLatency = 500;
            output.Volume = (float)(volume);
            output.Init(wav);
            output.Play();
        }


        // -------------------------
        // Key Pressed
        // -------------------------
        public static void KeyPressed(RawKeyEventArgs args)
        {
            // -------------------------
            // Letters
            // -------------------------
            if (args.Key >= Key.A && args.Key <= Key.Z)
            {
                // randomize
                wavKey = arrWavChar[App.rnd.Next(arrWavChar.Length)];

                if (args.Key == Key.A) { PlaySound(wavKey6); }
                else if (args.Key == Key.B) { PlaySound(wavKey1); }
                else if (args.Key == Key.C) { PlaySound(wavKey3); }
                else if (args.Key == Key.D) { PlaySound(wavKey4); }
                else if (args.Key == Key.E) { PlaySound(wavKey5); }
                else if (args.Key == Key.F) { PlaySound(wavKey6); }
                else if (args.Key == Key.G) { PlaySound(wavKey7); }
                else if (args.Key == Key.H) { PlaySound(wavKey8); }
                else if (args.Key == Key.I) { PlaySound(wavKey10); }
                else if (args.Key == Key.J) { PlaySound(wavKey16); }
                else if (args.Key == Key.K) { PlaySound(wavKey11); }
                else if (args.Key == Key.L) { PlaySound(wavKey12); }
                else if (args.Key == Key.M) { PlaySound(wavKey13); }
                else if (args.Key == Key.N) { PlaySound(wavKey14); }
                else if (args.Key == Key.O) { PlaySound(wavKey15); }
                else if (args.Key == Key.P) { PlaySound(wavKey16); }
                else if (args.Key == Key.Q) { PlaySound(wavKey4); }
                else if (args.Key == Key.R) { PlaySound(wavKey5); }
                else if (args.Key == Key.S) { PlaySound(wavKey1); }
                else if (args.Key == Key.T) { PlaySound(wavKey18); }
                else if (args.Key == Key.U) { PlaySound(wavKey17); }
                else if (args.Key == Key.V) { PlaySound(wavKey10); }
                else if (args.Key == Key.W) { PlaySound(wavKey9); }
                else if (args.Key == Key.X) { PlaySound(wavKey11); }
                else if (args.Key == Key.Y) { PlaySound(wavKey12); }
                else if (args.Key == Key.Z) { PlaySound(wavKey13); }
                else { PlaySound(wavKey); }
            }
            // -------------------------
            // Numbers
            // -------------------------
            else if (args.Key >= Key.D0 && args.Key <= Key.D9)
            {
                // randomize
                wavKey = arrWavChar[App.rnd.Next(arrWavChar.Length)];

                if (args.Key == Key.D1) { PlaySound(wavKey6); }
                else if (args.Key == Key.D2) { PlaySound(wavKey2); }
                else if (args.Key == Key.D3) { PlaySound(wavKey3); }
                else if (args.Key == Key.D4) { PlaySound(wavKey4); }
                else if (args.Key == Key.D5) { PlaySound(wavKey5); }
                else if (args.Key == Key.D6) { PlaySound(wavKey6); }
                else if (args.Key == Key.D7) { PlaySound(wavKey7); }
                else if (args.Key == Key.D8) { PlaySound(wavKey1); }
                else if (args.Key == Key.D9) { PlaySound(wavKey14); }
                else if (args.Key == Key.D0) { PlaySound(wavKey13); }
                else { PlaySound(wavKey); }
            }

            // -------------------------
            // Numpad
            // -------------------------
            else if (args.Key >= Key.NumPad0 && args.Key <= Key.NumPad9)
            {
                // randomize
                wavKey = arrWavChar[App.rnd.Next(arrWavChar.Length)];

                PlaySound(wavKey);
            }

            // -------------------------
            // Math Operators
            // -------------------------
            else if (args.Key == Key.Subtract
            || args.Key == Key.Add
            || args.Key == Key.Decimal
            || args.Key == Key.Divide
            || args.Key == Key.Multiply)
            {
                // randomize
                wavKey = arrWavChar[App.rnd.Next(arrWavChar.Length)];

                PlaySound(wavKey);
            }

            // -------------------------
            // Punctuation
            // -------------------------
            else if (args.Key == Key.OemPlus
                || args.Key == Key.OemMinus
                || args.Key == Key.OemQuestion
                || args.Key == Key.OemComma
                || args.Key == Key.OemPeriod
                || args.Key == Key.OemOpenBrackets
                || args.Key == Key.OemQuotes
                || args.Key == Key.Oem1
                || args.Key == Key.Oem3
                || args.Key == Key.Oem5
                || args.Key == Key.Oem6)
            {
                // randomize
                wavKey = arrWavChar[App.rnd.Next(arrWavChar.Length)];

                PlaySound(wavKey);
            }

            // -------------------------
            // Space
            // -------------------------
            else if (args.Key == Key.Space)
            {
                // randomize
                wavSpace = arrWavSpace[App.rnd.Next(arrWavSpace.Length)];

                PlaySound(wavSpace);
            }

            // -------------------------
            // Modifiers
            // -------------------------
            // Shift (Strike Hold)
            else if (args.Key == Key.LeftShift
                || args.Key == Key.RightShift
                || args.Key == Key.CapsLock)
            {
                while (App.strikeHold == false)
                {
                    // randomize
                    wavMod = arrWavMod[App.rnd.Next(arrWavMod.Length)];

                    PlaySound(wavMod);

                    App.strikeHold = true;
                }
            }

            // -------------------------
            // Tab
            // -------------------------
            else if (args.Key == Key.Tab)
            {
                PlaySound(wavTab);
            }

            // -------------------------
            // Backspace
            // -------------------------
            else if (args.Key == Key.Back)
            {
                // randomize
                wavMod = arrWavMod[App.rnd.Next(arrWavMod.Length)];

                PlaySound(wavMod);
            }
            // -------------------------
            // Enter
            // -------------------------
            else if (args.Key == Key.Enter)
            {
                // randomize
                wavEnter = arrWavEnter[App.rnd.Next(arrWavEnter.Length)];

                PlaySound(wavEnter);
            }

            // -------------------------
            // Escape
            // -------------------------
            else if (args.Key == Key.Escape)
            {
                while (App.strikeHold == false)
                {
                    // randomize
                    wavEscape = arrWavEscape[App.rnd.Next(arrWavEscape.Length)];

                    PlaySound(wavEscape);

                    App.strikeHold = true;
                }
            }
        }


        // -------------------------
        // Media Ended
        // -------------------------
        public static void Media_Ended(object sender, EventArgs e)
        {
            if (output.PlaybackState == PlaybackState.Stopped)
            {
                wav = null;
                output = null;
            }
        }


    }
}
