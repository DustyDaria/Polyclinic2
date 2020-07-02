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
    

    public partial class AddDoc : Form
    {
        DataBase dataBase = new DataBase();

        public string loginAdd = String.Empty, passAdd = String.Empty, fioAdd = String.Empty;
        public string positionAdd = String.Empty, qualifAdd = String.Empty, specializAdd = String.Empty;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdmChooseDoc admChooseDoc = new AdmChooseDoc(IDmain);
            this.Hide();
            admChooseDoc.Show();
        }

        public int IDmain, IDAddUser;

        public AddDoc(int ID)
        {
            InitializeComponent();

            IDmain = ID;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            loginAdd = logBox.Text;
            passAdd = passBox.Text;
            fioAdd = fioBox.Text;
            positionAdd = positionBox.Text;
            qualifAdd = qualifBox.Text;
            specializAdd = specializBox.Text;

            if (loginAdd == "")
                MessageBox.Show("Введите логин");
            else if (passAdd == "")
                MessageBox.Show("Введите пароль");
            else if (fioAdd == "")
                MessageBox.Show("Введите ФИО врача");
            else if (positionAdd == "")
                MessageBox.Show("Введите должность врача");
            else if (qualifAdd == "")
                MessageBox.Show("Введите квалификацию врача");
            else if (specializAdd == "")
                MessageBox.Show("Введите специализацию врача");
            else
            {
                string queryProfile = "Insert Into Doctor (fio_doctor, position_doctor, qualification_doctor, specialization_doctor) Values ('" + fioAdd + "','"
                        + positionAdd + "', '" + qualifAdd + "', '" + specializAdd + "')";
                dataBase.Insert(queryProfile);

                string queryIdUser = String.Format("SELECT id_user FROM Doctor WHERE fio_doctor = '" + fioAdd + "'");
                IDAddUser = dataBase.getID(queryIdUser);

                string queryUsers = String.Format("INSERT INTO Users (id_user, typeOfAccount, login, password) VALUES ('" + IDAddUser + "', 2, '" + loginAdd + "','" + passAdd + "')");
                dataBase.Insert(queryUsers);

                MessageBox.Show("Пользователь добавлен");
            }

            AdmChooseDoc admChooseDoc = new AdmChooseDoc(IDmain);
            this.Hide();
            admChooseDoc.Show();
        }
    }
}
