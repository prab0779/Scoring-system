using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tournament_Scoring_System
{
    public partial class fm_Switchboard : Form
    {
        public fm_Switchboard()
        {
            InitializeComponent();
        }

        private void btn_event_Click(object sender, EventArgs e)
        {
            fm_Event fm = new fm_Event();
            fm.Show();
            this.Hide();
        }

        private void btn_particpant_Click(object sender, EventArgs e)
        {
            fm_Participant fm = new fm_Participant();
            fm.Show();
            this.Hide();
        }

        private void btn_team_Click(object sender, EventArgs e)
        {
            fm_Teams fm = new fm_Teams();
            fm.Show();
            this.Hide();
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            fm_Result fm = new fm_Result();
            fm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fm_Event fm = new fm_Event();
            fm.Show();
            this.Hide();
        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            fm_DisplayResult fm = new fm_DisplayResult();
            fm.Show();
            this.Hide();
        }
    }
}
