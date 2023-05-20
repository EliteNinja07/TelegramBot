
namespace TelegramBot
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSendCode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewChannel = new System.Windows.Forms.TextBox();
            this.buttonCreateChannel = new System.Windows.Forms.Button();
            this.buttonCreateGroup = new System.Windows.Forms.Button();
            this.textBoxNewGroup = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.labelContactCount = new System.Windows.Forms.Label();
            this.listBoxContact = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxChannel = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelChannelCount = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelGroupCount = new System.Windows.Forms.Label();
            this.listBoxGroup = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMemberCount = new System.Windows.Forms.Label();
            this.textBoxSearchMember = new System.Windows.Forms.TextBox();
            this.listBoxMember = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxLogMaxLines = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAddUserGroup = new System.Windows.Forms.Button();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAddUser2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonAddUserChannel = new System.Windows.Forms.Button();
            this.comboBoxChannel = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxAddUser1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddUserContact = new System.Windows.Forms.Button();
            this.radioButtonPhone = new System.Windows.Forms.RadioButton();
            this.textBoxAddPhone = new System.Windows.Forms.TextBox();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.textBoxAddUser = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxDontAppend = new System.Windows.Forms.CheckBox();
            this.buttonStartFileAdd = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.labelFileContactCount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.listBoxFileContacts = new System.Windows.Forms.ListBox();
            this.buttonContactBrowser = new System.Windows.Forms.Button();
            this.textBoxContactFilePath = new System.Windows.Forms.TextBox();
            this.radioButtonFilePhone = new System.Windows.Forms.RadioButton();
            this.radioButtonFileUser = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "user phone number:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TelegramBot.Properties.Settings.Default, "phone_number", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPhone.Location = new System.Drawing.Point(136, 27);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(150, 20);
            this.textBoxPhone.TabIndex = 1;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(472, 29);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(91, 13);
            this.labelCode.TabIndex = 2;
            this.labelCode.Text = "verification_code:";
            this.labelCode.Visible = false;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(583, 27);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(150, 20);
            this.textBoxCode.TabIndex = 3;
            this.textBoxCode.Visible = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(302, 25);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_ClickAsync);
            // 
            // buttonSendCode
            // 
            this.buttonSendCode.Location = new System.Drawing.Point(749, 25);
            this.buttonSendCode.Name = "buttonSendCode";
            this.buttonSendCode.Size = new System.Drawing.Size(75, 23);
            this.buttonSendCode.TabIndex = 5;
            this.buttonSendCode.Text = "Verify";
            this.buttonSendCode.UseVisualStyleBackColor = true;
            this.buttonSendCode.Visible = false;
            this.buttonSendCode.Click += new System.EventHandler(this.buttonSendCode_ClickAsync);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "create channel:";
            // 
            // textBoxNewChannel
            // 
            this.textBoxNewChannel.Location = new System.Drawing.Point(136, 67);
            this.textBoxNewChannel.Name = "textBoxNewChannel";
            this.textBoxNewChannel.Size = new System.Drawing.Size(150, 20);
            this.textBoxNewChannel.TabIndex = 12;
            // 
            // buttonCreateChannel
            // 
            this.buttonCreateChannel.Location = new System.Drawing.Point(302, 65);
            this.buttonCreateChannel.Name = "buttonCreateChannel";
            this.buttonCreateChannel.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateChannel.TabIndex = 13;
            this.buttonCreateChannel.Text = "Create";
            this.buttonCreateChannel.UseVisualStyleBackColor = true;
            this.buttonCreateChannel.Click += new System.EventHandler(this.buttonCreateChannel_ClickAsync);
            // 
            // buttonCreateGroup
            // 
            this.buttonCreateGroup.Location = new System.Drawing.Point(749, 65);
            this.buttonCreateGroup.Name = "buttonCreateGroup";
            this.buttonCreateGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateGroup.TabIndex = 26;
            this.buttonCreateGroup.Text = "Create";
            this.buttonCreateGroup.UseVisualStyleBackColor = true;
            this.buttonCreateGroup.Click += new System.EventHandler(this.buttonCreateGroup_ClickAsync);
            // 
            // textBoxNewGroup
            // 
            this.textBoxNewGroup.Location = new System.Drawing.Point(583, 67);
            this.textBoxNewGroup.Name = "textBoxNewGroup";
            this.textBoxNewGroup.Size = new System.Drawing.Size(150, 20);
            this.textBoxNewGroup.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "create group:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1,
            this.menu2,
            this.menu3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(244, 70);
            // 
            // menu1
            // 
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(243, 22);
            this.menu1.Text = "Copy Text to Clipboard";
            this.menu1.Click += new System.EventHandler(this.menu1_Click);
            // 
            // menu2
            // 
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(243, 22);
            this.menu2.Text = "Save all members in list to file";
            this.menu2.Click += new System.EventHandler(this.menu2_Click);
            // 
            // menu3
            // 
            this.menu3.Name = "menu3";
            this.menu3.Size = new System.Drawing.Size(243, 22);
            this.menu3.Text = "Save all memers from all groups";
            this.menu3.Click += new System.EventHandler(this.menu3_ClickAsync);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 138);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(392, 440);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.labelContactCount);
            this.tabPage1.Controls.Add(this.listBoxContact);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(384, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contact List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Items Count";
            // 
            // labelContactCount
            // 
            this.labelContactCount.AutoSize = true;
            this.labelContactCount.Location = new System.Drawing.Point(72, 7);
            this.labelContactCount.Name = "labelContactCount";
            this.labelContactCount.Size = new System.Drawing.Size(13, 13);
            this.labelContactCount.TabIndex = 35;
            this.labelContactCount.Text = "0";
            // 
            // listBoxContact
            // 
            this.listBoxContact.FormattingEnabled = true;
            this.listBoxContact.Location = new System.Drawing.Point(5, 27);
            this.listBoxContact.Name = "listBoxContact";
            this.listBoxContact.Size = new System.Drawing.Size(372, 381);
            this.listBoxContact.TabIndex = 34;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxChannel);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.labelChannelCount);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(384, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Channel List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxChannel
            // 
            this.listBoxChannel.FormattingEnabled = true;
            this.listBoxChannel.Location = new System.Drawing.Point(5, 27);
            this.listBoxChannel.Name = "listBoxChannel";
            this.listBoxChannel.Size = new System.Drawing.Size(372, 381);
            this.listBoxChannel.TabIndex = 39;
            this.listBoxChannel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxChannel_MouseDoubleClickAsync);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Items Count";
            // 
            // labelChannelCount
            // 
            this.labelChannelCount.AutoSize = true;
            this.labelChannelCount.Location = new System.Drawing.Point(72, 7);
            this.labelChannelCount.Name = "labelChannelCount";
            this.labelChannelCount.Size = new System.Drawing.Size(13, 13);
            this.labelChannelCount.TabIndex = 37;
            this.labelChannelCount.Text = "0";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelGroupCount);
            this.tabPage3.Controls.Add(this.listBoxGroup);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(384, 414);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Group List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelGroupCount
            // 
            this.labelGroupCount.AutoSize = true;
            this.labelGroupCount.Location = new System.Drawing.Point(72, 7);
            this.labelGroupCount.Name = "labelGroupCount";
            this.labelGroupCount.Size = new System.Drawing.Size(13, 13);
            this.labelGroupCount.TabIndex = 38;
            this.labelGroupCount.Text = "0";
            // 
            // listBoxGroup
            // 
            this.listBoxGroup.FormattingEnabled = true;
            this.listBoxGroup.Location = new System.Drawing.Point(5, 27);
            this.listBoxGroup.Name = "listBoxGroup";
            this.listBoxGroup.Size = new System.Drawing.Size(372, 381);
            this.listBoxGroup.TabIndex = 37;
            this.listBoxGroup.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxGroup_MouseDoubleClickAsync);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Items Count";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.labelMemberCount);
            this.tabPage4.Controls.Add(this.textBoxSearchMember);
            this.tabPage4.Controls.Add(this.listBoxMember);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(384, 414);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Member List";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Search";
            // 
            // labelMemberCount
            // 
            this.labelMemberCount.AutoSize = true;
            this.labelMemberCount.Location = new System.Drawing.Point(72, 7);
            this.labelMemberCount.Name = "labelMemberCount";
            this.labelMemberCount.Size = new System.Drawing.Size(13, 13);
            this.labelMemberCount.TabIndex = 40;
            this.labelMemberCount.Text = "0";
            // 
            // textBoxSearchMember
            // 
            this.textBoxSearchMember.Location = new System.Drawing.Point(250, 4);
            this.textBoxSearchMember.Name = "textBoxSearchMember";
            this.textBoxSearchMember.Size = new System.Drawing.Size(127, 20);
            this.textBoxSearchMember.TabIndex = 39;
            this.textBoxSearchMember.TextChanged += new System.EventHandler(this.textBoxSearchMember_TextChanged);
            // 
            // listBoxMember
            // 
            this.listBoxMember.FormattingEnabled = true;
            this.listBoxMember.Location = new System.Drawing.Point(5, 27);
            this.listBoxMember.Name = "listBoxMember";
            this.listBoxMember.Size = new System.Drawing.Size(372, 381);
            this.listBoxMember.TabIndex = 38;
            this.listBoxMember.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxMember_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Member List";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.textBoxLogMaxLines);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.textBoxLog);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(384, 414);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Log Window";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "lines";
            // 
            // textBoxLogMaxLines
            // 
            this.textBoxLogMaxLines.Location = new System.Drawing.Point(65, 4);
            this.textBoxLogMaxLines.Name = "textBoxLogMaxLines";
            this.textBoxLogMaxLines.Size = new System.Drawing.Size(45, 20);
            this.textBoxLogMaxLines.TabIndex = 2;
            this.textBoxLogMaxLines.Text = "500";
            this.textBoxLogMaxLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "show max";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(5, 27);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(372, 381);
            this.textBoxLog.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 109);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(121, 23);
            this.buttonRefresh.TabIndex = 33;
            this.buttonRefresh.Text = "Refresh List";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_ClickAsync);
            // 
            // buttonAddUserGroup
            // 
            this.buttonAddUserGroup.Location = new System.Drawing.Point(776, 179);
            this.buttonAddUserGroup.Name = "buttonAddUserGroup";
            this.buttonAddUserGroup.Size = new System.Drawing.Size(121, 23);
            this.buttonAddUserGroup.TabIndex = 43;
            this.buttonAddUserGroup.Text = "add user to group";
            this.buttonAddUserGroup.UseVisualStyleBackColor = true;
            this.buttonAddUserGroup.Click += new System.EventHandler(this.buttonAddUserGroup_ClickAsync);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(638, 181);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGroup.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(580, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "to group";
            // 
            // textBoxAddUser2
            // 
            this.textBoxAddUser2.Location = new System.Drawing.Point(477, 182);
            this.textBoxAddUser2.Name = "textBoxAddUser2";
            this.textBoxAddUser2.Size = new System.Drawing.Size(87, 20);
            this.textBoxAddUser2.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(423, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "add user";
            // 
            // buttonAddUserChannel
            // 
            this.buttonAddUserChannel.Location = new System.Drawing.Point(776, 142);
            this.buttonAddUserChannel.Name = "buttonAddUserChannel";
            this.buttonAddUserChannel.Size = new System.Drawing.Size(121, 23);
            this.buttonAddUserChannel.TabIndex = 38;
            this.buttonAddUserChannel.Text = "add user to channel";
            this.buttonAddUserChannel.UseVisualStyleBackColor = true;
            this.buttonAddUserChannel.Click += new System.EventHandler(this.buttonAddUserChannel_ClickAsync);
            // 
            // comboBoxChannel
            // 
            this.comboBoxChannel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxChannel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxChannel.FormattingEnabled = true;
            this.comboBoxChannel.Location = new System.Drawing.Point(638, 144);
            this.comboBoxChannel.Name = "comboBoxChannel";
            this.comboBoxChannel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChannel.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(580, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "to channel";
            // 
            // textBoxAddUser1
            // 
            this.textBoxAddUser1.Location = new System.Drawing.Point(477, 145);
            this.textBoxAddUser1.Name = "textBoxAddUser1";
            this.textBoxAddUser1.Size = new System.Drawing.Size(87, 20);
            this.textBoxAddUser1.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(423, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "add user";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddUserContact);
            this.groupBox1.Controls.Add(this.radioButtonPhone);
            this.groupBox1.Controls.Add(this.textBoxAddPhone);
            this.groupBox1.Controls.Add(this.radioButtonUser);
            this.groupBox1.Controls.Add(this.textBoxAddUser);
            this.groupBox1.Location = new System.Drawing.Point(416, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 98);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a user to contact";
            // 
            // buttonAddUserContact
            // 
            this.buttonAddUserContact.Location = new System.Drawing.Point(177, 63);
            this.buttonAddUserContact.Name = "buttonAddUserContact";
            this.buttonAddUserContact.Size = new System.Drawing.Size(121, 23);
            this.buttonAddUserContact.TabIndex = 53;
            this.buttonAddUserContact.Text = "add user to contact";
            this.buttonAddUserContact.UseVisualStyleBackColor = true;
            this.buttonAddUserContact.Click += new System.EventHandler(this.buttonAddUserContact_ClickAsync);
            // 
            // radioButtonPhone
            // 
            this.radioButtonPhone.AutoSize = true;
            this.radioButtonPhone.Location = new System.Drawing.Point(265, 28);
            this.radioButtonPhone.Name = "radioButtonPhone";
            this.radioButtonPhone.Size = new System.Drawing.Size(93, 17);
            this.radioButtonPhone.TabIndex = 52;
            this.radioButtonPhone.Text = "phone number";
            this.radioButtonPhone.UseVisualStyleBackColor = true;
            // 
            // textBoxAddPhone
            // 
            this.textBoxAddPhone.Location = new System.Drawing.Point(364, 27);
            this.textBoxAddPhone.Name = "textBoxAddPhone";
            this.textBoxAddPhone.Size = new System.Drawing.Size(87, 20);
            this.textBoxAddPhone.TabIndex = 51;
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Checked = true;
            this.radioButtonUser.Location = new System.Drawing.Point(36, 28);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(71, 17);
            this.radioButtonUser.TabIndex = 50;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "username";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // textBoxAddUser
            // 
            this.textBoxAddUser.Location = new System.Drawing.Point(113, 27);
            this.textBoxAddUser.Name = "textBoxAddUser";
            this.textBoxAddUser.Size = new System.Drawing.Size(87, 20);
            this.textBoxAddUser.TabIndex = 49;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxDontAppend);
            this.groupBox2.Controls.Add(this.buttonStartFileAdd);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textBoxDelay);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.labelFileContactCount);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.listBoxFileContacts);
            this.groupBox2.Controls.Add(this.buttonContactBrowser);
            this.groupBox2.Controls.Add(this.textBoxContactFilePath);
            this.groupBox2.Controls.Add(this.radioButtonFilePhone);
            this.groupBox2.Controls.Add(this.radioButtonFileUser);
            this.groupBox2.Location = new System.Drawing.Point(416, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 243);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add contacts from file";
            // 
            // checkBoxDontAppend
            // 
            this.checkBoxDontAppend.AutoSize = true;
            this.checkBoxDontAppend.Location = new System.Drawing.Point(194, 140);
            this.checkBoxDontAppend.Name = "checkBoxDontAppend";
            this.checkBoxDontAppend.Size = new System.Drawing.Size(271, 17);
            this.checkBoxDontAppend.TabIndex = 60;
            this.checkBoxDontAppend.Text = "don\'t try append users that are already in contact list";
            this.checkBoxDontAppend.UseVisualStyleBackColor = true;
            // 
            // buttonStartFileAdd
            // 
            this.buttonStartFileAdd.Location = new System.Drawing.Point(251, 180);
            this.buttonStartFileAdd.Name = "buttonStartFileAdd";
            this.buttonStartFileAdd.Size = new System.Drawing.Size(166, 41);
            this.buttonStartFileAdd.TabIndex = 59;
            this.buttonStartFileAdd.Text = "Start Adding";
            this.buttonStartFileAdd.UseVisualStyleBackColor = true;
            this.buttonStartFileAdd.Click += new System.EventHandler(this.buttonStartFileAdd_ClickAsync);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(368, 103);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 58;
            this.label18.Text = "Seconds";
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Location = new System.Drawing.Point(294, 100);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(58, 20);
            this.textBoxDelay.TabIndex = 54;
            this.textBoxDelay.Text = "10000";
            this.textBoxDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(193, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 13);
            this.label17.TabIndex = 57;
            this.label17.Text = "delay between adding contacts";
            // 
            // labelFileContactCount
            // 
            this.labelFileContactCount.AutoSize = true;
            this.labelFileContactCount.Location = new System.Drawing.Point(126, 23);
            this.labelFileContactCount.Name = "labelFileContactCount";
            this.labelFileContactCount.Size = new System.Drawing.Size(13, 13);
            this.labelFileContactCount.TabIndex = 56;
            this.labelFileContactCount.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 51;
            this.label15.Text = "total contacts loaded:";
            // 
            // listBoxFileContacts
            // 
            this.listBoxFileContacts.FormattingEnabled = true;
            this.listBoxFileContacts.Location = new System.Drawing.Point(7, 45);
            this.listBoxFileContacts.Name = "listBoxFileContacts";
            this.listBoxFileContacts.Size = new System.Drawing.Size(171, 186);
            this.listBoxFileContacts.TabIndex = 55;
            // 
            // buttonContactBrowser
            // 
            this.buttonContactBrowser.Location = new System.Drawing.Point(433, 44);
            this.buttonContactBrowser.Name = "buttonContactBrowser";
            this.buttonContactBrowser.Size = new System.Drawing.Size(63, 23);
            this.buttonContactBrowser.TabIndex = 51;
            this.buttonContactBrowser.Text = "browser";
            this.buttonContactBrowser.UseVisualStyleBackColor = true;
            this.buttonContactBrowser.Click += new System.EventHandler(this.buttonContactBrowser_Click);
            // 
            // textBoxContactFilePath
            // 
            this.textBoxContactFilePath.Location = new System.Drawing.Point(184, 46);
            this.textBoxContactFilePath.Name = "textBoxContactFilePath";
            this.textBoxContactFilePath.Size = new System.Drawing.Size(243, 20);
            this.textBoxContactFilePath.TabIndex = 54;
            // 
            // radioButtonFilePhone
            // 
            this.radioButtonFilePhone.AutoSize = true;
            this.radioButtonFilePhone.Location = new System.Drawing.Point(324, 21);
            this.radioButtonFilePhone.Name = "radioButtonFilePhone";
            this.radioButtonFilePhone.Size = new System.Drawing.Size(93, 17);
            this.radioButtonFilePhone.TabIndex = 54;
            this.radioButtonFilePhone.Text = "phone number";
            this.radioButtonFilePhone.UseVisualStyleBackColor = true;
            // 
            // radioButtonFileUser
            // 
            this.radioButtonFileUser.AutoSize = true;
            this.radioButtonFileUser.Checked = true;
            this.radioButtonFileUser.Location = new System.Drawing.Point(194, 21);
            this.radioButtonFileUser.Name = "radioButtonFileUser";
            this.radioButtonFileUser.Size = new System.Drawing.Size(71, 17);
            this.radioButtonFileUser.TabIndex = 54;
            this.radioButtonFileUser.TabStop = true;
            this.radioButtonFileUser.Text = "username";
            this.radioButtonFileUser.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAddUserGroup);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxAddUser2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonAddUserChannel);
            this.Controls.Add(this.comboBoxChannel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxAddUser1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonCreateGroup);
            this.Controls.Add(this.textBoxNewGroup);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonCreateChannel);
            this.Controls.Add(this.textBoxNewChannel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSendCode);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonSendCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewChannel;
        private System.Windows.Forms.Button buttonCreateChannel;
        private System.Windows.Forms.Button buttonCreateGroup;
        private System.Windows.Forms.TextBox textBoxNewGroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.ToolStripMenuItem menu2;
        private System.Windows.Forms.ToolStripMenuItem menu3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label labelContactCount;
        private System.Windows.Forms.ListBox listBoxContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelChannelCount;
        private System.Windows.Forms.ListBox listBoxChannel;
        private System.Windows.Forms.Label labelGroupCount;
        private System.Windows.Forms.ListBox listBoxGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelMemberCount;
        private System.Windows.Forms.TextBox textBoxSearchMember;
        private System.Windows.Forms.ListBox listBoxMember;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLogMaxLines;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAddUserGroup;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxAddUser2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonAddUserChannel;
        private System.Windows.Forms.ComboBox comboBoxChannel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxAddUser1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddUserContact;
        private System.Windows.Forms.RadioButton radioButtonPhone;
        private System.Windows.Forms.TextBox textBoxAddPhone;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.TextBox textBoxAddUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonFilePhone;
        private System.Windows.Forms.RadioButton radioButtonFileUser;
        private System.Windows.Forms.TextBox textBoxContactFilePath;
        private System.Windows.Forms.Button buttonContactBrowser;
        private System.Windows.Forms.ListBox listBoxFileContacts;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelFileContactCount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxDelay;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonStartFileAdd;
        private System.Windows.Forms.CheckBox checkBoxDontAppend;
    }
}

