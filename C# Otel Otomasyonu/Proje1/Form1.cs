using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
            
        {    

            tablo.Columns.Add("Ad");
            tablo.Columns.Add("Soyad");
            tablo.Columns.Add("Cinsiyet");
            tablo.Columns.Add("Oda No");
            tablo.Columns.Add("TC Kimlik No/Passport No");
            tablo.Columns.Add("Cep Telefon");
            tablo.Columns.Add("Doğum Tarih");
            tablo.Columns.Add("Geliş");
            tablo.Columns.Add("Çıkış");
            dataGridView1.DataSource = tablo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dogumTarihh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gelis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cikis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(isim.Text, soyadı.Text, cins.Text, oda.Text, kimlikno.Text, telefon.Text, dogumTarihh.Text, gelis.Text, cikis.Text);
            dataGridView1.DataSource = tablo;

         
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lütfen silenecek veriyi seçiniz.");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }
    }
}
