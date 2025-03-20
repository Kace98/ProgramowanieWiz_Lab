using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_GridView
{
    public partial class Form2 : Form
    {
        private string imie;
        private string nazwisko;
        private
        private Form1 parentForm;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.parentForm = form1;

            comboBox1.Items.AddRange(new string[]
            {
                "Dyrektor",
                "Asystent",
                "Profesor",
                "Inżynier",
            });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_zatwierdz_Click(object sender, EventArgs e)
        {

        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show();
        }
    }
}
