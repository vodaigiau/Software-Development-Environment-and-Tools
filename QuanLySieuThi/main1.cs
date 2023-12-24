using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class main1 : Form
    {
        public int i = -1;
        public int j = 3;
        public main1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbform.Location = new Point(lbform.Location.X, lbform.Location.Y + i);
            if (lbform.Location.Y <= 30)
            {
                i = 1;
            }
            if (lbform.Location.Y >= 60) i = -1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbleff.Location = new Point(lbleff.Location.X - j, lbleff.Location.Y);
            lblright.Location = new Point(lblright.Location.X + j, lblright.Location.Y);
            if (lbleff.Location.X <= -100) pictureBox1.Visible = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.02;
        }

        private void đăngNhậpHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap a = new Dangnhap();
            a.Show();
            this.Hide();
        }

        private void đăngKýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKy b = new DangKy();
            b.Show();
            this.Hide();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentYear = DateTime.Now.Year.ToString();
            String tt = "";
            tt += "Phần mềm : Quản lý Siêu thị  \n";

            
            tt += "\n\n";
            tt += " Đồ án cuối kỳ C# ";
            tt += "\n";
            tt += " ____ Môn Công cụ và môi trường phát triển phần mềm ____ ";
            tt += "\n";
            tt += "\nSinh viên thực hiện : - Võ Đại Giàu";
            tt += "\nversion : 1.1 @ năm " + currentYear + "  \n\n";
            tt += "Email : vorich1502@gmail.com  \n\n";
            tt += "Facebook : https://www.facebook.com/giauchuaheee";
            tt += "\n";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
               
                this.Close();
            }
        }

        private void main1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbsv_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbform_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbleff_Click(object sender, EventArgs e)
        {

        }
    }
}
