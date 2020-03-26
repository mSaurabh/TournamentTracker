namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.teamSlashPlayersLabel = new System.Windows.Forms.Label();
            this.removeSelectedPlayerButton = new System.Windows.Forms.Button();
            this.removeSelectedPrizeButton = new System.Windows.Forms.Button();
            this.teamsPlayersLabel = new System.Windows.Forms.Label();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(319, 43);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(42, 114);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(323, 31);
            this.tournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tournamentNameLabel.Location = new System.Drawing.Point(36, 77);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(229, 34);
            this.tournamentNameLabel.TabIndex = 9;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(164, 171);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(100, 31);
            this.entryFeeValue.TabIndex = 12;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.entryFeeLabel.Location = new System.Drawing.Point(36, 169);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(122, 34);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(42, 314);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(323, 34);
            this.selectTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.selectTeamLabel.Location = new System.Drawing.Point(36, 277);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(155, 34);
            this.selectTeamLabel.TabIndex = 13;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(251, 283);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(114, 26);
            this.createNewTeamLink.TabIndex = 15;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "Create New";
            this.createNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLink_LinkClicked);
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.addTeamButton.Location = new System.Drawing.Point(103, 364);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(200, 41);
            this.addTeamButton.TabIndex = 16;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createPrizeButton.Location = new System.Drawing.Point(103, 444);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(200, 41);
            this.createPrizeButton.TabIndex = 17;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 26;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(433, 114);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(244, 158);
            this.tournamentTeamsListBox.TabIndex = 18;
            // 
            // teamSlashPlayersLabel
            // 
            this.teamSlashPlayersLabel.AutoSize = true;
            this.teamSlashPlayersLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamSlashPlayersLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.teamSlashPlayersLabel.Location = new System.Drawing.Point(427, 77);
            this.teamSlashPlayersLabel.Name = "teamSlashPlayersLabel";
            this.teamSlashPlayersLabel.Size = new System.Drawing.Size(199, 34);
            this.teamSlashPlayersLabel.TabIndex = 19;
            this.teamSlashPlayersLabel.Text = "Teams / Players";
            // 
            // removeSelectedPlayerButton
            // 
            this.removeSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPlayerButton.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedPlayerButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.removeSelectedPlayerButton.Location = new System.Drawing.Point(702, 161);
            this.removeSelectedPlayerButton.Name = "removeSelectedPlayerButton";
            this.removeSelectedPlayerButton.Size = new System.Drawing.Size(128, 64);
            this.removeSelectedPlayerButton.TabIndex = 21;
            this.removeSelectedPlayerButton.Text = "Remove Selected";
            this.removeSelectedPlayerButton.UseVisualStyleBackColor = true;
            this.removeSelectedPlayerButton.Click += new System.EventHandler(this.removeSelectedPlayerButton_Click);
            // 
            // removeSelectedPrizeButton
            // 
            this.removeSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPrizeButton.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedPrizeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.removeSelectedPrizeButton.Location = new System.Drawing.Point(702, 374);
            this.removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            this.removeSelectedPrizeButton.Size = new System.Drawing.Size(128, 64);
            this.removeSelectedPrizeButton.TabIndex = 24;
            this.removeSelectedPrizeButton.Text = "Remove Selected";
            this.removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            this.removeSelectedPrizeButton.Click += new System.EventHandler(this.removeSelectedPrizeButton_Click);
            // 
            // teamsPlayersLabel
            // 
            this.teamsPlayersLabel.AutoSize = true;
            this.teamsPlayersLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsPlayersLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.teamsPlayersLabel.Location = new System.Drawing.Point(427, 291);
            this.teamsPlayersLabel.Name = "teamsPlayersLabel";
            this.teamsPlayersLabel.Size = new System.Drawing.Size(83, 34);
            this.teamsPlayersLabel.TabIndex = 23;
            this.teamsPlayersLabel.Text = "Prizes";
            // 
            // prizeListBox
            // 
            this.prizeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizeListBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.ItemHeight = 26;
            this.prizeListBox.Location = new System.Drawing.Point(433, 327);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(244, 158);
            this.prizeListBox.TabIndex = 22;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createTournamentButton.Location = new System.Drawing.Point(294, 518);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(249, 77);
            this.createTournamentButton.TabIndex = 25;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 607);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.removeSelectedPrizeButton);
            this.Controls.Add(this.teamsPlayersLabel);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(this.removeSelectedPlayerButton);
            this.Controls.Add(this.teamSlashPlayersLabel);
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.Label teamSlashPlayersLabel;
        private System.Windows.Forms.Button removeSelectedPlayerButton;
        private System.Windows.Forms.Button removeSelectedPrizeButton;
        private System.Windows.Forms.Label teamsPlayersLabel;
        private System.Windows.Forms.ListBox prizeListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}