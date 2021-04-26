
namespace MultiLayered_Encryptor_App {
    partial class App {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label_InputText = new System.Windows.Forms.Label();
            this.label_OutputText = new System.Windows.Forms.Label();
            this.textBox_InputText = new System.Windows.Forms.TextBox();
            this.textBox_OutputText = new System.Windows.Forms.TextBox();
            this.button_Transform = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_MLE = new System.Windows.Forms.Label();
            this.comboBox_TypeToPerform = new System.Windows.Forms.ComboBox();
            this.comboBox_Algorithm = new System.Windows.Forms.ComboBox();
            this.comboBox_MLEBits = new System.Windows.Forms.ComboBox();
            this.label_ProcessTracker = new System.Windows.Forms.Label();
            this.label_KeyForDecrypt = new System.Windows.Forms.Label();
            this.textBox_KeyToDecrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_KeyAfterEncrypt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_InputText
            // 
            this.label_InputText.AutoSize = true;
            this.label_InputText.BackColor = System.Drawing.Color.Transparent;
            this.label_InputText.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_InputText.Location = new System.Drawing.Point(14, 108);
            this.label_InputText.Name = "label_InputText";
            this.label_InputText.Size = new System.Drawing.Size(159, 24);
            this.label_InputText.TabIndex = 0;
            this.label_InputText.Text = "Enter your text:";
            // 
            // label_OutputText
            // 
            this.label_OutputText.AutoSize = true;
            this.label_OutputText.BackColor = System.Drawing.Color.Transparent;
            this.label_OutputText.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_OutputText.Location = new System.Drawing.Point(14, 331);
            this.label_OutputText.Name = "label_OutputText";
            this.label_OutputText.Size = new System.Drawing.Size(83, 24);
            this.label_OutputText.TabIndex = 1;
            this.label_OutputText.Text = "Result: ";
            // 
            // textBox_InputText
            // 
            this.textBox_InputText.Location = new System.Drawing.Point(14, 135);
            this.textBox_InputText.Multiline = true;
            this.textBox_InputText.Name = "textBox_InputText";
            this.textBox_InputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_InputText.Size = new System.Drawing.Size(678, 179);
            this.textBox_InputText.TabIndex = 4;
            this.textBox_InputText.Text = "Text Box";
            // 
            // textBox_OutputText
            // 
            this.textBox_OutputText.Location = new System.Drawing.Point(14, 361);
            this.textBox_OutputText.Multiline = true;
            this.textBox_OutputText.Name = "textBox_OutputText";
            this.textBox_OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_OutputText.Size = new System.Drawing.Size(678, 161);
            this.textBox_OutputText.TabIndex = 5;
            this.textBox_OutputText.Text = "Text Box 2";
            // 
            // button_Transform
            // 
            this.button_Transform.Location = new System.Drawing.Point(545, 528);
            this.button_Transform.Name = "button_Transform";
            this.button_Transform.Size = new System.Drawing.Size(146, 41);
            this.button_Transform.TabIndex = 6;
            this.button_Transform.Text = "Transform";
            this.button_Transform.UseVisualStyleBackColor = true;
            this.button_Transform.Click += new System.EventHandler(this.button_Transform_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(354, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Algorithm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(14, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Do";
            // 
            // label_MLE
            // 
            this.label_MLE.AutoSize = true;
            this.label_MLE.BackColor = System.Drawing.Color.Transparent;
            this.label_MLE.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_MLE.Location = new System.Drawing.Point(354, 60);
            this.label_MLE.Name = "label_MLE";
            this.label_MLE.Size = new System.Drawing.Size(255, 24);
            this.label_MLE.TabIndex = 11;
            this.label_MLE.Text = "Multi-Layered Encryption:";
            // 
            // comboBox_TypeToPerform
            // 
            this.comboBox_TypeToPerform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TypeToPerform.FormattingEnabled = true;
            this.comboBox_TypeToPerform.Items.AddRange(new object[] {
            "Encrypt",
            "Decrypt"});
            this.comboBox_TypeToPerform.Location = new System.Drawing.Point(73, 18);
            this.comboBox_TypeToPerform.Name = "comboBox_TypeToPerform";
            this.comboBox_TypeToPerform.Size = new System.Drawing.Size(109, 28);
            this.comboBox_TypeToPerform.TabIndex = 13;
            // 
            // comboBox_Algorithm
            // 
            this.comboBox_Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Algorithm.FormattingEnabled = true;
            this.comboBox_Algorithm.Items.AddRange(new object[] {
            "AES-Advanced Encryption Standard",
            "Multi-Layered Encryption"});
            this.comboBox_Algorithm.Location = new System.Drawing.Point(468, 14);
            this.comboBox_Algorithm.Name = "comboBox_Algorithm";
            this.comboBox_Algorithm.Size = new System.Drawing.Size(224, 28);
            this.comboBox_Algorithm.Sorted = true;
            this.comboBox_Algorithm.TabIndex = 14;
            // 
            // comboBox_MLEBits
            // 
            this.comboBox_MLEBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MLEBits.FormattingEnabled = true;
            this.comboBox_MLEBits.Items.AddRange(new object[] {
            "2 bit",
            "4 bit",
            "8 bit",
            "16 bit",
            "32 bit"});
            this.comboBox_MLEBits.Location = new System.Drawing.Point(615, 56);
            this.comboBox_MLEBits.Name = "comboBox_MLEBits";
            this.comboBox_MLEBits.Size = new System.Drawing.Size(77, 28);
            this.comboBox_MLEBits.TabIndex = 15;
            // 
            // label_ProcessTracker
            // 
            this.label_ProcessTracker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_ProcessTracker.BackColor = System.Drawing.Color.Transparent;
            this.label_ProcessTracker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ProcessTracker.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label_ProcessTracker.Location = new System.Drawing.Point(139, 535);
            this.label_ProcessTracker.Name = "label_ProcessTracker";
            this.label_ProcessTracker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_ProcessTracker.Size = new System.Drawing.Size(387, 24);
            this.label_ProcessTracker.TabIndex = 16;
            this.label_ProcessTracker.Text = "Processed in ";
            this.label_ProcessTracker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_ProcessTracker.Visible = false;
            // 
            // label_KeyForDecrypt
            // 
            this.label_KeyForDecrypt.AutoSize = true;
            this.label_KeyForDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.label_KeyForDecrypt.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_KeyForDecrypt.Location = new System.Drawing.Point(14, 60);
            this.label_KeyForDecrypt.Name = "label_KeyForDecrypt";
            this.label_KeyForDecrypt.Size = new System.Drawing.Size(53, 24);
            this.label_KeyForDecrypt.TabIndex = 17;
            this.label_KeyForDecrypt.Text = "Key:";
            // 
            // textBox_KeyToDecrypt
            // 
            this.textBox_KeyToDecrypt.Location = new System.Drawing.Point(73, 52);
            this.textBox_KeyToDecrypt.Multiline = true;
            this.textBox_KeyToDecrypt.Name = "textBox_KeyToDecrypt";
            this.textBox_KeyToDecrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_KeyToDecrypt.Size = new System.Drawing.Size(267, 53);
            this.textBox_KeyToDecrypt.TabIndex = 18;
            this.textBox_KeyToDecrypt.Text = "Text Box";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(103, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "YOUR KEY FOR DECRYPT:";
            // 
            // textBox_KeyAfterEncrypt
            // 
            this.textBox_KeyAfterEncrypt.Location = new System.Drawing.Point(374, 331);
            this.textBox_KeyAfterEncrypt.Multiline = true;
            this.textBox_KeyAfterEncrypt.Name = "textBox_KeyAfterEncrypt";
            this.textBox_KeyAfterEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_KeyAfterEncrypt.Size = new System.Drawing.Size(318, 24);
            this.textBox_KeyAfterEncrypt.TabIndex = 20;
            this.textBox_KeyAfterEncrypt.Text = "Text Box";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 581);
            this.Controls.Add(this.textBox_KeyAfterEncrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_KeyToDecrypt);
            this.Controls.Add(this.label_KeyForDecrypt);
            this.Controls.Add(this.label_ProcessTracker);
            this.Controls.Add(this.comboBox_MLEBits);
            this.Controls.Add(this.comboBox_Algorithm);
            this.Controls.Add(this.comboBox_TypeToPerform);
            this.Controls.Add(this.label_MLE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Transform);
            this.Controls.Add(this.textBox_OutputText);
            this.Controls.Add(this.textBox_InputText);
            this.Controls.Add(this.label_OutputText);
            this.Controls.Add(this.label_InputText);
            this.Name = "App";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InputText;
        private System.Windows.Forms.Label label_OutputText;
        private System.Windows.Forms.TextBox textBox_InputText;
        private System.Windows.Forms.TextBox textBox_OutputText;
        private System.Windows.Forms.Button button_Transform;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_MLE;
        private System.Windows.Forms.ComboBox comboBox_TypeToPerform;
        private System.Windows.Forms.ComboBox comboBox_Algorithm;
        private System.Windows.Forms.ComboBox comboBox_MLEBits;
        private System.Windows.Forms.Label label_ProcessTracker;
        private System.Windows.Forms.Label label_KeyForDecrypt;
        private System.Windows.Forms.TextBox textBox_KeyToDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_KeyAfterEncrypt;
    }
}

