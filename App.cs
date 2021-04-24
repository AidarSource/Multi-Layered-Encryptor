﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MultiLayered_Encryptor_App {
    public partial class App : Form {
        public App() {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.mle;
            BackgroundImageLayout = ImageLayout.Stretch;


        }


        private void Form1_Load(object sender, EventArgs e) {
            bool bIsMLE = false;
            // checking for Multi-Layered Encryption in Algorithms
            if(comboBox_Algorithm.Text != "Multi-Layered Encryption") {
                label_MLE.Visible = false;
                comboBox_MLEBits.Visible = false;
            } else if(comboBox_Algorithm.Text != "Multi-Layered Encryption") {
                label_MLE.Visible = true;
                comboBox_MLEBits.Visible = true;
            }
            
        }

        private void button_Transform_Click(object sender, EventArgs e) {
            // AES-Advanced Encryption Standard
            if (comboBox_Algorithm.Text == "AES-Advanced Encryption Standard") {
                if (comboBox_TypeToPerform.Text == "Encrypt") {
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    label_ProcessTracker.Visible = true;
                    label_ProcessTracker.Text = "Processing . . .";

                    textBox_OutputText.Text = AES.EncryptString("b14ca58981434133bbce2ea2315a1916", textBox_InputText.Text);


                    stopwatch.Stop();
                    label_ProcessTracker.Text = String.Format("Completed in {0} seconds.", stopwatch.ElapsedMilliseconds / 1000.0);
                } else if(comboBox_TypeToPerform.Text == "Decrypt") {
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    label_ProcessTracker.Visible = true;
                    label_ProcessTracker.Text = "Processing . . .";



                    stopwatch.Stop();
                    label_ProcessTracker.Text = String.Format("Completed in {0} seconds.", stopwatch.ElapsedMilliseconds / 1000.0);
                }
            }
        }
    }
}
