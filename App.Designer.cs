
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
            this.listBox_Algorithm = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_TypeToPerform = new System.Windows.Forms.ListBox();
            this.label_MLE = new System.Windows.Forms.Label();
            this.listBox_MLEbits = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_InputText
            // 
            this.label_InputText.AutoSize = true;
            this.label_InputText.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_InputText.Location = new System.Drawing.Point(12, 60);
            this.label_InputText.Name = "label_InputText";
            this.label_InputText.Size = new System.Drawing.Size(152, 24);
            this.label_InputText.TabIndex = 0;
            this.label_InputText.Text = "Enter your text";
            // 
            // label_OutputText
            // 
            this.label_OutputText.AutoSize = true;
            this.label_OutputText.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_OutputText.Location = new System.Drawing.Point(13, 263);
            this.label_OutputText.Name = "label_OutputText";
            this.label_OutputText.Size = new System.Drawing.Size(83, 24);
            this.label_OutputText.TabIndex = 1;
            this.label_OutputText.Text = "Result: ";
            // 
            // textBox_InputText
            // 
            this.textBox_InputText.Location = new System.Drawing.Point(13, 87);
            this.textBox_InputText.Multiline = true;
            this.textBox_InputText.Name = "textBox_InputText";
            this.textBox_InputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_InputText.Size = new System.Drawing.Size(540, 163);
            this.textBox_InputText.TabIndex = 4;
            this.textBox_InputText.Text = "Text Box";
            // 
            // textBox_OutputText
            // 
            this.textBox_OutputText.Location = new System.Drawing.Point(13, 290);
            this.textBox_OutputText.Multiline = true;
            this.textBox_OutputText.Name = "textBox_OutputText";
            this.textBox_OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_OutputText.Size = new System.Drawing.Size(540, 163);
            this.textBox_OutputText.TabIndex = 5;
            this.textBox_OutputText.Text = "Text Box 2";
            // 
            // button_Transform
            // 
            this.button_Transform.Location = new System.Drawing.Point(407, 459);
            this.button_Transform.Name = "button_Transform";
            this.button_Transform.Size = new System.Drawing.Size(146, 41);
            this.button_Transform.TabIndex = 6;
            this.button_Transform.Text = "Transform";
            this.button_Transform.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(215, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Algorithm:";
            // 
            // listBox_Algorithm
            // 
            this.listBox_Algorithm.FormattingEnabled = true;
            this.listBox_Algorithm.ItemHeight = 20;
            this.listBox_Algorithm.Location = new System.Drawing.Point(329, 18);
            this.listBox_Algorithm.Name = "listBox_Algorithm";
            this.listBox_Algorithm.Size = new System.Drawing.Size(224, 24);
            this.listBox_Algorithm.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(13, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Do";
            // 
            // listBox_TypeToPerform
            // 
            this.listBox_TypeToPerform.FormattingEnabled = true;
            this.listBox_TypeToPerform.ItemHeight = 20;
            this.listBox_TypeToPerform.Location = new System.Drawing.Point(61, 18);
            this.listBox_TypeToPerform.Name = "listBox_TypeToPerform";
            this.listBox_TypeToPerform.Size = new System.Drawing.Size(112, 24);
            this.listBox_TypeToPerform.TabIndex = 10;
            // 
            // label_MLE
            // 
            this.label_MLE.AutoSize = true;
            this.label_MLE.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_MLE.Location = new System.Drawing.Point(215, 60);
            this.label_MLE.Name = "label_MLE";
            this.label_MLE.Size = new System.Drawing.Size(255, 24);
            this.label_MLE.TabIndex = 11;
            this.label_MLE.Text = "Multi-Layered Encryption:";
            // 
            // listBox_MLEbits
            // 
            this.listBox_MLEbits.FormattingEnabled = true;
            this.listBox_MLEbits.ItemHeight = 20;
            this.listBox_MLEbits.Location = new System.Drawing.Point(476, 60);
            this.listBox_MLEbits.Name = "listBox_MLEbits";
            this.listBox_MLEbits.Size = new System.Drawing.Size(77, 24);
            this.listBox_MLEbits.TabIndex = 12;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 512);
            this.Controls.Add(this.listBox_MLEbits);
            this.Controls.Add(this.label_MLE);
            this.Controls.Add(this.listBox_TypeToPerform);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_Algorithm);
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
        private System.Windows.Forms.ListBox listBox_Algorithm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_TypeToPerform;
        private System.Windows.Forms.Label label_MLE;
        private System.Windows.Forms.ListBox listBox_MLEbits;
    }
}

