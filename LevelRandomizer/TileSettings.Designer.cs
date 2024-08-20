namespace KRtDL_Level_Randomizer.LevelRandomizer
{
    partial class TileSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TileSettings));
            panelModifiers = new Panel();
            numericUpDownLadder = new NumericUpDown();
            trackBarLadder = new TrackBar();
            labelLadder = new Label();
            numericUpDownSpikes = new NumericUpDown();
            trackBarSpikes = new TrackBar();
            labelSpikes = new Label();
            numericUpDownWater = new NumericUpDown();
            trackBarWater = new TrackBar();
            labelWater = new Label();
            labelBoundary = new Label();
            numericUpDownBoundary = new NumericUpDown();
            trackBarBoundary = new TrackBar();
            labelModifiers = new Label();
            panelMisc = new Panel();
            numericUpDownBlocks = new NumericUpDown();
            trackBarBlocks = new TrackBar();
            labelBlocks = new Label();
            labelAutoMove = new Label();
            numericUpDownAutoMove = new NumericUpDown();
            trackBarAutoMove = new TrackBar();
            labelMisc = new Label();
            richTextBoxInfo = new RichTextBox();
            buttonRandomize = new Button();
            panelModifiers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLadder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLadder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpikes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpikes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWater).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarWater).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBoundary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBoundary).BeginInit();
            panelMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAutoMove).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAutoMove).BeginInit();
            SuspendLayout();
            // 
            // panelModifiers
            // 
            panelModifiers.BorderStyle = BorderStyle.FixedSingle;
            panelModifiers.Controls.Add(numericUpDownLadder);
            panelModifiers.Controls.Add(trackBarLadder);
            panelModifiers.Controls.Add(labelLadder);
            panelModifiers.Controls.Add(numericUpDownSpikes);
            panelModifiers.Controls.Add(trackBarSpikes);
            panelModifiers.Controls.Add(labelSpikes);
            panelModifiers.Controls.Add(numericUpDownWater);
            panelModifiers.Controls.Add(trackBarWater);
            panelModifiers.Controls.Add(labelWater);
            panelModifiers.Controls.Add(labelBoundary);
            panelModifiers.Controls.Add(numericUpDownBoundary);
            panelModifiers.Controls.Add(trackBarBoundary);
            panelModifiers.Location = new Point(12, 12);
            panelModifiers.Name = "panelModifiers";
            panelModifiers.Size = new Size(469, 336);
            panelModifiers.TabIndex = 0;
            // 
            // numericUpDownLadder
            // 
            numericUpDownLadder.Location = new Point(377, 281);
            numericUpDownLadder.Name = "numericUpDownLadder";
            numericUpDownLadder.Size = new Size(75, 23);
            numericUpDownLadder.TabIndex = 11;
            numericUpDownLadder.ValueChanged += numericUpDownLadder_ValueChanged;
            // 
            // trackBarLadder
            // 
            trackBarLadder.Location = new Point(16, 272);
            trackBarLadder.Maximum = 100;
            trackBarLadder.Name = "trackBarLadder";
            trackBarLadder.Size = new Size(355, 45);
            trackBarLadder.TabIndex = 10;
            trackBarLadder.Scroll += trackBarLadder_Scroll;
            // 
            // labelLadder
            // 
            labelLadder.AutoSize = true;
            labelLadder.Location = new Point(16, 254);
            labelLadder.Name = "labelLadder";
            labelLadder.Size = new Size(43, 15);
            labelLadder.TabIndex = 9;
            labelLadder.Text = "Ladder";
            // 
            // numericUpDownSpikes
            // 
            numericUpDownSpikes.Location = new Point(377, 205);
            numericUpDownSpikes.Name = "numericUpDownSpikes";
            numericUpDownSpikes.Size = new Size(75, 23);
            numericUpDownSpikes.TabIndex = 8;
            numericUpDownSpikes.ValueChanged += numericUpDownSpikes_ValueChanged;
            // 
            // trackBarSpikes
            // 
            trackBarSpikes.Location = new Point(16, 196);
            trackBarSpikes.Maximum = 100;
            trackBarSpikes.Name = "trackBarSpikes";
            trackBarSpikes.Size = new Size(355, 45);
            trackBarSpikes.TabIndex = 7;
            trackBarSpikes.Scroll += trackBarSpikes_Scroll;
            // 
            // labelSpikes
            // 
            labelSpikes.AutoSize = true;
            labelSpikes.Location = new Point(16, 178);
            labelSpikes.Name = "labelSpikes";
            labelSpikes.Size = new Size(40, 15);
            labelSpikes.TabIndex = 6;
            labelSpikes.Text = "Spikes";
            // 
            // numericUpDownWater
            // 
            numericUpDownWater.Location = new Point(377, 129);
            numericUpDownWater.Name = "numericUpDownWater";
            numericUpDownWater.Size = new Size(75, 23);
            numericUpDownWater.TabIndex = 5;
            numericUpDownWater.ValueChanged += numericUpDownWater_ValueChanged;
            // 
            // trackBarWater
            // 
            trackBarWater.Location = new Point(16, 120);
            trackBarWater.Maximum = 100;
            trackBarWater.Name = "trackBarWater";
            trackBarWater.Size = new Size(355, 45);
            trackBarWater.TabIndex = 4;
            trackBarWater.Scroll += trackBarWater_Scroll;
            // 
            // labelWater
            // 
            labelWater.AutoSize = true;
            labelWater.Location = new Point(16, 102);
            labelWater.Name = "labelWater";
            labelWater.Size = new Size(38, 15);
            labelWater.TabIndex = 3;
            labelWater.Text = "Water";
            // 
            // labelBoundary
            // 
            labelBoundary.AutoSize = true;
            labelBoundary.Location = new Point(16, 26);
            labelBoundary.Name = "labelBoundary";
            labelBoundary.Size = new Size(58, 15);
            labelBoundary.TabIndex = 2;
            labelBoundary.Text = "Boundary";
            // 
            // numericUpDownBoundary
            // 
            numericUpDownBoundary.Location = new Point(377, 55);
            numericUpDownBoundary.Name = "numericUpDownBoundary";
            numericUpDownBoundary.Size = new Size(75, 23);
            numericUpDownBoundary.TabIndex = 1;
            numericUpDownBoundary.ValueChanged += numericUpDownBoundary_ValueChanged;
            // 
            // trackBarBoundary
            // 
            trackBarBoundary.Location = new Point(16, 44);
            trackBarBoundary.Maximum = 100;
            trackBarBoundary.Name = "trackBarBoundary";
            trackBarBoundary.Size = new Size(355, 45);
            trackBarBoundary.TabIndex = 0;
            trackBarBoundary.Scroll += trackBarBoundary_Scroll;
            // 
            // labelModifiers
            // 
            labelModifiers.AutoSize = true;
            labelModifiers.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelModifiers.Location = new Point(29, 4);
            labelModifiers.Name = "labelModifiers";
            labelModifiers.Size = new Size(72, 20);
            labelModifiers.TabIndex = 0;
            labelModifiers.Text = "Modifiers";
            // 
            // panelMisc
            // 
            panelMisc.BorderStyle = BorderStyle.FixedSingle;
            panelMisc.Controls.Add(numericUpDownBlocks);
            panelMisc.Controls.Add(trackBarBlocks);
            panelMisc.Controls.Add(labelBlocks);
            panelMisc.Controls.Add(labelAutoMove);
            panelMisc.Controls.Add(numericUpDownAutoMove);
            panelMisc.Controls.Add(trackBarAutoMove);
            panelMisc.Location = new Point(497, 12);
            panelMisc.Name = "panelMisc";
            panelMisc.Size = new Size(466, 176);
            panelMisc.TabIndex = 1;
            // 
            // numericUpDownBlocks
            // 
            numericUpDownBlocks.Location = new Point(377, 129);
            numericUpDownBlocks.Name = "numericUpDownBlocks";
            numericUpDownBlocks.Size = new Size(75, 23);
            numericUpDownBlocks.TabIndex = 16;
            numericUpDownBlocks.ValueChanged += numericUpDownBlocks_ValueChanged;
            // 
            // trackBarBlocks
            // 
            trackBarBlocks.Location = new Point(16, 120);
            trackBarBlocks.Maximum = 100;
            trackBarBlocks.Name = "trackBarBlocks";
            trackBarBlocks.Size = new Size(355, 45);
            trackBarBlocks.TabIndex = 15;
            trackBarBlocks.Scroll += trackBarBlocks_Scroll;
            // 
            // labelBlocks
            // 
            labelBlocks.AutoSize = true;
            labelBlocks.Location = new Point(16, 102);
            labelBlocks.Name = "labelBlocks";
            labelBlocks.Size = new Size(41, 15);
            labelBlocks.TabIndex = 14;
            labelBlocks.Text = "Blocks";
            // 
            // labelAutoMove
            // 
            labelAutoMove.AutoSize = true;
            labelAutoMove.Location = new Point(16, 26);
            labelAutoMove.Name = "labelAutoMove";
            labelAutoMove.Size = new Size(94, 15);
            labelAutoMove.TabIndex = 13;
            labelAutoMove.Text = "Auto Movement";
            // 
            // numericUpDownAutoMove
            // 
            numericUpDownAutoMove.Location = new Point(377, 55);
            numericUpDownAutoMove.Name = "numericUpDownAutoMove";
            numericUpDownAutoMove.Size = new Size(75, 23);
            numericUpDownAutoMove.TabIndex = 12;
            numericUpDownAutoMove.ValueChanged += numericUpDownAutoMove_ValueChanged;
            // 
            // trackBarAutoMove
            // 
            trackBarAutoMove.Location = new Point(16, 44);
            trackBarAutoMove.Maximum = 100;
            trackBarAutoMove.Name = "trackBarAutoMove";
            trackBarAutoMove.Size = new Size(355, 45);
            trackBarAutoMove.TabIndex = 12;
            trackBarAutoMove.Scroll += trackBarAutoMove_Scroll;
            // 
            // labelMisc
            // 
            labelMisc.AutoSize = true;
            labelMisc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMisc.Location = new Point(514, 4);
            labelMisc.Name = "labelMisc";
            labelMisc.Size = new Size(102, 20);
            labelMisc.TabIndex = 13;
            labelMisc.Text = "Miscellaneous";
            // 
            // richTextBoxInfo
            // 
            richTextBoxInfo.Location = new Point(497, 198);
            richTextBoxInfo.Name = "richTextBoxInfo";
            richTextBoxInfo.ReadOnly = true;
            richTextBoxInfo.Size = new Size(466, 150);
            richTextBoxInfo.TabIndex = 14;
            richTextBoxInfo.Text = resources.GetString("richTextBoxInfo.Text");
            // 
            // buttonRandomize
            // 
            buttonRandomize.Location = new Point(448, 354);
            buttonRandomize.Name = "buttonRandomize";
            buttonRandomize.Size = new Size(75, 23);
            buttonRandomize.TabIndex = 15;
            buttonRandomize.Text = "Randomize";
            buttonRandomize.UseVisualStyleBackColor = true;
            buttonRandomize.Click += buttonRandomize_Click;
            // 
            // TileSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 389);
            Controls.Add(buttonRandomize);
            Controls.Add(richTextBoxInfo);
            Controls.Add(labelMisc);
            Controls.Add(panelMisc);
            Controls.Add(labelModifiers);
            Controls.Add(panelModifiers);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TileSettings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tile Randomizer";
            FormClosing += TileSettings_FormClosing;
            Load += TileSettings_Load;
            panelModifiers.ResumeLayout(false);
            panelModifiers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLadder).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLadder).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpikes).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpikes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWater).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarWater).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBoundary).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBoundary).EndInit();
            panelMisc.ResumeLayout(false);
            panelMisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAutoMove).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAutoMove).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelModifiers;
        private Label labelModifiers;
        private TrackBar trackBarBoundary;
        private Label labelWater;
        private Label labelBoundary;
        private NumericUpDown numericUpDownBoundary;
        private NumericUpDown numericUpDownSpikes;
        private TrackBar trackBarSpikes;
        private Label labelSpikes;
        private NumericUpDown numericUpDownWater;
        private TrackBar trackBarWater;
        private NumericUpDown numericUpDownLadder;
        private TrackBar trackBarLadder;
        private Label labelLadder;
        private Panel panelMisc;
        private NumericUpDown numericUpDownAutoMove;
        private TrackBar trackBarAutoMove;
        private Label labelMisc;
        private NumericUpDown numericUpDownBlocks;
        private TrackBar trackBarBlocks;
        private Label labelBlocks;
        private Label labelAutoMove;
        private RichTextBox richTextBoxInfo;
        private Button buttonRandomize;
    }
}