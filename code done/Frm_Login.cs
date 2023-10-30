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
using System.Data.SqlClient;


namespace code_done
{
    public partial class Frm_Login : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=CodeDoneDb;Integrated Security=True");






        /*form border*/
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


        public Frm_Login()
        {
            InitializeComponent();


            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));


        }


      


        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PnlRegister.Height = PnlLogin.Height;
            Line1.Width = 90;
         
           
            
        }

        private void PnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PnlRegister.Height = 0;
          
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {


            /*
             SqlCommand cmd = new SqlCommand("insert into Login(UserName,Name,Password,ConfPass) values('"+TxtUserNameR.Text+"','"+TxtNameR.Text+"','"+TxtPasswordR.Text+"','"+TxtConfPassR.Text+"')");
             con.Close();*/

            if (TxtUserNameR.Text == "" || TxtNameR.Text == "" || TxtPasswordR.Text == "" || TxtConfPassR.Text == "")
            {

                MessageBox.Show("One of the boxes is empty, data is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else
            {
                if (TxtPasswordR.Text != TxtConfPassR.Text)
                {
                    MessageBox.Show("Wrong in confirm password");
                }
                else
                {
                    

                    con.Open();
                    SqlCommand cmm = con.CreateCommand();
                    cmm.CommandType = CommandType.Text;

                    cmm.CommandText = "insert into [Login1]  values (" + TxtUserNameR.Text + " , '" + TxtNameR.Text + "' , '" + TxtPasswordR.Text + "' , '" + TxtConfPassR + "' ) ";
                   cmm.ExecuteNonQuery();
                    con.Close();
                   
                    MessageBox.Show("Recoed Inserted Successfully");
                }

            }
            

            






                PnlRegister.Height = 0;
            Line1.Width = 65;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
           

            SqlDataAdapter sdt = new SqlDataAdapter(" select count(*) from Login1 where UserName ='" + TxtUserName.Text + "' and Password ='" + TxtPassword.Text + "'", con);
          
            DataTable dt = new DataTable();
            sdt.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
              
                MainForm m = new MainForm(TxtUserName.Text);
        
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Correct username and password", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            con.Close();







        }

        private void PnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
