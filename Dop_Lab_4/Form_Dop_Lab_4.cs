using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Dop_Lab_4 {
    public partial class Form_Dop_Lab_4 : Form {
        public Form_Dop_Lab_4() {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            panelToolbar.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            splitContainerPictures.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;

            if (pictureBoxInput.Image == null) {
                countButton.Enabled = false;
                saveButton.Enabled = false;
            }
        }

        private void loadButton_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Users\\volch\\RiderProjects\\MiKM_Sharp\\MathCompMethods\\Dop_Lab_4\\resources";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2; 
                
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    // Получаем полный путь к выбранному файлу
                    string filePath = openFileDialog.FileName;
                    Bitmap bmp = new Bitmap(filePath);
                    pictureBoxInput.Image = bmp;
                    countButton.Enabled = true;
                    saveButton.Enabled = true;
                    labelInfo.Text = "—";
                    labelInfo.ForeColor = Color.Black;
                } catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e) {
            using (SaveFileDialog sfd = new SaveFileDialog()) {
                sfd.Filter = "JPEG файл(*.jpg)|*.jpg|PNG файл(*.png)|*.png|Bitmap файл(*.bmp)|*.bmp";
        
                if (sfd.ShowDialog() == DialogResult.OK) {
                    string ext = Path.GetExtension(sfd.FileName).ToLower();
                    ImageFormat format;
            
                    switch (ext) {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        default:
                            format = ImageFormat.Jpeg;
                            break;
                    }
                    pictureBoxOutput.Image.Save(sfd.FileName, format);
                }
            }
        }

        private void countButton_Click(object sender, EventArgs e) {
            Thread thread = new Thread(() => {
                labelInfo.Text = "Start";
                labelInfo.ForeColor = Color.Red;
            });
            thread.Start();
            thread.Join();
            Bitmap bmp = (Bitmap)pictureBoxInput.Image;
            int br;
            double v = 0;
            double max_u = Math.PI / (2 * bmp.Width);
            double u = 0;
            for (int y = 0; y < bmp.Height; ++y) {
                for (int x = 0; x < bmp.Width; ++x) {
                    u = max_u * x;
                    br = Convert.ToInt32(100 + 50 * Math.Cos(u * x + v * y));
                    if (br < 0) {
                        br = 0; 
                    }
                    if (br > 255) { 
                        br = 255; 
                    }
                    Color cl = Color.FromArgb(br, br, br);
                    bmp.SetPixel(x, y, cl);
                }
            }
            labelInfo.Text = "Ready";
            labelInfo.ForeColor = Color.DarkGreen;
            pictureBoxOutput.Image = bmp;
        }
    }
}