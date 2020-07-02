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
    public partial class MainDoctorForm : Form
    {
        DataBase dataBase = new DataBase();

        public MainDoctorForm(int ID)
        {
            InitializeComponent();
            string queryUserName = String.Format("Select fio_doctor From Doctor Where id_user = '{0}'", ID);
            userName.Text = "Ваше имя: " + Convert.ToString(dataBase.getResult(queryUserName));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            this.Hide();
            mainForm.Show();
        }
    }
}
