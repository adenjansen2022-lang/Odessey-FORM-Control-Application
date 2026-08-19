using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_summative_test_Practice
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        

        

        private void btnCrewManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crew crew = new Crew(this);
            crew.Show();
        }

        private void btnMissionControl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mission crew = new Mission(this);
            crew.Show();
        }

        private void btnEventLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event_Log crew = new Event_Log(this);
            crew.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
