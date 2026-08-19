namespace Form_summative_test_Practice
{
    partial class frmMain
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
            this.btnCrewManagement = new System.Windows.Forms.Button();
            this.btnMissionControl = new System.Windows.Forms.Button();
            this.btnEventLog = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "The ODESSEY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voyage Control Centre";
            
            // 
            // btnCrewManagement
            // 
            this.btnCrewManagement.Location = new System.Drawing.Point(255, 113);
            this.btnCrewManagement.Name = "btnCrewManagement";
            this.btnCrewManagement.Size = new System.Drawing.Size(312, 62);
            this.btnCrewManagement.TabIndex = 2;
            this.btnCrewManagement.Text = "Crew Managemnet";
            this.btnCrewManagement.UseVisualStyleBackColor = true;
            this.btnCrewManagement.Click += new System.EventHandler(this.btnCrewManagement_Click);
            // 
            // btnMissionControl
            // 
            this.btnMissionControl.Location = new System.Drawing.Point(255, 181);
            this.btnMissionControl.Name = "btnMissionControl";
            this.btnMissionControl.Size = new System.Drawing.Size(312, 65);
            this.btnMissionControl.TabIndex = 3;
            this.btnMissionControl.Text = "Mission Control";
            this.btnMissionControl.UseVisualStyleBackColor = true;
            this.btnMissionControl.Click += new System.EventHandler(this.btnMissionControl_Click);
            // 
            // btnEventLog
            // 
            this.btnEventLog.Location = new System.Drawing.Point(255, 252);
            this.btnEventLog.Name = "btnEventLog";
            this.btnEventLog.Size = new System.Drawing.Size(312, 65);
            this.btnEventLog.TabIndex = 4;
            this.btnEventLog.Text = "Event Log";
            this.btnEventLog.UseVisualStyleBackColor = true;
            this.btnEventLog.Click += new System.EventHandler(this.btnEventLog_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(255, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(312, 70);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEventLog);
            this.Controls.Add(this.btnMissionControl);
            this.Controls.Add(this.btnCrewManagement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Odessy Main - Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrewManagement;
        private System.Windows.Forms.Button btnMissionControl;
        private System.Windows.Forms.Button btnEventLog;
        private System.Windows.Forms.Button btnExit;
    }
}

