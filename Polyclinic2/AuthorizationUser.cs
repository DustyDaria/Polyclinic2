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
    public partial class AuthorizationUser : Form
    {

        DataBase dataBase = new DataBase();

        public string Login;
        public string Password;
        public string typeUser;
        public int ID;
        

        public AuthorizationUser()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login = loginField.Text;
            Password = passField.Text;
            typeUser = comboTypeField.Text;

            string queryID = String.Format("Select id_user From Users Where login = '{0}'", Login);
            string queryTypeTest = String.Format("SELECT typeOfAccount FROM Users WHERE login = '" 
                + Login + "' AND password = '" + Password + "';");

            if (typeUser == dataBase.getResult(queryTypeTest))
            {
                if (typeUser == "Администратор")
                {
                    ID = dataBase.getID(queryID);

                    MainAdminForm admForm = new MainAdminForm(ID);
                    this.Hide();
                    admForm.Show();
                }
                else if (typeUser == "Доктор")
                {
                    ID = dataBase.getID(queryID);

                    MainDoctorForm docForm = new MainDoctorForm(ID);
                    this.Hide();
                    docForm.Show();
                }
                else if (typeUser == "Пациент")
                {
                    ID = dataBase.getID(queryID);

                    MainPatientForm patForm = new MainPatientForm(ID);
                    this.Hide();
                    patForm.Show();
                }
                else
                    MessageBox.Show("ОШИБКА: неверные данные для входа");
            }
            else
                MessageBox.Show("ОШИБКА: неверные данные для входа");
            
        }
        
    }
}
