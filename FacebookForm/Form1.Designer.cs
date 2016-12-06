namespace FacebookForm
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.facebookPage = new System.Windows.Forms.TabPage();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.comboBoxExposure = new System.Windows.Forms.ComboBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.groupBoxFeed = new System.Windows.Forms.GroupBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.groupBoxPages = new System.Windows.Forms.GroupBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.groupBoxGroups = new System.Windows.Forms.GroupBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.groupBoxFriends = new System.Windows.Forms.GroupBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.checkinsPage = new System.Windows.Forms.TabPage();
            this.groupBoxCheckins = new System.Windows.Forms.GroupBox();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.buttonCheckins = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDescMap2 = new System.Windows.Forms.Label();
            this.labelDescMap1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.likesPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxLikePages = new System.Windows.Forms.GroupBox();
            this.listBoxLikePages = new System.Windows.Forms.ListBox();
            this.groupBoxCategories = new System.Windows.Forms.GroupBox();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.groupBoxLikePage = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelBG = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.facebookPage.SuspendLayout();
            this.groupBoxFeed.SuspendLayout();
            this.groupBoxPages.SuspendLayout();
            this.groupBoxGroups.SuspendLayout();
            this.groupBoxFriends.SuspendLayout();
            this.checkinsPage.SuspendLayout();
            this.groupBoxCheckins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.likesPage.SuspendLayout();
            this.groupBoxLikePages.SuspendLayout();
            this.groupBoxCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.facebookPage);
            this.tabControl.Controls.Add(this.checkinsPage);
            this.tabControl.Controls.Add(this.likesPage);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabControl.ItemSize = new System.Drawing.Size(4, 31);
            this.tabControl.Location = new System.Drawing.Point(47, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(772, 604);
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
            this.facebookPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.facebookPage.Name = "facebookPage";
            this.facebookPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.facebookPage.Size = new System.Drawing.Size(764, 565);
            this.facebookPage.TabIndex = 0;
            this.facebookPage.Text = "Facebook";
            this.facebookPage.ToolTipText = "Basic Facebook functionality";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPost.Location = new System.Drawing.Point(205, 32);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(333, 50);
            this.textBoxPost.TabIndex = 7;
            // 
            // comboBoxExposure
            // 
            this.comboBoxExposure.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxExposure.FormattingEnabled = true;
            this.comboBoxExposure.Items.AddRange(new object[] {
            "Everyone",
            "Friends",
            "Only Me"});
            this.comboBoxExposure.Location = new System.Drawing.Point(380, 93);
            this.comboBoxExposure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxExposure.Name = "comboBoxExposure";
            this.comboBoxExposure.Size = new System.Drawing.Size(92, 20);
            this.comboBoxExposure.TabIndex = 6;
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonPost.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.ForeColor = System.Drawing.Color.White;
            this.buttonPost.Location = new System.Drawing.Point(475, 86);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(63, 32);
            this.buttonPost.TabIndex = 5;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            // 
            // groupBoxFeed
            // 
            this.groupBoxFeed.Controls.Add(this.buttonNext);
            this.groupBoxFeed.Controls.Add(this.buttonPrev);
            this.groupBoxFeed.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxFeed.Location = new System.Drawing.Point(205, 123);
            this.groupBoxFeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFeed.Name = "groupBoxFeed";
            this.groupBoxFeed.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFeed.Size = new System.Drawing.Size(334, 444);
            this.groupBoxFeed.TabIndex = 4;
            this.groupBoxFeed.TabStop = false;
            this.groupBoxFeed.Text = "My Feed";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(256, 415);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(72, 24);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Next >";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(179, 415);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(72, 24);
            this.buttonPrev.TabIndex = 0;
            this.buttonPrev.Text = "< Previous";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // groupBoxPages
            // 
            this.groupBoxPages.Controls.Add(this.listBoxPages);
            this.groupBoxPages.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxPages.Location = new System.Drawing.Point(4, 305);
            this.groupBoxPages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPages.Name = "groupBoxPages";
            this.groupBoxPages.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPages.Size = new System.Drawing.Size(182, 262);
            this.groupBoxPages.TabIndex = 3;
            this.groupBoxPages.TabStop = false;
            this.groupBoxPages.Text = "Pages";
            // 
            // listBoxPages
            // 
            this.listBoxPages.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 12;
            this.listBoxPages.Location = new System.Drawing.Point(4, 17);
            this.listBoxPages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(174, 220);
            this.listBoxPages.TabIndex = 0;
            // 
            // groupBoxGroups
            // 
            this.groupBoxGroups.Controls.Add(this.listBoxGroups);
            this.groupBoxGroups.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxGroups.Location = new System.Drawing.Point(4, 26);
            this.groupBoxGroups.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxGroups.Name = "groupBoxGroups";
            this.groupBoxGroups.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxGroups.Size = new System.Drawing.Size(182, 262);
            this.groupBoxGroups.TabIndex = 2;
            this.groupBoxGroups.TabStop = false;
            this.groupBoxGroups.Text = "Groups";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 12;
            this.listBoxGroups.Location = new System.Drawing.Point(4, 17);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(174, 220);
            this.listBoxGroups.TabIndex = 0;
            // 
            // groupBoxFriends
            // 
            this.groupBoxFriends.Controls.Add(this.listBoxFriends);
            this.groupBoxFriends.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxFriends.Location = new System.Drawing.Point(558, 123);
            this.groupBoxFriends.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFriends.Name = "groupBoxFriends";
            this.groupBoxFriends.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFriends.Size = new System.Drawing.Size(202, 444);
            this.groupBoxFriends.TabIndex = 1;
            this.groupBoxFriends.TabStop = false;
            this.groupBoxFriends.Text = "Friends";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 12;
            this.listBoxFriends.Location = new System.Drawing.Point(5, 17);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(194, 412);
            this.listBoxFriends.TabIndex = 0;
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
            this.checkinsPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkinsPage.Name = "checkinsPage";
            this.checkinsPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkinsPage.Size = new System.Drawing.Size(764, 565);
            this.checkinsPage.TabIndex = 1;
            this.checkinsPage.Text = "Map my checkins";
            this.checkinsPage.ToolTipText = "Display all checkins in date range on a map";
            // 
            // groupBoxCheckins
            // 
            this.groupBoxCheckins.Controls.Add(this.listBoxCheckins);
            this.groupBoxCheckins.Location = new System.Drawing.Point(568, 121);
            this.groupBoxCheckins.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCheckins.Name = "groupBoxCheckins";
            this.groupBoxCheckins.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCheckins.Size = new System.Drawing.Size(184, 445);
            this.groupBoxCheckins.TabIndex = 8;
            this.groupBoxCheckins.TabStop = false;
            this.groupBoxCheckins.Text = "Checkins";
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.ItemHeight = 12;
            this.listBoxCheckins.Location = new System.Drawing.Point(5, 20);
            this.listBoxCheckins.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(176, 412);
            this.listBoxCheckins.TabIndex = 0;
            // 
            // buttonCheckins
            // 
            this.buttonCheckins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonCheckins.ForeColor = System.Drawing.Color.White;
            this.buttonCheckins.Location = new System.Drawing.Point(441, 83);
            this.buttonCheckins.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCheckins.Name = "buttonCheckins";
            this.buttonCheckins.Size = new System.Drawing.Size(72, 32);
            this.buttonCheckins.TabIndex = 7;
            this.buttonCheckins.Text = "Go!";
            this.buttonCheckins.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 438);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelDescMap2
            // 
            this.labelDescMap2.AutoSize = true;
            this.labelDescMap2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.labelDescMap2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescMap2.Location = new System.Drawing.Point(16, 45);
            this.labelDescMap2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescMap2.Name = "labelDescMap2";
            this.labelDescMap2.Size = new System.Drawing.Size(411, 15);
            this.labelDescMap2.TabIndex = 3;
            this.labelDescMap2.Text = "Select a specific checkin from the list, and we will show a close up map for it.";
            // 
            // labelDescMap1
            // 
            this.labelDescMap1.AutoSize = true;
            this.labelDescMap1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.labelDescMap1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescMap1.Location = new System.Drawing.Point(16, 24);
            this.labelDescMap1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescMap1.Name = "labelDescMap1";
            this.labelDescMap1.Size = new System.Drawing.Size(496, 15);
            this.labelDescMap1.TabIndex = 2;
            this.labelDescMap1.Text = "Select a date range, and we will display all of your corresponding checkins on th" +
    "e world map!";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker2.Location = new System.Drawing.Point(266, 87);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 21);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 87);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 21);
            this.dateTimePicker1.TabIndex = 0;
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
            this.likesPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.likesPage.Name = "likesPage";
            this.likesPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.likesPage.Size = new System.Drawing.Size(764, 565);
            this.likesPage.TabIndex = 2;
            this.likesPage.Text = "Likes you might like";
            this.likesPage.ToolTipText = "Display likes of friends based on category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(13, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select a page to see details about it, and maybe like it too.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(508, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select a category, and we will display all pages in the category which were liked" +
    " by your friends!";
            // 
            // groupBoxLikePages
            // 
            this.groupBoxLikePages.Controls.Add(this.listBoxLikePages);
            this.groupBoxLikePages.Location = new System.Drawing.Point(236, 65);
            this.groupBoxLikePages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLikePages.Name = "groupBoxLikePages";
            this.groupBoxLikePages.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLikePages.Size = new System.Drawing.Size(227, 501);
            this.groupBoxLikePages.TabIndex = 2;
            this.groupBoxLikePages.TabStop = false;
            this.groupBoxLikePages.Text = "Pages Liked by Friends";
            // 
            // listBoxLikePages
            // 
            this.listBoxLikePages.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxLikePages.FormattingEnabled = true;
            this.listBoxLikePages.ItemHeight = 12;
            this.listBoxLikePages.Location = new System.Drawing.Point(5, 20);
            this.listBoxLikePages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxLikePages.Name = "listBoxLikePages";
            this.listBoxLikePages.Size = new System.Drawing.Size(218, 472);
            this.listBoxLikePages.TabIndex = 0;
            // 
            // groupBoxCategories
            // 
            this.groupBoxCategories.Controls.Add(this.listBoxCategories);
            this.groupBoxCategories.Location = new System.Drawing.Point(10, 65);
            this.groupBoxCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCategories.Name = "groupBoxCategories";
            this.groupBoxCategories.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCategories.Size = new System.Drawing.Size(203, 501);
            this.groupBoxCategories.TabIndex = 1;
            this.groupBoxCategories.TabStop = false;
            this.groupBoxCategories.Text = "Categories";
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 12;
            this.listBoxCategories.Location = new System.Drawing.Point(5, 20);
            this.listBoxCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(194, 472);
            this.listBoxCategories.TabIndex = 0;
            // 
            // groupBoxLikePage
            // 
            this.groupBoxLikePage.Location = new System.Drawing.Point(482, 116);
            this.groupBoxLikePage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLikePage.Name = "groupBoxLikePage";
            this.groupBoxLikePage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLikePage.Size = new System.Drawing.Size(274, 450);
            this.groupBoxLikePage.TabIndex = 0;
            this.groupBoxLikePage.TabStop = false;
            this.groupBoxLikePage.Text = "Page Details";
            // 
            // flowLayoutPanelBG
            // 
            this.flowLayoutPanelBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.flowLayoutPanelBG.Location = new System.Drawing.Point(-1, 43);
            this.flowLayoutPanelBG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelBG.Name = "flowLayoutPanelBG";
            this.flowLayoutPanelBG.Size = new System.Drawing.Size(868, 582);
            this.flowLayoutPanelBG.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(14, 15);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.White;
            this.pictureBoxProfile.Location = new System.Drawing.Point(648, 12);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(126, 136);
            this.pictureBoxProfile.TabIndex = 4;
            this.pictureBoxProfile.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(865, 614);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.flowLayoutPanelBG);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form2";
            this.tabControl.ResumeLayout(false);
            this.facebookPage.ResumeLayout(false);
            this.facebookPage.PerformLayout();
            this.groupBoxFeed.ResumeLayout(false);
            this.groupBoxPages.ResumeLayout(false);
            this.groupBoxGroups.ResumeLayout(false);
            this.groupBoxFriends.ResumeLayout(false);
            this.checkinsPage.ResumeLayout(false);
            this.checkinsPage.PerformLayout();
            this.groupBoxCheckins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.likesPage.ResumeLayout(false);
            this.likesPage.PerformLayout();
            this.groupBoxLikePages.ResumeLayout(false);
            this.groupBoxCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
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