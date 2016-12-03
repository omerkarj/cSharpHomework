namespace Ex01.FacebookClient
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.facebookPage = new System.Windows.Forms.TabPage();
            this.checkinsPage = new System.Windows.Forms.TabPage();
            this.likesPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelBG = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxFriends = new System.Windows.Forms.GroupBox();
            this.groupBoxGroups = new System.Windows.Forms.GroupBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.groupBoxPages = new System.Windows.Forms.GroupBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.groupBoxFeed = new System.Windows.Forms.GroupBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.comboBoxExposure = new System.Windows.Forms.ComboBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelDescMap1 = new System.Windows.Forms.Label();
            this.labelDescMap2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCheckins = new System.Windows.Forms.Button();
            this.groupBoxCheckins = new System.Windows.Forms.GroupBox();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.groupBoxLikePage = new System.Windows.Forms.GroupBox();
            this.groupBoxCategories = new System.Windows.Forms.GroupBox();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.groupBoxLikePages = new System.Windows.Forms.GroupBox();
            this.listBoxLikePages = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.facebookPage.SuspendLayout();
            this.checkinsPage.SuspendLayout();
            this.likesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.groupBoxFriends.SuspendLayout();
            this.groupBoxGroups.SuspendLayout();
            this.groupBoxPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.groupBoxFeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxCheckins.SuspendLayout();
            this.groupBoxCategories.SuspendLayout();
            this.groupBoxLikePages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.facebookPage);
            this.tabControl.Controls.Add(this.checkinsPage);
            this.tabControl.Controls.Add(this.likesPage);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabControl.ItemSize = new System.Drawing.Size(4, 31);
            this.tabControl.Location = new System.Drawing.Point(63, 18);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(1030, 744);
            this.tabControl.TabIndex = 0;
            // 
            // facebookPage
            // 
            this.facebookPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.facebookPage.Controls.Add(this.textBoxPost);
            this.facebookPage.Controls.Add(this.comboBoxExposure);
            this.facebookPage.Controls.Add(this.buttonPost);
            this.facebookPage.Controls.Add(this.groupBoxFeed);
            this.facebookPage.Controls.Add(this.groupBoxPages);
            this.facebookPage.Controls.Add(this.groupBoxGroups);
            this.facebookPage.Controls.Add(this.groupBoxFriends);
            this.facebookPage.Location = new System.Drawing.Point(4, 35);
            this.facebookPage.Name = "facebookPage";
            this.facebookPage.Padding = new System.Windows.Forms.Padding(3);
            this.facebookPage.Size = new System.Drawing.Size(1022, 705);
            this.facebookPage.TabIndex = 0;
            this.facebookPage.Text = "Facebook";
            this.facebookPage.ToolTipText = "Basic Facebook functionality";
            // 
            // checkinsPage
            // 
            this.checkinsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.checkinsPage.Controls.Add(this.groupBoxCheckins);
            this.checkinsPage.Controls.Add(this.buttonCheckins);
            this.checkinsPage.Controls.Add(this.label2);
            this.checkinsPage.Controls.Add(this.label1);
            this.checkinsPage.Controls.Add(this.pictureBox1);
            this.checkinsPage.Controls.Add(this.labelDescMap2);
            this.checkinsPage.Controls.Add(this.labelDescMap1);
            this.checkinsPage.Controls.Add(this.dateTimePicker2);
            this.checkinsPage.Controls.Add(this.dateTimePicker1);
            this.checkinsPage.Location = new System.Drawing.Point(4, 35);
            this.checkinsPage.Name = "checkinsPage";
            this.checkinsPage.Padding = new System.Windows.Forms.Padding(3);
            this.checkinsPage.Size = new System.Drawing.Size(1022, 705);
            this.checkinsPage.TabIndex = 1;
            this.checkinsPage.Text = "Map my checkins";
            this.checkinsPage.ToolTipText = "Display all checkins in date range on a map";
            // 
            // likesPage
            // 
            this.likesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.likesPage.Controls.Add(this.label4);
            this.likesPage.Controls.Add(this.label3);
            this.likesPage.Controls.Add(this.groupBoxLikePages);
            this.likesPage.Controls.Add(this.groupBoxCategories);
            this.likesPage.Controls.Add(this.groupBoxLikePage);
            this.likesPage.Location = new System.Drawing.Point(4, 35);
            this.likesPage.Name = "likesPage";
            this.likesPage.Padding = new System.Windows.Forms.Padding(3);
            this.likesPage.Size = new System.Drawing.Size(1022, 705);
            this.likesPage.TabIndex = 2;
            this.likesPage.Text = "Likes you might like";
            this.likesPage.ToolTipText = "Display likes of friends based on category";
            // 
            // flowLayoutPanelBG
            // 
            this.flowLayoutPanelBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.flowLayoutPanelBG.Location = new System.Drawing.Point(-1, 53);
            this.flowLayoutPanelBG.Name = "flowLayoutPanelBG";
            this.flowLayoutPanelBG.Size = new System.Drawing.Size(1158, 716);
            this.flowLayoutPanelBG.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(18, 18);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(26, 24);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // groupBoxFriends
            // 
            this.groupBoxFriends.Controls.Add(this.listBoxFriends);
            this.groupBoxFriends.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxFriends.Location = new System.Drawing.Point(744, 151);
            this.groupBoxFriends.Name = "groupBoxFriends";
            this.groupBoxFriends.Size = new System.Drawing.Size(270, 546);
            this.groupBoxFriends.TabIndex = 1;
            this.groupBoxFriends.TabStop = false;
            this.groupBoxFriends.Text = "Friends";
            // 
            // groupBoxGroups
            // 
            this.groupBoxGroups.Controls.Add(this.listBoxGroups);
            this.groupBoxGroups.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxGroups.Location = new System.Drawing.Point(6, 32);
            this.groupBoxGroups.Name = "groupBoxGroups";
            this.groupBoxGroups.Size = new System.Drawing.Size(242, 323);
            this.groupBoxGroups.TabIndex = 2;
            this.groupBoxGroups.TabStop = false;
            this.groupBoxGroups.Text = "Groups";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 17;
            this.listBoxGroups.Location = new System.Drawing.Point(6, 21);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(230, 276);
            this.listBoxGroups.TabIndex = 0;
            // 
            // groupBoxPages
            // 
            this.groupBoxPages.Controls.Add(this.listBoxPages);
            this.groupBoxPages.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxPages.Location = new System.Drawing.Point(6, 375);
            this.groupBoxPages.Name = "groupBoxPages";
            this.groupBoxPages.Size = new System.Drawing.Size(242, 322);
            this.groupBoxPages.TabIndex = 3;
            this.groupBoxPages.TabStop = false;
            this.groupBoxPages.Text = "Pages";
            // 
            // listBoxPages
            // 
            this.listBoxPages.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 17;
            this.listBoxPages.Location = new System.Drawing.Point(6, 21);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(230, 276);
            this.listBoxPages.TabIndex = 0;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 17;
            this.listBoxFriends.Location = new System.Drawing.Point(7, 21);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(257, 514);
            this.listBoxFriends.TabIndex = 0;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.White;
            this.pictureBoxProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.Image")));
            this.pictureBoxProfile.Location = new System.Drawing.Point(864, 15);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(168, 168);
            this.pictureBoxProfile.TabIndex = 4;
            this.pictureBoxProfile.TabStop = false;
            // 
            // groupBoxFeed
            // 
            this.groupBoxFeed.Controls.Add(this.buttonNext);
            this.groupBoxFeed.Controls.Add(this.buttonPrev);
            this.groupBoxFeed.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxFeed.Location = new System.Drawing.Point(273, 151);
            this.groupBoxFeed.Name = "groupBoxFeed";
            this.groupBoxFeed.Size = new System.Drawing.Size(445, 546);
            this.groupBoxFeed.TabIndex = 4;
            this.groupBoxFeed.TabStop = false;
            this.groupBoxFeed.Text = "My Feed";
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonPost.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.ForeColor = System.Drawing.Color.White;
            this.buttonPost.Location = new System.Drawing.Point(633, 106);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(84, 39);
            this.buttonPost.TabIndex = 5;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            // 
            // comboBoxExposure
            // 
            this.comboBoxExposure.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxExposure.FormattingEnabled = true;
            this.comboBoxExposure.Items.AddRange(new object[] {
            "Everyone",
            "Friends",
            "Only Me"});
            this.comboBoxExposure.Location = new System.Drawing.Point(506, 114);
            this.comboBoxExposure.Name = "comboBoxExposure";
            this.comboBoxExposure.Size = new System.Drawing.Size(121, 25);
            this.comboBoxExposure.TabIndex = 6;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPost.Location = new System.Drawing.Point(273, 39);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(443, 61);
            this.textBoxPost.TabIndex = 7;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(239, 511);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(96, 29);
            this.buttonPrev.TabIndex = 0;
            this.buttonPrev.Text = "< Previous";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(341, 511);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(96, 29);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Next >";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker2.Location = new System.Drawing.Point(355, 107);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // labelDescMap1
            // 
            this.labelDescMap1.AutoSize = true;
            this.labelDescMap1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.labelDescMap1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescMap1.Location = new System.Drawing.Point(22, 30);
            this.labelDescMap1.Name = "labelDescMap1";
            this.labelDescMap1.Size = new System.Drawing.Size(626, 20);
            this.labelDescMap1.TabIndex = 2;
            this.labelDescMap1.Text = "Select a date range, and we will display all of your corresponding checkins on th" +
    "e world map!";
            // 
            // labelDescMap2
            // 
            this.labelDescMap2.AutoSize = true;
            this.labelDescMap2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.labelDescMap2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescMap2.Location = new System.Drawing.Point(22, 55);
            this.labelDescMap2.Name = "labelDescMap2";
            this.labelDescMap2.Size = new System.Drawing.Size(516, 20);
            this.labelDescMap2.TabIndex = 3;
            this.labelDescMap2.Text = "Select a specific checkin from the list, and we will show a close up map for it.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 539);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // buttonCheckins
            // 
            this.buttonCheckins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonCheckins.ForeColor = System.Drawing.Color.White;
            this.buttonCheckins.Location = new System.Drawing.Point(588, 102);
            this.buttonCheckins.Name = "buttonCheckins";
            this.buttonCheckins.Size = new System.Drawing.Size(96, 39);
            this.buttonCheckins.TabIndex = 7;
            this.buttonCheckins.Text = "Go!";
            this.buttonCheckins.UseVisualStyleBackColor = false;
            // 
            // groupBoxCheckins
            // 
            this.groupBoxCheckins.Controls.Add(this.listBoxCheckins);
            this.groupBoxCheckins.Location = new System.Drawing.Point(758, 149);
            this.groupBoxCheckins.Name = "groupBoxCheckins";
            this.groupBoxCheckins.Size = new System.Drawing.Size(246, 548);
            this.groupBoxCheckins.TabIndex = 8;
            this.groupBoxCheckins.TabStop = false;
            this.groupBoxCheckins.Text = "Checkins";
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.ItemHeight = 17;
            this.listBoxCheckins.Location = new System.Drawing.Point(7, 25);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(233, 514);
            this.listBoxCheckins.TabIndex = 0;
            // 
            // groupBoxLikePage
            // 
            this.groupBoxLikePage.Location = new System.Drawing.Point(643, 143);
            this.groupBoxLikePage.Name = "groupBoxLikePage";
            this.groupBoxLikePage.Size = new System.Drawing.Size(365, 554);
            this.groupBoxLikePage.TabIndex = 0;
            this.groupBoxLikePage.TabStop = false;
            this.groupBoxLikePage.Text = "Page Details";
            // 
            // groupBoxCategories
            // 
            this.groupBoxCategories.Controls.Add(this.listBoxCategories);
            this.groupBoxCategories.Location = new System.Drawing.Point(14, 80);
            this.groupBoxCategories.Name = "groupBoxCategories";
            this.groupBoxCategories.Size = new System.Drawing.Size(271, 617);
            this.groupBoxCategories.TabIndex = 1;
            this.groupBoxCategories.TabStop = false;
            this.groupBoxCategories.Text = "Categories";
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 17;
            this.listBoxCategories.Location = new System.Drawing.Point(7, 25);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(258, 582);
            this.listBoxCategories.TabIndex = 0;
            // 
            // groupBoxLikePages
            // 
            this.groupBoxLikePages.Controls.Add(this.listBoxLikePages);
            this.groupBoxLikePages.Location = new System.Drawing.Point(314, 80);
            this.groupBoxLikePages.Name = "groupBoxLikePages";
            this.groupBoxLikePages.Size = new System.Drawing.Size(303, 617);
            this.groupBoxLikePages.TabIndex = 2;
            this.groupBoxLikePages.TabStop = false;
            this.groupBoxLikePages.Text = "Pages Liked by Friends";
            // 
            // listBoxLikePages
            // 
            this.listBoxLikePages.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxLikePages.FormattingEnabled = true;
            this.listBoxLikePages.ItemHeight = 17;
            this.listBoxLikePages.Location = new System.Drawing.Point(7, 25);
            this.listBoxLikePages.Name = "listBoxLikePages";
            this.listBoxLikePages.Size = new System.Drawing.Size(290, 582);
            this.listBoxLikePages.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(643, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select a category, and we will display all pages in the category which were liked" +
    " by your friends!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(17, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select a page to see details about it, and maybe like it too.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(1153, 762);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.flowLayoutPanelBG);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl.ResumeLayout(false);
            this.facebookPage.ResumeLayout(false);
            this.facebookPage.PerformLayout();
            this.checkinsPage.ResumeLayout(false);
            this.checkinsPage.PerformLayout();
            this.likesPage.ResumeLayout(false);
            this.likesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.groupBoxFriends.ResumeLayout(false);
            this.groupBoxGroups.ResumeLayout(false);
            this.groupBoxPages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.groupBoxFeed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxCheckins.ResumeLayout(false);
            this.groupBoxCategories.ResumeLayout(false);
            this.groupBoxLikePages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage facebookPage;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.GroupBox groupBoxPages;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.GroupBox groupBoxGroups;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.GroupBox groupBoxFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.TabPage checkinsPage;
        private System.Windows.Forms.TabPage likesPage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBG;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.ComboBox comboBoxExposure;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.GroupBox groupBoxFeed;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.GroupBox groupBoxCheckins;
        private System.Windows.Forms.ListBox listBoxCheckins;
        private System.Windows.Forms.Button buttonCheckins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDescMap2;
        private System.Windows.Forms.Label labelDescMap1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxLikePages;
        private System.Windows.Forms.ListBox listBoxLikePages;
        private System.Windows.Forms.GroupBox groupBoxCategories;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.GroupBox groupBoxLikePage;

    }
}