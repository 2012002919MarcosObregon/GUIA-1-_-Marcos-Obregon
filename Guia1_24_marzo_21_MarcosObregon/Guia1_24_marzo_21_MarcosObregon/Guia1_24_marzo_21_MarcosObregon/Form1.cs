namespace Guia1_24_marzo_21_MarcosObregon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);

            for (int cont = 0; cont < 11; cont++)
            {
                int multi;
                multi = num1 * cont;
                //agregar los datos en el DataGridView
                dataGridView1.Rows.Add(num1, cont, multi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 v2 = new Form2();
            v2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 v2 = new Form3();
            v2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 v2 = new Form4();
            v2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 v2 = new Form5();
            v2.ShowDialog();
        }
    }
}
