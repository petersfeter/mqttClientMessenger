using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace ClientMqtt
{
    public partial class Form1 : Form
    {
        List<string> privMessagesStarted = new List<string>();
        //public static List<string> selectedUser = new List<string>(new string[] { null, null });
        string lastMessage;
        int port;
        MqttClient client;
        string BrokerAddress;
        string[] connectedUser;
        Timer timer = new Timer();
        List<string> onlineUsers = new List<string>();
        //List<PrivMessage> privMessages = new List<PrivMessage>();
        public static List<PrivMessageModel> privMessagesTest = new List<PrivMessageModel>();
        //PrivMessage privMessage;

        public Form1()
        {
            InitializeComponent();
            BrokerAddress = LoginForm.loginData[2];
            port = Int32.Parse(LoginForm.loginData[3]);
            client = new MqttClient(BrokerAddress, port, false, null, null, MqttSslProtocols.TLSv1_2);
            // client.Connect(mqttConfig.PanelClientId + $"_SendDeviceConfig_{applicationId}", mqttConfig.UserName, mqttConfig.Password);
            client.Connect(LoginForm.loginData[0], LoginForm.loginData[4], LoginForm.loginData[5]);//, false, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true, LoginForm.loginData[1], $"{LoginForm.loginData[0]},disconnect", true, 60);
            client.Subscribe(new string[] { $"{LoginForm.loginData[1]}", $"{LoginForm.loginData[1]}/{LoginForm.loginData[0]}" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            //client.Subscribe(new string[] { $"{LoginForm.loginData[1]}/{LoginForm.loginData[0]}" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            outputText.SelectionStart = outputText.TextLength;

            client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            client.Publish(LoginForm.loginData[1], Encoding.UTF8.GetBytes($"{LoginForm.loginData[0]},online"), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, false);
            timer.Interval = 4000;
            if (client.IsConnected)
            {
                timer.Tick += new EventHandler(Timer_tick);
                timer.Enabled = true;
            }
            else timer.Enabled = false;
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            client.Publish(LoginForm.loginData[1], Encoding.UTF8.GetBytes($"{LoginForm.loginData[0]},online"), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, false);
        }

        public void AppendText(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendText), new object[] { value });
                return;
            }
            if (value.Contains("Sent: "))
            {                
                int firstCharOfLineIndex = outputText.GetFirstCharIndexOfCurrentLine();
                int currentLine = outputText.GetLineFromCharIndex(firstCharOfLineIndex);
                this.outputText.Select(firstCharOfLineIndex, currentLine);
                this.outputText.SelectionColor = Color.Green;
                outputText.AppendText(value);
            }
            else
                outputText.AppendText(value);

            outputText.SelectionStart = outputText.TextLength;
            outputText.ScrollToCaret();

        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string text = txtMsg.Text;
            txtMsg.Text = null;
            lastMessage = $"[{DateTime.Now.ToString("dd-MM-yyyy hh:mm")}] - {LoginForm.loginData[0]}: {text}";
            client.Publish(LoginForm.loginData[1], Encoding.UTF8.GetBytes(lastMessage), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, false);
        }

        void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);
            if (ReceivedMessage.Contains("authorize"))
            {
                connectedUser = ReceivedMessage.Split(',');
                //selectedUser[0] = connectedUser[0];
                //if (privMessagesStarted.Contains())
                //{

                //}
                if (LoginForm.loginData[0] != connectedUser[0])
                {
                    privMessagesStarted.Add($"{connectedUser[0]},authorize");
                    //PrivMessage privMessage = new PrivMessage();
                    ////Application.Run(privMessage);
                    //privMessage.Show();
                    ShowPrivMessage(connectedUser[0], connectedUser[1]);
                }
            }
            else
            {
                if (ReceivedMessage.Contains("disconnect") || ReceivedMessage.Contains("online"))
                {
                    connectedUser = ReceivedMessage.Split(',');
                    if (ReceivedMessage.Contains("disconnect"))
                    {
                        RemoveUserFromOnlineList(connectedUser[0]);
                    }
                    else
                    if (ReceivedMessage.Contains("online")) //Wiadomość zawierająca ,online' nie wyświetla, dodaje użytkownika jeżeli nie jest już na liście
                    {
                        if (!onlineUsers.Contains(connectedUser[0]))
                        {
                            AppendUser(connectedUser[0]);
                        }
                    }
                }
                else
                if (ReceivedMessage == lastMessage)
                {
                    AppendText($"Sent: {ReceivedMessage}{Environment.NewLine}");
                }
                else AppendText($"{ReceivedMessage}{Environment.NewLine}");
            }
        }

        private void ShowPrivMessage(string user, string topicNameGenerated)
        {
            //privMessage.Show();
            if (this.InvokeRequired)
                this.Invoke(new Action<string, string>(ShowPrivMessage), user, topicNameGenerated);
            else
            {
                //PrivMessage privMessageRecv = new PrivMessage();
                //Application.Run(privMessage);
                var currentPrivMessage = privMessagesTest.FirstOrDefault(x => x.ConversationBetween.Contains(user));
                if (currentPrivMessage != null)
                {
                    currentPrivMessage.PrivMessage.Show();
                }
                else
                {
                    var privMessage = new PrivMessage(user, topicNameGenerated);
                    privMessage.Show();
                }
            }
        }

        public void RemoveUserFromOnlineList(string user)
        {
            onlineUsers.Remove(user);
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(RemoveUserFromOnlineList), new object[] { user });
                return;
            }
            for (int i = usersListOnline.Items.Count - 1; i >= 0; i--) //usuwa użytkownika z ListView
            {
                if (usersListOnline.Items[i].Text == user)
                    usersListOnline.Items[i].Remove();
            }
        }

        public void AppendUser(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendUser), new object[] { value });
                return;
            }
            onlineUsers.Add(value);//dodaje użytkownika do listy pomocniczej
            usersListOnline.Items.Add(value);//dodaje użytkownika do ListView
        }

        private void TxtMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSend_Click(this, new EventArgs());
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //wciśnięcie przycisku Logout
            client.Publish(LoginForm.loginData[1], Encoding.UTF8.GetBytes($"{LoginForm.loginData[0]},disconnect"), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, false);
            client.Disconnect();
            //this.Close();
            Environment.Exit(1);
            //Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //zamknięcie okna
            client.Publish(LoginForm.loginData[1], Encoding.UTF8.GetBytes($"{LoginForm.loginData[0]},disconnect"), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, false);
            client.Disconnect();
            Environment.Exit(1);
            //Application.Exit();
        }

        private void UsersListOnline_ItemActivate(object sender, EventArgs e)
        {
            var receiver = usersListOnline.SelectedItems[0].Text;

            if (privMessagesStarted.Contains($"{receiver},authorize"))
            {
                ShowPrivMessage(receiver, privMessagesTest.FirstOrDefault(x => x.ConversationBetween.Contains(receiver)).TopicName);

                //PrivMessage.something = true;
            }
            else if (LoginForm.loginData[0] != receiver)
            {
                string topicName = $"{Guid.NewGuid().ToString()}/{receiver}";
                //subuje kanał z nazwą użytkownika po czym wysyła wiadomość informującą klienta o połączeniu
                client.Subscribe(new string[] { $"{LoginForm.loginData[1]}/{receiver}" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                client.Publish($"{LoginForm.loginData[1]}/{receiver}", Encoding.UTF8.GetBytes($"{LoginForm.loginData[0]},{topicName},authorize"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
                //unsubuje topic nasłuchowy klienta
                client.Unsubscribe(new string[] { $"{LoginForm.loginData[1]}/{receiver}" });
                //otwiera okno z prywatnym chatem

                privMessagesStarted.Add($"{receiver},authorize");
                var privMessage = new PrivMessage(receiver, topicName);
                privMessage.Show();
                //selectedUser = new List<string>(new string[] { null, null });
            }
            else MessageBox.Show("Nie możesz chatować ze sobą, chyba że 'jest nas wielu' to okej ale nie tutaj", "Ni dy rydy", MessageBoxButtons.OK);
        }
    }
}