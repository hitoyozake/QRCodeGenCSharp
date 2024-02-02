using QRCoder;

namespace QRCodeWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenQRCodeButton_Click(object sender, EventArgs e)
        {
           
            var targetStr = textBox1.Text;

            var qrGenerator = new QRCoder.QRCodeGenerator();

            var qrCodeData = qrGenerator.CreateQrCode(targetStr, QRCoder.QRCodeGenerator.ECCLevel.M);

            var qrCode = new QRCode(qrCodeData);

            var qrCodeImage = qrCode.GetGraphic(32);

            pictureBox1.Image = qrCodeImage;


        }
    }
}
