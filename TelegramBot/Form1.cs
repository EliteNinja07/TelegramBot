using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TL;

namespace TelegramBot
{
    public partial class Form1 : Form
    {
        //string api_id = "26249405";
        //string api_hash = "ce6bddc0f5a1d21d39ae5ca8e61623ba";

        string api_id = "26173383";
        string api_hash = "b4b2b8cf838d5ab4e2a073f522c92a6a";

        private WTelegram.Client _client;

        ProgressForm m_progressForm = new ProgressForm();       

        public Form1()
        {
            InitializeComponent();
            this.textBoxPhone.Text = global::TelegramBot.Properties.Settings.Default.phone_number;
            LoadApplicationInformation();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _client?.Dispose();
            Properties.Settings.Default.Save();
            SaveApplicationInformation();
        }

        private void LoadApplicationInformation()
        {
            try
            {
                string file_path = "App.cfg";
                string[] strs = File.ReadAllLines(file_path);

                textBoxContactFilePath.Text = strs[0];
                textBoxDelay.Text = strs[1];

                string[] item_strs = File.ReadAllLines(textBoxContactFilePath.Text);

                for (int i = 0; i < item_strs.Length; i++)
                {
                    listBoxFileContacts.Items.Add(item_strs[i]);
                }
                labelFileContactCount.Text = item_strs.Length.ToString();
               
                if (strs[2] == "1") checkBoxDontAppend.Checked = true;
                else checkBoxDontAppend.Checked = false;
            }
            catch
            {
                textBoxContactFilePath.Text = "";
                listBoxFileContacts.Items.Clear();
                labelFileContactCount.Text = "0";
            }
        }

        private void SaveApplicationInformation()
        {
            string file_path = "App.cfg";            
            File.WriteAllText(file_path, textBoxContactFilePath.Text + "\r\n");
            File.AppendAllText(file_path, textBoxDelay.Text + "\r\n");
            if (checkBoxDontAppend.Checked)
                File.AppendAllText(file_path,"1\r\n");
            else
                File.AppendAllText(file_path, "0\r\n");
        }

        private async void buttonLogin_ClickAsync(object sender, EventArgs e)
        {
            var SessionPath = Path.GetTempFileName();
            buttonLogin.Enabled = false;
            if (_client == null) _client = new WTelegram.Client(int.Parse(api_id), api_hash,SessionPath);
            try
            {
                await DoLogin(textBoxPhone.Text);
            }
            catch(Exception ee)
            {
                _client.Dispose();
                _client = null;            
                MessageBox.Show(ee.Message);
                buttonLogin.Enabled = true;
            }
        }

        private async void buttonSendCode_ClickAsync(object sender, EventArgs e)
        {
            labelCode.Visible = textBoxCode.Visible = buttonSendCode.Visible = false;
            await DoLogin(textBoxCode.Text);
        }

        private async Task DoLogin(string loginInfo)
        {
            string what = await _client.Login(loginInfo);
            if (what != null)
            {
                labelCode.Visible = textBoxCode.Visible = buttonSendCode.Visible = true;
                textBoxCode.Focus();
                AppendLogText($"From {loginInfo} a {what} is required...\r\n\r\n");
                MessageBox.Show($"A {what} is required...");
            }
            else
            {
                AppendLogText($"logged in to {loginInfo} successfully.\r\n\r\n");
               // MessageBox.Show("Login Success!!!");

                await GetAllContactsAsync();
                await GetAllChannelAndGroupListAsync();
            }
        }

        private async Task GetAllContactsAsync()
        {
            if (_client == null || _client.User == null)
            {
                MessageBox.Show("You must login first.");
                return;
            }

            var Contacts = await _client.Contacts_GetContacts();

            listBoxContact.Items.Clear();

            for (int i = 0; i < Contacts.users.Count; i++)
            {
                User user = Contacts.users[Contacts.users.Keys.ElementAt(i)];
                string contact_name = user.username;
                if (contact_name == null || contact_name == "") continue;
                listBoxContact.Items.Add(contact_name);
            }

            labelContactCount.Text = listBoxContact.Items.Count.ToString();
        }

        private async Task GetAllChannelAndGroupListAsync()
        {
            labelChannelCount.Text = "0";
            labelGroupCount.Text = "0";
            labelMemberCount.Text = "0";

            if (_client == null || _client.User == null)
            {
                MessageBox.Show("You must login first.");
                return;
            }

            listBoxChannel.Items.Clear();
            comboBoxChannel.Items.Clear();
            listBoxGroup.Items.Clear();
            comboBoxGroup.Items.Clear();
            listBoxMember.Items.Clear();
            textBoxSearchMember.Text = "";

            var dialogs = await _client.Messages_GetAllDialogs();
            foreach (Dialog dialog in dialogs.dialogs)
            {
                var peer = dialogs.UserOrChat(dialog);
                string obj_string;
                if (peer.ToString() != null)
                    obj_string = peer.ToString()?.ToLower();
                else
                    continue;

                if (peer is User || obj_string.IndexOf('@') == 0 || obj_string.IndexOf("telegram") == 0) continue;

                if (obj_string.IndexOf("channel") == 0)
                {
                    listBoxChannel.Items.Add(((ChatBase)peer).Title);
                    comboBoxChannel.Items.Add(((ChatBase)peer).Title);
                }
                else
                {
                    listBoxGroup.Items.Add(((ChatBase)peer).Title);
                    comboBoxGroup.Items.Add(((ChatBase)peer).Title);
                }
            }

            labelChannelCount.Text = listBoxChannel.Items.Count.ToString();
            labelGroupCount.Text = listBoxGroup.Items.Count.ToString();
        }

        private async void buttonRefresh_ClickAsync(object sender, EventArgs e)
        {
            await GetAllContactsAsync();
            await GetAllChannelAndGroupListAsync();
        }

        private async void buttonCreateChannel_ClickAsync(object sender, EventArgs e)
        {
            if (_client == null || _client.User == null)
            {
                MessageBox.Show("You must login first.");
                return;
            }

            if (textBoxNewChannel.Text == "")
            {
                MessageBox.Show("Please Input New channel name.");
                return;
            }

            var res = await _client.Channels_CreateChannel(textBoxNewChannel.Text, textBoxNewChannel.Text);
            string log_text = textBoxNewChannel.Text;
            AppendLogText($"Created Channel {log_text}.\r\n\r\n");
            await GetAllChannelAndGroupListAsync ();
        }

        private async void buttonCreateGroup_ClickAsync(object sender, EventArgs e)
        {
            if (_client == null || _client.User == null)
            {
                MessageBox.Show("You must login first.");
                return;
            }

            if (textBoxNewGroup.Text == "")
            {
                MessageBox.Show("Please Input New Group name.");
                return;
            }

            await _client.Messages_CreateChat(null, textBoxNewGroup.Text);
            string log_text = textBoxNewGroup.Text;
            AppendLogText($"Created Group {log_text}.\r\n\r\n");
            await GetAllChannelAndGroupListAsync ();
        }

        private async void buttonAddUserChannel_ClickAsync(object sender, EventArgs e)
        {
            if (_client == null || _client.User == null)
            {
                MessageBox.Show("You must login first.");
                return;
            }

            if (textBoxAddUser1.Text == "")
            {
                MessageBox.Show("Please input user name");
                return;
            }

            if (comboBoxChannel.SelectedIndex == -1)
            {
                MessageBox.Show("Please select channel combo");
                return;
            }

            bool bExist = false;

            string phonenumber = textBoxAddUser1.Text.Replace(" ", "");
            phonenumber = phonenumber.Replace("+", "");

            User selectedUser = null;

            var Contacts = await _client.Contacts_GetContacts();

            for (int i = 0; i < Contacts.users.Count; i++)
            {
                User user = Contacts.users[Contacts.users.Keys.ElementAt(i)];
                string contact_name = user.username;
                if (contact_name == null || contact_name == "") continue;

                string user_phone = user.phone?.Replace(" ", "");
                user_phone = user.phone?.Replace("+", "");
                string username = contact_name?.ToLower().Replace(" ", "");
                string inputname = textBoxAddUser1.Text?.ToLower().Replace(" ", "");

                if (username == inputname || phonenumber == user_phone)
                {
                    selectedUser = user;
                    bExist = true;
                    break;
                }
            }

            if (!bExist)
            {
                MessageBox.Show("Please input correct user name");
                return;
            }

            Channel selectedChannel = null;
            bExist = false;
            int nIndex = 0;

            var dialogs = await _client.Messages_GetAllDialogs(null);
            foreach (Dialog dialog in dialogs.dialogs)
            {
                var peer = dialogs.UserOrChat(dialog);
                string obj_string = peer.ToString().ToLower();
                if (peer is User || obj_string.IndexOf('@') == 0 || obj_string.IndexOf("telegram") == 0) continue;

                if (obj_string.IndexOf("channel") == 0)
                {
                    if (nIndex == comboBoxChannel.SelectedIndex)
                    {
                        selectedChannel = (Channel)peer;
                        bExist = true;
                        break;
                    }
                    nIndex++;
                }
            }

            if (!bExist)
            {
                MessageBox.Show("Please select Channel combo");
                return;
            }

            try
            {
                await _client.AddChatUser(selectedChannel, selectedUser);
                string user_text = textBoxAddUser1.Text;
                string channel_text = comboBoxChannel.Text;
                AppendLogText($"Added user {user_text} to channel {channel_text}.\r\n\r\n");
                MessageBox.Show("Add user to Channel Success!!!");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private async void buttonAddUserGroup_ClickAsync(object sender, EventArgs e)
        {
            if (_client == null || _client.User == null)
            {
                MessageBox.Show("You must login first.");
                return;
            }

            if (textBoxAddUser2.Text == "")
            {
                MessageBox.Show("Please input user name");
                return;
            }

            if (comboBoxGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Please select group combo");
                return;
            }

            bool bExist = false;

            string phonenumber = textBoxAddUser2.Text.Replace(" ", "");
            phonenumber = phonenumber.Replace("+", "");

            User selectedUser = null;

            var Contacts = await _client.Contacts_GetContacts();

            for (int i = 0; i < Contacts.users.Count; i++)
            {
                User user = Contacts.users[Contacts.users.Keys.ElementAt(i)];
                string contact_name = user.username;
                if (contact_name == null || contact_name == "") continue;

                string user_phone = user.phone?.Replace(" ", "");
                user_phone = user.phone?.Replace("+", "");
                string username = contact_name?.ToLower().Replace(" ", "");
                string inputname = textBoxAddUser2.Text?.ToLower().Replace(" ", "");

                if (username == inputname || phonenumber == user_phone)
                {
                    selectedUser = user;
                    bExist = true;
                    break;
                }
            }

            if (!bExist)
            {
                MessageBox.Show("Please input correct user name");
                return;
            }

            ChatBase selectedChat = null;
            bExist = false;
            int nIndex = 0;

            var dialogs = await _client.Messages_GetAllDialogs(null);
            foreach (Dialog dialog in dialogs.dialogs)
            {
                var peer = dialogs.UserOrChat(dialog);
                string obj_string = peer.ToString().ToLower();
                if (peer is User || obj_string.IndexOf('@') == 0 || obj_string.IndexOf("telegram") == 0) continue;

                if (!(obj_string.IndexOf("channel") == 0))
                {
                    if (nIndex == comboBoxGroup.SelectedIndex)
                    {
                        bExist = true;
                        selectedChat = (ChatBase)peer;
                        break;
                    }
                    nIndex++;
                }
            }

            if (!bExist)
            {
                MessageBox.Show("Please select Group combo");
                return;
            }

            try
            {
                await _client.AddChatUser(selectedChat, selectedUser);
                string user_text = textBoxAddUser2.Text;
                string channel_text = comboBoxGroup.Text;
                AppendLogText($"Added user {user_text} to Group {channel_text}.\r\n\r\n");
                MessageBox.Show("Add user to Group Success!!!");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private async void buttonAddUserContact_ClickAsync(object sender, EventArgs e)
        {
            if (_client == null || _client.User == null)
            {
                MessageBox.Show("You must login first.");
                return;
            }

            if (radioButtonUser.Checked && textBoxAddUser.Text == "")
            {
                MessageBox.Show("Please input username!!!");
                return;
            }

            if (radioButtonPhone.Checked && textBoxAddPhone.Text == "")
            {
                MessageBox.Show("Please input phone number!!!");
                return;
            }

            try
            {
                if (radioButtonUser.Checked)
                {
                    Contacts_ResolvedPeer user = await _client.Contacts_ResolveUsername(textBoxAddUser.Text);
                    await _client.Contacts_AddContact(user.User, user.User.first_name, user.User.last_name, user.User.phone);
                    string user_text = textBoxAddUser.Text;
                    AppendLogText($"Added user {user_text} : {DateTime.Now} \r\n\r\n");
                }
                else if (radioButtonPhone.Checked)
                {
                    Contacts_ResolvedPeer user = await _client.Contacts_ResolvePhone(textBoxAddPhone.Text);
                    await _client.Contacts_AddContact(user.User, user.User.first_name, user.User.last_name, user.User.phone);
                    string phone_text = textBoxAddPhone.Text;
                    AppendLogText($"Added phone number {phone_text} : {DateTime.Now} \r\n\r\n");
                }
            }
            catch
            {
                MessageBox.Show("The user does not exist.!!!");
                return;
            }

            await GetAllContactsAsync();
            MessageBox.Show("Seccess add the user to contact!!!");
        }

        private void buttonContactBrowser_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select file.";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "Text files(*.txt)|*.txt";
            var dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                textBoxContactFilePath.Text = openFileDialog.FileName;
                listBoxFileContacts.Items.Clear();

                string[] item_strs = File.ReadAllLines(openFileDialog.FileName);

                for (int i = 0; i < item_strs.Length; i++)
                {
                    listBoxFileContacts.Items.Add(item_strs[i]);
                }
                labelFileContactCount.Text = item_strs.Length.ToString();
            }

            SaveApplicationInformation();
        }

        private async void buttonStartFileAdd_ClickAsync(object sender, EventArgs e)
        {
            if (_client == null || _client.User == null)
            {
                MessageBox.Show("You must login first.");
                return;
            }

            if (listBoxFileContacts.Items.Count < 1)
            {
                MessageBox.Show("Please load correct text file!!!");
                return;
            }

            int nSleep = 10000;
            try
            {
                nSleep = int.Parse(textBoxDelay.Text);
            }
            catch { }

            var Contacts = await _client.Contacts_GetContacts();

            List<string> m_PrevUserNames = new List<string>();
            List<string> m_PrevPhoneNumbers = new List<string>();
            if (checkBoxDontAppend.Checked)
            {
                for (int i = 0; i < Contacts.users.Count; i++)
                {
                    User user = Contacts.users[Contacts.users.Keys.ElementAt(i)];
                    string contact_name = user.username;                   
                    if (contact_name != null && contact_name != "") m_PrevUserNames.Add(contact_name);                   
                    if (!(user.phone is null))
                    {
                        string phonenumber = user.phone.Replace(" ", "");
                        phonenumber = phonenumber.Replace("+", "");
                        m_PrevPhoneNumbers.Add(phonenumber);
                    }                    
                }
            }

            PercentForm m_percentForm = new PercentForm();
            m_percentForm.Show();


            for (int i = 0; i < listBoxFileContacts.Items.Count; i++)
            {
                if (m_percentForm.bStop) break;

                string user_text = listBoxFileContacts.Items[i].ToString();
                AppendLogText($"Adding user {user_text} : {DateTime.Now} \r\n\r\n");

                if (checkBoxDontAppend.Checked)
                {
                    bool bExist = false;

                    if (radioButtonFileUser.Checked)
                    {
                        for (int k = 0; k < m_PrevUserNames.Count; k++)
                        {
                            string prev_name = m_PrevUserNames[k].ToLower();
                            string cur_name = user_text.ToLower();
                            if (prev_name == cur_name)
                            {
                                bExist = true;
                                break;
                            }
                        }
                    }
                    else if (radioButtonFilePhone.Checked)
                    {
                        for (int k = 0; k < m_PrevPhoneNumbers.Count; k++)
                        {
                            string prev_num = m_PrevPhoneNumbers[k].ToLower();
                            string cur_num = user_text.ToLower().Replace(" ", "").Replace("+", "");
                            if (prev_num == cur_num)
                            {
                                bExist = true;
                                break;
                            }
                        }
                    }

                    m_percentForm.percent_value = ((double)i) * 100 / ((double)listBoxFileContacts.Items.Count);
                    m_percentForm.nAddedCount = i + 1;
                    Application.DoEvents();

                    if (bExist)
                        continue;
                }

                try
                {

                    if (radioButtonFileUser.Checked)
                    {
                        Contacts_ResolvedPeer user = await _client.Contacts_ResolveUsername(listBoxFileContacts.Items[i].ToString());
                        await _client.Contacts_AddContact(user.User, user.User.first_name, user.User.last_name, user.User.phone);
                        if (checkBoxDontAppend.Checked)
                        {
                            string contact_name = user.User.username;
                            if (contact_name == "") contact_name = user.User.first_name + " " + user.User.last_name;
                            m_PrevUserNames.Add(contact_name);
                        }
                    }
                    else if (radioButtonFilePhone.Checked)
                    {
                        Contacts_ResolvedPeer user = await _client.Contacts_ResolvePhone(listBoxFileContacts.Items[i].ToString());
                        await _client.Contacts_AddContact(user.User, user.User.first_name, user.User.last_name, user.User.phone);
                        if (checkBoxDontAppend.Checked)
                        {
                            if (!(user.User.phone is null))
                            {
                                string phonenumber = user.User.phone.Replace(" ", "");
                                phonenumber = phonenumber.Replace("+", "");
                                m_PrevPhoneNumbers.Add(phonenumber);
                            }   
                        }
                    }
                }
                catch
                {

                }

                m_percentForm.percent_value = ((double)i) * 100 / ((double)listBoxFileContacts.Items.Count);
                m_percentForm.nAddedCount = i + 1;

                if (i != (listBoxFileContacts.Items.Count - 1))
                {
                    string next_user_text = listBoxFileContacts.Items[i + 1].ToString();
                    AppendLogText($"sleeping {nSleep} sec - next task is adding user {next_user_text}\r\n\r\n");
                }

                DateTime m_StartTime = DateTime.Now;

                while (true)
                {
                    DateTime m_CurrentTime = DateTime.Now;
                    if ((m_CurrentTime - m_StartTime).TotalSeconds > nSleep)
                        break;
                    else
                        Application.DoEvents();
                }
                Application.DoEvents();
            }

            m_percentForm.Close();
            await GetAllContactsAsync();
        }

        private async void listBoxChannel_MouseDoubleClickAsync(object sender, MouseEventArgs e)
        {
            int index = this.listBoxChannel.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                labelMemberCount.Text = "0";
                
                listBoxMember.Items.Clear();

                Channel selectedChannel = null;
                bool bExist = false;
                int nIndex = 0;

                var dialogs = await _client.Messages_GetAllDialogs(null);
                foreach (Dialog dialog in dialogs.dialogs)
                {
                    var peer = dialogs.UserOrChat(dialog);
                    string obj_string = peer.ToString().ToLower();
                    if (obj_string.IndexOf('@') == 0 || obj_string.IndexOf("telegram") == 0) continue;

                    if (obj_string.IndexOf("channel") == 0)
                    {
                        if (nIndex == index)
                        {
                            selectedChannel = (Channel)peer;
                            bExist = true;
                            break;
                        }
                        nIndex++;
                    }                    
                }

                if (!bExist)
                {
                    MessageBox.Show("Please select channel");
                    return;
                }

                m_progressForm.Show();

                try
                {
                    var users = (await _client.Channels_GetAllParticipants(selectedChannel)).users;
                    foreach (var user in users.Values)
                    {
                        try
                        {
                            string member_name = user.username;
                            if (member_name == null || member_name == "") continue;
                            listBoxMember.Items.Add(member_name);
                            Application.DoEvents();
                        }
                        catch
                        {

                        }
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Error");
                }

                m_progressForm.Hide();
                labelMemberCount.Text = listBoxMember.Items.Count.ToString();
                tabControl1.SelectedIndex = 3;
            }
        }

        private async void listBoxGroup_MouseDoubleClickAsync(object sender, MouseEventArgs e)
        {
            int index = this.listBoxGroup.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                labelMemberCount.Text = "0";
                
                listBoxMember.Items.Clear();

                ChatBase selectedChat = null;
                bool bExist = false;
                int nIndex = 0;

                var dialogs = await _client.Messages_GetAllDialogs(null);
                foreach (Dialog dialog in dialogs.dialogs)
                {
                    var peer = dialogs.UserOrChat(dialog);
                    string obj_string = peer.ToString().ToLower();
                    if (obj_string.IndexOf('@') == 0 || obj_string.IndexOf("telegram") == 0) continue;

                    if (!(obj_string.IndexOf("channel") == 0)) 
                    {
                        if (nIndex == index)
                        {
                            selectedChat = (ChatBase)peer;
                            bExist = true;
                            break;
                        }
                        nIndex++;
                    }
                }

                if (!bExist)
                {
                    MessageBox.Show("Please select group");
                    return;
                }

                m_progressForm.Show();

                try
                {
                    var users = selectedChat is Channel channel
                            ? (await _client.Channels_GetAllParticipants(channel)).users
                            : (await _client.Messages_GetFullChat(selectedChat.ID)).users;
                    foreach (var user in users.Values)
                    {
                        try
                        {
                            string member_name = user.username;
                            if (member_name == null || member_name == "") continue;
                            listBoxMember.Items.Add(member_name);
                            Application.DoEvents();
                        }
                        catch
                        {

                        }
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Error");
                }

                m_progressForm.Hide();
                labelMemberCount.Text = listBoxMember.Items.Count.ToString();
                tabControl1.SelectedIndex = 3;
            }            
        }

        private void listBoxMember_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(listBoxMember.PointToScreen(e.Location));
            }
        }

        private void menu1_Click(object sender, EventArgs e)
        {
            string member_string = "";

            for (int i = 0; i < listBoxMember.Items.Count; i++)
            {
                member_string = member_string + listBoxMember.Items[i].ToString() + "\r\n";
            }

            Clipboard.SetText(member_string);
        }

        private void menu2_Click(object sender, EventArgs e)
        {
            string file_path = "";

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Select save file.";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.Filter = "Text files(*.txt)|*.txt";
            var dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                file_path = saveFileDialog.FileName;
            }
            else return;

            string member_string = "";

            for (int i = 0; i < listBoxMember.Items.Count; i++)
            {
                member_string = member_string + listBoxMember.Items[i].ToString() + "\r\n";
            }

            File.WriteAllText(file_path, member_string);
        }

        private async void menu3_ClickAsync(object sender, EventArgs e)
        {
            if (_client == null || _client.User == null)
            {
                MessageBox.Show("You must login first.");
                return;
            }

            string file_path = "";

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Select save file.";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.Filter = "Text files(*.txt)|*.txt";
            var dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                file_path = saveFileDialog.FileName;
            }
            else return;

            PercentForm m_percentForm = new PercentForm();
            m_percentForm.Show();
            Application.DoEvents();

            int nTotalCount = 0;

            var dialogs = await _client.Messages_GetAllDialogs(null);
            foreach (Dialog dialog in dialogs.dialogs)
            {
                var peer = dialogs.UserOrChat(dialog);
                string obj_string = peer.ToString().ToLower();
                if (obj_string.IndexOf('@') == 0 || obj_string.IndexOf("telegram") == 0) continue;
                
                if (!(obj_string.IndexOf("channel") == 0)) 
                {
                    nTotalCount++;
                }
            }

            if (nTotalCount == 0)
            {
                MessageBox.Show("There is no groups!!!");
                m_percentForm.Close();
                return;
            }

            int nCurrent = 0;

            bool bFirstLine = true;

            foreach (Dialog dialog in dialogs.dialogs)
            {
                var peer = dialogs.UserOrChat(dialog);
                string obj_string = peer.ToString().ToLower();
                if (obj_string.IndexOf('@') == 0 || obj_string.IndexOf("telegram") == 0) continue;

                if (!(obj_string.IndexOf("channel") == 0))
                {
                    var users = peer is Channel channel
                                    ? (await _client.Channels_GetAllParticipants(channel)).users
                                    : (await _client.Messages_GetFullChat(peer.ID)).users;

                    foreach (var user in users.Values)
                    {
                        try
                        {
                            string member_name = user.username;
                            if (member_name == null || member_name == "") continue;

                            if (bFirstLine)
                            {
                                File.WriteAllText(file_path, member_name + "\r\n");
                                bFirstLine = false;
                            }
                            else
                                File.AppendAllText(file_path, member_name + "\r\n");
                        }
                        catch
                        {

                        }
                        Application.DoEvents();
                    }

                    m_percentForm.percent_value = ((double)nCurrent) * 100 / ((double)nTotalCount);
                    m_percentForm.nAddedCount = nCurrent + 1;
                    nCurrent++;
                    Application.DoEvents();
                }

            }

            m_percentForm.Close();
        }


        private void AppendLogText(string log_str)
        {
            int nMaxLogLines = 500;
            try
            {
                nMaxLogLines = int.Parse(textBoxLogMaxLines.Text);
            }
            catch { }

            textBoxLogMaxLines.Text = nMaxLogLines.ToString();

            if (textBoxLog.Lines.Length > nMaxLogLines)
                textBoxLog.Text = "";
            else
                textBoxLog.Text += log_str;

            Application.DoEvents();
        }

        private void textBoxSearchMember_TextChanged(object sender, EventArgs e)
        {
            bool bExist = false;
            for (int i = 0; i < listBoxMember.Items.Count; i++)
            {
                string item_str = listBoxMember.Items[i].ToString();
                if (textBoxSearchMember.Text != "" && item_str.Contains(textBoxSearchMember.Text))
                {
                    listBoxMember.SelectedIndex = i;
                    bExist = true;
                    break;
                }
            }

            if (!bExist) listBoxMember.SelectedIndex = -1;
        }
    }
}
