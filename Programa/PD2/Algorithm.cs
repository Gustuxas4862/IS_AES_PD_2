using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PD2
{
    public class Algorithm
    {
        private readonly byte[] initializationVector = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

        private string inputText;
        private string passwordText;

        private CipherMode cipherMode = CipherMode.ECB;

        public void SetInputText(string inputText)
        {
            this.inputText = inputText;
        }

        public void SetPasswordText(string passwordText)
        {
            this.passwordText = passwordText;
        }

        public void SetAlgorithMode(CipherMode cipherMode)
        {
            this.cipherMode = cipherMode;
        }

        public byte[] RunEncryptor()
        {
            try
            {
                using (Aes aesAlgorithm = Aes.Create())
                {
                    aesAlgorithm.Key = Encoding.UTF8.GetBytes(passwordText);
                    aesAlgorithm.IV = initializationVector;
                    aesAlgorithm.Mode = cipherMode;

                    ICryptoTransform newEncryptor = aesAlgorithm.CreateEncryptor(aesAlgorithm.Key, aesAlgorithm.IV);

                    using (MemoryStream dataStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(dataStream, newEncryptor, CryptoStreamMode.Write)) 
                        {
                            using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                            {
                                streamWriter.Write(inputText);
                            }

                            return dataStream.ToArray();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Encountered an error while ecrypting your message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public string RunDecryptor()
        {
            try
            {
                byte[] stringBytes = Convert.FromBase64String(inputText);

                using (Aes aesAlgorithm = Aes.Create())
                {
                    aesAlgorithm.Key = Encoding.UTF8.GetBytes(passwordText);
                    aesAlgorithm.IV = initializationVector;
                    aesAlgorithm.Mode = cipherMode;

                    ICryptoTransform newDecryptor = aesAlgorithm.CreateDecryptor(aesAlgorithm.Key, aesAlgorithm.IV);

                    using (MemoryStream dataStream = new MemoryStream(stringBytes))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(dataStream, newDecryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader streamReader = new StreamReader(cryptoStream))
                            {
                                return streamReader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error encountered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "";
            }
        }
    }
}
