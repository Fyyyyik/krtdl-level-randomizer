namespace KRtDL_Level_Randomizer
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            panelInput = new Panel();
            checkBoxKrtdlDx = new CheckBox();
            checkBoxManualFdg = new CheckBox();
            buttonFdg = new Button();
            textBoxFdg = new TextBox();
            labelFdg = new Label();
            buttonRandomizeSeed = new Button();
            numericUpDownSeed = new NumericUpDown();
            buttonStart = new Button();
            buttonSelectPath = new Button();
            textBoxTargetPath = new TextBox();
            labelTarget = new Label();
            labelSettings = new Label();
            panelSettings = new Panel();
            checkBoxProperties = new CheckBox();
            checkBoxBackground = new CheckBox();
            checkBoxMovingTerrain = new CheckBox();
            checkBoxTypes = new CheckBox();
            checkBoxEnemySize = new CheckBox();
            checkBoxMusic = new CheckBox();
            checkBoxRooms = new CheckBox();
            checkBoxObjects = new CheckBox();
            checkBoxItems = new CheckBox();
            checkBoxBosses = new CheckBox();
            checkBoxEnemies = new CheckBox();
            panelTileModifiers = new Panel();
            buttonTilesCustomize = new Button();
            checkBoxTiles = new CheckBox();
            labelSeed = new Label();
            labelInput = new Label();
            panelOutput = new Panel();
            richTextBoxMessage = new RichTextBox();
            labelProgress = new Label();
            progressBarRandomizer = new ProgressBar();
            labelOutput = new Label();
            toolTip1 = new ToolTip(components);
            panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeed).BeginInit();
            panelSettings.SuspendLayout();
            panelTileModifiers.SuspendLayout();
            panelOutput.SuspendLayout();
            SuspendLayout();
            // 
            // panelInput
            // 
            panelInput.BorderStyle = BorderStyle.FixedSingle;
            panelInput.Controls.Add(checkBoxKrtdlDx);
            panelInput.Controls.Add(checkBoxManualFdg);
            panelInput.Controls.Add(buttonFdg);
            panelInput.Controls.Add(textBoxFdg);
            panelInput.Controls.Add(labelFdg);
            panelInput.Controls.Add(buttonRandomizeSeed);
            panelInput.Controls.Add(numericUpDownSeed);
            panelInput.Controls.Add(buttonStart);
            panelInput.Controls.Add(buttonSelectPath);
            panelInput.Controls.Add(textBoxTargetPath);
            panelInput.Controls.Add(labelTarget);
            panelInput.Controls.Add(labelSettings);
            panelInput.Controls.Add(panelSettings);
            panelInput.Controls.Add(labelSeed);
            panelInput.Location = new Point(12, 12);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(352, 600);
            panelInput.TabIndex = 0;
            // 
            // checkBoxKrtdlDx
            // 
            checkBoxKrtdlDx.AutoSize = true;
            checkBoxKrtdlDx.Location = new Point(14, 501);
            checkBoxKrtdlDx.Name = "checkBoxKrtdlDx";
            checkBoxKrtdlDx.Size = new Size(200, 19);
            checkBoxKrtdlDx.TabIndex = 16;
            checkBoxKrtdlDx.Text = "Is Deluxe version (VERY BROKEN)";
            toolTip1.SetToolTip(checkBoxKrtdlDx, "Enable this if you are randomizing\r\nthe levels of the remake on Switch.\r\nThis feature will most likely cause\r\ncrashes in game due to the low\r\namount of research on the game.");
            checkBoxKrtdlDx.UseVisualStyleBackColor = true;
            checkBoxKrtdlDx.CheckedChanged += checkBoxKrtdlDx_CheckedChanged;
            // 
            // checkBoxManualFdg
            // 
            checkBoxManualFdg.AutoSize = true;
            checkBoxManualFdg.Location = new Point(81, 466);
            checkBoxManualFdg.Name = "checkBoxManualFdg";
            checkBoxManualFdg.Size = new Size(165, 19);
            checkBoxManualFdg.TabIndex = 15;
            checkBoxManualFdg.Text = "Ignore problematic scenes";
            toolTip1.SetToolTip(checkBoxManualFdg, "If enabled, the automatic FDG\r\nscene finder will not ask you to\r\nmanually select the correct scene\r\nand will instead stub the step out.");
            checkBoxManualFdg.UseVisualStyleBackColor = true;
            // 
            // buttonFdg
            // 
            buttonFdg.Location = new Point(14, 462);
            buttonFdg.Name = "buttonFdg";
            buttonFdg.Size = new Size(61, 23);
            buttonFdg.TabIndex = 13;
            buttonFdg.Text = "Set path";
            buttonFdg.UseVisualStyleBackColor = true;
            buttonFdg.Click += buttonFdg_Click;
            // 
            // textBoxFdg
            // 
            textBoxFdg.Location = new Point(14, 433);
            textBoxFdg.Name = "textBoxFdg";
            textBoxFdg.Size = new Size(326, 23);
            textBoxFdg.TabIndex = 12;
            toolTip1.SetToolTip(textBoxFdg, "Will allow you to fix the lag\r\ncaused by the game having\r\nto load each new object.\r\nDoes not work with KRtDL DX.");
            // 
            // labelFdg
            // 
            labelFdg.AutoSize = true;
            labelFdg.Location = new Point(14, 415);
            labelFdg.Name = "labelFdg";
            labelFdg.Size = new Size(111, 15);
            labelFdg.TabIndex = 11;
            labelFdg.Text = "FDG Path (optional)";
            // 
            // buttonRandomizeSeed
            // 
            buttonRandomizeSeed.Location = new Point(212, 44);
            buttonRandomizeSeed.Name = "buttonRandomizeSeed";
            buttonRandomizeSeed.Size = new Size(101, 23);
            buttonRandomizeSeed.TabIndex = 10;
            buttonRandomizeSeed.Text = "Randomize seed";
            buttonRandomizeSeed.UseVisualStyleBackColor = true;
            buttonRandomizeSeed.Click += buttonRandomizeSeed_Click;
            // 
            // numericUpDownSeed
            // 
            numericUpDownSeed.Location = new Point(14, 44);
            numericUpDownSeed.Maximum = new decimal(new int[] { 2147483000, 0, 0, 0 });
            numericUpDownSeed.Minimum = new decimal(new int[] { 2147483000, 0, 0, int.MinValue });
            numericUpDownSeed.Name = "numericUpDownSeed";
            numericUpDownSeed.Size = new Size(183, 23);
            numericUpDownSeed.TabIndex = 9;
            toolTip1.SetToolTip(numericUpDownSeed, "The seed that will be used to\r\nrandomize the values.");
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(44, 536);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(114, 48);
            buttonStart.TabIndex = 8;
            buttonStart.Text = "RANDOMIZE!!!!";
            toolTip1.SetToolTip(buttonStart, "Start randomizing!\r\nThis action is irreversible.\r\nYou have been warned.");
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonSelectPath
            // 
            buttonSelectPath.Location = new Point(14, 371);
            buttonSelectPath.Name = "buttonSelectPath";
            buttonSelectPath.Size = new Size(61, 23);
            buttonSelectPath.TabIndex = 7;
            buttonSelectPath.Text = "Set path";
            buttonSelectPath.UseVisualStyleBackColor = true;
            buttonSelectPath.Click += buttonSelectPath_Click;
            // 
            // textBoxTargetPath
            // 
            textBoxTargetPath.Location = new Point(14, 342);
            textBoxTargetPath.Name = "textBoxTargetPath";
            textBoxTargetPath.Size = new Size(326, 23);
            textBoxTargetPath.TabIndex = 6;
            toolTip1.SetToolTip(textBoxTargetPath, "The actual level files that you\r\nwant randomized. I suggest\r\nsetting this to the \"map\"\r\nfolder inside your dump.");
            // 
            // labelTarget
            // 
            labelTarget.AutoSize = true;
            labelTarget.Location = new Point(14, 324);
            labelTarget.Name = "labelTarget";
            labelTarget.Size = new Size(39, 15);
            labelTarget.TabIndex = 5;
            labelTarget.Text = "Target";
            // 
            // labelSettings
            // 
            labelSettings.AutoSize = true;
            labelSettings.Location = new Point(26, 86);
            labelSettings.Name = "labelSettings";
            labelSettings.Size = new Size(49, 15);
            labelSettings.TabIndex = 3;
            labelSettings.Text = "Settings";
            // 
            // panelSettings
            // 
            panelSettings.BorderStyle = BorderStyle.FixedSingle;
            panelSettings.Controls.Add(checkBoxProperties);
            panelSettings.Controls.Add(checkBoxBackground);
            panelSettings.Controls.Add(checkBoxMovingTerrain);
            panelSettings.Controls.Add(checkBoxTypes);
            panelSettings.Controls.Add(checkBoxEnemySize);
            panelSettings.Controls.Add(checkBoxMusic);
            panelSettings.Controls.Add(checkBoxRooms);
            panelSettings.Controls.Add(checkBoxObjects);
            panelSettings.Controls.Add(checkBoxItems);
            panelSettings.Controls.Add(checkBoxBosses);
            panelSettings.Controls.Add(checkBoxEnemies);
            panelSettings.Controls.Add(panelTileModifiers);
            panelSettings.Location = new Point(14, 92);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(326, 216);
            panelSettings.TabIndex = 4;
            // 
            // checkBoxProperties
            // 
            checkBoxProperties.AutoSize = true;
            checkBoxProperties.Location = new Point(11, 147);
            checkBoxProperties.Name = "checkBoxProperties";
            checkBoxProperties.Size = new Size(116, 34);
            checkBoxProperties.TabIndex = 12;
            checkBoxProperties.Text = "Randomize stage\r\nproperties";
            toolTip1.SetToolTip(checkBoxProperties, "Randomizes miscellaneous\r\nsettings like if the stage has a\r\ngrayscale effect, a particular run\r\neffect, etc...");
            checkBoxProperties.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackground
            // 
            checkBoxBackground.AutoSize = true;
            checkBoxBackground.Location = new Point(169, 158);
            checkBoxBackground.Name = "checkBoxBackground";
            checkBoxBackground.Size = new Size(152, 19);
            checkBoxBackground.TabIndex = 11;
            checkBoxBackground.Text = "Randomize background";
            toolTip1.SetToolTip(checkBoxBackground, "If enabled, every level will use\r\na random background available.");
            checkBoxBackground.UseVisualStyleBackColor = true;
            // 
            // checkBoxMovingTerrain
            // 
            checkBoxMovingTerrain.AutoSize = true;
            checkBoxMovingTerrain.Location = new Point(169, 118);
            checkBoxMovingTerrain.Name = "checkBoxMovingTerrain";
            checkBoxMovingTerrain.Size = new Size(129, 34);
            checkBoxMovingTerrain.TabIndex = 10;
            checkBoxMovingTerrain.Text = "Randomize moving\r\nterrain";
            toolTip1.SetToolTip(checkBoxMovingTerrain, "If enabled, the moving platforms\r\nwill have random directions, speed, etc.");
            checkBoxMovingTerrain.UseVisualStyleBackColor = true;
            // 
            // checkBoxTypes
            // 
            checkBoxTypes.AutoSize = true;
            checkBoxTypes.Location = new Point(169, 78);
            checkBoxTypes.Name = "checkBoxTypes";
            checkBoxTypes.Size = new Size(152, 34);
            checkBoxTypes.TabIndex = 9;
            checkBoxTypes.Text = "Randomize object types\r\n(very chaotic!)";
            toolTip1.SetToolTip(checkBoxTypes, "If enabled alongside randomizing\r\nobjects, the selected options will be\r\nturned into different types of object.");
            checkBoxTypes.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnemySize
            // 
            checkBoxEnemySize.AutoSize = true;
            checkBoxEnemySize.Location = new Point(171, 38);
            checkBoxEnemySize.Name = "checkBoxEnemySize";
            checkBoxEnemySize.Size = new Size(124, 34);
            checkBoxEnemySize.TabIndex = 8;
            checkBoxEnemySize.Text = "Randomize enemy\r\nEX and AD size";
            toolTip1.SetToolTip(checkBoxEnemySize, "If enabled, the enemies in EX mode\r\nand the Another Dimension parts\r\nwill have a random size.");
            checkBoxEnemySize.UseVisualStyleBackColor = true;
            // 
            // checkBoxMusic
            // 
            checkBoxMusic.AutoSize = true;
            checkBoxMusic.Location = new Point(171, 13);
            checkBoxMusic.Name = "checkBoxMusic";
            checkBoxMusic.Size = new Size(120, 19);
            checkBoxMusic.TabIndex = 7;
            checkBoxMusic.Text = "Randomize music";
            toolTip1.SetToolTip(checkBoxMusic, "If enabled, every stage will\r\npick a random music available.");
            checkBoxMusic.UseVisualStyleBackColor = true;
            // 
            // checkBoxRooms
            // 
            checkBoxRooms.AutoSize = true;
            checkBoxRooms.Location = new Point(11, 122);
            checkBoxRooms.Name = "checkBoxRooms";
            checkBoxRooms.Size = new Size(122, 19);
            checkBoxRooms.TabIndex = 6;
            checkBoxRooms.Text = "Randomize rooms";
            toolTip1.SetToolTip(checkBoxRooms, "If enabled, every object that\r\ncan change rooms will skip ahead\r\nto a random room.\r\nThe game will probably not be\r\nbeatable if this is enabled.");
            checkBoxRooms.UseVisualStyleBackColor = true;
            // 
            // checkBoxObjects
            // 
            checkBoxObjects.AutoSize = true;
            checkBoxObjects.Location = new Point(11, 97);
            checkBoxObjects.Name = "checkBoxObjects";
            checkBoxObjects.Size = new Size(140, 19);
            checkBoxObjects.TabIndex = 5;
            checkBoxObjects.Text = "Randomize gimmicks";
            toolTip1.SetToolTip(checkBoxObjects, "Every gimmick in each level will\r\nbe randomized.");
            checkBoxObjects.UseVisualStyleBackColor = true;
            // 
            // checkBoxItems
            // 
            checkBoxItems.AutoSize = true;
            checkBoxItems.Location = new Point(11, 72);
            checkBoxItems.Name = "checkBoxItems";
            checkBoxItems.Size = new Size(117, 19);
            checkBoxItems.TabIndex = 4;
            checkBoxItems.Text = "Randomize items";
            toolTip1.SetToolTip(checkBoxItems, "Every item in each level will\r\nbe randomized.");
            checkBoxItems.UseVisualStyleBackColor = true;
            // 
            // checkBoxBosses
            // 
            checkBoxBosses.AutoSize = true;
            checkBoxBosses.Location = new Point(11, 47);
            checkBoxBosses.Name = "checkBoxBosses";
            checkBoxBosses.Size = new Size(123, 19);
            checkBoxBosses.TabIndex = 3;
            checkBoxBosses.Text = "Randomize bosses";
            toolTip1.SetToolTip(checkBoxBosses, "Every boss in each level will\r\nbe randomized.");
            checkBoxBosses.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnemies
            // 
            checkBoxEnemies.AutoSize = true;
            checkBoxEnemies.Location = new Point(11, 22);
            checkBoxEnemies.Name = "checkBoxEnemies";
            checkBoxEnemies.Size = new Size(132, 19);
            checkBoxEnemies.TabIndex = 2;
            checkBoxEnemies.Text = "Randomize enemies";
            toolTip1.SetToolTip(checkBoxEnemies, "Every enemy in each level will\r\nbe randomized.");
            checkBoxEnemies.UseVisualStyleBackColor = true;
            // 
            // panelTileModifiers
            // 
            panelTileModifiers.BorderStyle = BorderStyle.FixedSingle;
            panelTileModifiers.Controls.Add(buttonTilesCustomize);
            panelTileModifiers.Controls.Add(checkBoxTiles);
            panelTileModifiers.Location = new Point(-1, 183);
            panelTileModifiers.Name = "panelTileModifiers";
            panelTileModifiers.Size = new Size(326, 32);
            panelTileModifiers.TabIndex = 14;
            // 
            // buttonTilesCustomize
            // 
            buttonTilesCustomize.Enabled = false;
            buttonTilesCustomize.Location = new Point(186, 3);
            buttonTilesCustomize.Name = "buttonTilesCustomize";
            buttonTilesCustomize.Size = new Size(109, 23);
            buttonTilesCustomize.TabIndex = 14;
            buttonTilesCustomize.Text = "Customize";
            buttonTilesCustomize.UseVisualStyleBackColor = true;
            buttonTilesCustomize.Click += buttonTilesCustomize_Click;
            // 
            // checkBoxTiles
            // 
            checkBoxTiles.AutoSize = true;
            checkBoxTiles.Location = new Point(11, 5);
            checkBoxTiles.Name = "checkBoxTiles";
            checkBoxTiles.Size = new Size(109, 19);
            checkBoxTiles.TabIndex = 13;
            checkBoxTiles.Text = "Randomize tiles";
            toolTip1.SetToolTip(checkBoxTiles, "If enabled, each tile will\r\nhave a chance to have\r\nsomething placed there.");
            checkBoxTiles.UseVisualStyleBackColor = true;
            checkBoxTiles.CheckedChanged += checkBoxTiles_CheckedChanged;
            // 
            // labelSeed
            // 
            labelSeed.AutoSize = true;
            labelSeed.Location = new Point(14, 26);
            labelSeed.Name = "labelSeed";
            labelSeed.Size = new Size(32, 15);
            labelSeed.TabIndex = 1;
            labelSeed.Text = "Seed";
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelInput.Location = new Point(32, 0);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(43, 20);
            labelInput.TabIndex = 0;
            labelInput.Text = "Input";
            // 
            // panelOutput
            // 
            panelOutput.BorderStyle = BorderStyle.FixedSingle;
            panelOutput.Controls.Add(richTextBoxMessage);
            panelOutput.Controls.Add(labelProgress);
            panelOutput.Controls.Add(progressBarRandomizer);
            panelOutput.Location = new Point(370, 12);
            panelOutput.Name = "panelOutput";
            panelOutput.Size = new Size(260, 600);
            panelOutput.TabIndex = 1;
            // 
            // richTextBoxMessage
            // 
            richTextBoxMessage.Location = new Point(14, 86);
            richTextBoxMessage.Name = "richTextBoxMessage";
            richTextBoxMessage.ReadOnly = true;
            richTextBoxMessage.Size = new Size(232, 498);
            richTextBoxMessage.TabIndex = 2;
            richTextBoxMessage.Text = "";
            // 
            // labelProgress
            // 
            labelProgress.AutoSize = true;
            labelProgress.Location = new Point(14, 26);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(52, 15);
            labelProgress.TabIndex = 1;
            labelProgress.Text = "Progress";
            // 
            // progressBarRandomizer
            // 
            progressBarRandomizer.Location = new Point(14, 44);
            progressBarRandomizer.Name = "progressBarRandomizer";
            progressBarRandomizer.Size = new Size(232, 23);
            progressBarRandomizer.Step = 1;
            progressBarRandomizer.TabIndex = 0;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelOutput.Location = new Point(390, 0);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(55, 20);
            labelOutput.TabIndex = 0;
            labelOutput.Text = "Output";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 624);
            Controls.Add(labelOutput);
            Controls.Add(panelOutput);
            Controls.Add(labelInput);
            Controls.Add(panelInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KRtDL Level Randomizer";
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeed).EndInit();
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            panelTileModifiers.ResumeLayout(false);
            panelTileModifiers.PerformLayout();
            panelOutput.ResumeLayout(false);
            panelOutput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelInput;
        private Label labelInput;
        private Label labelSeed;
        private Panel panelSettings;
        private Label labelSettings;
        private CheckBox checkBoxEnemies;
        private CheckBox checkBoxRooms;
        private CheckBox checkBoxObjects;
        private CheckBox checkBoxItems;
        private CheckBox checkBoxBosses;
        private Button buttonSelectPath;
        private TextBox textBoxTargetPath;
        private Label labelTarget;
        private Button buttonStart;
        private Panel panelOutput;
        private Label labelOutput;
        private RichTextBox richTextBoxMessage;
        private Label labelProgress;
        private ProgressBar progressBarRandomizer;
        private CheckBox checkBoxMusic;
        private CheckBox checkBoxTypes;
        private CheckBox checkBoxEnemySize;
        private NumericUpDown numericUpDownSeed;
        private CheckBox checkBoxMovingTerrain;
        private Button buttonRandomizeSeed;
        private CheckBox checkBoxProperties;
        private CheckBox checkBoxBackground;
        private Panel panelTileModifiers;
        private Button buttonTilesCustomize;
        private CheckBox checkBoxTiles;
        private Button buttonFdg;
        private TextBox textBoxFdg;
        private Label labelFdg;
        private CheckBox checkBoxManualFdg;
        private CheckBox checkBoxKrtdlDx;
        private ToolTip toolTip1;
    }
}