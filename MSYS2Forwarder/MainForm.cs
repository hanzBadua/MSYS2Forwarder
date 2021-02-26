using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MSYS2Forwarder
{
    public partial class MainForm : Form
    {
        private const string msys2 = "MSYS2Forwarding";
        private const string cmd = "command";
        private static readonly string loc = $"\"{Program.CurrentExeLocation}\"";

        public MainForm()
        {
            InitializeComponent();
        }

        private void ChooseMinGW32RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb.Checked)
            {
                Program.Shell = "-mingw32";
            }
        }

        private void ChooseMSYSRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb.Checked)
            {
                Program.Shell = "-msys";
            }
        }

        private void ChooseMinGW64RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb.Checked)
            {
                Program.Shell = "-mingw64";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        { 
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            var startInfo = new ProcessStartInfo(Program.Msys2CmdPath)
            {
                UseShellExecute = false,
                Arguments = $"{Program.Shell} {Program.LaunchingDirectory}"
            };

            if (Program.IsAdmin)
                startInfo.Verb = "runas";

            Process.Start(startInfo);

            Environment.Exit(0);
        }

        private void AddContextMenuEntriesButton_Click(object sender, EventArgs e)
        {
            Program.AdminCheckForContextMenuEntries();
            using (var firstKey = Registry.ClassesRoot.OpenSubKey(@"Directory\Background\shell", RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                firstKey.CreateSubKey(msys2, RegistryKeyPermissionCheck.ReadWriteSubTree);

                using (var msys2key = firstKey.OpenSubKey(msys2, RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    msys2key.SetValue(null, "Open MSYS2 here", RegistryValueKind.ExpandString);
                    msys2key.SetValue("Icon", loc, RegistryValueKind.ExpandString);
                    msys2key.CreateSubKey(cmd, RegistryKeyPermissionCheck.ReadWriteSubTree);

                    using (var commandkey = msys2key.OpenSubKey(cmd, RegistryKeyPermissionCheck.ReadWriteSubTree))
                    {
                        commandkey.SetValue(null, loc + " \"%V\"", RegistryValueKind.ExpandString);
                    }
                }
            }

            using (var secondKey = Registry.ClassesRoot.OpenSubKey(@"Directory\shell", RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                secondKey.CreateSubKey(msys2, RegistryKeyPermissionCheck.ReadWriteSubTree);

                using (var msys2key = secondKey.OpenSubKey(msys2, RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    msys2key.SetValue(null, "Open MSYS2 here", RegistryValueKind.ExpandString);
                    msys2key.SetValue(@"Icon", loc, RegistryValueKind.ExpandString);
                    msys2key.CreateSubKey(cmd, RegistryKeyPermissionCheck.ReadWriteSubTree);

                    using (var commandkey = msys2key.OpenSubKey(cmd, RegistryKeyPermissionCheck.ReadWriteSubTree))
                    {
                        commandkey.SetValue(null, loc + " \"%V\"", RegistryValueKind.ExpandString);
                    }
                }
            }

            using (var lastKey = Registry.ClassesRoot.OpenSubKey(@"Drive\shell", RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                lastKey.CreateSubKey(msys2, true);

                using (var msys2key = lastKey.OpenSubKey(msys2, RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    msys2key.SetValue(null, "Open MSYS2 here", RegistryValueKind.ExpandString);
                    msys2key.SetValue(@"Icon", loc, RegistryValueKind.ExpandString);
                    msys2key.CreateSubKey(cmd, RegistryKeyPermissionCheck.ReadWriteSubTree);

                    using (var commandkey = msys2key.OpenSubKey(cmd, RegistryKeyPermissionCheck.ReadWriteSubTree))
                    {
                        commandkey.SetValue(null, loc + " \"%V\"", RegistryValueKind.ExpandString);
                    }
                }
            }
        }

        private void RemoveContextMenuEntriesButton_Click(object sender, EventArgs e)
        {
            Program.AdminCheckForContextMenuEntries();
            using (var firstKey = Registry.ClassesRoot.OpenSubKey(@"Directory\Background\shell", RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                firstKey.DeleteSubKeyTree(msys2, false);
            }

            using (var secondKey = Registry.ClassesRoot.OpenSubKey(@"Directory\shell", RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                secondKey.DeleteSubKeyTree(msys2, false);
            }

            using (var lastKey = Registry.ClassesRoot.OpenSubKey(@"Drive\shell", RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                lastKey.DeleteSubKeyTree(msys2, false);
            }
        }
    }
}
