
using Polyclinic2.Doctor_s_profile;
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
        public int IDmain;

        DataBase dataBase = new DataBase();

        public MainDoctorForm(int ID)
        {
            IDmain = ID;

            InitializeComponent();
            string queryUserName = String.Format("Select fio_doctor From Doctor Where id_user = '{0}'", IDmain);
            userName.Text = "Ваше имя: " + Convert.ToString(dataBase.getResult(queryUserName)) + ", да и ваш айдишник Доктора = " + IDmain;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthorizationUser authorizationUser = new AuthorizationUser();
            this.Hide();
            authorizationUser.Show();
        }

        private void buttonChooseDiz_Click(object sender, EventArgs e)
        {
            ChooseDiz chooseDiz = new ChooseDiz(IDmain);
            this.Hide();
            chooseDiz.Show();
        }

        private void buttonChoosePat_Click(object sender, EventArgs e)
        {
            ChoosePat choosePat = new ChoosePat(IDmain);
            this.Hide();
            choosePat.Show();
        }

        private void buttonPersonalAcc_Click(object sender, EventArgs e)
        {
            DocPersonalAccount docPersonalAccount = new DocPersonalAccount(IDmain);
            this.Hide();
            docPersonalAccount.Show();
        }
    }
}
