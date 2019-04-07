using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using BarcodeLib;

namespace Generardor_de_Codigo_de_barras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtenter.Text))
            {
                MessageBox.Show("Enter Text for the bar code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BarcodeLib.Barcode codigol = new BarcodeLib.Barcode();
                codigol.IncludeLabel = true;
                pnlview.BackgroundImage = codigol.Encode(BarcodeLib.TYPE.CODE128, txtenter.Text, Color.Black, Color.White, 400, 100);
                btnsave.Enabled = true;
                txtenter.Text = "";
            }
            
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Image img = (Image)pnlview.BackgroundImage.Clone();
            SaveFileDialog cajadedialogo = new SaveFileDialog();
            cajadedialogo.AddExtension = true;
            cajadedialogo.Filter = "Image PNG (*.png)|*.png";
            cajadedialogo.ShowDialog();
            if (!string.IsNullOrEmpty(cajadedialogo.FileName))
            {
                img.Save(cajadedialogo.FileName, ImageFormat.Png);
            }
            img.Dispose();
            pnlview.BackgroundImage = null ;
            btnsave.Enabled = false;
        }

       
    }
}
