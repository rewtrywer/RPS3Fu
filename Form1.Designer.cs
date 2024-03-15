namespace рпс3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            YPos = new DataGridViewTextBoxColumn();
            YNeg = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1.25F;
            formsPlot1.Location = new Point(-1, 0);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(508, 358);
            formsPlot1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(497, 289);
            button1.Name = "button1";
            button1.Size = new Size(124, 40);
            button1.TabIndex = 1;
            button1.Text = "построить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, YPos, YNeg });
            dataGridView1.Location = new Point(495, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(278, 228);
            dataGridView1.TabIndex = 2;
            // 
            // X
            // 
            X.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 75;
            // 
            // YPos
            // 
            YPos.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            YPos.HeaderText = "YPos";
            YPos.MinimumWidth = 6;
            YPos.Name = "YPos";
            YPos.Width = 75;
            // 
            // YNeg
            // 
            YNeg.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            YNeg.HeaderText = "YNeg";
            YNeg.MinimumWidth = 6;
            YNeg.Name = "YNeg";
            YNeg.Width = 75;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 385);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "a";
            textBox1.Size = new Size(34, 27);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 385);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "c";
            textBox2.Size = new Size(34, 27);
            textBox2.TabIndex = 4;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(167, 385);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "шаг";
            textBox3.Size = new Size(34, 27);
            textBox3.TabIndex = 5;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(230, 385);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "min";
            textBox4.Size = new Size(34, 27);
            textBox4.TabIndex = 6;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(290, 385);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "max";
            textBox5.Size = new Size(34, 27);
            textBox5.TabIndex = 7;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Location = new Point(649, 289);
            button2.Name = "button2";
            button2.Size = new Size(124, 40);
            button2.TabIndex = 8;
            button2.Text = "сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(649, 349);
            button3.Name = "button3";
            button3.Size = new Size(124, 40);
            button3.TabIndex = 9;
            button3.Text = "загрузить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(formsPlot1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn YPos;
        private DataGridViewTextBoxColumn YNeg;
        private Button button2;
        private Button button3;
    }
}
