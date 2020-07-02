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
    public partial class ChangePat : Form
    {
        DataBase dataBase = new DataBase();
        public int cellID, returnIDmain;

        public string Log = String.Empty, Pass = String.Empty, FIO = String.Empty;
        public string DateOfBirth = String.Empty, SocialStatus = String.Empty, CurrentState = String.Empty;

        private void dateOfBirthPicker_ValueChanged(object sender, EventArgs e)
        {
            //label8.Text = String.Format("Вы выбрали {0}", dateTimePicker1.Value.ToLongDateString());
        }

        private void ChangePat_Load(object sender, EventArgs e)
        {
            /*// свойства DateTimePicker

            DateTimePicker dt = new DateTimePicker();

            dt.Location = new Point(247, 294);

            dt.Size = new Size(212, 20);

            dt.MaxDate = new DateTime(2500, 12, 20);

            dt.MinDate = new DateTime(1753, 1, 1);

            dt.Format = DateTimePickerFormat.Long;

            dt.Name = "MyPicker";

            //dt.Font = new Font("Comic Sans MS", 12);

            dt.Visible = true;

            dt.Value = DateTime.Today;



            // Добавление этого элемента управления

            // к форме

            this.Controls.Add(dt);*/
        }

        public string loginChange = String.Empty, passChange = String.Empty, fioChange = String.Empty;
        public string dateOfBirthChange = String.Empty, socialStatusChange = String.Empty, currentStateChange = String.Empty;

        public ChangePat(int ID, int IDmain)
        {
            InitializeComponent();
            cellID = ID;
            returnIDmain = IDmain;

            //////

            //dateTimePicker1.Format = dateTimePicker1.Long;
            //dateTimePicker1.ValueChanged += dateOfBirthPicker_ValueChanged;
            //////

            string queryLog = String.Format("Select login From Users Where id_user = '{0}'", cellID);
            string queryPass = String.Format("Select password From Users Where id_user = '{0}'", cellID);
            string queryFIO = String.Format("Select fio_patient From Patient Where id_user = '{0}'", cellID);
            string queryDateOfBirth = String.Format("Select birth_patient From Patient Where id_user = '{0}'", cellID); ///выборка даты
            string querySocialStatus = String.Format("Select socialStatus_patient From Patient Where id_user = '{0}'", cellID);
            string queryCurrentState = String.Format("Select currentState_patient From Patient Where id_user = '{0}'", cellID);

            Log = dataBase.getResult(queryLog);
            Pass = dataBase.getResult(queryPass);
            FIO = dataBase.getResult(queryFIO);
            DateOfBirth = dataBase.getResult(queryDateOfBirth);
            SocialStatus = dataBase.getResult(querySocialStatus);
            CurrentState = dataBase.getResult(queryCurrentState);

            logBox.Text = Log;
            passBox.Text = Pass;
            fioBox.Text = FIO;
            dateOfBirthBox.Text = DateOfBirth;
            socialStatusBox.Text = SocialStatus;
            currentStateBox.Text = CurrentState;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            loginChange = logBox.Text;
            passChange = passBox.Text;
            fioChange = fioBox.Text;
            dateOfBirthChange = dateOfBirthBox.Text;
            socialStatusChange = socialStatusBox.Text;
            currentStateChange = currentStateBox.Text;

            if (loginChange == "")
                MessageBox.Show("Введите логин");
            else if (passChange == "")
                MessageBox.Show("Введите пароль");
            else if (fioChange == "")
                MessageBox.Show("Введите ФИО пациента");
            else if (dateOfBirthChange == "")
                MessageBox.Show("Введите дату рождения пациента");
            else if (socialStatusChange == "")
                MessageBox.Show("Введите социальный статус пациента");
            else if (currentStateChange == "")
                MessageBox.Show("Введите текущее состояние пациента");
            else
            {
                string queryProfile = String.Format("Update Patient Set fio_patient = '" + fioChange + "', birth_patient = '"
                    + dateOfBirthChange + "', socialStatus_patient = '" + socialStatusChange + "', currentState_patient = '" 
                    + currentStateChange + "' Where id_user = '" + cellID + "'");
                dataBase.Update(queryProfile);

                string queryUsers = String.Format("Update Users Set login = '" + loginChange + "', password = '" + passChange 
                    + "' Where id_user = '" + cellID + "'");
                dataBase.Update(queryUsers);

                MessageBox.Show("Пользователь изменен");
            }

            AdmChoosePat admChoosePat = new AdmChoosePat(returnIDmain);
            this.Hide();
            admChoosePat.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }
    }
}
