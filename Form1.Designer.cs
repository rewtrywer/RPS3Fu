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
        private void InitializeComponent() {
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
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1.25F;
            formsPlot1.Location = new Point(-1, 0);
            formsPlot1.Margin = new Padding(3, 2, 3, 2);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(444, 268);
            formsPlot1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(458, 238);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(108, 30);
            button1.TabIndex = 1;
            button1.Text = "Построить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, YPos, YNeg });
            dataGridView1.Location = new Point(458, 24);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(229, 201);
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
            textBox1.Location = new Point(95, 280);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "a";
            textBox1.Size = new Size(30, 23);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyPress += textBox2_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 280);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "c";
            textBox2.Size = new Size(30, 23);
            textBox2.TabIndex = 4;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(199, 280);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "шаг";
            textBox3.Size = new Size(30, 23);
            textBox3.TabIndex = 5;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(254, 280);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "min";
            textBox4.Size = new Size(30, 23);
            textBox4.TabIndex = 6;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.KeyPress += textBox2_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(306, 280);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "max";
            textBox5.Size = new Size(30, 23);
            textBox5.TabIndex = 7;
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.KeyPress += textBox2_KeyPress;
            // 
            // button2
            // 
            button2.Location = new Point(458, 284);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(108, 30);
            button2.TabIndex = 8;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(592, 284);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(108, 30);
            button3.TabIndex = 9;
            button3.Text = "Загрузить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(592, 238);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(108, 30);
            button4.TabIndex = 10;
            button4.Text = "Информация";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 338);
            Controls.Add(button4);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Овал Кассини";
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
        private Button button4;
    }
}
