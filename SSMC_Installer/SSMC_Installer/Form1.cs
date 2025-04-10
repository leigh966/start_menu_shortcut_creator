using System.IO;
using System.Xml.Linq;
using Microsoft.Win32;

namespace SSMC_Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // open directory dialog
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.InitialDirectory = Directory.GetParent(txtDestination.Text).ToString();
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    txtDestination.Text = dialog.SelectedPath+"\\SMSC";
                }
            }
        }

        private void SetControlsEnabled(bool enabled)
        {
            txtDestination.Enabled = enabled;
            btnBrowse.Enabled = enabled;
            btnInstall.Enabled = enabled;
        }

        private void CopyFiles(string sourceDirectory, string destinationDirectory)
        {
            foreach(string filePath in Directory.GetFiles(sourceDirectory))
            {
                File.Copy(filePath, filePath.Replace(sourceDirectory, destinationDirectory), true);
            }
        }

        private void CreateRegistryKeys()
        {
            const string shellDirectory = "SOFTWARE\\Classes\\*\\shell\\smscas";
            RegistryKey parentKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(shellDirectory, true);
            parentKey.SetValue("", "Create Start Menu Shortcut As...");
            RegistryKey commandKey = parentKey.CreateSubKey("command", true);


            string command = "powershell -File \"" + txtDestination.Text + "\\smscas.ps1\" \"%V\"";
            commandKey.SetValue("", command);
        }

        // enable controls when this finishes if the form is still open
        private void btnInstall_Click(object sender, EventArgs e)
        {
            // disable controls
            SetControlsEnabled(false);

            try
            {
                // if directory does not exist
                if (!Directory.Exists(txtDestination.Text))
                {
                    // create it
                    Directory.CreateDirectory(txtDestination.Text);
                }

                // fetch the files?
                const string payloadPath = "F:\\Work\\Programming\\poweshell\\start_menu_shortcut_creator\\payload"; // change this!

                // copy the files into the directory
                CopyFiles(payloadPath, txtDestination.Text);

                // create the environment variable
                Environment.SetEnvironmentVariable("START_MENU_SHORTCUT_CREATOR", txtDestination.Text, EnvironmentVariableTarget.Machine);

                // create the registry keys
                CreateRegistryKeys();


                MessageBox.Show("Done.");
                Close();
            }
            catch (Exception ex) 
            {
                // output error
                MessageBox.Show(ex.Message);

                // enable the controls
                SetControlsEnabled(true);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDestination.Text = "C:\\Program Files\\SMSC";
        }
    }
}
