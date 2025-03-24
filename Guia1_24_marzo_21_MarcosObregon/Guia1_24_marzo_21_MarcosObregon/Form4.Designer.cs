namespace Guia1_24_marzo_21_MarcosObregon
{
    partial class Form4
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
            numero = new DataGridViewTextBoxColumn();
            multiplicacion = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { numero, multiplicacion, total });
            dataGridView1.Location = new Point(78, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(321, 150);
            dataGridView1.TabIndex = 0;
            // 
            // numero
            // 
            numero.HeaderText = "Numero";
            numero.Name = "numero";
            // 
            // multiplicacion
            // 
            multiplicacion.HeaderText = "Multiplicacion";
            multiplicacion.Name = "multiplicacion";
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.Name = "total";
            // 
            // button1
            // 
            button1.Location = new Point(270, 86);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Ver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 89);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese un Numero";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 376);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn multiplicacion;
        private DataGridViewTextBoxColumn total;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}