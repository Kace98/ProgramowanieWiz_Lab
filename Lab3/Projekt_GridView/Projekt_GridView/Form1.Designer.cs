namespace Projekt_GridView
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
            dataGridView1 = new DataGridView();
            button_dodaj = new Button();
            button_usun = new Button();
            button_zapisz = new Button();
            button_wczytaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(594, 347);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button_dodaj
            // 
            button_dodaj.Location = new Point(623, 12);
            button_dodaj.Name = "button_dodaj";
            button_dodaj.Size = new Size(153, 23);
            button_dodaj.TabIndex = 1;
            button_dodaj.Text = "Dodaj";
            button_dodaj.UseVisualStyleBackColor = true;
            button_dodaj.Click += button_dodaj_Click;
            // 
            // button_usun
            // 
            button_usun.Location = new Point(623, 41);
            button_usun.Name = "button_usun";
            button_usun.Size = new Size(153, 23);
            button_usun.TabIndex = 2;
            button_usun.Text = "Usuń";
            button_usun.UseVisualStyleBackColor = true;
            button_usun.Click += button_usun_Click;
            // 
            // button_zapisz
            // 
            button_zapisz.Location = new Point(12, 378);
            button_zapisz.Name = "button_zapisz";
            button_zapisz.Size = new Size(294, 23);
            button_zapisz.TabIndex = 3;
            button_zapisz.Text = "Zapisz do csv";
            button_zapisz.UseVisualStyleBackColor = true;
            button_zapisz.Click += button_zapisz_Click;
            // 
            // button_wczytaj
            // 
            button_wczytaj.Location = new Point(312, 378);
            button_wczytaj.Name = "button_wczytaj";
            button_wczytaj.Size = new Size(294, 23);
            button_wczytaj.TabIndex = 5;
            button_wczytaj.Text = "Wczytaj z csv";
            button_wczytaj.UseVisualStyleBackColor = true;
            button_wczytaj.Click += button_wczytaj_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_wczytaj);
            Controls.Add(button_zapisz);
            Controls.Add(button_usun);
            Controls.Add(button_dodaj);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridView1;
        private Button button_dodaj;
        private Button button_usun;
        private Button button_zapisz;
        private Button button_wczytaj;
    }
}
