using System;
using IronBarCode;
using IronSoftware.Drawing;
using Common.Cache;

namespace GenerateQR
{
    public partial class GenerateQR : Form
    {
        private static int cont = 0;//aumenta el numero de serie 
        public GenerateQR()
        {
            InitializeComponent();
        }

        private void date_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("yyyyMMdd");
            txtSerialNum.Text = cont.ToString("0000");
        }

        private void btnPrintQR_Click(object sender, EventArgs e)
        {
            int Cont;
            if (int.TryParse(txtSerialNum.Text, out Cont))
            {
                txtSerialNum.Text = (Cont + 1).ToString("0000");
            }
            cont++;

            var qrData = txtPartNum.Text + "_" + txtDate.Text + "_" + txtSerialNum.Text;


            GeneratedBarcode QRCode = BarcodeWriter.CreateBarcode(qrData, BarcodeEncoding.QRCode);
            QRCode.AddBarcodeValueTextBelowBarcode();
            qrPicture.Image = QRCode.ToImage();
        }
    }
}