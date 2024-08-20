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
    public partial class TileSettings : Form
    {
        MainForm mainForm;

        public TileSettings(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        void SyncTrackBarToNumeric(NumericUpDown control, int value)
        {
            control.Value = value;
        }

        void SyncNumericToTrackBar(TrackBar control, int value)
        {
            control.Value = value;
        }

        void SyncAllTrackBarsToAllNumerics()
        {
            SyncTrackBarToNumeric(numericUpDownBoundary, trackBarBoundary.Value);
            SyncTrackBarToNumeric(numericUpDownWater, trackBarWater.Value);
            SyncTrackBarToNumeric(numericUpDownSpikes, trackBarSpikes.Value);
            SyncTrackBarToNumeric(numericUpDownLadder, trackBarLadder.Value);
            SyncTrackBarToNumeric(numericUpDownAutoMove, trackBarAutoMove.Value);
            SyncTrackBarToNumeric(numericUpDownBlocks, trackBarBlocks.Value);
        }

        private void TileSettings_Load(object sender, EventArgs e)
        {
            int boundary = mainForm.tileProbabilities["Boundary"];
            int water = mainForm.tileProbabilities["Water"];
            int spikes = mainForm.tileProbabilities["Spikes"];
            int ladder = mainForm.tileProbabilities["Ladder"];
            int autoMovement = mainForm.tileProbabilities["Auto Movement"];
            int blocks = mainForm.tileProbabilities["Blocks"];

            numericUpDownBoundary.Value = boundary;
            numericUpDownWater.Value = water;
            numericUpDownSpikes.Value = spikes;
            numericUpDownLadder.Value = ladder;
            numericUpDownAutoMove.Value = autoMovement;
            numericUpDownBlocks.Value = blocks;

            trackBarBoundary.Value = boundary;
            trackBarWater.Value = water;
            trackBarSpikes.Value = spikes;
            trackBarLadder.Value = ladder;
            trackBarAutoMove.Value = autoMovement;
            trackBarBlocks.Value = blocks;
        }

        private void TileSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.tileProbabilities["Boundary"] = (int)numericUpDownBoundary.Value;
            mainForm.tileProbabilities["Water"] = (int)numericUpDownWater.Value;
            mainForm.tileProbabilities["Spikes"] = (int)numericUpDownSpikes.Value;
            mainForm.tileProbabilities["Ladder"] = (int)numericUpDownLadder.Value;
            mainForm.tileProbabilities["Auto Movement"] = (int)numericUpDownAutoMove.Value;
            mainForm.tileProbabilities["Blocks"] = (int)numericUpDownBlocks.Value;
        }

        // TrackBars
        private void trackBarBoundary_Scroll(object sender, EventArgs e)
        {
            SyncTrackBarToNumeric(numericUpDownBoundary, trackBarBoundary.Value);
        }

        private void trackBarWater_Scroll(object sender, EventArgs e)
        {
            SyncTrackBarToNumeric(numericUpDownWater, trackBarWater.Value);
        }

        private void trackBarSpikes_Scroll(object sender, EventArgs e)
        {
            SyncTrackBarToNumeric(numericUpDownSpikes, trackBarSpikes.Value);
        }

        private void trackBarLadder_Scroll(object sender, EventArgs e)
        {
            SyncTrackBarToNumeric(numericUpDownLadder, trackBarLadder.Value);
        }

        private void trackBarAutoMove_Scroll(object sender, EventArgs e)
        {
            SyncTrackBarToNumeric(numericUpDownAutoMove, trackBarAutoMove.Value);
        }

        private void trackBarBlocks_Scroll(object sender, EventArgs e)
        {
            SyncTrackBarToNumeric(numericUpDownBlocks, trackBarBlocks.Value);
        }

        // NumericUpDowns
        private void numericUpDownBoundary_ValueChanged(object sender, EventArgs e)
        {
            SyncNumericToTrackBar(trackBarBoundary, (int)numericUpDownBoundary.Value);
        }

        private void numericUpDownWater_ValueChanged(object sender, EventArgs e)
        {
            SyncNumericToTrackBar(trackBarWater, (int)numericUpDownWater.Value);
        }

        private void numericUpDownSpikes_ValueChanged(object sender, EventArgs e)
        {
            SyncNumericToTrackBar(trackBarSpikes, (int)numericUpDownSpikes.Value);
        }

        private void numericUpDownLadder_ValueChanged(object sender, EventArgs e)
        {
            SyncNumericToTrackBar(trackBarLadder, (int)numericUpDownLadder.Value);
        }

        private void numericUpDownAutoMove_ValueChanged(object sender, EventArgs e)
        {
            SyncNumericToTrackBar(trackBarAutoMove, (int)numericUpDownAutoMove.Value);
        }

        private void numericUpDownBlocks_ValueChanged(object sender, EventArgs e)
        {
            SyncNumericToTrackBar(trackBarBlocks, (int)numericUpDownBlocks.Value);
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            trackBarBoundary.Value = rand.Next(trackBarBoundary.Maximum);
            trackBarWater.Value = rand.Next(trackBarWater.Maximum);
            trackBarSpikes.Value = rand.Next(trackBarSpikes.Maximum);
            trackBarLadder.Value = rand.Next(trackBarLadder.Maximum);
            trackBarAutoMove.Value = rand.Next(trackBarAutoMove.Maximum);
            trackBarBlocks.Value = rand.Next(trackBarBlocks.Maximum);
            SyncAllTrackBarsToAllNumerics();
        }
    }
}
