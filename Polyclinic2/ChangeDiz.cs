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
    public partial class ChangeDiz : Form
    {
        DataBase dataBase = new DataBase();

        public int cellID, returnIDmain;

        public string diagnosisChange = String.Empty, ambulatoryTreatmentChange = String.Empty, termOfDisabilityChange = String.Empty;
        public string dispensaryAccountingChange = String.Empty, startDateOfTreatmentChange = String.Empty;

        public ChangeDiz(int ID, int IDmain)
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

            string queryDiagnosis = String.Format("SELECT diagnosis FROM Diagnosis WHERE id_user = '" + ID + "'");
            string queryAmbulatoryTreatment = String.Format("SELECT ambulatoryTreatment FROM Diagnosis WHERE id_user = '" + ID + "'");
            string queryTermOfDisability = String.Format("SELECT termOfDisability FROM Diagnosis WHERE id_user = '" + ID + "'");
            string queryDispensaryAccounting = String.Format("SELECT dispensaryAccounting FROM Diagnosis WHERE id_user = '" + ID + "'");
            string queryStartDateOfTreatment = String.Format("SELECT startDateOfTreatment FROM Diagnosis WHERE id_user = '" + ID + "'");

            fioBox.Text = dataBase.getResult(queryFioPat);
            birthPatientBox.Text = dataBase.getResult(queryBirthPat);
            socialStatusBox.Text = dataBase.getResult(querySocialStatusPat);
            currentStateBox.Text = dataBase.getResult(queryCurrentStatePat);

            diagnosisBox.Text = dataBase.getResult(queryDiagnosis);
            ambulatoryTreatmentBox.Text = dataBase.getResult(queryAmbulatoryTreatment);
            termOfDisabilityBox.Text = dataBase.getResult(queryTermOfDisability);
            dispensaryAccountingBox.Text = dataBase.getResult(queryDispensaryAccounting);
            startDateOfTreatmentBox.Text = dataBase.getResult(queryStartDateOfTreatment);

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            diagnosisChange = diagnosisBox.Text;
            ambulatoryTreatmentChange = ambulatoryTreatmentBox.Text;
            termOfDisabilityChange = termOfDisabilityBox.Text;
            dispensaryAccountingChange = dispensaryAccountingBox.Text;
            startDateOfTreatmentChange = startDateOfTreatmentBox.Text;

            if (diagnosisChange == "")
            {
                MessageBox.Show("Диагноз - это обязательное для заполнения поле");
            }
            else if (ambulatoryTreatmentChange == "")
            {
                MessageBox.Show("Амбулаторное лечение - это обязательное поле для заполнения");
            }
            else if (startDateOfTreatmentChange == "")
            {
                MessageBox.Show("Дата начала лечения - это обязательное для заполнения поле");
            }
            else
            {
                string queryDiz = String.Format("UPDATE Diagnosis SET diagnosis = '" + diagnosisChange + "', ambulatoryTreatment = '" 
                    + ambulatoryTreatmentChange + "', termOfDisability = '" + termOfDisabilityChange + "', dispensaryAccounting = '" 
                    + dispensaryAccountingChange + "', startDateOfTreatment = '" + startDateOfTreatmentChange + "' WHERE id_user = '" + cellID + "'");
                dataBase.Insert(queryDiz);

                MessageBox.Show("Диагноз пациента успешно изменен");
            }

            AdmChooseDiz admChooseDiz = new AdmChooseDiz(returnIDmain);
            this.Hide();
            admChooseDiz.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdmChooseDiz admChooseDiz = new AdmChooseDiz(returnIDmain);
            this.Hide();
            admChooseDiz.Show();
        }
    }
}
