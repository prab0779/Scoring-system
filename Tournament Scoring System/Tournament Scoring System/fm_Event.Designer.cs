namespace Tournament_Scoring_System
{
    partial class fm_Event
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
            this.cbx_Team = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbx_Events = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_Category = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_EventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_score = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_event = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_team = new System.Windows.Forms.Button();
            this.btn_particpant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_Team
            // 
            this.cbx_Team.FormattingEnabled = true;
            this.cbx_Team.Location = new System.Drawing.Point(37, 301);
            this.cbx_Team.Name = "cbx_Team";
            this.cbx_Team.Size = new System.Drawing.Size(100, 21);
            this.cbx_Team.TabIndex = 51;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(554, 225);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 46;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click_1);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(554, 181);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 45;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(554, 136);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 44;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // lbx_Events
            // 
            this.lbx_Events.FormattingEnabled = true;
            this.lbx_Events.Location = new System.Drawing.Point(232, 136);
            this.lbx_Events.Name = "lbx_Events";
            this.lbx_Events.Size = new System.Drawing.Size(302, 186);
            this.lbx_Events.TabIndex = 43;
            this.lbx_Events.SelectedIndexChanged += new System.EventHandler(this.lbx_Events_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Team";
            // 
            // tbx_ID
            // 
            this.tbx_ID.Location = new System.Drawing.Point(37, 152);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.Size = new System.Drawing.Size(100, 20);
            this.tbx_ID.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 64);
            this.label3.TabIndex = 39;
            this.label3.Text = " Events";
            // 
            // tbx_Category
            // 
            this.tbx_Category.Location = new System.Drawing.Point(37, 251);
            this.tbx_Category.Name = "tbx_Category";
            this.tbx_Category.Size = new System.Drawing.Size(100, 20);
            this.tbx_Category.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Category";
            // 
            // tbx_EventName
            // 
            this.tbx_EventName.Location = new System.Drawing.Point(37, 202);
            this.tbx_EventName.Name = "tbx_EventName";
            this.tbx_EventName.Size = new System.Drawing.Size(100, 20);
            this.tbx_EventName.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Event Name";
            // 
            // btn_score
            // 
            this.btn_score.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_score.Location = new System.Drawing.Point(704, 12);
            this.btn_score.Name = "btn_score";
            this.btn_score.Size = new System.Drawing.Size(93, 32);
            this.btn_score.TabIndex = 65;
            this.btn_score.Text = "Score";
            this.btn_score.UseVisualStyleBackColor = true;
            this.btn_score.Click += new System.EventHandler(this.btn_score_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(209, 12);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(93, 32);
            this.btn_menu.TabIndex = 63;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click_1);
            // 
            // btn_event
            // 
            this.btn_event.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_event.Location = new System.Drawing.Point(506, 12);
            this.btn_event.Name = "btn_event";
            this.btn_event.Size = new System.Drawing.Size(93, 32);
            this.btn_event.TabIndex = 62;
            this.btn_event.Text = "Event";
            this.btn_event.UseVisualStyleBackColor = true;
            this.btn_event.Click += new System.EventHandler(this.btn_event_Click);
            // 
            // btn_result
            // 
            this.btn_result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_result.Location = new System.Drawing.Point(605, 12);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(93, 32);
            this.btn_result.TabIndex = 61;
            this.btn_result.Text = "Result";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_team
            // 
            this.btn_team.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_team.Location = new System.Drawing.Point(407, 12);
            this.btn_team.Name = "btn_team";
            this.btn_team.Size = new System.Drawing.Size(93, 32);
            this.btn_team.TabIndex = 60;
            this.btn_team.Text = "Team";
            this.btn_team.UseVisualStyleBackColor = true;
            this.btn_team.Click += new System.EventHandler(this.btn_team_Click);
            // 
            // btn_particpant
            // 
            this.btn_particpant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_particpant.Location = new System.Drawing.Point(308, 12);
            this.btn_particpant.Name = "btn_particpant";
            this.btn_particpant.Size = new System.Drawing.Size(93, 32);
            this.btn_particpant.TabIndex = 59;
            this.btn_particpant.Text = "Participant";
            this.btn_particpant.UseVisualStyleBackColor = true;
            this.btn_particpant.Click += new System.EventHandler(this.btn_particpant_Click);
            // 
            // fm_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_score);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_event);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_team);
            this.Controls.Add(this.btn_particpant);
            this.Controls.Add(this.cbx_Team);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbx_Events);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_Category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_EventName);
            this.Controls.Add(this.label1);
            this.Name = "fm_Event";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.fm_Event_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Team;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListBox lbx_Events;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_Category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_EventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_score;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_event;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_team;
        private System.Windows.Forms.Button btn_particpant;
    }
}