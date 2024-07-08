namespace Tournament_Scoring_System
{
    partial class fm_Switchboard
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
            this.btn_particpant = new System.Windows.Forms.Button();
            this.btn_team = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_event = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Event_btn = new System.Windows.Forms.Button();
            this.btn_score = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_particpant
            // 
            this.btn_particpant.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_particpant.Location = new System.Drawing.Point(236, 185);
            this.btn_particpant.Name = "btn_particpant";
            this.btn_particpant.Size = new System.Drawing.Size(153, 56);
            this.btn_particpant.TabIndex = 1;
            this.btn_particpant.Text = "Participant";
            this.btn_particpant.UseVisualStyleBackColor = true;
            this.btn_particpant.Click += new System.EventHandler(this.btn_particpant_Click);
            // 
            // btn_team
            // 
            this.btn_team.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_team.Location = new System.Drawing.Point(54, 185);
            this.btn_team.Name = "btn_team";
            this.btn_team.Size = new System.Drawing.Size(153, 56);
            this.btn_team.TabIndex = 2;
            this.btn_team.Text = "Team";
            this.btn_team.UseVisualStyleBackColor = true;
            this.btn_team.Click += new System.EventHandler(this.btn_team_Click);
            // 
            // btn_result
            // 
            this.btn_result.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_result.Location = new System.Drawing.Point(579, 185);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(153, 56);
            this.btn_result.TabIndex = 3;
            this.btn_result.Text = "Result";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_event
            // 
            this.btn_event.Location = new System.Drawing.Point(0, 0);
            this.btn_event.Name = "btn_event";
            this.btn_event.Size = new System.Drawing.Size(75, 23);
            this.btn_event.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(713, 64);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tournament Scoring System";
            // 
            // Event_btn
            // 
            this.Event_btn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event_btn.Location = new System.Drawing.Point(408, 185);
            this.Event_btn.Name = "Event_btn";
            this.Event_btn.Size = new System.Drawing.Size(156, 56);
            this.Event_btn.TabIndex = 7;
            this.Event_btn.Text = "Event";
            this.Event_btn.UseVisualStyleBackColor = true;
            this.Event_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_score
            // 
            this.btn_score.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_score.Location = new System.Drawing.Point(321, 264);
            this.btn_score.Name = "btn_score";
            this.btn_score.Size = new System.Drawing.Size(153, 56);
            this.btn_score.TabIndex = 8;
            this.btn_score.Text = "Score";
            this.btn_score.UseVisualStyleBackColor = true;
            this.btn_score.Click += new System.EventHandler(this.btn_score_Click);
            // 
            // fm_Switchboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_score);
            this.Controls.Add(this.Event_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_event);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_team);
            this.Controls.Add(this.btn_particpant);
            this.Name = "fm_Switchboard";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_particpant;
        private System.Windows.Forms.Button btn_team;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_event;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Event_btn;
        private System.Windows.Forms.Button btn_score;
    }
}