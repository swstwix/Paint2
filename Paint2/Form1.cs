using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint2
{
    public partial class Form1 : Form
    {
        private readonly OutputPanel outputPanel;

        public Form1()
        {
            InitializeComponent();
            outputPanel = new OutputPanel();
            DrawPanel.Controls.Add(outputPanel);
            outputPanel.Width = DrawPanel.Width;
            outputPanel.Height = DrawPanel.Height;
        }

        private void Line1ButtonClick(object sender, EventArgs e)
        {
            Invalidate(true);
        }

    }
}
