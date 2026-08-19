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

        
        BindingList<CrewClass> crewList = new BindingList<CrewClass>();
        public Crew(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void Crew_Load(object sender, EventArgs e)
        {
            groupBoxCrewDetails.Visible = false;

            
            dgvCrew.DataSource = crewList;
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
                if (!int.TryParse(txbID.Text, out int id))
                {
                    MessageBox.Show("enter a numeric value");
                    return;
                }

                string name = txbName.Text.Trim();
                string role = txbRole.Text.Trim();
                string type = txbType.Text.Trim();
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(role))
                {
                    MessageBox.Show("connot leave name or role empty");
                    return;
                }

                CrewClass newMember = null;

                if (type.Equals("Senior Crew", StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(textAssigned.Text, out int rankLevel))
                    {
                        MessageBox.Show("For Senior Crew, 'assigned' must be a numeric Rank Level.", "Input Error");
                        return;
                    }

                    newMember = new SeniorClass(id, name, role, rankLevel);
                }
                else if (type.Equals("Station Crew", StringComparison.OrdinalIgnoreCase))
                {
                    if (string.IsNullOrWhiteSpace(textAssigned.Text))
                    {
                        MessageBox.Show("crew must be in a stattion location");
                        return;
                    }
                    newMember = new StationCrewClass(id, name, role, textAssigned.Text);
                }
                else
                {
                    // Prevents null from being added to the BindingList
                    MessageBox.Show("Type must be either 'Senior Crew' or 'Station Crew'.", "Input Error");
                    return;
                }

                crewList.Add(newMember);
                btnClear_Click(sender, e);
                groupBoxCrewDetails.Visible = false;
                
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbID.Clear();
            txbName.Clear();
            txbRole.Clear();
            txbType.Clear();
            textAssigned.Clear();
        }
    }
}
