using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;
using Tools.Interfaces;

namespace Paint2
{
    public partial class Form1 : Form
    {
        private readonly OutputPanel outputPanel;
        private readonly IList<IPaintTool> tools = new List<IPaintTool>();

        public Form1()
        {
            InitializeComponent();
            outputPanel = new OutputPanel();
            DrawPanel.Controls.Add(outputPanel);
            outputPanel.Width = DrawPanel.Width;
            outputPanel.Height = DrawPanel.Height;
            tools.Add(new EmptyTool());
        }

        private void Line1ButtonClick(object sender, EventArgs e)
        {
            Invalidate(true);
        }

        private void DrawPanelMouseDown(object sender, MouseEventArgs e)
        {
            tools.Last().OnMouseClick(e.X, e.Y);
            Invalidate(true);
        }

        private void DrawPanelMouseUp(object sender, MouseEventArgs e)
        {
            tools.Last().OnMouseClicked(e.X, e.Y);
            Invalidate(true);
        }

        private void DrawPanelMouseMove(object sender, MouseEventArgs e)
        {
            tools.Last().OnMouseMoved(e.X, e.Y);
            Invalidate(true);
        }

    }
}
