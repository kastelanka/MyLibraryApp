using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //prilikom stvaranja forme, mi cemo overrideati jednu metodu:
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Login login = new Login();
            login.Show(this); //this pripada formi koja ju ju otvorila
        }
    }
}
