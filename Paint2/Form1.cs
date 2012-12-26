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

        public Form1()
        {
            InitializeComponent();
            outputPanel = new OutputPanel(new PaintToolsCollection());
            DrawPanel.Controls.Add(outputPanel);
            outputPanel.Width = DrawPanel.Width;
            outputPanel.Height = DrawPanel.Height;
            outputPanel.Add(new EmptyTool());
        }

        private void Line1ButtonClick(object sender, EventArgs e)
        {
            outputPanel.Add(Line1Tool.Build());
            listView1.Items.Add(new ListViewItem("Line1"));
            Invalidate(true);
        }

        private void ZoomIncButtonClick(object sender, EventArgs e)
        {
            ZoomDecButton.Enabled = true;
            var needDisable = outputPanel.IncZoom();
            ZoomIncButton.Enabled = !needDisable;
            Invalidate(true);
        }

        private void ZoomDecButtonClick(object sender, EventArgs e)
        {
            ZoomIncButton.Enabled = true;
            var needDisable = outputPanel.DecZoom();
            ZoomDecButton.Enabled = !needDisable;
            Invalidate(true);
        }

        private void Line2ButtonClick(object sender, EventArgs e)
        {
            outputPanel.Add(Line2Tool.Build());
            listView1.Items.Add(new ListViewItem("Line2"));
            Invalidate(true);
        }

        private void CirlceButtonClick(object sender, EventArgs e)
        {
            outputPanel.Add(CircleTool.Build());
            listView1.Items.Add(new ListViewItem("Circle"));
            Invalidate(true);
        }

        private void EllipseButtonClick(object sender, EventArgs e)
        {
            outputPanel.Add(EllipseTool.Build());
            listView1.Items.Add(new ListViewItem("Ellipse"));
            Invalidate(true);
        }

        private void PolygonClick(object sender, EventArgs e)
        {
            outputPanel.Add(new PolygonTool());
            listView1.Items.Add(new ListViewItem("Polygon"));
            Invalidate(true);
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            outputPanel.Clear();
            outputPanel.Add(new EmptyTool());
            listView1.Items.Clear();
            Invalidate(true);
        }

        private void FillRecursiveButtonClick(object sender, EventArgs e)
        {
            outputPanel.Add(new RecursiveFloodFillTool());
            listView1.Items.Add("Recursive fill");
            Invalidate(true);
        }

        private void UpButtonClick(object sender, EventArgs e)
        {
            foreach (var tool in outputPanel)
                tool.Move(0, -30);
            Invalidate(true);
        }

        private void DownButtonClick(object sender, EventArgs e)
        {
            foreach (var tool in outputPanel)
                tool.Move(0, 30);
            Invalidate(true);
        }

        private void LeftButtonClick(object sender, EventArgs e)
        {
            foreach (var tool in outputPanel)
                tool.Move(-30, 0);
            Invalidate(true);
        }

        private void RightButtonClick(object sender, EventArgs e)
        {
            foreach (var tool in outputPanel)
                tool.Move(30, 0);
            Invalidate(true);
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            foreach (var tool in outputPanel)
                tool.Rotate(outputPanel.Width/2, outputPanel.Height/2);
            Invalidate(true);
        }

        private void FillLinearButtonClick(object sender, EventArgs e)
        {
            outputPanel.Add(LineFloodFill.Build());
            Invalidate(true);
        }

        private void CuttingButtonClick(object sender, EventArgs e)
        {
            outputPanel.Add(CuttingTool.Build());
            Invalidate(true);
        }

        private void BezieButtonClick(object sender, EventArgs e)
        {
            outputPanel.Add(new BezieLine());
            Invalidate(true);
        }

        private void ErmitButtonClick(object sender, EventArgs e)
        {
            outputPanel.Add(new ErmitLine());
            Invalidate(true);
        }

        private void SplineButtonClick(object sender, EventArgs e)
        {
            outputPanel.Add(new SplineLine());
            Invalidate(true);
        }
    }
}
