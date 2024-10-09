using System.Diagnostics;

namespace RandomFileOpener
{
    public partial class RandomFileOpenerForm : Form
    {
        private string selectedFolderPath = string.Empty;
        private string configFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RandomFileOpener", "config.txt");

        public RandomFileOpenerForm()
        {
            InitializeComponent();
            LoadLastUsedFolder();
        }

        private void LoadLastUsedFolder()
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    selectedFolderPath = File.ReadAllText(configFilePath);
                    folderPathLabel.Text = selectedFolderPath;  // Display the previously used folder path
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load last used folder path: {ex.Message}");
            }
        }

        private void SaveLastUsedFolder()
        {
            try
            {
                string folder = Path.GetDirectoryName(configFilePath);
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                File.WriteAllText(configFilePath, selectedFolderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save folder path: {ex.Message}");
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFolderPath = folderDialog.SelectedPath;
                    folderPathLabel.Text = selectedFolderPath;  // Display the selected folder path
                    SaveLastUsedFolder();
                }
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFolderPath))
            {
                MessageBox.Show("Please select a folder first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get all files in the folder
                var files = Directory.GetFiles(selectedFolderPath);

                if (files.Length == 0)
                {
                    MessageBox.Show("The selected folder is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Pick a random file
                Random random = new Random();
                int randomIndex = random.Next(files.Length);
                string randomFile = files[randomIndex];

                // Open or execute the random file using the default associated application
                ProcessStartInfo psi = new ProcessStartInfo(randomFile)
                {
                    UseShellExecute = true // Use the shell to open the file with the default program
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
