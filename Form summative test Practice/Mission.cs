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

        private List<MissionClass> missions = new List<MissionClass>();
        private frmMain mainForm;
        public Mission(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        

        private void btnCloseMission_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void Mission_Load(object sender, EventArgs e)
        {
            missions.Add(new MissionClass("Appollo 11", "Moon", "Planned"));
            missions.Add(new MissionClass("Pass the Siren", "Island", "Planned"));
            missions.Add(new MissionClass("Alert companions", "Ship", "Planned"));

            MissionClass.StatusChanged += (s, message) =>
            {
                label3.Text = message;
            };

            foreach (var m in missions)
            { 
                cmbMissionName.Items.Add(m.missionName);
            }

            cmbMissionStatus.Items.Add("In Progress");
            cmbMissionStatus.Items.Add("Completed");
            cmbMissionStatus.Items.Add("Failed");
            cmbMissionStatus.Items.Add("Planned");
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            string missionName = cmbMissionName.SelectedItem.ToString();
            string status = cmbMissionStatus.SelectedItem.ToString();

            if(cmbMissionName.SelectedItem == null ) {
                MessageBox.Show("Please select a mission.");
                return;
            }

            if(cmbMissionStatus.SelectedItem == null ) {
                MessageBox.Show("Please select a status.");
                return;
            }
             MissionClass selectedMission = missions.Find(m => m.missionName == missionName);
             if (selectedMission != null)
             {
                 selectedMission.status = status;
             }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
