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
    public partial class PrivMessage : Form
    {
        string topicName;
        string lastMessage;
        MqttClient privClient;
        //public static bool something;
        // string[] connectedUser;

        public PrivMessage(string otherUser,string topicName)
        {
            InitializeComponent();

            //msgUsername.Text = Form1.selectedUser;
            string BrokerAddress = "broker.hivemq.com";
            privClient = new MqttClient(BrokerAddress);

            var conversation = Form1.privMessagesTest.FirstOrDefault(x => x.ConversationBetween.Contains(otherUser));

            if (conversation == null)
            {
                Form1.privMessagesTest.Add(new PrivMessageModel
                {
                    ConversationBetween = new List<string>(new string[] { LoginForm.loginData[0], otherUser }),
                    PrivMessage = this,
                    TopicName = topicName
                });
                msgUsername.Text = otherUser;
                this.topicName = topicName;

                privClient.Connect(Guid.NewGuid().ToString(), LoginForm.loginData[4], LoginForm.loginData[5], true, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE/*, true, topicName, $"{LoginForm.loginData[0]},disconnect", true, 60*/);
                privClient.Subscribe(new string[] { this.topicName }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                privClient.MqttMsgPublishReceived += PrivClient_MqttMsgPublishReceived;
                //topicName = $"/{otherUser}_{LoginForm.loginData[0]}_private{LoginForm.loginData[1]}";
                //privClient.Connect(Guid.NewGuid().ToString(), null, null, false, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true, topicName, $"{LoginForm.loginData[0]},disconnect", true, 60);
                //privClient.Subscribe(new string[] { topicName }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            }
            else
            {
                msgUsername.Text = otherUser;
                this.topicName = conversation.TopicName;
                //ChangeVisibility(string.Empty);
                //privClient.Connect(Guid.NewGuid().ToString(), null, null, false, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true, topicName, $"{LoginForm.loginData[0]},disconnect", true, 60);
                //privClient.Subscribe(new string[] { topicName }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            }
        }

        private void PrivClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);

            if (this.Visible == false)
            {
                ChangeVisibility(ReceivedMessage);
            }
            else
            if (ReceivedMessage == lastMessage)
            {
                AppendText($"Sent: {ReceivedMessage}{Environment.NewLine}");
            }
            else
            {
                AppendText($"{ReceivedMessage}{Environment.NewLine}");
            }
        }

        public void ChangeVisibility(string Message)
        {
            if (this.InvokeRequired)
                this.Invoke(new Action<string>(ChangeVisibility), Message);
            else
            {
                this.Visible = true;
                if (Message != null)
                    AppendText($"{Message}{Environment.NewLine}");
            }
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

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = privMsg.Text;
                privMsg.Text = null;
                lastMessage = $"[{DateTime.Now.ToString("dd-MM-yyyy hh:mm")}] - {LoginForm.loginData[0]}: {text}";
                privClient.Publish(topicName, Encoding.UTF8.GetBytes(lastMessage), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
            }
        }

        private void PrivMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
                //this.Hide();
            }
        }
    }
}