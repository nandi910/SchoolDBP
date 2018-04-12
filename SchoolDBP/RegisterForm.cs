using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SchoolDBP
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private int temp = Convert.ToInt32(null);
        Random rand = new Random((int)DateTime.Now.Ticks);
        private string user = null;
        private string pass = null;
        private string firstN = null;
        private string lastN = null;
        private int year = 0;
        private int spec = 0;
        private int semester = 0;

        private bool check_formula_empty()
        {
            bool tempEmpty = true;

            if (usernameBox.Text == null)
                tempEmpty = true;
            else
                tempEmpty = false;
            if (passwordBox.Text == null)
                tempEmpty = true;
            else
                tempEmpty = false;
            if (firstNameBox.Text == null)
                tempEmpty = true;
            else
                tempEmpty = false;
            if (lastNameBox.Text == null)
                tempEmpty = true;
            else
                tempEmpty = false;
            if (year == 0)
                tempEmpty = true;
            else
                tempEmpty = false;
            if (semester == 0)
                tempEmpty = true;
            else
                tempEmpty = false;
            if (spec == 0)
                tempEmpty = true;
            else
                tempEmpty = false;
            if (emailBox.Text == null)
                tempEmpty = true;
            else
                tempEmpty = false;
            if (confirmPass == null)
                tempEmpty = true;
            else
                tempEmpty = false;
            return tempEmpty;
        }

        private bool checkExistingUser(string input)
        {
            try
            {
                SqlConnection conn = new SqlConnection(GVars.connectionString());
                SqlCommand cmd = new SqlCommand("SELECT username FROM users WHERE username= @Username", conn);
                cmd.Parameters.AddWithValue("@Username", usernameBox.Text);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                    return true;
                else
                    return false;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                return true;
            }
        }
        
        private void year1rad_CheckedChanged(object sender, EventArgs e)
        {
            year = 1;
        }

        private void year2rad_CheckedChanged(object sender, EventArgs e)
        {
            year = 2;
        }

        private void year3rad_CheckedChanged(object sender, EventArgs e)
        {
            year = 3;
        }

        private void year4rad_CheckedChanged(object sender, EventArgs e)
        {
            year = 4;
        }

        private void semester1rad_CheckedChanged(object sender, EventArgs e)
        {
            semester = 1;
        }

        private void semester2rad_CheckedChanged(object sender, EventArgs e)
        {
            semester = 2;
        }

        private void spec1rad_CheckedChanged(object sender, EventArgs e)
        {
            spec = 1;
        }

        private void spec2rad_CheckedChanged(object sender, EventArgs e)
        {
            spec = 2;
        }

        private void spec3rad_CheckedChanged(object sender, EventArgs e)
        {
            spec = 3;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            //DataTable dt_users = new DataTable();
            //dt_users = DatabaseHelper.load_users();
            //int dr = dt_users.Rows.Count;
            
        }

        private void spec4rad_CheckedChanged(object sender, EventArgs e)
        {
            spec = 4;
        }
    
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void sendEmail_Click(object sender, EventArgs e)
        {
            

            if(checkExistingUser(usernameBox.Text))
            {
                MessageBox.Show("User already exists.");
            }
            else
            {
                if(!check_formula_empty() && passwordBox.Text == confirmPass.Text)
                {
                    string app_mail = "unidbproj@gmail.com";
                    string app_password = "iP1HcFr,ne";
                    temp = rand.Next(100000, 999999);
                    SmtpClient client = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        Credentials = new System.Net.NetworkCredential(app_mail, app_password),
                    };

                    try
                    {
                        MailMessage mail = new MailMessage(app_mail, emailBox.Text, "Verification Code", Convert.ToString(temp));
                        client.Send(mail);
                        MessageBox.Show("Check your mail");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
                else
                {
                    MessageBox.Show("[PH]Fill out the formula");
                }
            }
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(verifyBox.Text) != temp)
            {
                MessageBox.Show("Wrong verification code");
            }
            else
            {
                user = usernameBox.Text;
                pass = customFuncs.SHA512Hash(passwordBox.Text);
                firstN = firstNameBox.Text;
                lastN = lastNameBox.Text;
                
                DatabaseHelper.addNewUsers(user, pass, firstN, lastN, spec, year, semester, 0, 0, 0, 0);
                
                MessageBox.Show("Registration Successful, to log in, restart the app[PH].");
            }
        }
    }
}
