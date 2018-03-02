using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        static extern long GetWindowLong(IntPtr hWnd, int nIndex);

        public Form1()
        {
            InitializeComponent();
            int initialStyle = Convert.ToInt32(GetWindowLong(this.Handle, -20));
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }
    }
}
