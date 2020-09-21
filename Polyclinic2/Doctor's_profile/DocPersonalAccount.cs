using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyclinic2.Doctor_s_profile
{
    public partial class DocPersonalAccount : Form
    {
        public int IDmain;

        public DocPersonalAccount(int ID)
        {
            IDmain = ID;

            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MainDoctorForm mainDoctorForm = new MainDoctorForm(IDmain);
            this.Hide();
            mainDoctorForm.Show();
        }
    }
}
