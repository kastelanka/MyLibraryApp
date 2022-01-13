using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyLibrary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool UserIsValid()
        {
            //XDocument korisnici = new XDocument();
            XElement korisnici = XElement.Load("korisnici.xml");

            var users = from user in korisnici.Elements()
                select new
                {
                    username = (string)user.Element("korisnickoIme"),
                    password = (string)user.Element("lozinka")
                };
            foreach (var user in users)
            {
                if (string.Compare(user.username, textBoxUsername.Text, true) == 0
                    && user.password == textBoxPassword.Text)
                    return true;
            }
            
            return false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (UserIsValid())
            {
                Close();
                return;
            }

            //MessageBox.Show("Invalid Username or password."); ili:
            MessageBox.Show(this, "Invalid Username or password.", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
