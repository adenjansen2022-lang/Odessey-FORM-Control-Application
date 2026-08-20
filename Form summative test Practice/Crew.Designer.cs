namespace Form_summative_test_Practice
{
    partial class Crew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCloseCrew = new System.Windows.Forms.Button();
            this.btnAddCrew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCrew = new System.Windows.Forms.DataGridView();
            this.groupBoxCrewDetails = new System.Windows.Forms.GroupBox();
            this.btnPerformDuty = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveMember = new System.Windows.Forms.Button();
            this.textAssigned = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrew)).BeginInit();
            this.groupBoxCrewDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseCrew
            // 
            this.btnCloseCrew.Location = new System.Drawing.Point(584, 372);
            this.btnCloseCrew.Name = "btnCloseCrew";
            this.btnCloseCrew.Size = new System.Drawing.Size(144, 52);
            this.btnCloseCrew.TabIndex = 0;
            this.btnCloseCrew.Text = "Close";
            this.btnCloseCrew.UseVisualStyleBackColor = true;
            this.btnCloseCrew.Click += new System.EventHandler(this.btnCloseCrew_Click);
            // 
            // btnAddCrew
            // 
            this.btnAddCrew.Location = new System.Drawing.Point(62, 372);
            this.btnAddCrew.Name = "btnAddCrew";
            this.btnAddCrew.Size = new System.Drawing.Size(152, 52);
            this.btnAddCrew.TabIndex = 1;
            this.btnAddCrew.Text = "Add Crew";
            this.btnAddCrew.UseVisualStyleBackColor = true;
            this.btnAddCrew.Click += new System.EventHandler(this.btnAddCrew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Crew Manifest";
            // 
            // dgvCrew
            // 
            this.dgvCrew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrew.Location = new System.Drawing.Point(59, 58);
            this.dgvCrew.Name = "dgvCrew";
            this.dgvCrew.RowHeadersWidth = 51;
            this.dgvCrew.RowTemplate.Height = 24;
            this.dgvCrew.Size = new System.Drawing.Size(669, 291);
            this.dgvCrew.TabIndex = 3;
            // 
            // groupBoxCrewDetails
            // 
            this.groupBoxCrewDetails.Controls.Add(this.numericUpDownId);
            this.groupBoxCrewDetails.Controls.Add(this.btnPerformDuty);
            this.groupBoxCrewDetails.Controls.Add(this.cmbType);
            this.groupBoxCrewDetails.Controls.Add(this.btnClear);
            this.groupBoxCrewDetails.Controls.Add(this.btnSaveMember);
            this.groupBoxCrewDetails.Controls.Add(this.textAssigned);
            this.groupBoxCrewDetails.Controls.Add(this.label6);
            this.groupBoxCrewDetails.Controls.Add(this.label5);
            this.groupBoxCrewDetails.Controls.Add(this.txbName);
            this.groupBoxCrewDetails.Controls.Add(this.txbRole);
            this.groupBoxCrewDetails.Controls.Add(this.label3);
            this.groupBoxCrewDetails.Controls.Add(this.label2);
            this.groupBoxCrewDetails.Controls.Add(this.label7);
            this.groupBoxCrewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCrewDetails.Location = new System.Drawing.Point(788, 41);
            this.groupBoxCrewDetails.Name = "groupBoxCrewDetails";
            this.groupBoxCrewDetails.Size = new System.Drawing.Size(448, 366);
            this.groupBoxCrewDetails.TabIndex = 4;
            this.groupBoxCrewDetails.TabStop = false;
            this.groupBoxCrewDetails.Text = "Enter member detials";
            // 
            // btnPerformDuty
            // 
            this.btnPerformDuty.Location = new System.Drawing.Point(253, 299);
            this.btnPerformDuty.Name = "btnPerformDuty";
            this.btnPerformDuty.Size = new System.Drawing.Size(182, 38);
            this.btnPerformDuty.TabIndex = 36;
            this.btnPerformDuty.Text = "Perform duty";
            this.btnPerformDuty.UseVisualStyleBackColor = true;
            this.btnPerformDuty.Click += new System.EventHandler(this.btnPerformDuty_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(109, 201);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(241, 37);
            this.cmbType.TabIndex = 35;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(127, 299);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 38);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveMember
            // 
            this.btnSaveMember.Location = new System.Drawing.Point(6, 299);
            this.btnSaveMember.Name = "btnSaveMember";
            this.btnSaveMember.Size = new System.Drawing.Size(115, 38);
            this.btnSaveMember.TabIndex = 33;
            this.btnSaveMember.Text = "Save";
            this.btnSaveMember.UseVisualStyleBackColor = true;
            this.btnSaveMember.Click += new System.EventHandler(this.btnSaveMember_Click);
            // 
            // textAssigned
            // 
            this.textAssigned.Location = new System.Drawing.Point(140, 243);
            this.textAssigned.Name = "textAssigned";
            this.textAssigned.Size = new System.Drawing.Size(241, 34);
            this.textAssigned.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "assigned";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Type:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(109, 117);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(241, 34);
            this.txbName.TabIndex = 27;
            // 
            // txbRole
            // 
            this.txbRole.Location = new System.Drawing.Point(109, 161);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(241, 34);
            this.txbRole.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "id:";
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(109, 79);
            this.numericUpDownId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(241, 34);
            this.numericUpDownId.TabIndex = 37;
            // 
            // Crew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 450);
            this.Controls.Add(this.groupBoxCrewDetails);
            this.Controls.Add(this.dgvCrew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCrew);
            this.Controls.Add(this.btnCloseCrew);
            this.Name = "Crew";
            this.Text = "Crew";
            this.Load += new System.EventHandler(this.Crew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrew)).EndInit();
            this.groupBoxCrewDetails.ResumeLayout(false);
            this.groupBoxCrewDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseCrew;
        private System.Windows.Forms.Button btnAddCrew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCrew;
        private System.Windows.Forms.GroupBox groupBoxCrewDetails;
        private System.Windows.Forms.TextBox textAssigned;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveMember;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnPerformDuty;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
    }
}