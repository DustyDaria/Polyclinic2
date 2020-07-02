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
    public partial class AdmChooseDiz : Form
    {
        DataBase dataBase = new DataBase();

        public int IDmain;
        public string typeSearchTransfer_Diz, typeSearchTransfer_Pat;
        public string stringReaderBoxTransfer;
        public string cellClickDataPat = String.Empty, cellClickDataDiz = String.Empty;
        public int cellClickRowIndex;
        public int cellClickColumnIndex;

        public string search_ID_FROM_Pat = String.Empty, search_ID_FROM_Diz = String.Empty;

        public List<String> ID_users = new List<String>();

        public const string tablePat = "Patient";
        public const string tableDiz = "Diagnosis";

        public AdmChooseDiz(int ID)
        {
            IDmain = ID;
            InitializeComponent();
            string queryUserName = String.Format("Select name_admin From Admin Where id_user = '{0}'", IDmain);
            userName.Text = "Ваше имя: " + Convert.ToString(dataBase.getResult(queryUserName));

            LoadDataDiz();
            LoadDataPat();
        }

        private void LoadDataDiz()
        {
            string connectionString = @"Server = DESKTOP-BSEODEL\SQLEXPRESS; Database = Polyclinic; Trusted_Connection = True";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();

            string queryDiz = "Select * From " + tableDiz + " Order By id_user;";

            SqlCommand command = new SqlCommand(queryDiz, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();
            myConnection.Close();
            foreach (string[] diz in data)
                dataGridViewDiz.Rows.Add(diz);
        }

        private void LoadDataPat()
        {
            string connectionString = @"Server = DESKTOP-BSEODEL\SQLEXPRESS; Database = Polyclinic; Trusted_Connection = True";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            
            string queryPat = "Select * From " + tablePat + " Order By id_user";

            SqlCommand command = new SqlCommand(queryPat, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }
            reader.Close();
            myConnection.Close();
            foreach (string[] pat in data)
                dataGridViewPat.Rows.Add(pat);
        }
       

        private void ListStatus(string typeSearchDiz, string typeSearchPat, string stringReaderBox)
        {
             
            //=============== Нужно доработать поиск ======================//



            dataGridViewDiz.Rows.Clear();//чистка старых данных
            dataGridViewPat.Rows.Clear();
            dataBase.data.Clear(); //чистка буфера данных
            
            string queryIDDiz = String.Format("SELECT * FROM " + tableDiz + " WHERE id_user LIKE '%" + stringReaderBox + "%';");
            string queryIDPat = String.Format("SELECT * FROM " + tablePat + " WHERE id_user LIKE '%" + stringReaderBox + "%';");

            string queryDiagnosisDiz = String.Format("SELECT * FROM " + tableDiz + " WHERE diagnosis LIKE '%" + stringReaderBox + "%';");
            string queryDiagnosisDiz_ID = String.Format("SELECT id_user FROM " + tableDiz + " WHERE diagnosis LIKE '%" + stringReaderBox + "%';");

            string queryAmbulatoryTreatmentDiz = String.Format("SELECT * FROM " + tableDiz + " WHERE ambulatoryTreatment LIKE '%" + stringReaderBox + "%';");
            string queryAmbulatoryTreatmentDiz_ID = String.Format("SELECT id_user FROM " + tableDiz + " WHERE ambulatoryTreatment LIKE '%" + stringReaderBox + "%';");

            string queryTermOfDisabilityDiz = String.Format("SELECT * FROM " + tableDiz + " WHERE termOfDisability LIKE '%" + stringReaderBox + "%';");
            string queryTermOfDisabilityDiz_ID = String.Format("SELECT id_user FROM " + tableDiz + " WHERE termOfDisability LIKE '%" + stringReaderBox + "%';");

            string queryDispensaryAccountingDiz = String.Format("SELECT * FROM " + tableDiz + " WHERE dispensaryAccounting LIKE '%" + stringReaderBox + "%';");
            string queryDispensaryAccountingDiz_ID = String.Format("SELECT id_user FROM " + tableDiz + " WHERE dispensaryAccounting LIKE '%" + stringReaderBox + "%';");

            string queryStartDateOfTreatmentDiz = String.Format("SELECT * FROM " + tableDiz + " WHERE startDateOfTreatment LIKE '%" + stringReaderBox + "%';");
            string queryStartDateOfTreatmentDiz_ID = String.Format("SELECT id_user FROM " + tableDiz + "WHERE startDateOfTreatment LIKE '%" + stringReaderBox + "%';");
            
            string queryFIOPat = String.Format("SELECT * FROM " + tablePat + " WHERE fio_patient LIKE '%" + stringReaderBox + "%';");
            string queryFIOPat_ID = String.Format("SELECT id_user FROM " + tablePat + " WHERE fio_patient LIKE '%" + stringReaderBox + "%';");
            
            string queryBirthPatientPat = String.Format("SELECT * FROM " + tablePat + " WHERE birth_patient LIKE '%" + stringReaderBox + "%';");
            string queryBirthPatientPat_ID = String.Format("SELECT id_user FROM " + tablePat + " WHERE birth_patient LIKE '%" + stringReaderBox + "%';");

            string querySocialStatusPat = String.Format("SELECT * FROM " + tablePat + " WHERE socialStatus_patient LIKE '%" + stringReaderBox + "%';");
            string querySocialStatusPat_ID = String.Format("SELECT id_user FROM " + tablePat + " WHERE socialStatus_patient LIKE '%" + stringReaderBox + "%';");

            string queryCurrentStatePat = String.Format("SELECT * FROM " + tablePat + " WHERE currentState_patient LIKE '%" + stringReaderBox + "%';");
            string queryCurrentStatePat_ID = String.Format("SELECT id_user FROM " + tablePat + " WHERE currentState_patient LIKE '%" + stringReaderBox + "%';");
            

            if (Convert.ToString(typeSearchDiz) != String.Empty && Convert.ToString(typeSearchPat) == String.Empty)
            {
                if (Convert.ToString(typeSearchDiz) == "ID")
                {
                    dataBase.Select_6(queryIDDiz);
                    foreach (string[] diz in dataBase.data)  // Загрузка данных из нашего буфера.
                        dataGridViewDiz.Rows.Add(diz);

                    dataBase.data.Clear(); //чистка буфера данных

                    dataBase.Select(queryIDPat);
                    foreach (string[] pat in dataBase.data)
                        dataGridViewPat.Rows.Add(pat);
                }
                else if (Convert.ToString(typeSearchDiz) == "Диагноз пациента")
                {
                    dataBase.Select_6(queryDiagnosisDiz);
                    foreach (string[] diz in dataBase.data)
                    {
                        dataGridViewDiz.Rows.Add(diz);
                        ID_users.Add(Convert.ToString(dataBase.getID(queryDiagnosisDiz_ID)));
                    }

                    dataBase.data.Clear();

                    //search_ID_FROM_Diz = Convert.ToString(dataBase.getID(queryDiagnosisDiz_ID));

                    //int n = ID_users.Count;

                    /*dataBase.Select("SELECT * FROM " + tablePat + " WHERE id_user = '" + ID_users.ForEach() + "';");
                    foreach (string[] pat in dataBase.data)
                        dataGridViewPat.Rows.Add(pat);*/

                    /*ID_users.ForEach(delegate (string id)
                    {
                        dataBase.Select("SELECT * FROM " + tablePat + " WHERE id_user = '" + id + "';");
                        foreach (string[] pat in dataBase.data)
                            dataGridViewPat.Rows.Add(pat);
                    });*/

                    /*for (int i = 0; i < ID_users.Count; i++)
                    {
                        dataBase.Select("SELECT * FROM " + tablePat + " WHERE id_user = '" + ID_users[i] + "';");
                        foreach (string[] pat in dataBase.data)
                            dataGridViewPat.Rows.Add(pat);
                    }*/

                    foreach (var item in ID_users)
                    {
                        dataBase.Select("SELECT * FROM " + tablePat + " WHERE id_user = '" + item + "';");
                        foreach (string[] pat in dataBase.data)
                            dataGridViewPat.Rows.Add(pat);
                    }
                }
                else if (Convert.ToString(typeSearchDiz) == "Амбулаторное лечение")
                {
                    
                    dataBase.Select_6(queryAmbulatoryTreatmentDiz);
                    foreach (string[] diz in dataBase.data)
                    {
                        dataGridViewDiz.Rows.Add(diz);
                        ID_users.Add(Convert.ToString(dataBase.getID(queryAmbulatoryTreatmentDiz_ID)));
                    }

                    dataBase.data.Clear(); 

                    //search_ID_FROM_Diz = Convert.ToString(dataBase.getID(queryAmbulatoryTreatmentDiz_ID));

                    foreach (var item in ID_users)
                    {
                        dataBase.Select("SELECT * FROM " + tablePat + " WHERE id_user = '" + item + "';");
                        foreach (string[] pat in dataBase.data)
                            dataGridViewPat.Rows.Add(pat);
                    }
                }
                else if (Convert.ToString(typeSearchDiz) == "Срок нетрудоспособности")
                {
                    dataBase.Select_6(queryTermOfDisabilityDiz);
                    foreach (string[] diz in dataBase.data)
                    {
                        dataGridViewDiz.Rows.Add(diz);
                        ID_users.Add(Convert.ToString(dataBase.getID(queryTermOfDisabilityDiz_ID)));
                    }
                        
                    dataBase.data.Clear();

                    //search_ID_FROM_Diz = Convert.ToString(dataBase.getID(queryTermOfDisabilityDiz_ID));

                    foreach (var item in ID_users)
                    {
                        dataBase.Select("SELECT * FROM " + tablePat + " WHERE id_user = '" + item + "';");
                        foreach (string[] pat in dataBase.data)
                            dataGridViewPat.Rows.Add(pat);
                    }
                }
                else if (Convert.ToString(typeSearchDiz) == "Диспансерный учет")
                {
                    dataBase.Select_6(queryDispensaryAccountingDiz);
                    foreach (string[] diz in dataBase.data)
                    {
                        dataGridViewDiz.Rows.Add(diz);
                        ID_users.Add(Convert.ToString(dataBase.getID(queryDispensaryAccountingDiz_ID)));
                    }
                        
                    dataBase.data.Clear();

                    //search_ID_FROM_Diz = Convert.ToString(dataBase.getID(queryDispensaryAccountingDiz_ID));

                    foreach (var item in ID_users)
                    {
                        dataBase.Select("SELECT * FROM " + tablePat + " WHERE id_user = '" + item + "';");
                        foreach (string[] pat in dataBase.data)
                            dataGridViewPat.Rows.Add(pat);
                    }
                    
                }
                else if (Convert.ToString(typeSearchDiz) == "Дата начала лечения")
                {
                    dataBase.Select_6(queryStartDateOfTreatmentDiz);
                    foreach (string[] diz in dataBase.data)
                    {
                        dataGridViewDiz.Rows.Add(diz);
                        ID_users.Add(Convert.ToString(dataBase.getID(queryStartDateOfTreatmentDiz_ID)));
                    }

                    dataBase.data.Clear();

                    //search_ID_FROM_Diz = Convert.ToString(dataBase.getID(queryStartDateOfTreatmentDiz_ID));

                    foreach (var item in ID_users)
                    {
                        dataBase.Select("SELECT * FROM " + tablePat + " WHERE id_user = '" + item + "';");
                        foreach (string[] pat in dataBase.data)
                            dataGridViewPat.Rows.Add(pat);
                    }
                    
                }
            }
            else if (Convert.ToString(typeSearchPat) != String.Empty && Convert.ToString(typeSearchDiz) == String.Empty)
            {
                if (Convert.ToString(typeSearchPat) == "ID")
                {
                    dataBase.Select(queryIDPat);
                    foreach (string[] pat in dataBase.data)
                        dataGridViewPat.Rows.Add(pat);

                    dataBase.data.Clear();

                    dataBase.Select_6(queryIDDiz);
                    foreach (string[] diz in dataBase.data)
                        dataGridViewDiz.Rows.Add(diz);
                }
                else if (Convert.ToString(typeSearchPat) == "ФИО пациента")
                {
                    dataBase.Select(queryFIOPat);
                    foreach (string[] pat in dataBase.data)
                    {
                        dataGridViewPat.Rows.Add(pat);
                        ID_users.Add(Convert.ToString(dataBase.getID(queryFIOPat_ID)));
                    }

                    dataBase.data.Clear();

                    //search_ID_FROM_Pat = Convert.ToString(dataBase.getID(queryFIOPat_ID));

                    foreach (var item in ID_users)
                    {
                        dataBase.Select_6("SELECT * FROM " + tableDiz + " WHERE id_user = '" + item + "';");
                        foreach (string[] diz in dataBase.data)
                            dataGridViewDiz.Rows.Add(diz);
                    }
                    
                }
                else if (Convert.ToString(typeSearchPat) == "Дата рождения пациента")
                {
                    dataBase.Select(queryBirthPatientPat);
                    foreach (string[] pat in dataBase.data)
                    {
                        dataGridViewPat.Rows.Add(pat);
                        ID_users.Add(Convert.ToString(dataBase.getID(queryBirthPatientPat_ID)));
                    }

                    dataBase.data.Clear();

                    //search_ID_FROM_Pat = Convert.ToString(dataBase.getID(queryBirthPatientPat_ID));

                    foreach (var item in ID_users)
                    {
                        dataBase.Select_6("SELECT * FROM " + tableDiz + " WHERE id_user = '" + item + "';");
                        foreach (string[] diz in dataBase.data)
                            dataGridViewDiz.Rows.Add(diz);
                    }
                }
                else if (Convert.ToString(typeSearchPat) == "Социальный статус пациента")
                {
                    dataBase.Select(querySocialStatusPat);
                    foreach (string[] pat in dataBase.data)
                    {
                        dataGridViewPat.Rows.Add(pat);
                        ID_users.Add(Convert.ToString(dataBase.getID(querySocialStatusPat_ID)));
                    }
                        
                    dataBase.data.Clear(); //чистка буфера данных

                    //search_ID_FROM_Pat = Convert.ToString(dataBase.getID(querySocialStatusPat_ID));

                    foreach (var item in ID_users)
                    {
                        dataBase.Select_6("SELECT * FROM " + tableDiz + " WHERE id_user = '" + item + "';");
                        foreach (string[] diz in dataBase.data)
                            dataGridViewDiz.Rows.Add(diz);
                    }
                }
                else if (Convert.ToString(typeSearchPat) == "Текущее состояние пациента")
                {
                    dataBase.Select(queryCurrentStatePat);
                    foreach (string[] pat in dataBase.data)
                    {
                        dataGridViewPat.Rows.Add(pat);
                        ID_users.Add(Convert.ToString(dataBase.getID(queryCurrentStatePat_ID)));
                    }

                    dataBase.data.Clear(); //чистка буфера данных

                    //search_ID_FROM_Pat = Convert.ToString(dataBase.getID(queryCurrentStatePat_ID));

                    foreach (var item in ID_users)
                    {
                        dataBase.Select_6("SELECT * FROM " + tableDiz + " WHERE id_user = '" + item + "';");
                        foreach (string[] diz in dataBase.data)
                            dataGridViewDiz.Rows.Add(diz);
                    }
                }
            }
            else if (Convert.ToString(listStatusPat) == String.Empty && Convert.ToString(listStatusDiz) == String.Empty)
            {
                MessageBox.Show("Выберите один из двух критериев поиска");
            }
            else
            {
                MessageBox.Show("Выберите один из двух критериев поиска");
            }
            
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            typeSearchTransfer_Diz = listStatusDiz.Text;
            typeSearchTransfer_Pat = listStatusPat.Text;
            stringReaderBoxTransfer = searchReaderBox.Text;

            ListStatus(typeSearchTransfer_Diz, typeSearchTransfer_Pat, stringReaderBoxTransfer);
        }

        private void AdmChooseDiz_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            searchReaderBox.Text = String.Empty;
            listStatusDiz.Text = String.Empty;
            listStatusPat.Text = String.Empty;
            ID_users.Clear();
            dataGridViewDiz.Rows.Clear(); // Чистка старых  данных.
            dataGridViewPat.Rows.Clear();
            dataBase.data.Clear(); // чистка нашего буфера данных.
            LoadDataDiz();
            LoadDataPat();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int cellIDPat = Convert.ToInt32(cellClickDataPat);
            AddDiz addDiz = new AddDiz(cellIDPat, IDmain);
            this.Hide();
            addDiz.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MainAdminForm mainAdminForm = new MainAdminForm(IDmain);
            this.Hide();
            mainAdminForm.Show();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int cellIDDiz = Convert.ToInt32(cellClickDataDiz);
            ChangeDiz changeDiz = new ChangeDiz(cellIDDiz, IDmain);
            this.Hide();
            changeDiz.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int cellIDDiz = Convert.ToInt32(cellClickDataDiz);

            string queryDelDiz = String.Format("Delete From Diagnosis Where id_user = '" + cellIDDiz + "'");

            dataBase.Delete(queryDelDiz);

            MessageBox.Show("Данные о диагнозе пациента удалены");

            dataGridViewDiz.Rows.Clear(); // Чистка старых  данных.
            dataBase.data.Clear(); // чистка нашего буфера данных.
            LoadDataDiz();

            dataGridViewPat.Rows.Clear();
            dataBase.data.Clear();
            LoadDataPat();
        }

        private void dataGridViewPat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cellClickDataPat = dataGridViewPat.CurrentCell.Value.ToString();
        }

        private void dataGridViewDiz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cellClickDataDiz = dataGridViewDiz.CurrentCell.Value.ToString();
        }
    }
}
