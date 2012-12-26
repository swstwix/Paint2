namespace Paint2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ActionsPanel = new System.Windows.Forms.Panel();
            this.SplineButton = new System.Windows.Forms.Button();
            this.ErmitButton = new System.Windows.Forms.Button();
            this.BezieButton = new System.Windows.Forms.Button();
            this.CuttingButton = new System.Windows.Forms.Button();
            this.FillLinearButton = new System.Windows.Forms.Button();
            this.RotateButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.FillRecursiveButton = new System.Windows.Forms.Button();
            this.PolygonButton = new System.Windows.Forms.Button();
            this.ZoomDecButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ZoomIncButton = new System.Windows.Forms.Button();
            this.EllipseButton = new System.Windows.Forms.Button();
            this.CirlceButton = new System.Windows.Forms.Button();
            this.Line2Button = new System.Windows.Forms.Button();
            this.Line1Button = new System.Windows.Forms.Button();
            this.ZoomPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.ActionsPanel.SuspendLayout();
            this.ZoomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActionsPanel.Controls.Add(this.SplineButton);
            this.ActionsPanel.Controls.Add(this.ErmitButton);
            this.ActionsPanel.Controls.Add(this.BezieButton);
            this.ActionsPanel.Controls.Add(this.CuttingButton);
            this.ActionsPanel.Controls.Add(this.FillLinearButton);
            this.ActionsPanel.Controls.Add(this.RotateButton);
            this.ActionsPanel.Controls.Add(this.LeftButton);
            this.ActionsPanel.Controls.Add(this.RightButton);
            this.ActionsPanel.Controls.Add(this.DownButton);
            this.ActionsPanel.Controls.Add(this.UpButton);
            this.ActionsPanel.Controls.Add(this.FillRecursiveButton);
            this.ActionsPanel.Controls.Add(this.PolygonButton);
            this.ActionsPanel.Controls.Add(this.ZoomDecButton);
            this.ActionsPanel.Controls.Add(this.ClearButton);
            this.ActionsPanel.Controls.Add(this.ZoomIncButton);
            this.ActionsPanel.Controls.Add(this.EllipseButton);
            this.ActionsPanel.Controls.Add(this.CirlceButton);
            this.ActionsPanel.Controls.Add(this.Line2Button);
            this.ActionsPanel.Controls.Add(this.Line1Button);
            this.ActionsPanel.Location = new System.Drawing.Point(12, 12);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(330, 167);
            this.ActionsPanel.TabIndex = 0;
            // 
            // SplineButton
            // 
            this.SplineButton.Location = new System.Drawing.Point(180, 82);
            this.SplineButton.Name = "SplineButton";
            this.SplineButton.Size = new System.Drawing.Size(75, 23);
            this.SplineButton.TabIndex = 10;
            this.SplineButton.Text = "Spline";
            this.SplineButton.UseVisualStyleBackColor = true;
            this.SplineButton.Click += new System.EventHandler(this.SplineButtonClick);
            // 
            // ErmitButton
            // 
            this.ErmitButton.Location = new System.Drawing.Point(180, 111);
            this.ErmitButton.Name = "ErmitButton";
            this.ErmitButton.Size = new System.Drawing.Size(75, 23);
            this.ErmitButton.TabIndex = 10;
            this.ErmitButton.Text = "Ermit";
            this.ErmitButton.UseVisualStyleBackColor = true;
            this.ErmitButton.Click += new System.EventHandler(this.ErmitButtonClick);
            // 
            // BezieButton
            // 
            this.BezieButton.Location = new System.Drawing.Point(180, 139);
            this.BezieButton.Name = "BezieButton";
            this.BezieButton.Size = new System.Drawing.Size(75, 23);
            this.BezieButton.TabIndex = 10;
            this.BezieButton.Text = "Bezie";
            this.BezieButton.UseVisualStyleBackColor = true;
            this.BezieButton.Click += new System.EventHandler(this.BezieButtonClick);
            // 
            // CuttingButton
            // 
            this.CuttingButton.Location = new System.Drawing.Point(84, 141);
            this.CuttingButton.Name = "CuttingButton";
            this.CuttingButton.Size = new System.Drawing.Size(75, 23);
            this.CuttingButton.TabIndex = 9;
            this.CuttingButton.Text = "Cutting";
            this.CuttingButton.UseVisualStyleBackColor = true;
            this.CuttingButton.Click += new System.EventHandler(this.CuttingButtonClick);
            // 
            // FillLinearButton
            // 
            this.FillLinearButton.Location = new System.Drawing.Point(86, 91);
            this.FillLinearButton.Name = "FillLinearButton";
            this.FillLinearButton.Size = new System.Drawing.Size(75, 23);
            this.FillLinearButton.TabIndex = 8;
            this.FillLinearButton.Text = "FillLinear";
            this.FillLinearButton.UseVisualStyleBackColor = true;
            this.FillLinearButton.Click += new System.EventHandler(this.FillLinearButtonClick);
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(4, 91);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(75, 23);
            this.RotateButton.TabIndex = 7;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(180, 18);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(41, 23);
            this.LeftButton.TabIndex = 6;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButtonClick);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(280, 18);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(45, 23);
            this.RightButton.TabIndex = 6;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButtonClick);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(227, 33);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(47, 23);
            this.DownButton.TabIndex = 6;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButtonClick);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(227, 3);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(47, 23);
            this.UpButton.TabIndex = 6;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButtonClick);
            // 
            // FillRecursiveButton
            // 
            this.FillRecursiveButton.Location = new System.Drawing.Point(86, 62);
            this.FillRecursiveButton.Name = "FillRecursiveButton";
            this.FillRecursiveButton.Size = new System.Drawing.Size(75, 23);
            this.FillRecursiveButton.TabIndex = 5;
            this.FillRecursiveButton.Text = "FillRecursive";
            this.FillRecursiveButton.UseVisualStyleBackColor = true;
            this.FillRecursiveButton.Click += new System.EventHandler(this.FillRecursiveButtonClick);
            // 
            // PolygonButton
            // 
            this.PolygonButton.Location = new System.Drawing.Point(4, 62);
            this.PolygonButton.Name = "PolygonButton";
            this.PolygonButton.Size = new System.Drawing.Size(75, 23);
            this.PolygonButton.TabIndex = 0;
            this.PolygonButton.Text = "Polygon";
            this.PolygonButton.UseVisualStyleBackColor = true;
            this.PolygonButton.Click += new System.EventHandler(this.PolygonClick);
            // 
            // ZoomDecButton
            // 
            this.ZoomDecButton.Enabled = false;
            this.ZoomDecButton.Location = new System.Drawing.Point(301, 140);
            this.ZoomDecButton.Name = "ZoomDecButton";
            this.ZoomDecButton.Size = new System.Drawing.Size(24, 23);
            this.ZoomDecButton.TabIndex = 1;
            this.ZoomDecButton.Text = "-";
            this.ZoomDecButton.UseVisualStyleBackColor = true;
            this.ZoomDecButton.Click += new System.EventHandler(this.ZoomDecButtonClick);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(4, 141);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // ZoomIncButton
            // 
            this.ZoomIncButton.Location = new System.Drawing.Point(301, 111);
            this.ZoomIncButton.Name = "ZoomIncButton";
            this.ZoomIncButton.Size = new System.Drawing.Size(24, 23);
            this.ZoomIncButton.TabIndex = 0;
            this.ZoomIncButton.Text = "+";
            this.ZoomIncButton.UseVisualStyleBackColor = true;
            this.ZoomIncButton.Click += new System.EventHandler(this.ZoomIncButtonClick);
            // 
            // EllipseButton
            // 
            this.EllipseButton.Location = new System.Drawing.Point(86, 33);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(75, 23);
            this.EllipseButton.TabIndex = 3;
            this.EllipseButton.Text = "Ellipse";
            this.EllipseButton.UseVisualStyleBackColor = true;
            this.EllipseButton.Click += new System.EventHandler(this.EllipseButtonClick);
            // 
            // CirlceButton
            // 
            this.CirlceButton.Location = new System.Drawing.Point(4, 33);
            this.CirlceButton.Name = "CirlceButton";
            this.CirlceButton.Size = new System.Drawing.Size(75, 23);
            this.CirlceButton.TabIndex = 2;
            this.CirlceButton.Text = "Circle";
            this.CirlceButton.UseVisualStyleBackColor = true;
            this.CirlceButton.Click += new System.EventHandler(this.CirlceButtonClick);
            // 
            // Line2Button
            // 
            this.Line2Button.Location = new System.Drawing.Point(84, 3);
            this.Line2Button.Name = "Line2Button";
            this.Line2Button.Size = new System.Drawing.Size(75, 23);
            this.Line2Button.TabIndex = 1;
            this.Line2Button.Text = "Line2";
            this.Line2Button.UseVisualStyleBackColor = true;
            this.Line2Button.Click += new System.EventHandler(this.Line2ButtonClick);
            // 
            // Line1Button
            // 
            this.Line1Button.Location = new System.Drawing.Point(3, 3);
            this.Line1Button.Name = "Line1Button";
            this.Line1Button.Size = new System.Drawing.Size(75, 23);
            this.Line1Button.TabIndex = 0;
            this.Line1Button.Text = "Line1";
            this.Line1Button.UseVisualStyleBackColor = true;
            this.Line1Button.Click += new System.EventHandler(this.Line1ButtonClick);
            // 
            // ZoomPanel
            // 
            this.ZoomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZoomPanel.Controls.Add(this.listView1);
            this.ZoomPanel.Location = new System.Drawing.Point(12, 185);
            this.ZoomPanel.Name = "ZoomPanel";
            this.ZoomPanel.Size = new System.Drawing.Size(326, 177);
            this.ZoomPanel.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(4, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(157, 169);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // DrawPanel
            // 
            this.DrawPanel.AutoScroll = true;
            this.DrawPanel.BackColor = System.Drawing.SystemColors.Window;
            this.DrawPanel.Location = new System.Drawing.Point(348, 12);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(416, 350);
            this.DrawPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 374);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.ZoomPanel);
            this.Controls.Add(this.ActionsPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ActionsPanel.ResumeLayout(false);
            this.ZoomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ActionsPanel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EllipseButton;
        private System.Windows.Forms.Button CirlceButton;
        private System.Windows.Forms.Button Line2Button;
        private System.Windows.Forms.Button Line1Button;
        private System.Windows.Forms.Panel ZoomPanel;
        private System.Windows.Forms.Button ZoomDecButton;
        private System.Windows.Forms.Button ZoomIncButton;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Button PolygonButton;
        private System.Windows.Forms.Button FillRecursiveButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.Button FillLinearButton;
        private System.Windows.Forms.Button CuttingButton;
        private System.Windows.Forms.Button SplineButton;
        private System.Windows.Forms.Button ErmitButton;
        private System.Windows.Forms.Button BezieButton;
    }
}

