namespace PDSACourseWork.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScreenPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectorBtn = new System.Windows.Forms.RadioButton();
            this.ShortPathBtn = new System.Windows.Forms.RadioButton();
            this.QueenBtn = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScreenPanel
            // 
            this.ScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.ScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.ScreenPanel.Name = "ScreenPanel";
            this.ScreenPanel.Size = new System.Drawing.Size(1264, 800);
            this.ScreenPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ConnectorBtn);
            this.panel2.Controls.Add(this.ShortPathBtn);
            this.panel2.Controls.Add(this.QueenBtn);
            this.panel2.Location = new System.Drawing.Point(0, 800);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 74);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(718, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min Connectors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(594, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shortest Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(472, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eight Queen";
            // 
            // ConnectorBtn
            // 
            this.ConnectorBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.ConnectorBtn.BackColor = System.Drawing.Color.Transparent;
            this.ConnectorBtn.BackgroundImage = global::PDSACourseWork.Properties.Resources.MinimumConnectors;
            this.ConnectorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConnectorBtn.FlatAppearance.BorderSize = 0;
            this.ConnectorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectorBtn.ForeColor = System.Drawing.Color.Black;
            this.ConnectorBtn.Location = new System.Drawing.Point(738, 4);
            this.ConnectorBtn.Name = "ConnectorBtn";
            this.ConnectorBtn.Size = new System.Drawing.Size(50, 50);
            this.ConnectorBtn.TabIndex = 2;
            this.ConnectorBtn.TabStop = true;
            this.ConnectorBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConnectorBtn.UseVisualStyleBackColor = false;
            this.ConnectorBtn.Click += new System.EventHandler(this.ConnectorBtn_Click);
            // 
            // ShortPathBtn
            // 
            this.ShortPathBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.ShortPathBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShortPathBtn.BackgroundImage = global::PDSACourseWork.Properties.Resources.ShortPath;
            this.ShortPathBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShortPathBtn.FlatAppearance.BorderSize = 0;
            this.ShortPathBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShortPathBtn.ForeColor = System.Drawing.Color.Black;
            this.ShortPathBtn.Location = new System.Drawing.Point(607, 4);
            this.ShortPathBtn.Name = "ShortPathBtn";
            this.ShortPathBtn.Size = new System.Drawing.Size(50, 50);
            this.ShortPathBtn.TabIndex = 1;
            this.ShortPathBtn.TabStop = true;
            this.ShortPathBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ShortPathBtn.UseVisualStyleBackColor = false;
            this.ShortPathBtn.CheckedChanged += new System.EventHandler(this.ShortPathBtn_CheckedChanged);
            this.ShortPathBtn.Click += new System.EventHandler(this.ShortPathBtn_Click);
            // 
            // QueenBtn
            // 
            this.QueenBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.QueenBtn.BackColor = System.Drawing.Color.Transparent;
            this.QueenBtn.BackgroundImage = global::PDSACourseWork.Properties.Resources.EightQueen;
            this.QueenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueenBtn.FlatAppearance.BorderSize = 0;
            this.QueenBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.QueenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueenBtn.ForeColor = System.Drawing.Color.Black;
            this.QueenBtn.Location = new System.Drawing.Point(482, 4);
            this.QueenBtn.Name = "QueenBtn";
            this.QueenBtn.Size = new System.Drawing.Size(50, 50);
            this.QueenBtn.TabIndex = 0;
            this.QueenBtn.TabStop = true;
            this.QueenBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.QueenBtn.UseVisualStyleBackColor = false;
            this.QueenBtn.Click += new System.EventHandler(this.QueenBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 874);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ScreenPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ScreenPanel;
        private Panel panel2;
        private RadioButton QueenBtn;
        private Label label1;
        private RadioButton ConnectorBtn;
        private RadioButton ShortPathBtn;
        private Label label2;
        private Label label3;
    }
}