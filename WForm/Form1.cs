using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows;

namespace WForm
{
    public partial class Form1 : Form
    {
        [DllImport(@"qtdialog.dll")]
        public static extern bool showDialog(IntPtr parent);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showDialog(this.Handle);
        }
    }
}
