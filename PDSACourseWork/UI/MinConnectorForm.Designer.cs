namespace PDSACourseWork.UI
{
    partial class MinConnectorForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelSelectedCity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GameTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1171, 319);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelSelectedCity
            // 
            this.labelSelectedCity.AutoSize = true;
            this.labelSelectedCity.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSelectedCity.Location = new System.Drawing.Point(355, 461);
            this.labelSelectedCity.Name = "labelSelectedCity";
            this.labelSelectedCity.Size = new System.Drawing.Size(63, 25);
            this.labelSelectedCity.TabIndex = 3;
            this.labelSelectedCity.Text = "City C";
            this.labelSelectedCity.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please select two cities.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selected City as the Starting Point: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "City A",
            "City B",
            "City C",
            "City D",
            "City E",
            "City F",
            "City G",
            "City H",
            "City I",
            "City J"});
            this.comboBox1.Location = new System.Drawing.Point(47, 540);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 29);
            this.comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(47, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Select City";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(826, 489);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(392, 186);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(958, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Selected Cities";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(826, 681);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(392, 44);
            this.button2.TabIndex = 10;
            this.button2.Text = "Submit Answer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(485, 489);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(316, 236);
            this.dataGridView3.TabIndex = 11;
            this.dataGridView3.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "City A",
            "City B",
            "City C",
            "City D",
            "City E",
            "City F",
            "City G",
            "City H",
            "City I",
            "City J"});
            this.comboBox2.Location = new System.Drawing.Point(282, 540);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(169, 29);
            this.comboBox2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(232, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "- to -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(563, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Correct Anwser";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(1062, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 44);
            this.button3.TabIndex = 15;
            this.button3.Text = "Retry Again";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(159, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 29);
            this.txtName.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(47, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Player Name: ";
            // 
            // GameTitleLabel
            // 
            this.GameTitleLabel.AutoSize = true;
            this.GameTitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.GameTitleLabel.Location = new System.Drawing.Point(47, 10);
            this.GameTitleLabel.Name = "GameTitleLabel";
            this.GameTitleLabel.Size = new System.Drawing.Size(264, 30);
            this.GameTitleLabel.TabIndex = 18;
            this.GameTitleLabel.Text = "Minimum Connector Game";
            // 
            // MinConnectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1264, 800);
            this.Controls.Add(this.GameTitleLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSelectedCity);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MinConnectorForm";
            this.Text = "MinConnectorForm";
            this.Load += new System.EventHandler(this.MinConnectorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private Label labelSelectedCity;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridView dataGridView2;
        private Label label5;
        private Button button2;
        private DataGridView dataGridView3;
        private ComboBox comboBox2;
        private Label label2;
        private Label label6;
        private Button button3;
        private TextBox txtName;
        private Label label7;
        private Label GameTitleLabel;
    }
}