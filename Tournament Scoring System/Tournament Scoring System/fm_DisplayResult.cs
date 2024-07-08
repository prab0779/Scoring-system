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
    public partial class fm_DisplayResult : Form
    {
        public fm_DisplayResult()
        {
            InitializeComponent();
        }

        private void DisplayResult_Load(object sender, EventArgs e)
        {
            CalculateTeam();
            CalculateParticipant();
        }

        public void CalculateTeam()
        {
            Database db = new Database();
            DataTable tdResults = new DataTable();
            DataTable tdTeams = new DataTable();
            int score;
            tdTeams = db.SelectTeam();

            for (int x = 0; x < tdTeams.Rows.Count; x++)
            {
                score = 0;
                if (tdTeams.Rows[x][1].ToString().Trim() != "Individual")
                {
                    tdResults = db.SelectResultByTeam(tdTeams.Rows[x][1].ToString());
                    for (int y = 0; y < tdResults.Rows.Count; y++)
                    {
                        switch (Convert.ToInt32(tdResults.Rows[y][3]))
                        {
                            case 1:
                                score = score + 30;
                                break;

                            case 2:
                                score = score + 20;
                                break;
                            case 3:
                                score = score + 10;
                                break;
                            default:
                                score = score + 5;
                                break;
                        }

                    }
                    lbx_TeamScore.Items.Add(tdTeams.Rows[x][1].ToString().Trim() + ':' + score);
                }
            }
        }
        public void CalculateParticipant()
        {
            Database db = new Database();
            DataTable tdResults = new DataTable();
            DataTable tdParticipants = new DataTable();
            int score;
            tdParticipants = db.SelectParticipantByIndividual();

            for (int x = 0; x < tdParticipants.Rows.Count; x++)
            {
                score = 0;
                tdResults = db.SelectResultByIndividual(Convert.ToInt32(tdParticipants.Rows[x][0]));
                for (int y = 0; y < tdResults.Rows.Count; y++)
                {
                    switch (Convert.ToInt32(tdResults.Rows[y][3]))
                    {
                        case 1:
                            score = score + 30;
                            break;

                        case 2:
                            score = score + 20;
                            break;
                        case 3:
                            score = score + 10;
                            break;
                        default:
                            score = score + 5;
                            break;
                    }

                }
                lbx_ParticipantScore.Items.Add(tdParticipants.Rows[x][0].ToString().Trim() + ":" + tdParticipants.Rows[x][1].ToString().Trim() + ":" + tdParticipants.Rows[x][2].ToString().Trim() + ':' + score);
            }
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

        private void btn_result_Click(object sender, EventArgs e)
        {
            fm_Result fm = new fm_Result();
            fm.Show();
            this.Hide();
        }
    }
}