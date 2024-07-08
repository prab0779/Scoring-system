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
    public partial class fm_Teams : Form
    {
        public fm_Teams()
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

        private void Btn_event_Click(object sender, EventArgs e)
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

        private void fm_Teams_Load(object sender, EventArgs e)
        {
            LoadTeams();
        }

        public void LoadTeams()
        {
            lbx_Teams.Items.Clear();
            Database db = new Database();
            DataTable td = new DataTable();
            td = db.SelectTeam();

            for (int x = 0; x < td.Rows.Count; x++)
            {
                lbx_Teams.Items.Add(td.Rows[x][0].ToString() + ":" + td.Rows[x][1].ToString());
            }
        }

        private void lbx_Teams_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] line;
            line = lbx_Teams.Text.Split(':');
            tbx_ID.Text = line[0];
            tbx_TeamName.Text = line[1];
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.AddTeam(tbx_TeamName.Text);

            tbx_ID.Text = "";
            tbx_TeamName.Text = "";
            LoadTeams();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.UpdateTeam(tbx_TeamName.Text, Convert.ToInt32(tbx_ID.Text));

            tbx_ID.Text = "";
            tbx_TeamName.Text = "";
            LoadTeams();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.DeleteTeam(Convert.ToInt32(tbx_ID.Text));

            tbx_ID.Text = "";
            tbx_TeamName.Text = "";
            LoadTeams();
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            Database db = new Database();
            db.AddTeam(tbx_TeamName.Text);

            tbx_ID.Text = "";
            tbx_TeamName.Text = "";
            LoadTeams();
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            Database db = new Database();
            db.UpdateTeam(tbx_TeamName.Text, Convert.ToInt32(tbx_ID.Text));

            tbx_ID.Text = "";
            tbx_TeamName.Text = "";
            LoadTeams();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.DeleteTeam(Convert.ToInt32(tbx_ID.Text));

            tbx_ID.Text = "";
            tbx_TeamName.Text = "";
            LoadTeams();
        }

        private void fm_Teams_Load_1(object sender, EventArgs e)
        {
            LoadTeams();
        }

        private void btn_event_Click_1(object sender, EventArgs e)
        {
            fm_Event fm = new fm_Event();
            fm.Show();
            this.Hide();
        }

        private void btn_particpant_Click_1(object sender, EventArgs e)
        {
            fm_Participant fm = new fm_Participant();
            fm.Show();
            this.Hide();
        }

        private void lbx_Teams_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string[] line;
            line = lbx_Teams.Text.Split(':');
            tbx_ID.Text = line[0];
            tbx_TeamName.Text = line[1];
        }
    }
}
