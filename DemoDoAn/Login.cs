using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DemoDoAn
{
    
    public partial class Login : Form
    {
        bool t=false;
        public Login()
        {
            InitializeComponent();
            
        }

        bool isHidePass = false;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(isHidePass == false)
            {
                txt_Password.PasswordChar = char.MinValue; 
                pictureBox_HidePass.Image = new Bitmap(Application.StartupPath + "\\Resources\\eye-crossed.png");
                pictureBox_HidePass.SizeMode = PictureBoxSizeMode.CenterImage;
                isHidePass = true;
            }
            else
            {
                txt_Password.PasswordChar = '*' ;
                pictureBox_HidePass.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox_HidePass.Image = new Bitmap(Application.StartupPath + "\\Resources\\eye.png");
                isHidePass = false;
            }

            
        }

        bool isEmpty_Username = true;
        private void txt_Username_MouseClick(object sender, MouseEventArgs e)
        {
            
            if(isEmpty_Username == true)
            {
                txt_Username.Text = String.Empty;
                txt_Username.Font = new Font(txt_Username.Font, FontStyle.Regular);
                txt_Username.ForeColor = Color.DimGray;
                isEmpty_Username = false;
            }    
            //if(txt_Username.Text == String.Empty)
            //{
            //    txt_Username.Text = "KKKK";
            //}
            //else
            //{
            //    isEmpty_Username = false;
            //}
           
        }

        bool isEmpty_Password = true;
        private void txt_Password_MouseClick(object sender, MouseEventArgs e)
        {
            if( isEmpty_Password == true)
            {
                txt_Password.PasswordChar = '*';
                txt_Password.Text = String.Empty;
                txt_Password.Font = new Font(txt_Password.Font, FontStyle.Regular);
                txt_Password.ForeColor = Color.DimGray;
                isEmpty_Password = false;
            }
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
            try
            {
                conn.Open();
                
                string sql = string.Format("SELECT *FROM ACCOUNT where USERNAME='{0}' and PASS_WORD='{1}'", ad.name, ad.password);
                string tk = txt_Username.Text;
                string mk = txt_Password.Text;
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(ad.name, tk);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    string ctm = rd[ad.name].ToString();
                    if (ctm == ad.name)
                    {
                        Fadmin a = new Fadmin();
                        a.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                    txt_Password.Focus();
                }
                if (string.IsNullOrEmpty(txt_Username.Text))
                {
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                    errorProvider1.SetError(pnl_ErrorUserName, "No Fill !");
                }
                else
                {
                    errorProvider1.Clear();
                }
                if (string.IsNullOrEmpty(txt_Password.Text))
                {
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                    errorProvider1.SetError(pnl_ErrorPassword, "No Fill !");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("khong the dang nhap");
            }
        }

        private void lbl_CreateAccount_Click(object sender, EventArgs e)
        {
            SignUp a = new SignUp();
            this.Hide();
            a.Show();
        }

       
    }
}
