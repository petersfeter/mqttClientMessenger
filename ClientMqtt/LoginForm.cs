using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientMqtt
{
    
    public partial class LoginForm : Form
    {
        public static string[] loginData = new string[6];

        public LoginForm()
        {            
            InitializeComponent();
        }

        private void SubmitData_Click(object sender, EventArgs e)
        {
            
            if (clientId.Text != null && threadName.Text != null)
            {
                if (portBox != null)
                    loginData[3] = "1883";
                else loginData[3] = portBox.Text;

                if (brokerAddressBox != null)
                    loginData[2] = "broker.hivemq.com";
                else loginData[2] = brokerAddressBox.Text;
                if (username.Text != null && password.Text != null)
                {
                    loginData[4] = username.Text;
                    loginData[5] = password.Text;
                }
                else
                {
                    loginData[4] = null;
                    loginData[5] = null;
                }

                loginData[0] = clientId.Text;
                loginData[1] = threadName.Text;                
                // set the dialog result to ok
                this.DialogResult = DialogResult.OK;
                // close the dialog
                this.Close();
            }
            else
            {
                // login failed
                MessageBox.Show("Login failed");
                // do not close the window
            }
        }        
    }
}
