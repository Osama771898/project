using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace code_done
{
    public partial class MainForm : Form
    {



        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );






        public MainForm(string rvalue)
        {
            InitializeComponent();
            value.Text = rvalue;


            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));


            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);



        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            PnlDash.Height = 513;
        }




        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnTasks_Click(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            PnlNav.Height = BtnTasks.Height;
            PnlNav.Top = BtnTasks.Top;
            PnlNav.Left = BtnTasks.Left;
            PnlDash.Height = 5;
            BtnTasks.BackColor = Color.FromArgb(46, 51, 73);
            PnlTasks.Height = 513;
        }

        private void BtnProgramers_Click(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            PnlNav.Height = BtnProgramers.Height;
            PnlNav.Top = BtnProgramers.Top;
            PnlNav.Left = BtnProgramers.Left;
            PnlDash.Height = 5;
            BtnProgramers.BackColor = Color.FromArgb(46, 51, 73);
            PnlProgramers.Height = 513;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            PnlNav.Height = BtnLogout.Height;
            PnlNav.Top = BtnLogout.Top;
            PnlNav.Left = BtnLogout.Left;
            BtnLogout.BackColor = Color.FromArgb(46, 51, 73);
            Frm_Login frl = new Frm_Login();
            frl.Show();
            this.Hide();
        }

        private void BtnContact_Click(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            PnlNav.Height = BtnContact.Height;
            PnlNav.Top = BtnContact.Top;
            PnlNav.Left = BtnContact.Left;
            PnlDash.Height = 5;
            BtnContact.BackColor = Color.FromArgb(46, 51, 73);
            PnlContact.Height = 513;
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            
        }

        private void BtnTasks_Leave(object sender, EventArgs e)
        {
            BtnTasks.BackColor = Color.FromArgb(24, 30, 54);
            PnlTasks.Height = 5;
        }

        private void BtnProgramers_Leave(object sender, EventArgs e)
        {
            BtnProgramers.BackColor = Color.FromArgb(24, 30, 54);
            PnlProgramers.Height = 5;
        }

        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            BtnLogout.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnContact_Leave(object sender, EventArgs e)
        {
            BtnContact.BackColor = Color.FromArgb(24, 30, 54);
            PnlContact.Height = 5;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PnlProgramers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel34_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label46_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel38_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel41_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label52_Click(object sender, EventArgs e)
        {

        }

        private void Panel40_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel39_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label51_Click(object sender, EventArgs e)
        {

        }

        private void Label50_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void Panel42_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlContact_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void Userlable_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }
    }
    }

