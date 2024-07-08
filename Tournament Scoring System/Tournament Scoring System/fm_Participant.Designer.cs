using System;

namespace Tournament_Scoring_System
{
    partial class fm_Participant
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
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_event = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_team = new System.Windows.Forms.Button();
            this.btn_particpant = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbx_Participants = new System.Windows.Forms.ListBox();
            this.cbx_Teams = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_Surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Forename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_score = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_menu
            // 
            this.btn_menu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(305, 9);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(93, 32);
            this.btn_menu.TabIndex = 46;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_event
            // 
            this.btn_event.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_event.Location = new System.Drawing.Point(602, 9);
            this.btn_event.Name = "btn_event";
            this.btn_event.Size = new System.Drawing.Size(93, 32);
            this.btn_event.TabIndex = 45;
            this.btn_event.Text = "Event";
            this.btn_event.UseVisualStyleBackColor = true;
            this.btn_event.Click += new System.EventHandler(this.btn_event_Click);
            // 
            // btn_result
            // 
            this.btn_result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_result.Location = new System.Drawing.Point(701, 9);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(93, 32);
            this.btn_result.TabIndex = 44;
            this.btn_result.Text = "Result";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_team
            // 
            this.btn_team.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_team.Location = new System.Drawing.Point(503, 9);
            this.btn_team.Name = "btn_team";
            this.btn_team.Size = new System.Drawing.Size(93, 32);
            this.btn_team.TabIndex = 43;
            this.btn_team.Text = "Team";
            this.btn_team.UseVisualStyleBackColor = true;
            this.btn_team.Click += new System.EventHandler(this.btn_team_Click);
            // 
            // btn_particpant
            // 
            this.btn_particpant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_particpant.Location = new System.Drawing.Point(404, 9);
            this.btn_particpant.Name = "btn_particpant";
            this.btn_particpant.Size = new System.Drawing.Size(93, 32);
            this.btn_particpant.TabIndex = 42;
            this.btn_particpant.Text = "Participant";
            this.btn_particpant.UseVisualStyleBackColor = true;
            this.btn_particpant.Click += new System.EventHandler(this.btn_particpant_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(642, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 62;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(642, 139);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 61;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(642, 89);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 60;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // lbx_Participants
            // 
            this.lbx_Participants.Location = new System.Drawing.Point(348, 94);
            this.lbx_Participants.Name = "lbx_Participants";
            this.lbx_Participants.Size = new System.Drawing.Size(288, 199);
            this.lbx_Participants.TabIndex = 63;
            this.lbx_Participants.SelectedIndexChanged += new System.EventHandler(this.lbx_Participants_SelectedIndexChanged_1);
            // 
            // cbx_Teams
            // 
            this.cbx_Teams.FormattingEnabled = true;
            this.cbx_Teams.Location = new System.Drawing.Point(189, 259);
            this.cbx_Teams.Name = "cbx_Teams";
            this.cbx_Teams.Size = new System.Drawing.Size(100, 21);
            this.cbx_Teams.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Team";
            // 
            // tbx_ID
            // 
            this.tbx_ID.Location = new System.Drawing.Point(189, 121);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.Size = new System.Drawing.Size(100, 20);
            this.tbx_ID.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "ID";
            // 
            // tbx_Surname
            // 
            this.tbx_Surname.Location = new System.Drawing.Point(189, 209);
            this.tbx_Surname.Name = "tbx_Surname";
            this.tbx_Surname.Size = new System.Drawing.Size(100, 20);
            this.tbx_Surname.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "LastName";
            // 
            // tbx_Forename
            // 
            this.tbx_Forename.Location = new System.Drawing.Point(189, 160);
            this.tbx_Forename.Name = "tbx_Forename";
            this.tbx_Forename.Size = new System.Drawing.Size(100, 20);
            this.tbx_Forename.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "FirstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 64);
            this.label3.TabIndex = 72;
            this.label3.Text = "Participant";
            // 
            // btn_score
            // 
            this.btn_score.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_score.Location = new System.Drawing.Point(701, 47);
            this.btn_score.Name = "btn_score";
            this.btn_score.Size = new System.Drawing.Size(93, 32);
            this.btn_score.TabIndex = 73;
            this.btn_score.Text = "Score";
            this.btn_score.UseVisualStyleBackColor = true;
            this.btn_score.Click += new System.EventHandler(this.btn_score_Click);
            // 
            // fm_Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_Teams);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_Surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_Forename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbx_Participants);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_event);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_team);
            this.Controls.Add(this.btn_particpant);
            this.Name = "fm_Participant";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.fm_Participant_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_event;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_team;
        private System.Windows.Forms.Button btn_particpant;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListBox lbx_Participants;
        private System.Windows.Forms.ComboBox cbx_Teams;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_Surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Forename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private EventHandler fm_Participant_Load;
        private System.Windows.Forms.Button btn_score;
    }
}