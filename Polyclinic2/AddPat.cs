using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyclinic2
{
    public partial class AddPat : Form
    {
        DataBase dataBase = new DataBase();

        public string loginAdd = String.Empty, passAdd = String.Empty, fioAdd = String.Empty;
        public string dateOfBirthAdd = String.Empty, socialStatusAdd = String.Empty, currentStateAdd = String.Empty;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdmChoosePat admChoosePat = new AdmChoosePat(IDmain);
            this.Hide();
            admChoosePat.Show();
        }

        public int IDmain, IDAddUser;

        public AddPat(int ID)
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            loginAdd = logBox.Text;
            passAdd = passBox.Text;
            fioAdd = fioBox.Text;
            dateOfBirthAdd = dateOfBirthBox.Text;
            socialStatusAdd = socialStatusBox.Text;
            currentStateAdd = currentStateBox.Text;


            if (loginAdd == "")
                MessageBox.Show("Введите логин");
            else if (passAdd == "")
                MessageBox.Show("Введите пароль");
            else if (fioAdd == "")
                MessageBox.Show("Введите ФИО пациента");
            else if (dateOfBirthAdd == "")
                MessageBox.Show("Введите дату рождения пациента");
            else if (socialStatusAdd == "")
                MessageBox.Show("Введите социальный статус пациента");
            else if (currentStateAdd == "")
                MessageBox.Show("Введите текущее состояние пациента");
            else
            {
                string queryProfile = "Insert Into Patient (fio_patient, birth_patient, socialStatus_patient, currentState_patient) Values ('" + fioAdd + "','"
                        + dateOfBirthAdd + "', '" + socialStatusAdd + "', '" + currentStateAdd + "')";
                dataBase.Insert(queryProfile);
                string queryIdUser = String.Format("SELECT id_user FROM Patient WHERE fio_patient = '" + fioAdd + "'");
                IDAddUser = dataBase.getID(queryIdUser);
                string queryUsers = String.Format("INSERT INTO Users (id_user, typeOfAccount, login, password) VALUES ('" + IDAddUser + "', 3, '" + loginAdd + "','" + passAdd + "')");
                dataBase.Insert(queryUsers);

                MessageBox.Show("Пользователь добавлен");
            }

            AdmChoosePat admChoosePat = new AdmChoosePat(IDmain);
            this.Hide();
            admChoosePat.Show();
        }
    }
}
