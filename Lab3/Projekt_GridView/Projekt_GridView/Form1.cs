namespace Projekt_GridView
{
    public partial class Form1 : Form
    {
        public int id = 1;
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();

        }

        private void InitializeDataGridView()
        {

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Imiê";
            dataGridView1.Columns[2].Name = "Nazwisko";
            dataGridView1.Columns[3].Name = "Wiek";
            dataGridView1.Columns[4].Name = "Stanowisko";

            dataGridView1.Columns[0].ValueType = typeof(int);
            dataGridView1.Columns[1].ValueType = typeof(string);
            dataGridView1.Columns[2].ValueType = typeof(string);
            dataGridView1.Columns[3].ValueType = typeof(int);
            dataGridView1.Columns[4].ValueType = typeof(string);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void button_usun_Click(object sender, EventArgs e)
        {

        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {

        }

        private void button_wczytaj_Click(object sender, EventArgs e)
        {

        }
    }
}
