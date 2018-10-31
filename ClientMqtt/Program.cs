using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClientMqtt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>       

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm login_form = new LoginForm();
            if (login_form.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
            //Application.Run(new Form1());
        }        
    }
}
