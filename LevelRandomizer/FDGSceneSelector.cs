using KRtDL_Level_Randomizer.ext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRtDL_Level_Randomizer.LevelRandomizer
{
    public partial class FDGSceneSelector : Form
    {
        public string sceneToPatch { get; set; }

        public FDGSceneSelector(string scene)
        {
            InitializeComponent();

            textBoxProblem.Text = scene;
        }

        private void FDGSceneSelector_Load(object sender, EventArgs e)
        {
            comboBoxFdgScene.Items.AddRange(Objects.levelFDGs.Keys.ToArray());
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (comboBoxFdgScene.SelectedItem == null)
            {
                DialogResult result = MessageBox.Show("No scene has been selected, continue without patching this level's fdg?", "No scene", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.No;
                    this.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            sceneToPatch = (string)comboBoxFdgScene.SelectedItem;
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
