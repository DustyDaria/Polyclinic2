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
    public partial class ChoosePat : Form
    {
        DataBase dataBase = new DataBase();
        
        public int IDmain;
        private string typeSearchTransfer = String.Empty;
        private string stringReaderBoxTransfer = String.Empty;
        public string changeSpecializ = String.Empty;
        public string cellClickData = String.Empty;
        public int cellClickRowIndex;
        public int cellClickColumnIndex;

        public string userType;

        public ChoosePat(int ID)
        {
            IDmain = ID;
            InitializeComponent();

            string queryUserType = String.Format("SELECT typeOfAccount FROM Users WHERE id_user = " + IDmain + ";");
            userType = dataBase.getResult(queryUserType);

            if (userType == "Администратор")
            {
                string queryUserNameAdmin = String.Format("SELECT name_admin FROM Admin WHERE id_user = " + IDmain + ";");
                userName.Text = "Ваше имя: " + Convert.ToString(dataBase.getResult(queryUserNameAdmin));
            }
            else if (userType == "Доктор")
            {
                string queryUserNameDoctor = String.Format("SELECT fio_doctor FROM Doctor WHERE id_user = " + IDmain + ";");
                userName.Text = "Ваше имя: " + Convert.ToString(dataBase.getResult(queryUserNameDoctor));
            }
            else if (userType == "Пациент")
            {
                string queryUserNamePatient = String.Format("SELECT fio_patient FROM Patient WHERE id_user = " + IDmain + ";");
                userName.Text = "Ваше имя: " + Convert.ToString(dataBase.getResult(queryUserNamePatient));
            }

            LoadData();
        }

        private void LoadData()
        {
            string connectionString = @"Server = DESKTOP-BSEODEL\SQLEXPRESS; Database = Polyclinic; Trusted_Connection = True";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            string query = "Select * From Patient Order By id_user";
            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }
            reader.Close();
            myConnection.Close();
            foreach (string[] s in data)
                dataGridViewDoc.Rows.Add(s);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (userType == "Администратор")
            {
                MainAdminForm mainAdminForm = new MainAdminForm(IDmain);
                this.Hide();
                mainAdminForm.Show();
            }
            else if (userType == "Доктор")
            {
                MainDoctorForm mainDoctorForm = new MainDoctorForm(IDmain);
                this.Hide();
                mainDoctorForm.Show();
            }
        }

        private void AdmChoosePat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyclinicDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            //this.doctorTableAdapter.Fill(this.polyclinicDataSet.Doctor);

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            typeSearchTransfer = listStatus.Text;
            stringReaderBoxTransfer = searchReaderBox.Text;

            ListStatus(typeSearchTransfer, stringReaderBoxTransfer);
        }

        private void ListStatus(string typeSearch, string stringReaderBox)
        {
            dataGridViewDoc.Rows.Clear(); // Чистка старых  данных.
            dataBase.data.Clear(); // чистка нашего буфера данных.

            string querySearchID = String.Format("Select * From Patient Where id_user LIKE '%" + stringReaderBox + "%'");
            string querySearchFIO = String.Format("Select * From Patient Where fio_patient LIKE '%" + stringReaderBox + "%'");
            string querySearchDateOfBirth = String.Format("Select * From Patient Where birth_patient LIKE '%" + stringReaderBox + "%'");
            string querySearchSocialStatus = String.Format("Select * From Patient Where socialStatus_patient LIKE '%" + stringReaderBox + "%'");
            string querySearchCurrentState = String.Format("Select * From Patient Where currentState_patient LIKE '%" + stringReaderBox + "%'");

            if (typeSearch == "ID")
            {
                dataBase.Select(querySearchID);
                foreach (string[] s in dataBase.data) // Загрузка данных из нашего буфера.
                    dataGridViewDoc.Rows.Add(s);
            }
            else if (typeSearch == "ФИО пациента")
            {
                dataBase.Select(querySearchFIO);
                foreach (string[] s in dataBase.data) // Загрузка данных из нашего буфера.
                    dataGridViewDoc.Rows.Add(s);
            }
            else if (typeSearch == "Дата рождения пациента")
            {
                dataBase.Select(querySearchDateOfBirth);
                foreach (string[] s in dataBase.data) // Загрузка данных из нашего буфера.
                    dataGridViewDoc.Rows.Add(s);
            }
            else if (typeSearch == "Социальный статус пациента")
            {
                dataBase.Select(querySearchSocialStatus);
                foreach (string[] s in dataBase.data) // Загрузка данных из нашего буфера.
                    dataGridViewDoc.Rows.Add(s);
            }
            else if (typeSearch == "Текущее состояние пациента")
            {
                dataBase.Select(querySearchCurrentState);
                foreach (string[] s in dataBase.data) // Загрузка данных из нашего буфера.
                    dataGridViewDoc.Rows.Add(s);
            }
            else
            {
                MessageBox.Show("Выберите критерий поиска");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int cellIDDel = Convert.ToInt32(cellClickData);

            string queryDelProfile = String.Format("Delete From Patient Where id_user = '{0}'", cellIDDel);
            string queryDelUser = String.Format("Delete From Users Where id_user = '{0}'", cellIDDel);
            string queryDelDiagnosis = String.Format("Delete From Diagnosis Where id_user = '{0}'", cellIDDel);

            dataBase.Delete(queryDelProfile);
            dataBase.Delete(queryDelUser);
            dataBase.Delete(queryDelDiagnosis);

            MessageBox.Show("Данные пользователя удалены");

            dataGridViewDoc.Rows.Clear(); // Чистка старых  данных.
            dataBase.data.Clear(); // чистка нашего буфера данных.
            LoadData();
        }

        private void dataGridViewDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cellClickData = dataGridViewDoc.CurrentCell.Value.ToString(); //получение данных выбранной ячейки
            //cellClickRowIndex = dataGridViewDoc.SelectedCells[0].RowIndex; //получение индекса строки выбранной ячейки
            //cellClickColumnIndex = dataGridViewDoc.SelectedCells[0].ColumnIndex; //получение индекса столбца выбранной ячейки
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddPat addPat = new AddPat(IDmain);
            this.Hide();
            addPat.Show();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int cellID = Convert.ToInt32(cellClickData);
            ChangePat changePat = new ChangePat(cellID, IDmain);
            this.Hide();
            changePat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userType == "Администратор")
            {
                MainAdminForm admForm = new MainAdminForm(IDmain);
                this.Hide();
                admForm.Show();
            }
            else if (userType == "Доктор")
            {
                MainDoctorForm docForm = new MainDoctorForm(IDmain);
                this.Hide();
                docForm.Show();
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            searchReaderBox.Text = String.Empty;
            listStatus.Text = String.Empty;
            dataGridViewDoc.Rows.Clear(); // Чистка старых  данных.
            dataBase.data.Clear(); // чистка нашего буфера данных.
            LoadData();
        }
    }
}
