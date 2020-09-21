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
    public partial class AddDiz : Form
    { 
        DataBase dataBase = new DataBase();
        
        public string diagnosisAdd = String.Empty, ambulatoryTreatmentAdd = String.Empty, termOfDisabilityAdd = String.Empty;
        public string dispensaryAccountingAdd = String.Empty, startDateOfTreatmentAdd = String.Empty;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            diagnosisAdd = diagnosisBox.Text;
            ambulatoryTreatmentAdd = ambulatoryTreatmentBox.Text;
            termOfDisabilityAdd = termOfDisabilityBox.Text;
            dispensaryAccountingAdd = dispensaryAccountingBox.Text;
            startDateOfTreatmentAdd = startDateOfTreatmentBox.Text;

            if (diagnosisAdd == "")
            {
                MessageBox.Show("Диагноз - это обязательное для заполнения поле");
            }
            else if (ambulatoryTreatmentAdd == "")
            {
                MessageBox.Show("Амбулаторное лечение - это обязательное поле для заполнения");
            }
            else if (startDateOfTreatmentAdd == "")
            {
                MessageBox.Show("Дата начала лечения - это обязательное для заполнения поле");
            }
            else
            {
                string queryDiz = String.Format("INSERT INTO Diagnosis (id_user, diagnosis, ambulatoryTreatment, termOfDisability, dispensaryAccounting, startDateOfTreatment) Values ('" 
                    + cellID + "', '" + diagnosisAdd + "', '" + ambulatoryTreatmentAdd + "', '" + termOfDisabilityAdd + "', '" + dispensaryAccountingAdd + "', '" + startDateOfTreatmentAdd + "')");
                dataBase.Insert(queryDiz);

                MessageBox.Show("Новый диагноз пациента успешно добавлен");
            }

            ChooseDiz admChooseDiz = new ChooseDiz(returnIDmain);
            this.Hide();
            admChooseDiz.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ChooseDiz admChooseDiz = new ChooseDiz(returnIDmain);
            this.Hide();
            admChooseDiz.Show();
        }

        public int cellID, returnIDmain;

        public AddDiz(int ID, int IDmain)
        {
            InitializeComponent();

            cellID = ID;
            returnIDmain = IDmain;

            LoadData(cellID);
        }

        public void LoadData(int ID)
        {
            string queryFioPat = String.Format("SELECT fio_patient FROM Patient WHERE id_user = '" + ID + "'");
            string queryBirthPat = String.Format("SELECT birth_patient FROM Patient WHERE id_user = '" + ID + "'");
            string querySocialStatusPat = String.Format("SELECT socialStatus_patient FROM Patient WHERE id_user = '" + ID + "'");
            string queryCurrentStatePat = String.Format("SELECT currentState_patient FROM Patient WHERE id_user = '" + ID + "'");
            
            fioBox.Text = dataBase.getResult(queryFioPat);
            birthPatientBox.Text = dataBase.getResult(queryBirthPat);
            socialStatusBox.Text = dataBase.getResult(querySocialStatusPat);
            currentStateBox.Text = dataBase.getResult(queryCurrentStatePat);
        }
    }
}
