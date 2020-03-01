using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player player;   
        public SuperAdventure()
        {
            InitializeComponent();
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {
            player = new Player(10, 10, 20, 0, 1);

            lblHitPoints.Text = player.CurrentHitPoints.ToString();
            lblGold.Text = player.Gold.ToString();
            lblExperience.Text = player.ExperiencePoints.ToString();
            lblLevel.Text = player.Level.ToString();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lblGold.Text = "123";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
