namespace Guia1_24_marzo_21_MarcosObregon
{
    partial class Form5
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            vectror1 = new DataGridViewTextBoxColumn();
            vector2 = new DataGridViewTextBoxColumn();
            multiplicacion = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(311, 63);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Mostrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { vectror1, vector2, multiplicacion });
            dataGridView1.Location = new Point(85, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(427, 188);
            dataGridView1.TabIndex = 1;
            // 
            // vectror1
            // 
            vectror1.HeaderText = "vector1";
            vectror1.MinimumWidth = 6;
            vectror1.Name = "vectror1";
            vectror1.Width = 125;
            // 
            // vector2
            // 
            vector2.HeaderText = "vector2";
            vector2.MinimumWidth = 6;
            vector2.Name = "vector2";
            vector2.Width = 125;
            // 
            // multiplicacion
            // 
            multiplicacion.HeaderText = "multiplicacion";
            multiplicacion.MinimumWidth = 6;
            multiplicacion.Name = "multiplicacion";
            multiplicacion.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 68);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 2;
            label1.Text = "Digite un valor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn vectror1;
        private DataGridViewTextBoxColumn vector2;
        private DataGridViewTextBoxColumn multiplicacion;
    }
}