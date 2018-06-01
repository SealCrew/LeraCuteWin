using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeraCute;

namespace LeraForm
{
    public partial class myWin : Form
    {
        private Lera lera;

        public myWin()
        {
            lera = new Lera("awww");
         //   label1.Text = "arrrgh";
            InitializeComponent();
            label1.Text = "arrrgh";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = lera.GetMessage();
        }


    }
}
