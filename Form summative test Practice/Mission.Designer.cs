namespace Form_summative_test_Practice
{
    partial class Mission
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnCloseMission = new System.Windows.Forms.Button();
            this.cmbMissionName = new System.Windows.Forms.ComboBox();
            this.cmbMissionStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mission";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Event notification will appear here";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(255, 237);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(138, 49);
            this.btnUpdateStatus.TabIndex = 3;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnCloseMission
            // 
            this.btnCloseMission.Location = new System.Drawing.Point(437, 237);
            this.btnCloseMission.Name = "btnCloseMission";
            this.btnCloseMission.Size = new System.Drawing.Size(146, 49);
            this.btnCloseMission.TabIndex = 4;
            this.btnCloseMission.Text = "Close";
            this.btnCloseMission.UseVisualStyleBackColor = true;
            this.btnCloseMission.Click += new System.EventHandler(this.btnCloseMission_Click);
            // 
            // cmbMissionName
            // 
            this.cmbMissionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMissionName.FormattingEnabled = true;
            this.cmbMissionName.Location = new System.Drawing.Point(255, 104);
            this.cmbMissionName.Name = "cmbMissionName";
            this.cmbMissionName.Size = new System.Drawing.Size(328, 24);
            this.cmbMissionName.TabIndex = 5;
            // 
            // cmbMissionStatus
            // 
            this.cmbMissionStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMissionStatus.FormattingEnabled = true;
            this.cmbMissionStatus.Location = new System.Drawing.Point(255, 167);
            this.cmbMissionStatus.Name = "cmbMissionStatus";
            this.cmbMissionStatus.Size = new System.Drawing.Size(328, 24);
            this.cmbMissionStatus.TabIndex = 6;
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbMissionStatus);
            this.Controls.Add(this.cmbMissionName);
            this.Controls.Add(this.btnCloseMission);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mission";
            this.Text = "Mission";
            this.Load += new System.EventHandler(this.Mission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnCloseMission;
        private System.Windows.Forms.ComboBox cmbMissionName;
        private System.Windows.Forms.ComboBox cmbMissionStatus;
    }
}