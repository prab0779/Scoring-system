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
    public partial class fm_Event : Form
    {
        public fm_Event()
        {
            InitializeComponent();
        }

        private void fm_Events_Load(object sender, EventArgs e)
        {
            cbx_Team.Items.Add("Group");
            cbx_Team.Items.Add("Individual");
            LoadEvents();
        }

        public void LoadEvents()
        {
            lbx_Events.Items.Clear();
            Database db = new Database();
            DataTable td = new DataTable();
            td = db.SelectEvents();

            for (int x = 0; x < td.Rows.Count; x++)
            {
                lbx_Events.Items.Add(td.Rows[x][0].ToString() + ":" + td.Rows[x][1].ToString() + ":" + td.Rows[x][2].ToString() + ":" + td.Rows[x][3].ToString());
            }
        }

        private void lbx_Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] line;

            line = lbx_Events.Text.Split(':');
            tbx_ID.Text = line[0];
            tbx_EventName.Text = line[1];
            tbx_Category.Text = line[2];
            cbx_Team.Text = line[3];
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            Database db = new Database();
            db.Get_Event(tbx_EventName.Text, tbx_Category.Text, cbx_Team.Text);
            tbx_EventName.Text = "";
            tbx_Category.Text = "";
            cbx_Team.Text = "";
            LoadEvents();
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            Database db = new Database();
            db.UpdateEvent(tbx_EventName.Text, tbx_Category.Text, cbx_Team.Text, Convert.ToInt32(tbx_ID.Text));
            tbx_EventName.Text = "";
            tbx_Category.Text = "";
            cbx_Team.Text = "";
            LoadEvents();
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            Database db = new Database();
            db.DeleteEvent(Convert.ToInt32(tbx_ID.Text));
            tbx_EventName.Text = "";
            tbx_Category.Text = "";
            cbx_Team.Text = "";
            LoadEvents();
        }

        private void fm_Event_Load(object sender, EventArgs e)
        {
            cbx_Team.Items.Add("Group");
            cbx_Team.Items.Add("Individual");
            LoadEvents();
        }

        private void lbx_Events_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string[] line;

            line = lbx_Events.Text.Split(':');
            tbx_ID.Text = line[0];
            tbx_EventName.Text = line[1];
            tbx_Category.Text = line[2];
            cbx_Team.Text = line[3];
        }

        private void btn_menu_Click_1(object sender, EventArgs e)
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

        private void btn_score_Click(object sender, EventArgs e)
        {
            fm_DisplayResult fm = new fm_DisplayResult();
            fm.Show();
            this.Hide();
        }
    }
}
