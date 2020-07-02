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
    public partial class MainAdminForm : Form
    {
        public int IDmain;
        DataBase dataBase = new DataBase();

        public MainAdminForm(int ID)
        {
            IDmain = ID;
            InitializeComponent();
            string queryUserName = String.Format("Select name_admin From Admin Where id_user = '{0}'", IDmain);
            userName.Text = "Ваше имя: " + Convert.ToString(dataBase.getResult(queryUserName));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            this.Hide();
            mainForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonChooseDoc_Click(object sender, EventArgs e)
        {
            AdmChooseDoc admChooseDoc = new AdmChooseDoc(IDmain);
            this.Hide();
            admChooseDoc.Show();
        }

        private void buttonChoosePat_Click(object sender, EventArgs e)
        {
            AdmChoosePat admChoosePat = new AdmChoosePat(IDmain);
            this.Hide();
            admChoosePat.Show();
        }

        private void buttonChooseDiz_Click(object sender, EventArgs e)
        {
            AdmChooseDiz admChooseDiz = new AdmChooseDiz(IDmain);
            this.Hide();
            admChooseDiz.Show();
        }
    }
}
