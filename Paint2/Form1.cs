﻿using System;
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
        private readonly IPaintToolsCollection paintToolsCollection = new PaintToolsCollection();

        public Form1()
        {
            InitializeComponent();
            outputPanel = new OutputPanel(paintToolsCollection);
            DrawPanel.Controls.Add(outputPanel);
            outputPanel.Width = DrawPanel.Width;
            outputPanel.Height = DrawPanel.Height;
            paintToolsCollection.Add(new EmptyTool());
        }

        private void Line1ButtonClick(object sender, EventArgs e)
        {
            paintToolsCollection.Add(Line1Tool.Build());
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
            paintToolsCollection.Add(Line2Tool.Build());
            listView1.Items.Add(new ListViewItem("Line2"));
            Invalidate(true);
        }

        private void CirlceButtonClick(object sender, EventArgs e)
        {
            paintToolsCollection.Add(CircleTool.Build());
            listView1.Items.Add(new ListViewItem("Circle"));
            Invalidate(true);
        }

        private void EllipseButtonClick(object sender, EventArgs e)
        {
            paintToolsCollection.Add(EllipseTool.Build());
            listView1.Items.Add(new ListViewItem("Ellipse"));
            Invalidate(true);
        }

        private void PolygonClick(object sender, EventArgs e)
        {
            paintToolsCollection.Add(new PolygonTool());
            listView1.Items.Add(new ListViewItem("Polygon"));
            Invalidate(true);
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            paintToolsCollection.Clear();
            paintToolsCollection.Add(new EmptyTool());
            listView1.Items.Clear();
            Invalidate(true);
        }

        private void FillRecursiveButtonClick(object sender, EventArgs e)
        {
            paintToolsCollection.Add(new RecursiveFloodFillTool());
            listView1.Items.Add("Recursive fill");
            Invalidate(true);
        }

    }
}
