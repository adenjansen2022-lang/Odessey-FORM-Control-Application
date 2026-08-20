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
    public partial class Event_Log : Form
    {
        private frmMain mainform;

        public Event_Log(frmMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void btnCloseEventLog_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform.Show();
        }

        private void Event_Log_Load(object sender, EventArgs e)
        {
            //load all saved historical log entries into the listbox
            foreach(string logEntry in MissionClass.EventHistory)
            {
                listBox1.Items.Add(logEntry);
            }
            //subscriber receives real time updates while this form is open
            MissionClass.StatusChanged += LogMissionEvent;
        }

        private void LogMissionEvent(object sender, string message)
        {
            listBox1.Items.Add(message);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
