using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolDBP
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            {
                SqlConnection conn = new SqlConnection(GVars.connectionString());
                string spec = "SELECT Specialization FROM data WHERE userData_ID=@userID";
                string year = "SELECT Year FROM data WHERE userData_ID=@userID";
                string seme = "SELECT Semester FROM data WHERE userData_ID=@userID";
                SqlCommand cmdSpec = new SqlCommand(spec, conn);
                SqlCommand cmdYear = new SqlCommand(year, conn);
                SqlCommand cmdSeme = new SqlCommand(seme, conn);
                cmdSpec.Parameters.AddWithValue("@userID", GVars.getUserID());
                cmdYear.Parameters.AddWithValue("@userID", GVars.getUserID());
                cmdSeme.Parameters.AddWithValue("@userID", GVars.getUserID());
                conn.Open();
                int tempSpec = Convert.ToInt16(cmdSpec.ExecuteScalar());
                int tempYear = Convert.ToInt16(cmdYear.ExecuteScalar());
                int tempSeme = Convert.ToInt16(cmdSeme.ExecuteScalar());

                switch (tempSpec)
                {
                    case 1:
                        {
                            switch (tempYear)
                            {
                                case 1:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                                case 4:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case 2:
                        {
                            switch (tempYear)
                            {
                                case 1:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    dis1Label.Text = "Desen Tehnic";
                                                    dis2Label.Text = "PCLP";
                                                    dis1Box.Text = Convert.ToString(DatabaseHelper.getDiscipData("Discipline1", "disciplines", "user_ID"));
                                                    dis2Box.Text = Convert.ToString(DatabaseHelper.getDiscipData("Discipline2", "disciplines", "user_ID"));
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                                case 4:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case 3:
                        {
                            switch (tempYear)
                            {
                                case 1:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                                case 4:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case 4:
                        {
                            switch (tempYear)
                            {
                                case 1:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                                case 4:
                                    {
                                        switch (tempSeme)
                                        {
                                            case 1:
                                                {
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                }
            }

        }
    }
}

