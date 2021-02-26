using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;

namespace MSYS2Forwarder
{
    internal static class Program
    {
        public static string Shell { get; set; }
        public static string Msys2CmdPath { get; private set; }
        public static string LaunchingDirectory { get; private set; }
        public static readonly bool IsAdmin = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
        public static readonly string CurrentExeLocation = Assembly.GetExecutingAssembly().Location;

        public static void AdminCheckForContextMenuEntries()
        {
            if (!IsAdmin)
            {
                var res = MessageBox.Show("To add/remove context menu entries, this program needs to be 'Run as administrator'\r\nDo you want to restart as admin?", 
                    "MSYS2Forwarder: admin rights perms issue", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (res == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo(CurrentExeLocation)
                    {
                        UseShellExecute = true, 
                        Verb = "runas"
                    });

                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            // assign default values
            Msys2CmdPath = $@"C:\msys{(Environment.Is64BitOperatingSystem ? "64" : "32")}\msys2_shell.cmd";
            Shell = "-msys";

            // check if Msys2 exists
            // We can probably check this elsewhere via registry, but I assume most people have their msys2 installations
            // in the default paths due to the warning+many restrictions that the msys2 installer says when choosing a custom path
            if (!File.Exists(Msys2CmdPath))
            {
                MessageBox.Show("error: msys2_shell.cmd not found",
                    "MSYS2 Forwarder Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Alright, this was living hell to find out.
            // Basically, the context menu entry location parameter (%v)
            // returns -> ROOT:" when launching the context menu entry from the root of any drive
            // we need to foreach args to check for this, since the args.Length check is used for legit
            // path checking, and we can't simply index as we'll get an IndexOutOfRangeException for some dumb fucking reason
            // NOTE: won't work if your root drive isn't C D E F G, this is a lazy fix for now
            bool isDriveRoot = false;
            foreach (var i in args)
            {
                if (i == "C:\"" || i == "D:\"" || i == "E:\"" || i == "F:\"" || i == "G:\"")
                {
                    // ~/../../.. goes from home/currentUser location to the root of the drive
                    LaunchingDirectory = "-where ~/../../..";
                    isDriveRoot = true;
                }
            }

            // skip path check if we determined that the context menu entry was launching from a drive root
            if (args.Length != 0 && isDriveRoot == false)
            {
                if (!string.IsNullOrWhiteSpace(args[0]))
                    LaunchingDirectory = $"-where {Path.GetFullPath(args[0])}";
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
