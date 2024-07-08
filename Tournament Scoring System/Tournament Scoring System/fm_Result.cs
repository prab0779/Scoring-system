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
    public partial class fm_Result : Form
    {
        public fm_Result()
        {
            InitializeComponent();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            fm_Switchboard fm = new fm_Switchboard();
            fm.Show();
            this.Hide();
        }

        private void btn_team_Click(object sender, EventArgs e)
        {
            fm_Teams fm = new fm_Teams();
            fm.Show();
            this.Hide();
        }

        private void btn_particpant_Click(object sender, EventArgs e)
        {
            fm_Participant fm = new fm_Participant();
            fm.Show();
            this.Hide();
        }

        private void btn_event_Click(object sender, EventArgs e)
        {
            fm_Event fm = new fm_Event();
            fm.Show();
            this.Hide();
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            fm_Result fm = new fm_Result();
            fm.Show();
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string[] lineParticipants = lbx_Participants.Text.Split(':');
            string[] lineEvents = lbx_Events.Text.Split(':');


            db.Get_Result(Convert.ToInt32(lineParticipants[0]), Convert.ToInt32(lineEvents[0]), 0);
            LoadResults();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.UpdateResult(Convert.ToInt32(tbx_ParticipantID.Text.Split(':')[0]), Convert.ToInt32(tbx_EventID.Text.Split(':')[0]), Convert.ToInt32(cbx_Rank.Text), Convert.ToInt32(tbx_ID.Text));
            tbx_ID.Text = "";
            tbx_ParticipantID.Text = "";
            tbx_EventID.Text = "";
            cbx_Rank.Text = "";
            LoadResults();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.DeleteResult(Convert.ToInt32(tbx_ID.Text));
            tbx_ID.Text = "";
            tbx_ParticipantID.Text = "";
            tbx_EventID.Text = "";
            cbx_Rank.Text = "";
            LoadResults();
        }

        private void fm_Result_Load(object sender, EventArgs e)
        {
            LoadParticipants();
            LoadEvents();
            LoadResults();

            cbx_Rank.Items.Add(3);
            cbx_Rank.Items.Add(2);
            cbx_Rank.Items.Add(1);
            cbx_Rank.Items.Add(0);
        }

        public void LoadParticipants()
        {
            lbx_Participants.Items.Clear();
            Database db = new Database();
            DataTable td = new DataTable();
            td = db.Get_Participant();

            for (int x = 0; x < td.Rows.Count; x++)
            {
                lbx_Participants.Items.Add(td.Rows[x][0].ToString().Trim() + ":" + td.Rows[x][1].ToString().Trim() + ":" + td.Rows[x][2].ToString().Trim() + ":" + td.Rows[x][3].ToString().Trim());
            }
        }
        public void LoadEvents()
        {
            lbx_Events.Items.Clear();
            Database db = new Database();
            DataTable td = new DataTable();
            td = db.SelectEvents();

            for (int x = 0; x < td.Rows.Count; x++)
            {
                lbx_Events.Items.Add(td.Rows[x][0].ToString().Trim() + ":" + td.Rows[x][1].ToString().Trim() + ":" + td.Rows[x][2].ToString().Trim() + ":" + td.Rows[x][3].ToString().Trim());
            }
        }
        public void LoadResults()
        {
            lbx_Results.Items.Clear();
            Database db = new Database();
            DataTable td = new DataTable();
            td = db.SelectResult();

            for (int x = 0; x < td.Rows.Count; x++)
            {
                lbx_Results.Items.Add(td.Rows[x][0].ToString().Trim() + ":" + td.Rows[x][1].ToString().Trim() + ":" + td.Rows[x][5].ToString().Trim() + ":" + td.Rows[x][6].ToString().Trim() + ":" + td.Rows[x][2].ToString().Trim() + ":" + td.Rows[x][9].ToString().Trim() + ":" + td.Rows[x][3].ToString().Trim());
            }
        }

        private void lbx_Participants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbx_Results_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] line;

            line = lbx_Results.Text.Split(':');
            tbx_ID.Text = line[0];
            tbx_ParticipantID.Text = line[1] + ':' + line[2];
            tbx_EventID.Text = line[4] + ':' + line[5];
            cbx_Rank.Text = line[6];
        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            fm_DisplayResult fm = new fm_DisplayResult();
            fm.Show();
            this.Hide();
        }
    }
}    