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
    public partial class AdmChooseDoc : Form
    {
        DataBase dataBase = new DataBase();

        public int IDmain;
        public string typeSearchTransfer;
        public string stringReaderBoxTransfer;
        public string cellClickData = String.Empty;
        public int cellClickRowIndex;
        public int cellClickColumnIndex;
        
        public AdmChooseDoc(int ID)
        {
            IDmain = ID;
            InitializeComponent();
            string queryUserName = String.Format("Select name_admin From Admin Where id_user = '{0}'", IDmain);
            userName.Text = "Ваше имя: " + Convert.ToString(dataBase.getResult(queryUserName));

            LoadData();
        }

        private void LoadData()
        {
            string connectionString = @"Server = DESKTOP-BSEODEL\SQLEXPRESS; Database = Polyclinic; Trusted_Connection = True";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            string query = "Select * From Doctor Order By id_user";
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

        public void ListStatus(string typeSearch, string stringReaderBox) 
        {
            dataGridViewDoc.Rows.Clear(); // Чистка старых  данных.
            dataBase.data.Clear(); // чистка нашего буфера данных.

            string querySearchID = String.Format("Select * From Doctor Where id_user LIKE '%" + stringReaderBox + "%'");
            string querySearchFIO = String.Format("Select * From Doctor Where fio_doctor LIKE '%" + stringReaderBox + "%'");
            string querySearchPosition = String.Format("Select * From Doctor Where position_doctor LIKE '%" + stringReaderBox + "%'");
            string querySearchQualif = String.Format("Select * From Doctor Where qualification_doctor LIKE '%" + stringReaderBox + "%'");
            string querySearchSpecializ = String.Format("Select * From Doctor Where specialization_doctor LIKE '%" + stringReaderBox + "%'");

            if (typeSearch == "ID")
            {
                dataBase.Select(querySearchID);
                foreach (string[] s in dataBase.data) // Загрузка данных из нашего буфера.
                    dataGridViewDoc.Rows.Add(s);
            }
            else if (typeSearch == "ФИО сотрудника")
            {
                dataBase.Select(querySearchFIO);
                foreach (string[] s in dataBase.data) // Загрузка данных из нашего буфера.
                    dataGridViewDoc.Rows.Add(s);
            }
            else if (typeSearch == "Должность")
            {
                dataBase.Select(querySearchPosition);
                foreach (string[] s in dataBase.data) // Загрузка данных из нашего буфера.
                    dataGridViewDoc.Rows.Add(s);
            }
            else if (typeSearch == "Квалификация")
            {
                dataBase.Select(querySearchQualif);
                foreach (string[] s in dataBase.data) // Загрузка данных из нашего буфера.
                    dataGridViewDoc.Rows.Add(s);
            }
            else if (typeSearch == "Специализация")
            {
                dataBase.Select(querySearchSpecializ);
                foreach (string[] s in dataBase.data) // Загрузка данных из нашего буфера.
                    dataGridViewDoc.Rows.Add(s);
            }
            else
            {
                MessageBox.Show("Выберите критерий поиска");
            }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MainAdminForm mainAdminForm = new MainAdminForm(IDmain);
            this.Hide();
            mainAdminForm.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddDoc addDoc = new AddDoc(IDmain);
            this.Hide();
            addDoc.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            typeSearchTransfer = listStatus.Text;
            stringReaderBoxTransfer = searchReaderBox.Text;

            ListStatus(typeSearchTransfer, stringReaderBoxTransfer);
        }

        private void AdmChooseDoc_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)   ///buttonChange  
        {
            CellClickForChange(cellClickData); 
        }

        private void dataGridViewDoc_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            cellClickData = dataGridViewDoc.CurrentCell.Value.ToString(); 
            
        }

        private void CellClickForChange(string cellData) 
        {
            int cellID = Convert.ToInt32(cellData);
            ChangeDoc changeDoc = new ChangeDoc(cellID, IDmain);
            this.Hide();
            changeDoc.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int cellIDDel = Convert.ToInt32(cellClickData);

            string queryDelProfile = String.Format("Delete From Doctor Where id_user = '{0}'", cellIDDel);
            string queryDelUser = String.Format("Delete From Users Where id_user = '{0}'", cellIDDel);

            dataBase.Delete(queryDelProfile);
            dataBase.Delete(queryDelUser);

            MessageBox.Show("Данные пользователя удалены");

            dataGridViewDoc.Rows.Clear(); // Чистка старых  данных.
            dataBase.data.Clear(); // чистка нашего буфера данных.
            LoadData();
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            searchReaderBox.Text = String.Empty;
            listStatus.Text = String.Empty;
            dataGridViewDoc.Rows.Clear(); // Чистка старых  данных.
            dataBase.data.Clear(); // чистка нашего буфера данных.
            LoadData();
        }
    }
    }

