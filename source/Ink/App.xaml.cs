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
using System.Threading;
using System.Windows;
using System.Runtime.InteropServices;

namespace Ink
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // System
        public static string appDir = AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\') + @"\"; // exe directory

        [DllImport("Shlwapi.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public extern static bool PathFileExists(string path);

        // Generate Random Letter
        public static readonly Random rnd = new Random();

        // Allow key to strike only once
        public static bool strikeHold = false;


        // --------------------------------------------------
        // Keyboard Listener
        // --------------------------------------------------
        private Thread th = null;

        private KeyboardListener KListener = new KeyboardListener();

        // -------------------------
        // Application Startup
        // -------------------------
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            th = new Thread(() => RunKeyListener());
            th.IsBackground = true;
            th.Start();
            th.Join();
        }

        // -------------------------
        // Keyboard Listener Threaded Method
        // -------------------------
        private void RunKeyListener()
        {
            KListener.KeyDown += new RawKeyEventHandler(KListener_KeyDown);
            KListener.KeyUp += new RawKeyEventHandler(KListener_KeyUp);
        }



        // -------------------------
        // Key Up (Global)
        // -------------------------
        void KListener_KeyUp(object sender, RawKeyEventArgs args)
        {
            // Used for keys that don't repeat when held down
            // Shift Caps Lock, Esc
            App.strikeHold = false;
        }

        // -------------------------
        // Key Down (Global)
        // -------------------------
        void KListener_KeyDown(object sender, RawKeyEventArgs args)
        {
            // Note: Threading causes Crash

            Sound.KeyPressed(args);
        }


        // -------------------------
        // Application Exit
        // -------------------------
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            KListener.Dispose();

            // kill thread
            th.Abort();
        }

    }
}
