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
            userName.Text = "Ваше имя: " + Convert.ToString(dataBase.getResult(queryUserName)) + ", да и ваш айдишник Админа = " + IDmain;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthorizationUser mainForm = new AuthorizationUser();
            this.Hide();
            mainForm.Show();
        }

        private void buttonChooseDoc_Click(object sender, EventArgs e)
        {
            ChooseDoc admChooseDoc = new ChooseDoc(IDmain);
            this.Hide();
            admChooseDoc.Show();
        }

        private void buttonChoosePat_Click(object sender, EventArgs e)
        {
            ChoosePat admChoosePat = new ChoosePat(IDmain);
            this.Hide();
            admChoosePat.Show();
        }

        private void buttonChooseDiz_Click(object sender, EventArgs e)
        {
            ChooseDiz admChooseDiz = new ChooseDiz(IDmain);
            this.Hide();
            admChooseDiz.Show();
        }
    }
}
