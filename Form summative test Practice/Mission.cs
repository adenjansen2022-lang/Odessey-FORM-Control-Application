using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_summative_test_Practice
{
    public partial class Mission : Form
    {
        private frmMain mainForm;
        public Mission(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseMission_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }
    }
}
