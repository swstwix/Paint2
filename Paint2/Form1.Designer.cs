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
            this.button5 = new System.Windows.Forms.Button();
            this.EllipseButton = new System.Windows.Forms.Button();
            this.CirlceButton = new System.Windows.Forms.Button();
            this.Line2Button = new System.Windows.Forms.Button();
            this.Line1Button = new System.Windows.Forms.Button();
            this.ZoomPanel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.ActionsPanel.SuspendLayout();
            this.ZoomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActionsPanel.Controls.Add(this.button5);
            this.ActionsPanel.Controls.Add(this.EllipseButton);
            this.ActionsPanel.Controls.Add(this.CirlceButton);
            this.ActionsPanel.Controls.Add(this.Line2Button);
            this.ActionsPanel.Controls.Add(this.Line1Button);
            this.ActionsPanel.Location = new System.Drawing.Point(12, 12);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(200, 167);
            this.ActionsPanel.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // EllipseButton
            // 
            this.EllipseButton.Location = new System.Drawing.Point(86, 33);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(75, 23);
            this.EllipseButton.TabIndex = 3;
            this.EllipseButton.Text = "Ellipse";
            this.EllipseButton.UseVisualStyleBackColor = true;
            // 
            // CirlceButton
            // 
            this.CirlceButton.Location = new System.Drawing.Point(4, 33);
            this.CirlceButton.Name = "CirlceButton";
            this.CirlceButton.Size = new System.Drawing.Size(75, 23);
            this.CirlceButton.TabIndex = 2;
            this.CirlceButton.Text = "Circle";
            this.CirlceButton.UseVisualStyleBackColor = true;
            // 
            // Line2Button
            // 
            this.Line2Button.Location = new System.Drawing.Point(84, 3);
            this.Line2Button.Name = "Line2Button";
            this.Line2Button.Size = new System.Drawing.Size(75, 23);
            this.Line2Button.TabIndex = 1;
            this.Line2Button.Text = "Line2";
            this.Line2Button.UseVisualStyleBackColor = true;
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
            this.ZoomPanel.Controls.Add(this.button8);
            this.ZoomPanel.Controls.Add(this.button7);
            this.ZoomPanel.Location = new System.Drawing.Point(12, 185);
            this.ZoomPanel.Name = "ZoomPanel";
            this.ZoomPanel.Size = new System.Drawing.Size(200, 177);
            this.ZoomPanel.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(173, 32);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(24, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(173, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(24, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // DrawPanel
            // 
            this.DrawPanel.AutoScroll = true;
            this.DrawPanel.Location = new System.Drawing.Point(218, 12);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(416, 350);
            this.DrawPanel.TabIndex = 2;
            this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPanelMouseDown);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanelMouseMove);
            this.DrawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPanelMouseUp);
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button EllipseButton;
        private System.Windows.Forms.Button CirlceButton;
        private System.Windows.Forms.Button Line2Button;
        private System.Windows.Forms.Button Line1Button;
        private System.Windows.Forms.Panel ZoomPanel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel DrawPanel;
    }
}

