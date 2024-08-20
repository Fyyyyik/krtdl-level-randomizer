namespace KRtDL_Level_Randomizer.LevelRandomizer
{
    partial class FDGSceneSelector
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
            comboBoxFdgScene = new ComboBox();
            labelFdgScene = new Label();
            labelProblem = new Label();
            panelProblem = new Panel();
            textBoxProblem = new TextBox();
            buttonDone = new Button();
            panelProblem.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxFdgScene
            // 
            comboBoxFdgScene.FormattingEnabled = true;
            comboBoxFdgScene.Location = new Point(12, 35);
            comboBoxFdgScene.Name = "comboBoxFdgScene";
            comboBoxFdgScene.Size = new Size(331, 23);
            comboBoxFdgScene.TabIndex = 0;
            // 
            // labelFdgScene
            // 
            labelFdgScene.AutoSize = true;
            labelFdgScene.Location = new Point(12, 17);
            labelFdgScene.Name = "labelFdgScene";
            labelFdgScene.Size = new Size(102, 15);
            labelFdgScene.TabIndex = 1;
            labelFdgScene.Text = "Select FDG scene :";
            // 
            // labelProblem
            // 
            labelProblem.AutoSize = true;
            labelProblem.Location = new Point(23, 106);
            labelProblem.Name = "labelProblem";
            labelProblem.Size = new Size(104, 15);
            labelProblem.TabIndex = 2;
            labelProblem.Text = "Problematic scene";
            // 
            // panelProblem
            // 
            panelProblem.BorderStyle = BorderStyle.FixedSingle;
            panelProblem.Controls.Add(textBoxProblem);
            panelProblem.Location = new Point(12, 113);
            panelProblem.Name = "panelProblem";
            panelProblem.Size = new Size(331, 62);
            panelProblem.TabIndex = 3;
            // 
            // textBoxProblem
            // 
            textBoxProblem.Location = new Point(10, 21);
            textBoxProblem.Name = "textBoxProblem";
            textBoxProblem.ReadOnly = true;
            textBoxProblem.ScrollBars = ScrollBars.Horizontal;
            textBoxProblem.Size = new Size(305, 23);
            textBoxProblem.TabIndex = 0;
            textBoxProblem.WordWrap = false;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(131, 64);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 23);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Done";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // FDGSceneSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 187);
            Controls.Add(buttonDone);
            Controls.Add(labelProblem);
            Controls.Add(labelFdgScene);
            Controls.Add(comboBoxFdgScene);
            Controls.Add(panelProblem);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FDGSceneSelector";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Select level to patch";
            Load += FDGSceneSelector_Load;
            panelProblem.ResumeLayout(false);
            panelProblem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFdgScene;
        private Label labelFdgScene;
        private Label labelProblem;
        private Panel panelProblem;
        private TextBox textBoxProblem;
        private Button buttonDone;
    }
}