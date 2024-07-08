namespace Tournament_Scoring_System
{
    partial class fm_DisplayResult
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
            this.btn_event = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_team = new System.Windows.Forms.Button();
            this.btn_particpant = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbx_TeamScore = new System.Windows.Forms.ListBox();
            this.lbx_ParticipantScore = new System.Windows.Forms.ListBox();
            this.btn_score = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_event
            // 
            this.btn_event.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_event.Location = new System.Drawing.Point(676, 12);
            this.btn_event.Name = "btn_event";
            this.btn_event.Size = new System.Drawing.Size(100, 32);
            this.btn_event.TabIndex = 81;
            this.btn_event.Text = "Event";
            this.btn_event.UseVisualStyleBackColor = true;
            this.btn_event.Click += new System.EventHandler(this.btn_event_Click);
            // 
            // btn_result
            // 
            this.btn_result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_result.Location = new System.Drawing.Point(782, 12);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(100, 32);
            this.btn_result.TabIndex = 80;
            this.btn_result.Text = "Result";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_team
            // 
            this.btn_team.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_team.Location = new System.Drawing.Point(577, 12);
            this.btn_team.Name = "btn_team";
            this.btn_team.Size = new System.Drawing.Size(93, 32);
            this.btn_team.TabIndex = 79;
            this.btn_team.Text = "Team";
            this.btn_team.UseVisualStyleBackColor = true;
            this.btn_team.Click += new System.EventHandler(this.btn_team_Click);
            // 
            // btn_particpant
            // 
            this.btn_particpant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_particpant.Location = new System.Drawing.Point(478, 12);
            this.btn_particpant.Name = "btn_particpant";
            this.btn_particpant.Size = new System.Drawing.Size(93, 32);
            this.btn_particpant.TabIndex = 78;
            this.btn_particpant.Text = "Participant";
            this.btn_particpant.UseVisualStyleBackColor = true;
            this.btn_particpant.Click += new System.EventHandler(this.btn_particpant_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(379, 12);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(93, 32);
            this.btn_menu.TabIndex = 77;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 64);
            this.label3.TabIndex = 76;
            this.label3.Text = "Display Result";
            // 
            // lbx_TeamScore
            // 
            this.lbx_TeamScore.FormattingEnabled = true;
            this.lbx_TeamScore.Location = new System.Drawing.Point(261, 98);
            this.lbx_TeamScore.Name = "lbx_TeamScore";
            this.lbx_TeamScore.Size = new System.Drawing.Size(175, 303);
            this.lbx_TeamScore.TabIndex = 83;
            // 
            // lbx_ParticipantScore
            // 
            this.lbx_ParticipantScore.FormattingEnabled = true;
            this.lbx_ParticipantScore.Location = new System.Drawing.Point(27, 98);
            this.lbx_ParticipantScore.Name = "lbx_ParticipantScore";
            this.lbx_ParticipantScore.Size = new System.Drawing.Size(175, 303);
            this.lbx_ParticipantScore.TabIndex = 82;
            // 
            // btn_score
            // 
            this.btn_score.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_score.Location = new System.Drawing.Point(782, 60);
            this.btn_score.Name = "btn_score";
            this.btn_score.Size = new System.Drawing.Size(100, 32);
            this.btn_score.TabIndex = 84;
            this.btn_score.Text = "Score";
            this.btn_score.UseVisualStyleBackColor = true;
            // 
            // fm_DisplayResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 469);
            this.Controls.Add(this.btn_score);
            this.Controls.Add(this.lbx_TeamScore);
            this.Controls.Add(this.lbx_ParticipantScore);
            this.Controls.Add(this.btn_event);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_team);
            this.Controls.Add(this.btn_particpant);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.label3);
            this.Name = "fm_DisplayResult";
            this.Text = "DisplayResult";
            this.Load += new System.EventHandler(this.DisplayResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_event;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_team;
        private System.Windows.Forms.Button btn_particpant;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbx_TeamScore;
        private System.Windows.Forms.ListBox lbx_ParticipantScore;
        private System.Windows.Forms.Button btn_score;
    }
}