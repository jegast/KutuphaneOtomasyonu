using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kutuphane_Otomasyonu
{
    public partial class Form1 : Form
    {
        OleDbConnection baglanti;
        OleDbDataAdapter dataAdapter1;
        DataTable DataTable1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;data source=kitapdb.mdb");
            baglanti.Open();
            dataAdapter1 = new OleDbDataAdapter();
            DataTable1 = new DataTable();
            dataAdapter1.SelectCommand = baglanti.CreateCommand();
            dataAdapter1.SelectCommand.CommandText = "Select * from Kitaplar\n";
            dataAdapter1.SelectCommand.CommandText += "where BARKOD=0";
            DataTable1.Clear();
            dataAdapter1.Fill(DataTable1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekle_barkod.Text.Trim() == "") return;
            dataAdapter1.SelectCommand = baglanti.CreateCommand();
            dataAdapter1.SelectCommand.CommandText = "Select * from Kitaplar\n";
            dataAdapter1.SelectCommand.CommandText += "where Barkod=" + ekle_barkod.Text.Trim();
            DataTable1.Clear();
            dataAdapter1.Fill(DataTable1);
            if (DataTable1.Rows.Count > 0)
            {
                MessageBox.Show("Bu barkodu kullanan baska kitap var!");
                return;
            }

            dataAdapter1.InsertCommand = baglanti.CreateCommand();
            dataAdapter1.InsertCommand.CommandText = "insert into Kitaplar (BARKOD, Kitap_adi, Yayinevi, Yazar, Basimtarihi, Kategori) values (?,?,?,?,?,?)";

            dataAdapter1.InsertCommand.Parameters.Add("barkod", OleDbType.Numeric, 13, "BARKOD");
            dataAdapter1.InsertCommand.Parameters.Add("kitap_adi", OleDbType.Char, 50, "Kitap_adi");
            dataAdapter1.InsertCommand.Parameters.Add("yayinevi", OleDbType.Char, 50, "Yayinevi");
            dataAdapter1.InsertCommand.Parameters.Add("yazar", OleDbType.Char, 50, "Yazar");
            dataAdapter1.InsertCommand.Parameters.Add("basimtarihi", OleDbType.Char, 50, "Basimtarihi");
            dataAdapter1.InsertCommand.Parameters.Add("kategori", OleDbType.Char, 50, "Kategori");

            DataRow yeni = DataTable1.NewRow();
            
            yeni[0] = ekle_barkod.Text;
            yeni[1] = ekle_kitap_adi.Text;
            yeni[2] = ekle_yayinevi.Text;
            yeni[3] = ekle_yazar.Text;
            yeni[4] = ekle_basimtarihi.Text;
            yeni[5] = ekle_kategori.Text;

            DataTable1.Rows.Add(yeni);

            dataAdapter1.Update(DataTable1);
            DataTable1.AcceptChanges();
            MessageBox.Show("Kitap Arşive Eklendi!");
        }


        private void Sil_Barkod_getir_Click(object sender, EventArgs e)
        {
            if (sil_barkod.Text.Trim() == "") return;
            dataAdapter1.SelectCommand = baglanti.CreateCommand();
            dataAdapter1.SelectCommand.CommandText = "Select * from Kitaplar\n";
            dataAdapter1.SelectCommand.CommandText += "where BARKOD=" + sil_barkod.Text.Trim();
            DataTable1.Clear();
            dataAdapter1.Fill(DataTable1);
            if (DataTable1.Rows.Count > 0)
            {
                DataRow silinecek_veri = DataTable1.Rows[0];
                sil_kitap_adi.Text = silinecek_veri[1].ToString();
                sil_yayinevi.Text = silinecek_veri[2].ToString();
                sil_yazar.Text = silinecek_veri[3].ToString();
                sil_basimtarihi.Text = silinecek_veri[4].ToString();
                sil_kategori.Text = silinecek_veri[5].ToString();
                sil.Enabled = true;
            } else
                MessageBox.Show("Kayit Bulunamadi!");
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (DataTable1.Rows.Count == 0) return;
            DataRow silinecek_veri = DataTable1.Rows[0];
            dataAdapter1.DeleteCommand = baglanti.CreateCommand();
            dataAdapter1.DeleteCommand.CommandText = "delete from Kitaplar where BARKOD=" + silinecek_veri[0].ToString().Trim();

            silinecek_veri.Delete();

            dataAdapter1.Update(DataTable1);
            DataTable1.AcceptChanges();
            MessageBox.Show("Kayit Silindi!");
        }

        private void Duzenle_barkod_getir_Click(object sender, EventArgs e)
        {
            if (duzenle_barkod.Text.Trim() == "") return;
            dataAdapter1.SelectCommand = baglanti.CreateCommand();
            dataAdapter1.SelectCommand.CommandText = "Select * from Kitaplar\n";
            dataAdapter1.SelectCommand.CommandText += "where BARKOD=" + duzenle_barkod.Text.Trim();
            DataTable1.Clear();
            dataAdapter1.Fill(DataTable1);
            if (DataTable1.Rows.Count > 0)
            {
                DataRow duzenlenecek_veri = DataTable1.Rows[0];
                duzenle_kitap_adi.Text = duzenlenecek_veri[1].ToString();
                duzenle_yayinevi.Text = duzenlenecek_veri[2].ToString();
                duzenle_yazar.Text = duzenlenecek_veri[3].ToString();
                duzenle_basimtarihi.Text = duzenlenecek_veri[4].ToString();
                duzenle_kategori.Text = duzenlenecek_veri[5].ToString();
                duzenle.Enabled = true;
            }
            else
                MessageBox.Show("Kayit Bulunamadi!");
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            if (DataTable1.Rows.Count == 0) return;
            DataRow duzenlenecek_veri = DataTable1.Rows[0];
            dataAdapter1.UpdateCommand = baglanti.CreateCommand();
            dataAdapter1.UpdateCommand.CommandText = "update Kitaplar set Kitap_adi=?, Yayinevi=?, Yazar=?, Basimtarihi=?, Kategori=? where BARKOD=" + duzenle_barkod.Text.Trim();

            dataAdapter1.UpdateCommand.Parameters.Add("kitap_adi", OleDbType.Char, 50, "Kitap_adi");
            dataAdapter1.UpdateCommand.Parameters.Add("yayinevi", OleDbType.Char, 50, "Yayinevi");
            dataAdapter1.UpdateCommand.Parameters.Add("yazar", OleDbType.Char, 50, "Yazar");
            dataAdapter1.UpdateCommand.Parameters.Add("basimtarihi", OleDbType.Char, 50, "Basimtarihi");
            dataAdapter1.UpdateCommand.Parameters.Add("kategori", OleDbType.Char, 50, "Kategori");

            duzenlenecek_veri.BeginEdit();
            duzenlenecek_veri["kitap_adi"] = duzenle_kitap_adi .Text;
            duzenlenecek_veri["yayinevi"] = duzenle_yayinevi.Text;
            duzenlenecek_veri["yazar"] = duzenle_yazar.Text;
            duzenlenecek_veri["basimtarihi"] = duzenle_basimtarihi.Text;
            duzenlenecek_veri["kategori"] = duzenle_kategori.Text;
            duzenlenecek_veri.EndEdit();

            dataAdapter1.Update(DataTable1);
            DataTable1.AcceptChanges();
            MessageBox.Show("Kayit Düzenlendi!");
        }

        private void sil_isim_getir_Click(object sender, EventArgs e)
        {
            if (sil_kitap_adi.Text.Trim() == "") return;
            dataAdapter1.SelectCommand = baglanti.CreateCommand();
            dataAdapter1.SelectCommand.CommandText = "Select * from Kitaplar\n";
            dataAdapter1.SelectCommand.CommandText += "where Kitap_adi like '%" + duzenle_kitap_adi.Text + "%'";
            DataTable1.Clear();
            dataAdapter1.Fill(DataTable1);
            if (DataTable1.Rows.Count > 0)
            {
                DataRow silinecek_veri = DataTable1.Rows[0];
                sil_kitap_adi.Text = silinecek_veri[1].ToString();
                sil_yayinevi.Text = silinecek_veri[2].ToString();
                sil_yazar.Text = silinecek_veri[3].ToString();
                sil_basimtarihi.Text = silinecek_veri[4].ToString();
                sil_kategori.Text = silinecek_veri[5].ToString();
                sil.Enabled = true;
            }
            else
                MessageBox.Show("Kayit Bulunamadi!");
        }

        private void Duzenle_isim_getir_Click(object sender, EventArgs e)
        {
            if (duzenle_kitap_adi.Text.Trim() == "") return;
            dataAdapter1.SelectCommand = baglanti.CreateCommand();
            dataAdapter1.SelectCommand.CommandText = "Select * from Kitaplar\n";
            dataAdapter1.SelectCommand.CommandText += "where Kitap_adi like '%" + duzenle_kitap_adi.Text + "%'";
            DataTable1.Clear();
            dataAdapter1.Fill(DataTable1);
            if (DataTable1.Rows.Count > 0)
            {
                DataRow duzenlenecek_veri = DataTable1.Rows[0];
                duzenle_barkod.Text = duzenlenecek_veri[0].ToString();
                duzenle_kitap_adi.Text = duzenlenecek_veri[1].ToString();
                duzenle_yayinevi.Text = duzenlenecek_veri[2].ToString();
                duzenle_yazar.Text = duzenlenecek_veri[3].ToString();
                duzenle_basimtarihi.Text = duzenlenecek_veri[4].ToString();
                duzenle_kategori.Text = duzenlenecek_veri[5].ToString();
                duzenle.Enabled = true;
            }
            else
                MessageBox.Show("Kayit Bulunamadi!");
        }

        private void sonraki_Click(object sender, EventArgs e)
        {

        }

    }
}
