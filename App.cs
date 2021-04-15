using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLayered_Encryptor_App {
    public partial class App : Form {
        public App() {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.linux;
            BackgroundImageLayout = ImageLayout.Stretch;
        }


        private void Form1_Load(object sender, EventArgs e) {
            bool bIsMLE = true;
            if(!bIsMLE) {
                label_MLE.Dispose();
                listBox_MLEbits.Dispose();
            }
            
        }
    }
}
