namespace TigerHacks2024ChampionGardenSim
{
    partial class ChampionGardenSim
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
            this.bedSetupPanel = new System.Windows.Forms.Panel();
            this.walkwayNoteLabel = new System.Windows.Forms.Label();
            this.walkwayLabel = new System.Windows.Forms.Label();
            this.gardeningSpaceLabel = new System.Windows.Forms.Label();
            this.ChampionGardenSimLabel = new System.Windows.Forms.Label();
            this.whatCropsLabel = new System.Windows.Forms.Label();
            this.rowLabel = new System.Windows.Forms.Label();
            this.rowCropComboBox = new System.Windows.Forms.ComboBox();
            this.row1Panel = new System.Windows.Forms.Panel();
            this.cropInfoFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.simulateButton = new System.Windows.Forms.Button();
            this.bedSetupPanel.SuspendLayout();
            this.row1Panel.SuspendLayout();
            this.cropInfoFlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bedSetupPanel
            // 
            this.bedSetupPanel.Controls.Add(this.simulateButton);
            this.bedSetupPanel.Controls.Add(this.cropInfoFlowPanel);
            this.bedSetupPanel.Controls.Add(this.whatCropsLabel);
            this.bedSetupPanel.Controls.Add(this.walkwayNoteLabel);
            this.bedSetupPanel.Controls.Add(this.walkwayLabel);
            this.bedSetupPanel.Controls.Add(this.gardeningSpaceLabel);
            this.bedSetupPanel.Location = new System.Drawing.Point(12, 92);
            this.bedSetupPanel.Name = "bedSetupPanel";
            this.bedSetupPanel.Size = new System.Drawing.Size(416, 543);
            this.bedSetupPanel.TabIndex = 0;
            // 
            // walkwayNoteLabel
            // 
            this.walkwayNoteLabel.AutoSize = true;
            this.walkwayNoteLabel.Font = new System.Drawing.Font("Goudy Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walkwayNoteLabel.Location = new System.Drawing.Point(14, 123);
            this.walkwayNoteLabel.Name = "walkwayNoteLabel";
            this.walkwayNoteLabel.Size = new System.Drawing.Size(311, 38);
            this.walkwayNoteLabel.TabIndex = 2;
            this.walkwayNoteLabel.Text = "Note these minimums: 3ft for wheelbarrow access,\n4ft to accommodate wheelchair us" +
    "e.";
            // 
            // walkwayLabel
            // 
            this.walkwayLabel.AutoSize = true;
            this.walkwayLabel.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walkwayLabel.Location = new System.Drawing.Point(14, 88);
            this.walkwayLabel.Name = "walkwayLabel";
            this.walkwayLabel.Size = new System.Drawing.Size(394, 23);
            this.walkwayLabel.TabIndex = 1;
            this.walkwayLabel.Text = "2. How wide do you need your walkways to be?";
            // 
            // gardeningSpaceLabel
            // 
            this.gardeningSpaceLabel.AutoSize = true;
            this.gardeningSpaceLabel.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gardeningSpaceLabel.Location = new System.Drawing.Point(14, 22);
            this.gardeningSpaceLabel.Name = "gardeningSpaceLabel";
            this.gardeningSpaceLabel.Size = new System.Drawing.Size(304, 23);
            this.gardeningSpaceLabel.TabIndex = 0;
            this.gardeningSpaceLabel.Text = "1. How big is your gardening space?";
            // 
            // ChampionGardenSimLabel
            // 
            this.ChampionGardenSimLabel.AutoSize = true;
            this.ChampionGardenSimLabel.Font = new System.Drawing.Font("Goudy Old Style", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChampionGardenSimLabel.Location = new System.Drawing.Point(12, 21);
            this.ChampionGardenSimLabel.Name = "ChampionGardenSimLabel";
            this.ChampionGardenSimLabel.Size = new System.Drawing.Size(416, 50);
            this.ChampionGardenSimLabel.TabIndex = 0;
            this.ChampionGardenSimLabel.Text = "Champion Garden Sim";
            // 
            // whatCropsLabel
            // 
            this.whatCropsLabel.AutoSize = true;
            this.whatCropsLabel.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatCropsLabel.Location = new System.Drawing.Point(14, 224);
            this.whatCropsLabel.Name = "whatCropsLabel";
            this.whatCropsLabel.Size = new System.Drawing.Size(303, 23);
            this.whatCropsLabel.TabIndex = 3;
            this.whatCropsLabel.Text = "3. What crops do you want to grow?";
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Location = new System.Drawing.Point(7, 13);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(112, 23);
            this.rowLabel.TabIndex = 4;
            this.rowLabel.Text = "Row 1 Crop:";
            // 
            // rowCropComboBox
            // 
            this.rowCropComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rowCropComboBox.FormattingEnabled = true;
            this.rowCropComboBox.Location = new System.Drawing.Point(109, 10);
            this.rowCropComboBox.Name = "rowCropComboBox";
            this.rowCropComboBox.Size = new System.Drawing.Size(121, 31);
            this.rowCropComboBox.Sorted = true;
            this.rowCropComboBox.TabIndex = 5;
            // 
            // row1Panel
            // 
            this.row1Panel.AutoScroll = true;
            this.row1Panel.Controls.Add(this.rowLabel);
            this.row1Panel.Controls.Add(this.rowCropComboBox);
            this.row1Panel.Location = new System.Drawing.Point(3, 3);
            this.row1Panel.Name = "row1Panel";
            this.row1Panel.Size = new System.Drawing.Size(255, 56);
            this.row1Panel.TabIndex = 1;
            // 
            // cropInfoFlowPanel
            // 
            this.cropInfoFlowPanel.AutoScroll = true;
            this.cropInfoFlowPanel.Controls.Add(this.row1Panel);
            this.cropInfoFlowPanel.Location = new System.Drawing.Point(18, 250);
            this.cropInfoFlowPanel.Name = "cropInfoFlowPanel";
            this.cropInfoFlowPanel.Size = new System.Drawing.Size(374, 210);
            this.cropInfoFlowPanel.TabIndex = 4;
            // 
            // simulateButton
            // 
            this.simulateButton.Location = new System.Drawing.Point(130, 466);
            this.simulateButton.Name = "simulateButton";
            this.simulateButton.Size = new System.Drawing.Size(146, 65);
            this.simulateButton.TabIndex = 1;
            this.simulateButton.Text = "Simulate!";
            this.simulateButton.UseVisualStyleBackColor = true;
            this.simulateButton.Click += new System.EventHandler(this.simulateButton_Click);
            // 
            // ChampionGardenSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 647);
            this.Controls.Add(this.ChampionGardenSimLabel);
            this.Controls.Add(this.bedSetupPanel);
            this.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ChampionGardenSim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Champion Garden Sim";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.bedSetupPanel.ResumeLayout(false);
            this.bedSetupPanel.PerformLayout();
            this.row1Panel.ResumeLayout(false);
            this.row1Panel.PerformLayout();
            this.cropInfoFlowPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bedSetupPanel;
        private System.Windows.Forms.Label walkwayNoteLabel;
        private System.Windows.Forms.Label walkwayLabel;
        private System.Windows.Forms.Label gardeningSpaceLabel;
        private System.Windows.Forms.Label ChampionGardenSimLabel;
        private System.Windows.Forms.ComboBox rowCropComboBox;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.Label whatCropsLabel;
        private System.Windows.Forms.Panel row1Panel;
        private System.Windows.Forms.Button simulateButton;
        private System.Windows.Forms.FlowLayoutPanel cropInfoFlowPanel;
    }
}

