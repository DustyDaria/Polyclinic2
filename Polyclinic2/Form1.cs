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

namespace Polyclinic2
{
    public partial class Form1 : Form
    {

        DataBase dataBase = new DataBase();

        public string Login;
        public string Password;
        public string typeUser;
        public int ID;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login = loginField.Text;
            Password = passField.Text;
            typeUser = typeField.Text;

            int admType = 1;
            int docType = 2;
            int patType = 3;

            string queryLog = String.Format("Select login From Users Where login = '{0}'", Login);
            string queryPas = String.Format("Select password From Users Where password = '{0}'", Password);
            string queryType = String.Format("Select typeOfAccount From Users Where typeOfAccount = '{0}'", typeUser);
            string queryID = String.Format("Select id_user From Users Where login = '{0}'", Login);

            if (dataBase.Check(queryLog, Login) == 1)
            {
                if (dataBase.Check(queryPas, Password) == 1)
                {
                    if (dataBase.Check(queryType, typeUser) == 1) 
                    {
                        if (Convert.ToInt32(typeUser) == admType)
                        {
                            ID = dataBase.getID(queryID);
                            MainAdminForm admForm = new MainAdminForm(ID);
                            this.Hide();
                            admForm.Show();
                        }
                        else if (Convert.ToInt32(typeUser) == docType)
                        {
                            ID = dataBase.getID(queryID);

                            MainDoctorForm docForm = new MainDoctorForm(ID);
                            this.Hide();
                            docForm.Show();
                        }
                        else if (Convert.ToInt32(typeUser) == patType)
                        {
                            ID = dataBase.getID(queryID);

                            MainPatientForm patForm = new MainPatientForm(ID);
                            this.Hide();
                            patForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Авторизации не успешна. (Неверный тип аккаунта)");
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Авторизации не успешна. (Неверный пароль)");
                }
            }
            else
            {
                MessageBox.Show("Авторизации не успешна. (Неверный логин)");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
