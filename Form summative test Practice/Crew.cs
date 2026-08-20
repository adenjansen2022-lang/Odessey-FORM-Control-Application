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
    public partial class Crew : Form
    {
        private frmMain mainForm;

        
        
        public Crew(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void Crew_Load(object sender, EventArgs e)
        {
            groupBoxCrewDetails.Visible = false;

            

            cmbType.Items.Clear();
            
            cmbType.Items.Add("Senior Crew");
            cmbType.Items.Add("Station Crew");

            dgvCrew.DataSource = mainForm.crewList;
        }

        private void btnCloseCrew_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void btnAddCrew_Click(object sender, EventArgs e)
        {
            groupBoxCrewDetails.Visible = true;
        }

        private void btnSaveMember_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)numericUpDownId.Value;

                bool idExists = mainForm.crewList.Any(c => c.id == id);
                if (idExists) {
                    MessageBox.Show("A crew member with this ID already exists.", "ID Already Exists");
                    return;
                }

                string name = txbName.Text.Trim();
                string role = txbRole.Text.Trim();
                string SelectedType = cmbType.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(role))
                {
                    MessageBox.Show("connot leave name or role empty");
                    return;
                }

                if(string.IsNullOrWhiteSpace(SelectedType))
                {
                    MessageBox.Show("Please select a type from the dropdown.");
                    return;
                }

                CrewClass newMember = CreateCrewMember(SelectedType,id,name, role, textAssigned.Text.Trim());

                if (newMember != null) 
                {
                    mainForm.crewList.Add(newMember);
                    btnClear_Click(sender, e);
                    groupBoxCrewDetails.Visible = false;
                }    
                
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private CrewClass CreateCrewMember(string type, int id, string name, string role, string assigned)
        {
            if (type.Equals("Senior Crew", StringComparison.OrdinalIgnoreCase))
            {
                if (!int.TryParse(assigned, out int rankLevel))
                {
                    MessageBox.Show("For Senior Crew, 'assigned' must be a numeric Rank Level.", "Input Error");
                    return null;
                }
                return new SeniorClass(id, name, role, rankLevel);
            }
            else if (type.Equals("Station Crew", StringComparison.OrdinalIgnoreCase))
            {
                if (string.IsNullOrWhiteSpace(assigned))
                {
                    MessageBox.Show("Station Crew must have a station location assigned.", "Input Error");
                    return null;
                }
                return new StationCrewClass(id, name, role, assigned);
            }
            else
            {
                MessageBox.Show("Type must be either 'Senior Crew' or 'Station Crew'.", "Input Error");
                return null;
            }
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            numericUpDownId.Value = numericUpDownId.Minimum;
            txbName.Clear();
            txbRole.Clear();
            cmbType.SelectedIndex = -1;
            textAssigned.Clear();
        }

        private void btnPerformDuty_Click(object sender, EventArgs e)
        {
            if(dgvCrew.CurrentRow.DataBoundItem is CrewClass selectedCrew)
            {
                MessageBox.Show(selectedCrew.PerformDuty(), $"{selectedCrew.name}'s Duty");
            }
            else
            {
                MessageBox.Show("Please select a crew member from the list to perform duty.", "No Selection");
            }
        }
    }
}
