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
    public partial class fm_Participant : Form
    {
        public fm_Participant()
        {
            InitializeComponent();
        }

        private void fm_Participants_Load(object sender, EventArgs e)
        {
            LoadParticipants();

            Database db = new Database();
            DataTable td = new DataTable();
            td = db.SelectTeam();

            for (int x = 0; x < td.Rows.Count; x++)
            {
                cbx_Teams.Items.Add(td.Rows[x][1].ToString());
            }
        }

        public void LoadParticipants()
        {
            lbx_Participants.Items.Clear();
            Database db = new Database();
            DataTable td = new DataTable();
            td = db.Get_Participant();

            for (int x = 0; x < td.Rows.Count; x++)
            {
                lbx_Participants.Items.Add(td.Rows[x][0].ToString() + ":" + td.Rows[x][1].ToString() + ":" + td.Rows[x][2].ToString() + ":" + td.Rows[x][3].ToString());
            }
        }

        private void lbx_Participants_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] line;

            line = lbx_Participants.Text.Split(':');
            tbx_ID.Text = line[0];
            tbx_Forename.Text = line[1];
            tbx_Surname.Text = line[2];
            cbx_Teams.Text = line[3];
        }


        private void btn_team_Click(object sender, EventArgs e)
        {
            fm_Teams fm = new fm_Teams();
            fm.Show();
            this.Hide();
        }

        private void btn_event_Click(object sender, EventArgs e)
        {
            fm_Event fm = new fm_Event();
            fm.Show();
            this.Hide();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            fm_Switchboard fm = new fm_Switchboard();
            fm.Show();
            this.Hide();
        }

        private void btn_particpant_Click(object sender, EventArgs e)
        {
            fm_Participant fm = new fm_Participant();
            fm.Show();
            this.Hide();
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            fm_Result fm = new fm_Result();
            fm.Show();
            this.Hide();
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable td = new DataTable();

            if (cbx_Teams.Text != "Individual")
            {
                td = db.SelectPArticipantByTeam(cbx_Teams.Text);

                if (td.Rows.Count < 4)
                {
                    db.AddParticipant(tbx_Forename.Text, tbx_Surname.Text, cbx_Teams.Text);

                    tbx_ID.Text = "";
                    tbx_Forename.Text = "";
                    tbx_Surname.Text = "";
                    cbx_Teams.Text = "";
                    LoadParticipants();
                }
                else
                {
                    MessageBox.Show("Team Full");
                }
            }
            else
            {
                db.AddParticipant(tbx_Forename.Text, tbx_Surname.Text, cbx_Teams.Text);

                tbx_ID.Text = "";
                tbx_Forename.Text = "";
                tbx_Surname.Text = "";
                cbx_Teams.Text = "";
                LoadParticipants();
            }
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            Database db = new Database();
            db.UpdateParticipant(tbx_Forename.Text, tbx_Surname.Text, cbx_Teams.Text, Convert.ToInt32(tbx_ID.Text));
            tbx_ID.Text = "";
            tbx_Forename.Text = "";
            tbx_Surname.Text = "";
            cbx_Teams.Text = "";
            LoadParticipants();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.DeleteParticipant(Convert.ToInt32(tbx_ID.Text));
            tbx_ID.Text = "";
            tbx_Forename.Text = "";
            tbx_Surname.Text = "";
            cbx_Teams.Text = "";
            LoadParticipants();
        }

        private void fm_Participant_Load_1(object sender, EventArgs e)
        {
            LoadParticipants();

            Database db = new Database();
            DataTable td = new DataTable();
            td = db.SelectTeam();

            for (int x = 0; x < td.Rows.Count; x++)
            {
                cbx_Teams.Items.Add(td.Rows[x][1].ToString());
            }
        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            fm_DisplayResult fm = new fm_DisplayResult();
            fm.Show();
            this.Hide();
        }

        private void lbx_Participants_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string[] line;

            line = lbx_Participants.Text.Split(':');
            tbx_ID.Text = line[0];
            tbx_Forename.Text = line[1];
            tbx_Surname.Text = line[2];
            cbx_Teams.Text = line[3];
        }
    }
}
