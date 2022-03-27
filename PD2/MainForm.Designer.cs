
namespace PD2
{
    partial class MainPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.AlgorithmName = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.TextInputField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyInputField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputField = new System.Windows.Forms.TextBox();
            this.ECBButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CBCButton = new System.Windows.Forms.Button();
            this.SaveToFile = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.AlgorithmName);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 75);
            this.panel1.TabIndex = 0;
            // 
            // AlgorithmName
            // 
            this.AlgorithmName.AutoSize = true;
            this.AlgorithmName.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlgorithmName.ForeColor = System.Drawing.Color.White;
            this.AlgorithmName.Location = new System.Drawing.Point(75, 0);
            this.AlgorithmName.Name = "AlgorithmName";
            this.AlgorithmName.Size = new System.Drawing.Size(360, 65);
            this.AlgorithmName.TabIndex = 0;
            this.AlgorithmName.Text = "AES Algorithm";
            // 
            // EncryptButton
            // 
            this.EncryptButton.BackColor = System.Drawing.Color.Silver;
            this.EncryptButton.FlatAppearance.BorderSize = 0;
            this.EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptButton.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EncryptButton.Location = new System.Drawing.Point(11, 419);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(175, 54);
            this.EncryptButton.TabIndex = 1;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = false;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.Color.Silver;
            this.DecryptButton.FlatAppearance.BorderSize = 0;
            this.DecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptButton.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecryptButton.ForeColor = System.Drawing.Color.Black;
            this.DecryptButton.Location = new System.Drawing.Point(307, 419);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(175, 54);
            this.DecryptButton.TabIndex = 2;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // TextInputField
            // 
            this.TextInputField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextInputField.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextInputField.Location = new System.Drawing.Point(11, 222);
            this.TextInputField.Multiline = true;
            this.TextInputField.Name = "TextInputField";
            this.TextInputField.Size = new System.Drawing.Size(470, 56);
            this.TextInputField.TabIndex = 3;
            this.TextInputField.TextChanged += new System.EventHandler(this.TextInputField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // KeyInputField
            // 
            this.KeyInputField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyInputField.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyInputField.Location = new System.Drawing.Point(11, 326);
            this.KeyInputField.Multiline = true;
            this.KeyInputField.Name = "KeyInputField";
            this.KeyInputField.Size = new System.Drawing.Size(470, 56);
            this.KeyInputField.TabIndex = 5;
            this.KeyInputField.TextChanged += new System.EventHandler(this.KeyInputField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Algorithm Output:";
            // 
            // OutputField
            // 
            this.OutputField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputField.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputField.Location = new System.Drawing.Point(12, 514);
            this.OutputField.Multiline = true;
            this.OutputField.Name = "OutputField";
            this.OutputField.Size = new System.Drawing.Size(470, 95);
            this.OutputField.TabIndex = 7;
            // 
            // ECBButton
            // 
            this.ECBButton.BackColor = System.Drawing.Color.Silver;
            this.ECBButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ECBButton.FlatAppearance.BorderSize = 0;
            this.ECBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ECBButton.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ECBButton.Location = new System.Drawing.Point(12, 117);
            this.ECBButton.Name = "ECBButton";
            this.ECBButton.Size = new System.Drawing.Size(174, 54);
            this.ECBButton.TabIndex = 1;
            this.ECBButton.Text = "ECB";
            this.ECBButton.UseVisualStyleBackColor = false;
            this.ECBButton.Click += new System.EventHandler(this.ECBButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Algorithm Mode:";
            // 
            // CBCButton
            // 
            this.CBCButton.BackColor = System.Drawing.Color.Silver;
            this.CBCButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CBCButton.FlatAppearance.BorderSize = 0;
            this.CBCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBCButton.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBCButton.Location = new System.Drawing.Point(307, 117);
            this.CBCButton.Name = "CBCButton";
            this.CBCButton.Size = new System.Drawing.Size(174, 54);
            this.CBCButton.TabIndex = 1;
            this.CBCButton.Text = "CBC";
            this.CBCButton.UseVisualStyleBackColor = false;
            this.CBCButton.Click += new System.EventHandler(this.CBCButton_Click);
            // 
            // SaveToFile
            // 
            this.SaveToFile.BackColor = System.Drawing.Color.Silver;
            this.SaveToFile.FlatAppearance.BorderSize = 0;
            this.SaveToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveToFile.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveToFile.Location = new System.Drawing.Point(11, 629);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.Size = new System.Drawing.Size(221, 54);
            this.SaveToFile.TabIndex = 9;
            this.SaveToFile.Text = "Save Decrypted";
            this.SaveToFile.UseVisualStyleBackColor = false;
            this.SaveToFile.Click += new System.EventHandler(this.SaveToFile_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.Silver;
            this.OpenFile.FlatAppearance.BorderSize = 0;
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenFile.Location = new System.Drawing.Point(261, 629);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(220, 54);
            this.OpenFile.TabIndex = 10;
            this.OpenFile.Text = "Open Decrypted";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 710);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.SaveToFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyInputField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextInputField);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.CBCButton);
            this.Controls.Add(this.ECBButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.panel1);
            this.Name = "MainPanel";
            this.Text = "AES Algorithm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AlgorithmName;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox TextInputField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyInputField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OutputField;
        private System.Windows.Forms.Button ECBButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CBCButton;
        private System.Windows.Forms.Button SaveToFile;
        private System.Windows.Forms.Button OpenFile;
    }
}

