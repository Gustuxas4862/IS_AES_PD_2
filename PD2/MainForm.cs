using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace PD2
{
    public partial class MainPanel : Form
    {
        private string inputText = "";
        private string keyInputText = "";
        private Algorithm newAlgorithm = new Algorithm();

        public MainPanel()
        {
            InitializeComponent();
            ECBButton.FlatAppearance.BorderSize = 3;
        }

        private void TextInputField_TextChanged(object sender, EventArgs e)
        {
            inputText = TextInputField.Text;
            newAlgorithm.SetInputText(inputText);
        }

        private void KeyInputField_TextChanged(object sender, EventArgs e)
        {
            keyInputText = KeyInputField.Text;
            newAlgorithm.SetPasswordText(keyInputText);
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (IsEmpty(inputText, keyInputText) || !IsKeyValid(keyInputText))
            {
                MessageBox.Show("All empty input fields must be filled and the key length must be 16 bytes long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OutputField.Text = Convert.ToBase64String(newAlgorithm.RunEncryptor());
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (IsEmpty(inputText, keyInputText) || !IsKeyValid(keyInputText))
            {
                MessageBox.Show("All empty input fields must be filled and the key length must be 16 bytes long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string output = newAlgorithm.RunDecryptor();
            string newLine = Environment.NewLine;
            OutputField.Text = "Decrypted Output In Base64 Encoding: " + newLine + Convert.ToBase64String(Encoding.ASCII.GetBytes(output)) + 
                newLine + "Decrypted Output In Text: " + newLine + output;
        }

        private bool IsEmpty(string inputField, string keyInputField)
        {
            if (inputField.Equals("") || keyInputField.Equals(""))
            {
                return true;
            }

            return false;
        }

        private bool IsKeyValid(string keyInputField)
        {
            int keyLength = keyInputField.ToCharArray().Length;
            if (keyLength == 16)
            {
                return true;
            }

            return false;
        }

        private void ResetButtonBorder()
        {
            CBCButton.FlatAppearance.BorderSize = 0;
            ECBButton.FlatAppearance.BorderSize = 0;
        }

        private void CBCButton_Click(object sender, EventArgs e)
        {
            ResetButtonBorder();
            CBCButton.FlatAppearance.BorderSize = 3;
            newAlgorithm.SetAlgorithMode(CipherMode.CBC);
        }

        private void ECBButton_Click(object sender, EventArgs e)
        {
            ResetButtonBorder();
            ECBButton.FlatAppearance.BorderSize = 3;
            newAlgorithm.SetAlgorithMode(CipherMode.ECB);
        }

        private void SaveToFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(openFileDialog.FileName, OutputField.Lines[OutputField.Lines.Length - 1]);
            }

            if (!openFileDialog.FileName.Equals(""))
            {
                MessageBox.Show("Data was loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Failed to load.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextInputField.Text = "";
                TextInputField.Text = File.ReadAllText(openFileDialog.FileName);
                OutputField.Text = "";

                if (!TextInputField.Text.Equals(""))
                {
                    MessageBox.Show("Selected file was successfully loaded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("Selected file failed to load. Maybe it's empty?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
