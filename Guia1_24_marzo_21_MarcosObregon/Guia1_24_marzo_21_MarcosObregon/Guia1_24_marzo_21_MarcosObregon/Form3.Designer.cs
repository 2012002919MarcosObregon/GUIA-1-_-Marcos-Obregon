namespace Guia1_24_marzo_21_MarcosObregon
{
    partial class Form3
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            numero = new DataGridViewTextBoxColumn();
            Multi = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { numero, Multi, total });
            dataGridView1.Location = new Point(79, 169);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(428, 200);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(333, 80);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 1;
            button1.Text = "ver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 85);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 2;
            label1.Text = "Ingrese los Valores";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 81);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 3;
            // 
            // numero
            // 
            numero.HeaderText = "numero";
            numero.MinimumWidth = 6;
            numero.Name = "numero";
            numero.Width = 125;
            // 
            // Multi
            // 
            Multi.HeaderText = "Multi";
            Multi.MinimumWidth = 6;
            Multi.Name = "Multi";
            Multi.Width = 125;
            // 
            // total
            // 
            total.HeaderText = "total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.Width = 125;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 509);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn Multi;
        private DataGridViewTextBoxColumn total;
    }
}