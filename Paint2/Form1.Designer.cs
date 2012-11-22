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
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ActionsPanel.SuspendLayout();
            this.ZoomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.ActionsPanel.Size = new System.Drawing.Size(200, 167);
            this.ActionsPanel.TabIndex = 0;
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
            this.ZoomDecButton.Location = new System.Drawing.Point(171, 139);
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
            this.ZoomIncButton.Location = new System.Drawing.Point(171, 110);
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
            this.ZoomPanel.Size = new System.Drawing.Size(200, 177);
            this.ZoomPanel.TabIndex = 1;
            // 
            // DrawPanel
            // 
            this.DrawPanel.AutoScroll = true;
            this.DrawPanel.BackColor = System.Drawing.SystemColors.Window;
            this.DrawPanel.Location = new System.Drawing.Point(218, 12);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(416, 350);
            this.DrawPanel.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(4, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(157, 169);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 374);
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
    }
}

