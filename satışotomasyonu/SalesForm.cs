using satışotomasyonu.satisotomaosyonuDataSet1TableAdapters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Sql;

namespace satışotomasyonu
{




    public partial class SalesForm : Form
    {



        public SalesForm()
        {

            InitializeComponent();
        }

        public static string konekşınstringi = "Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True";
        public static Random siparişno = new Random();
        public static int siparişnumarası = siparişno.Next(1485796, 555561659);


        public void button1_Click(object sender, EventArgs e)
        {



            SqlConnection cntcn = new SqlConnection(konekşınstringi);
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id ='12' ", cntcn);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            string ürünadi;
            string ücret;
            string kdv;
            ücret = read["mayısfiyat"].ToString();
            ürünadi = read["isim"].ToString();
            kdv = read["kdv"].ToString();
            int adet = Convert.ToInt32(numericUpDown2.Text);
            int maliyet = Convert.ToInt32(ücret) * Convert.ToInt32(adet);
            int hesaplana_kdv = (maliyet * Convert.ToInt32(kdv)) / 100;
            int kdvli_toplam = Convert.ToInt32(hesaplana_kdv) + maliyet;

            read.Close();


            if (Convert.ToInt32(numericUpDown2.Text) > 100)
            {
                MessageBox.Show("Maksimim 100 Adet alınabilir. ", "UYARI!!!");
                int yüz = 100;
                numericUpDown2.Text = yüz.ToString();
            }
            if (Convert.ToInt32(numericUpDown2.Text) == 0)
            {
                MessageBox.Show("Sıfırdan Farklı Sayı Seçiniz ", "UYARI!!!");

            }
            else
            {
                dataGridView1.Rows.Add(ürünadi, adet, maliyet, kdv, hesaplana_kdv, kdvli_toplam);



                SqlCommand komand1 = new SqlCommand("select id,adi,soyadi,mailadresi from Customers where mailadresi = @mailadresi", cntcn);
                komand1.Parameters.AddWithValue("@mailadresi", GlobalClass.mailadresi);
                SqlDataReader kullanıcıveriokuma = komand1.ExecuteReader();
                kullanıcıveriokuma.Read();
                int kullaniciid = Convert.ToInt32(kullanıcıveriokuma["id"].ToString());
                string kullaniciadi = kullanıcıveriokuma["adi"].ToString();
                string kullanicisoyadi = kullanıcıveriokuma["soyadi"].ToString();
                string mailadresi = kullanıcıveriokuma["mailadresi"].ToString();
                string faturaonayı_false = "false";
                kullanıcıveriokuma.Close();

                kullaniciadi = kullaniciadi.TrimEnd();
                kullanicisoyadi = kullanicisoyadi.TrimEnd();
                mailadresi = mailadresi.TrimEnd();



                SqlCommand komand2 = new SqlCommand($"INSERT INTO Orders (kullanıcıid ,kullanıcıad,kullanıcısoyadı,mailadresi,ürünid,ürünadı,adet,maliyet,kdvoranı,faturaonayı,sipariş_numarası,kdvtutarı,kdvlitoplamtutar) VALUES ('{kullaniciid}','{kullaniciadi}','{kullanicisoyadi}','{mailadresi}','12','{ürünadi}','{adet}','{maliyet}','{kdv}','{faturaonayı_false}','{siparişnumarası}','{hesaplana_kdv}','{kdvli_toplam}')", cntcn);

                komand2.ExecuteNonQuery();





            }






            int toplam = 0;
            int toplam1 = 0;
            int toplam2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            toplam_tutar.Text = toplam.ToString();
            for (int x = 0; x < dataGridView1.Rows.Count; ++x)
            {
                toplam1 += Convert.ToInt32(dataGridView1.Rows[x].Cells[5].Value);
            }
            kdvltoplam_tutar.Text = toplam1.ToString();
            for (int y = 0; y < dataGridView1.Rows.Count; ++y)
            {
                toplam2 += Convert.ToInt32(dataGridView1.Rows[y].Cells[4].Value);
            }
            toplam_kdv.Text = toplam2.ToString();


            kdvltoplam_tutar.Show();
            toplam_kdv.Show();
            toplam_tutar.Show();
            button_sepetionayla.Enabled = true;



        }

        private void MüşteriFormu_Load(object sender, EventArgs e)
        {
            GlobalClass.siparişnumarası = siparişnumarası;
            label37.Text = GlobalClass.Isim;
            kdvltoplam_tutar.Hide();
            toplam_kdv.Hide();
            toplam_tutar.Hide();
            button_sepetionayla.Enabled = false;


        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id ='13' ", cntcn);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            string ürünadi;
            string ücret;
            string kdv;
            ücret = read["mayısfiyat"].ToString();
            ürünadi = read["isim"].ToString();
            kdv = read["kdv"].ToString();
            int adet = int.Parse(numericUpDown3.Text);
            int maliyet = Convert.ToInt32(ücret) * adet;
            int hesaplana_kdv = (maliyet * Convert.ToInt32(kdv)) / 100;
            int kdvli_toplam = hesaplana_kdv + maliyet;
            read.Close();
            if (Convert.ToInt32(numericUpDown3.Text) > 100)
            {
                MessageBox.Show("Maksimim 100 Adet alınabilir. ", "UYARI!!!");
                int yüz = 100;
                numericUpDown3.Text = yüz.ToString();
            }
            if (Convert.ToInt32(numericUpDown3.Text) == 0)
            {
                MessageBox.Show("Sıfırdan Farklı Sayı Seçiniz ", "UYARI!!!");

            }
            else
            {
                dataGridView1.Rows.Add(ürünadi, adet, maliyet, kdv, hesaplana_kdv, kdvli_toplam);


                SqlCommand komand1 = new SqlCommand("select id,adi,soyadi,mailadresi from Customers where mailadresi = @mailadresi", cntcn);
                komand1.Parameters.AddWithValue("@mailadresi", GlobalClass.mailadresi);
                SqlDataReader kullanıcıveriokuma = komand1.ExecuteReader();
                kullanıcıveriokuma.Read();
                int kullaniciid = Convert.ToInt32(kullanıcıveriokuma["id"].ToString());
                string kullaniciadi = kullanıcıveriokuma["adi"].ToString();
                string kullanicisoyadi = kullanıcıveriokuma["soyadi"].ToString();
                string mailadresi = kullanıcıveriokuma["mailadresi"].ToString();
                string faturaonayı_false = "false";
                kullanıcıveriokuma.Close();

                kullaniciadi = kullaniciadi.TrimEnd();
                kullanicisoyadi = kullanicisoyadi.TrimEnd();
                mailadresi = mailadresi.TrimEnd();




                SqlCommand komand2 = new SqlCommand($"INSERT INTO Orders (kullanıcıid ,kullanıcıad,kullanıcısoyadı,mailadresi,ürünid,ürünadı,adet,maliyet,kdvoranı,faturaonayı,sipariş_numarası,kdvtutarı,kdvlitoplamtutar) VALUES ('{kullaniciid}','{kullaniciadi}','{kullanicisoyadi}','{mailadresi}','13','{ürünadi}','{adet}','{maliyet}','{kdv}','{faturaonayı_false}','{siparişnumarası}','{hesaplana_kdv}','{kdvli_toplam}')", cntcn);

                komand2.ExecuteNonQuery();



            }

            int toplam = 0;
            int toplam1 = 0;
            int toplam2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            toplam_tutar.Text = toplam.ToString();
            for (int x = 0; x < dataGridView1.Rows.Count; ++x)
            {
                toplam1 += Convert.ToInt32(dataGridView1.Rows[x].Cells[5].Value);
            }
            kdvltoplam_tutar.Text = toplam1.ToString();
            for (int y = 0; y < dataGridView1.Rows.Count; ++y)
            {
                toplam2 += Convert.ToInt32(dataGridView1.Rows[y].Cells[4].Value);
            }
            toplam_kdv.Text = toplam2.ToString();


            kdvltoplam_tutar.Show();
            toplam_kdv.Show();
            toplam_tutar.Show();
            button_sepetionayla.Enabled = true;








        }


        private void button4_Click(object sender, EventArgs e)
        {



            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id ='11' ", cntcn);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            string ürünadi;
            string ücret;
            string kdv;
            ücret = read["mayısfiyat"].ToString();
            ürünadi = read["isim"].ToString();
            kdv = read["kdv"].ToString();
            int adet = int.Parse(numericUpDown4.Text);
            int maliyet = Convert.ToInt32(ücret) * adet;
            int hesaplana_kdv = (maliyet * Convert.ToInt32(kdv)) / 100;
            int kdvli_toplam = hesaplana_kdv + maliyet;
            read.Close();
            if (Convert.ToInt32(numericUpDown4.Text) > 100)
            {
                MessageBox.Show("Maksimim 100 Adet alınabilir. ", "UYARI!!!");
                int yüz = 100;
                numericUpDown4.Text = yüz.ToString();
            }
            if (Convert.ToInt32(numericUpDown4.Text) == 0)
            {
                MessageBox.Show("Sıfırdan Farklı Sayı Seçiniz ", "UYARI!!!");

            }
            else
            {
                dataGridView1.Rows.Add(ürünadi, adet, maliyet, kdv, hesaplana_kdv, kdvli_toplam);

                SqlCommand komand1 = new SqlCommand("select id,adi,soyadi,mailadresi from Customers where mailadresi = @mailadresi", cntcn);
                komand1.Parameters.AddWithValue("@mailadresi", GlobalClass.mailadresi);
                SqlDataReader kullanıcıveriokuma = komand1.ExecuteReader();
                kullanıcıveriokuma.Read();
                int kullaniciid = Convert.ToInt32(kullanıcıveriokuma["id"].ToString());
                string kullaniciadi = kullanıcıveriokuma["adi"].ToString();
                string kullanicisoyadi = kullanıcıveriokuma["soyadi"].ToString();
                string mailadresi = kullanıcıveriokuma["mailadresi"].ToString();
                string faturaonayı_false = "false";
                kullanıcıveriokuma.Close();

                kullaniciadi = kullaniciadi.TrimEnd();
                kullanicisoyadi = kullanicisoyadi.TrimEnd();
                mailadresi = mailadresi.TrimEnd();



                SqlCommand komand2 = new SqlCommand($"INSERT INTO Orders (kullanıcıid ,kullanıcıad,kullanıcısoyadı,mailadresi,ürünid,ürünadı,adet,maliyet,kdvoranı,faturaonayı,sipariş_numarası,kdvtutarı,kdvlitoplamtutar) VALUES ('{kullaniciid}','{kullaniciadi}','{kullanicisoyadi}','{mailadresi}','11','{ürünadi}','{adet}','{maliyet}','{kdv}','{faturaonayı_false}','{siparişnumarası}','{hesaplana_kdv}','{kdvli_toplam}')", cntcn);

                komand2.ExecuteNonQuery();



            }

            int toplam = 0;
            int toplam1 = 0;
            int toplam2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            toplam_tutar.Text = toplam.ToString();
            for (int x = 0; x < dataGridView1.Rows.Count; ++x)
            {
                toplam1 += Convert.ToInt32(dataGridView1.Rows[x].Cells[5].Value);
            }
            kdvltoplam_tutar.Text = toplam1.ToString();
            for (int y = 0; y < dataGridView1.Rows.Count; ++y)
            {
                toplam2 += Convert.ToInt32(dataGridView1.Rows[y].Cells[4].Value);
            }
            toplam_kdv.Text = toplam2.ToString();


            kdvltoplam_tutar.Show();
            toplam_kdv.Show();
            toplam_tutar.Show();
            button_sepetionayla.Enabled = true;


        }

        private void button3_Click(object sender, EventArgs e)
        {


            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id ='14' ", cntcn);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            string ürünadi;
            string ücret;
            string kdv;
            ücret = read["mayısfiyat"].ToString();
            ürünadi = read["isim"].ToString();
            kdv = read["kdv"].ToString();
            int adet = int.Parse(numericUpDown5.Text);
            int maliyet = Convert.ToInt32(ücret) * adet;
            int hesaplana_kdv = (maliyet * Convert.ToInt32(kdv)) / 100;
            int kdvli_toplam = hesaplana_kdv + maliyet;
            read.Close();
            if (Convert.ToInt32(numericUpDown5.Text) > 100)
            {
                MessageBox.Show("Maksimim 100 Adet alınabilir. ", "UYARI!!!");
                int yüz = 100;
                numericUpDown5.Text = yüz.ToString();
            }
            if (Convert.ToInt32(numericUpDown5.Text) == 0)
            {
                MessageBox.Show("Sıfırdan Farklı Sayı Seçiniz ", "UYARI!!!");

            }
            else
            {
                dataGridView1.Rows.Add(ürünadi, adet, maliyet, kdv, hesaplana_kdv, kdvli_toplam);

                SqlCommand komand1 = new SqlCommand("select id,adi,soyadi,mailadresi from Customers where mailadresi = @mailadresi", cntcn);
                komand1.Parameters.AddWithValue("@mailadresi", GlobalClass.mailadresi);
                SqlDataReader kullanıcıveriokuma = komand1.ExecuteReader();
                kullanıcıveriokuma.Read();
                int kullaniciid = Convert.ToInt32(kullanıcıveriokuma["id"].ToString());
                string kullaniciadi = kullanıcıveriokuma["adi"].ToString();
                string kullanicisoyadi = kullanıcıveriokuma["soyadi"].ToString();
                string mailadresi = kullanıcıveriokuma["mailadresi"].ToString();
                string faturaonayı_false = "false";
                kullanıcıveriokuma.Close();

                kullaniciadi = kullaniciadi.TrimEnd();
                kullanicisoyadi = kullanicisoyadi.TrimEnd();
                mailadresi = mailadresi.TrimEnd();




                SqlCommand komand2 = new SqlCommand($"INSERT INTO Orders (kullanıcıid ,kullanıcıad,kullanıcısoyadı,mailadresi,ürünid,ürünadı,adet,maliyet,kdvoranı,faturaonayı,sipariş_numarası,kdvtutarı,kdvlitoplamtutar) VALUES ('{kullaniciid}','{kullaniciadi}','{kullanicisoyadi}','{mailadresi}','14','{ürünadi}','{adet}','{maliyet}','{kdv}','{faturaonayı_false}','{siparişnumarası}','{hesaplana_kdv}','{kdvli_toplam}')", cntcn);

                komand2.ExecuteNonQuery();


            }

            int toplam = 0;
            int toplam1 = 0;
            int toplam2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            toplam_tutar.Text = toplam.ToString();
            for (int x = 0; x < dataGridView1.Rows.Count; ++x)
            {
                toplam1 += Convert.ToInt32(dataGridView1.Rows[x].Cells[5].Value);
            }
            kdvltoplam_tutar.Text = toplam1.ToString();
            for (int y = 0; y < dataGridView1.Rows.Count; ++y)
            {
                toplam2 += Convert.ToInt32(dataGridView1.Rows[y].Cells[4].Value);
            }
            toplam_kdv.Text = toplam2.ToString();


            kdvltoplam_tutar.Show();
            toplam_kdv.Show();
            toplam_tutar.Show();
            button_sepetionayla.Enabled = true;


        }

        private void button5_Click(object sender, EventArgs e)
        {


            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id ='10' ", cntcn);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            string ürünadi;
            string ücret;
            string kdv;
            ücret = read["mayısfiyat"].ToString();
            ürünadi = read["isim"].ToString();
            kdv = read["kdv"].ToString();
            int adet = int.Parse(numericUpDown6.Text);
            int maliyet = Convert.ToInt32(ücret) * adet;
            int hesaplana_kdv = (maliyet * Convert.ToInt32(kdv)) / 100;
            int kdvli_toplam = hesaplana_kdv + maliyet;
            read.Close();
            if (Convert.ToInt32(numericUpDown6.Text) > 100)
            {
                MessageBox.Show("Maksimim 100 Adet alınabilir. ", "UYARI!!!");
                int yüz = 100;
                numericUpDown6.Text = yüz.ToString();
            }
            if (Convert.ToInt32(numericUpDown6.Text) == 0)
            {
                MessageBox.Show("Sıfırdan Farklı Sayı Seçiniz ", "UYARI!!!");

            }
            else
            {
                dataGridView1.Rows.Add(ürünadi, adet, maliyet, kdv, hesaplana_kdv, kdvli_toplam);
                SqlCommand komand1 = new SqlCommand("select id,adi,soyadi,mailadresi from Customers where mailadresi = @mailadresi", cntcn);
                komand1.Parameters.AddWithValue("@mailadresi", GlobalClass.mailadresi);
                SqlDataReader kullanıcıveriokuma = komand1.ExecuteReader();
                kullanıcıveriokuma.Read();
                int kullaniciid = Convert.ToInt32(kullanıcıveriokuma["id"].ToString());
                string kullaniciadi = kullanıcıveriokuma["adi"].ToString();
                string kullanicisoyadi = kullanıcıveriokuma["soyadi"].ToString();
                string mailadresi = kullanıcıveriokuma["mailadresi"].ToString();
                string faturaonayı_false = "false";
                kullanıcıveriokuma.Close();

                kullaniciadi = kullaniciadi.TrimEnd();
                kullanicisoyadi = kullanicisoyadi.TrimEnd();
                mailadresi = mailadresi.TrimEnd();




                SqlCommand komand2 = new SqlCommand($"INSERT INTO Orders (kullanıcıid ,kullanıcıad,kullanıcısoyadı,mailadresi,ürünid,ürünadı,adet,maliyet,kdvoranı,faturaonayı,sipariş_numarası,kdvtutarı,kdvlitoplamtutar) VALUES ('{kullaniciid}','{kullaniciadi}','{kullanicisoyadi}','{mailadresi}','10','{ürünadi}','{adet}','{maliyet}','{kdv}','{faturaonayı_false}','{siparişnumarası}','{hesaplana_kdv}','{kdvli_toplam}')", cntcn);

                komand2.ExecuteNonQuery();


            }


            int toplam = 0;
            int toplam1 = 0;
            int toplam2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            toplam_tutar.Text = toplam.ToString();
            for (int x = 0; x < dataGridView1.Rows.Count; ++x)
            {
                toplam1 += Convert.ToInt32(dataGridView1.Rows[x].Cells[5].Value);
            }
            kdvltoplam_tutar.Text = toplam1.ToString();
            for (int y = 0; y < dataGridView1.Rows.Count; ++y)
            {
                toplam2 += Convert.ToInt32(dataGridView1.Rows[y].Cells[4].Value);
            }
            toplam_kdv.Text = toplam2.ToString();


            kdvltoplam_tutar.Show();
            toplam_kdv.Show();
            toplam_tutar.Show();
            button_sepetionayla.Enabled = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {


            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id ='5' ", cntcn);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            string ürünadi;
            string ücret;
            string kdv;
            ücret = read["mayısfiyat"].ToString();
            ürünadi = read["isim"].ToString();
            kdv = read["kdv"].ToString();
            int adet = int.Parse(numericUpDown1.Text);
            int maliyet = Convert.ToInt32(ücret) * adet;
            int hesaplana_kdv = (maliyet * Convert.ToInt32(kdv)) / 100;
            int kdvli_toplam = hesaplana_kdv + maliyet;
            read.Close();
            if (Convert.ToInt32(numericUpDown1.Text) > 100)
            {
                MessageBox.Show("Maksimim 100 Adet alınabilir. ", "UYARI!!!");
                int yüz = 100;
                numericUpDown1.Text = yüz.ToString();
            }
            if (Convert.ToInt32(numericUpDown1.Text) == 0)
            {
                MessageBox.Show("Sıfırdan Farklı Sayı Seçiniz ", "UYARI!!!");

            }
            else
            {
                dataGridView1.Rows.Add(ürünadi, adet, maliyet, kdv, hesaplana_kdv, kdvli_toplam);
                SqlCommand komand1 = new SqlCommand("select id,adi,soyadi,mailadresi from Customers where mailadresi = @mailadresi", cntcn);
                komand1.Parameters.AddWithValue("@mailadresi", GlobalClass.mailadresi);
                SqlDataReader kullanıcıveriokuma = komand1.ExecuteReader();
                kullanıcıveriokuma.Read();
                int kullaniciid = Convert.ToInt32(kullanıcıveriokuma["id"].ToString());
                string kullaniciadi = kullanıcıveriokuma["adi"].ToString();
                string kullanicisoyadi = kullanıcıveriokuma["soyadi"].ToString();
                string mailadresi = kullanıcıveriokuma["mailadresi"].ToString();
                string faturaonayı_false = "false";
                kullanıcıveriokuma.Close();

                kullaniciadi = kullaniciadi.TrimEnd();
                kullanicisoyadi = kullanicisoyadi.TrimEnd();
                mailadresi = mailadresi.TrimEnd();




                SqlCommand komand2 = new SqlCommand($"INSERT INTO Orders (kullanıcıid ,kullanıcıad,kullanıcısoyadı,mailadresi,ürünid,ürünadı,adet,maliyet,kdvoranı,faturaonayı,sipariş_numarası,kdvtutarı,kdvlitoplamtutar) VALUES ('{kullaniciid}','{kullaniciadi}','{kullanicisoyadi}','{mailadresi}','5','{ürünadi}','{adet}','{maliyet}','{kdv}','{faturaonayı_false}','{siparişnumarası}','{hesaplana_kdv}','{kdvli_toplam}')", cntcn);

                komand2.ExecuteNonQuery();


            }


            int toplam = 0;
            int toplam1 = 0;
            int toplam2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            toplam_tutar.Text = toplam.ToString();
            for (int x = 0; x < dataGridView1.Rows.Count; ++x)
            {
                toplam1 += Convert.ToInt32(dataGridView1.Rows[x].Cells[5].Value);
            }
            kdvltoplam_tutar.Text = toplam1.ToString();
            for (int y = 0; y < dataGridView1.Rows.Count; ++y)
            {
                toplam2 += Convert.ToInt32(dataGridView1.Rows[y].Cells[4].Value);
            }
            toplam_kdv.Text = toplam2.ToString();


            kdvltoplam_tutar.Show();
            toplam_kdv.Show();
            toplam_tutar.Show();
            button_sepetionayla.Enabled = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {


            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id ='7' ", cntcn);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            string ürünadi;
            string ücret;
            string kdv;
            ücret = read["mayısfiyat"].ToString();
            ürünadi = read["isim"].ToString();
            kdv = read["kdv"].ToString();
            int adet = int.Parse(numericUpDown7.Text);
            int maliyet = Convert.ToInt32(ücret) * adet;
            int hesaplana_kdv = (maliyet * Convert.ToInt32(kdv)) / 100;
            int kdvli_toplam = hesaplana_kdv + maliyet;
            read.Close();
            if (Convert.ToInt32(numericUpDown7.Text) > 100)
            {
                MessageBox.Show("Maksimim 100 Adet alınabilir. ", "UYARI!!!");
                int yüz = 100;
                numericUpDown7.Text = yüz.ToString();
            }
            if (Convert.ToInt32(numericUpDown7.Text) == 0)
            {
                MessageBox.Show("Sıfırdan Farklı Sayı Seçiniz ", "UYARI!!!");

            }
            else
            {
                dataGridView1.Rows.Add(ürünadi, adet, maliyet, kdv, hesaplana_kdv, kdvli_toplam);
                SqlCommand komand1 = new SqlCommand("select id,adi,soyadi,mailadresi from Customers where mailadresi = @mailadresi", cntcn);
                komand1.Parameters.AddWithValue("@mailadresi",  GlobalClass.mailadresi);
                SqlDataReader kullanıcıveriokuma = komand1.ExecuteReader();
                kullanıcıveriokuma.Read();
                int kullaniciid = Convert.ToInt32(kullanıcıveriokuma["id"].ToString());
                string kullaniciadi = kullanıcıveriokuma["adi"].ToString();
                string kullanicisoyadi = kullanıcıveriokuma["soyadi"].ToString();
                string mailadresi = kullanıcıveriokuma["mailadresi"].ToString();
                string faturaonayı_false = "false";
                kullanıcıveriokuma.Close();

                kullaniciadi = kullaniciadi.TrimEnd();
                kullanicisoyadi = kullanicisoyadi.TrimEnd();
                mailadresi = mailadresi.TrimEnd();




                SqlCommand komand2 = new SqlCommand($"INSERT INTO Orders (kullanıcıid ,kullanıcıad,kullanıcısoyadı,mailadresi,ürünid,ürünadı,adet,maliyet,kdvoranı,faturaonayı,sipariş_numarası,kdvtutarı,kdvlitoplamtutar) VALUES ('{kullaniciid}','{kullaniciadi}','{kullanicisoyadi}','{mailadresi}','7','{ürünadi}','{adet}','{maliyet}','{kdv}','{faturaonayı_false}','{siparişnumarası}','{hesaplana_kdv}','{kdvli_toplam}')", cntcn);

                komand2.ExecuteNonQuery();


            }


            int toplam = 0;
            int toplam1 = 0;
            int toplam2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            toplam_tutar.Text = toplam.ToString();
            for (int x = 0; x < dataGridView1.Rows.Count; ++x)
            {
                toplam1 += Convert.ToInt32(dataGridView1.Rows[x].Cells[5].Value);
            }
            kdvltoplam_tutar.Text = toplam1.ToString();
            for (int y = 0; y < dataGridView1.Rows.Count; ++y)
            {
                toplam2 += Convert.ToInt32(dataGridView1.Rows[y].Cells[4].Value);
            }
            toplam_kdv.Text = toplam2.ToString();


            kdvltoplam_tutar.Show();
            toplam_kdv.Show();
            toplam_tutar.Show();
            button_sepetionayla.Enabled = true;

        }

        private void button10_Click(object sender, EventArgs e)
        {


            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id ='6' ", cntcn);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            string ürünadi;
            string ücret;
            string kdv;
            ücret = read["mayısfiyat"].ToString();
            ürünadi = read["isim"].ToString();
            kdv = read["kdv"].ToString();
            int adet = int.Parse(numericUpDown8.Text);
            int maliyet = Convert.ToInt32(ücret) * adet;
            int hesaplana_kdv = (maliyet * Convert.ToInt32(kdv)) / 100;
            int kdvli_toplam = hesaplana_kdv + maliyet;
            read.Close();
            if (Convert.ToInt32(numericUpDown8.Text) > 100)
            {
                MessageBox.Show("Maksimim 100 Adet alınabilir. ", "UYARI!!!");
                int yüz = 100;
                numericUpDown8.Text = yüz.ToString();
            }
            if (Convert.ToInt32(numericUpDown8.Text) == 0)
            {
                MessageBox.Show("Sıfırdan Farklı Sayı Seçiniz ", "UYARI!!!");

            }
            else
            {
                dataGridView1.Rows.Add(ürünadi, adet, maliyet, kdv, hesaplana_kdv, kdvli_toplam);
                SqlCommand komand1 = new SqlCommand("select id,adi,soyadi,mailadresi from Customers where mailadresi = @mailadresi", cntcn);
                komand1.Parameters.AddWithValue("@mailadresi", GlobalClass.mailadresi);
                SqlDataReader kullanıcıveriokuma = komand1.ExecuteReader();
                kullanıcıveriokuma.Read();
                int kullaniciid = Convert.ToInt32(kullanıcıveriokuma["id"].ToString());
                string kullaniciadi = kullanıcıveriokuma["adi"].ToString();
                string kullanicisoyadi = kullanıcıveriokuma["soyadi"].ToString();
                string mailadresi = kullanıcıveriokuma["mailadresi"].ToString();
                string faturaonayı_false = "false";
                kullanıcıveriokuma.Close();

                kullaniciadi = kullaniciadi.TrimEnd();
                kullanicisoyadi = kullanicisoyadi.TrimEnd();
                mailadresi = mailadresi.TrimEnd();




                SqlCommand komand2 = new SqlCommand($"INSERT INTO Orders (kullanıcıid ,kullanıcıad,kullanıcısoyadı,mailadresi,ürünid,ürünadı,adet,maliyet,kdvoranı,faturaonayı,sipariş_numarası,kdvtutarı,kdvlitoplamtutar) VALUES ('{kullaniciid}','{kullaniciadi}','{kullanicisoyadi}','{mailadresi}','6','{ürünadi}','{adet}','{maliyet}','{kdv}','{faturaonayı_false}','{siparişnumarası}','{hesaplana_kdv}','{kdvli_toplam}')", cntcn);

                komand2.ExecuteNonQuery();


            }

            int toplam = 0;
            int toplam1 = 0;
            int toplam2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            toplam_tutar.Text = toplam.ToString();
            for (int x = 0; x < dataGridView1.Rows.Count; ++x)
            {
                toplam1 += Convert.ToInt32(dataGridView1.Rows[x].Cells[5].Value);
            }
            kdvltoplam_tutar.Text = toplam1.ToString();
            for (int y = 0; y < dataGridView1.Rows.Count; ++y)
            {
                toplam2 += Convert.ToInt32(dataGridView1.Rows[y].Cells[4].Value);
            }
            toplam_kdv.Text = toplam2.ToString();


            kdvltoplam_tutar.Show();
            toplam_kdv.Show();
            toplam_tutar.Show();
            button_sepetionayla.Enabled = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {


            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id ='8' ", cntcn);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            string ürünadi;
            string ücret;
            string kdv;
            ücret = read["mayısfiyat"].ToString();
            ürünadi = read["isim"].ToString();
            kdv = read["kdv"].ToString();
            int adet = int.Parse(numericUpDown10.Text);
            int maliyet = Convert.ToInt32(ücret) * adet;
            int hesaplana_kdv = (maliyet * Convert.ToInt32(kdv)) / 100;
            int kdvli_toplam = hesaplana_kdv + maliyet;
            read.Close();
            if (Convert.ToInt32(numericUpDown10.Text) > 100)
            {
                MessageBox.Show("Maksimim 100 Adet alınabilir. ", "UYARI!!!");
                int yüz = 100;
                numericUpDown10.Text = yüz.ToString();
            }
            if (Convert.ToInt32(numericUpDown10.Text) == 0)
            {
                MessageBox.Show("Sıfırdan Farklı Sayı Seçiniz ", "UYARI!!!");

            }
            else
            {
                dataGridView1.Rows.Add(ürünadi, adet, maliyet, kdv, hesaplana_kdv, kdvli_toplam);

                SqlCommand komand1 = new SqlCommand("select id,adi,soyadi,mailadresi from Customers where mailadresi = @mailadresi", cntcn);
                komand1.Parameters.AddWithValue("@mailadresi", GlobalClass.mailadresi);
                SqlDataReader kullanıcıveriokuma = komand1.ExecuteReader();
                kullanıcıveriokuma.Read();
                int kullaniciid = Convert.ToInt32(kullanıcıveriokuma["id"].ToString());
                string kullaniciadi = kullanıcıveriokuma["adi"].ToString();
                string kullanicisoyadi = kullanıcıveriokuma["soyadi"].ToString();
                string mailadresi = kullanıcıveriokuma["mailadresi"].ToString();
                string faturaonayı_false = "false";
                kullanıcıveriokuma.Close();

                kullaniciadi = kullaniciadi.TrimEnd();
                kullanicisoyadi = kullanicisoyadi.TrimEnd();
                mailadresi = mailadresi.TrimEnd();





                SqlCommand komand2 = new SqlCommand($"INSERT INTO Orders (kullanıcıid ,kullanıcıad,kullanıcısoyadı,mailadresi,ürünid,ürünadı,adet,maliyet,kdvoranı,faturaonayı,sipariş_numarası,kdvtutarı,kdvlitoplamtutar) VALUES ('{kullaniciid}','{kullaniciadi}','{kullanicisoyadi}','{mailadresi}','8','{ürünadi}','{adet}','{maliyet}','{kdv}','{faturaonayı_false}','{siparişnumarası}','{hesaplana_kdv}','{kdvli_toplam}')", cntcn);

                komand2.ExecuteNonQuery();

            }



            int toplam = 0;
            int toplam1 = 0;
            int toplam2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            toplam_tutar.Text = toplam.ToString();
            for (int x = 0; x < dataGridView1.Rows.Count; ++x)
            {
                toplam1 += Convert.ToInt32(dataGridView1.Rows[x].Cells[5].Value);
            }
            kdvltoplam_tutar.Text = toplam1.ToString();
            for (int y = 0; y < dataGridView1.Rows.Count; ++y)
            {
                toplam2 += Convert.ToInt32(dataGridView1.Rows[y].Cells[4].Value);
            }
            toplam_kdv.Text = toplam2.ToString();

            kdvltoplam_tutar.Show();
            toplam_kdv.Show();
            toplam_tutar.Show();
            button_sepetionayla.Enabled = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {


            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id ='9' ", cntcn);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            string ürünadi;
            string ücret;
            string kdv;
            ücret = read["mayısfiyat"].ToString();
            ürünadi = read["isim"].ToString();
            kdv = read["kdv"].ToString();
            int adet = int.Parse(numericUpDown9.Text);
            int maliyet = Convert.ToInt32(ücret) * adet;
            int hesaplana_kdv = (maliyet * Convert.ToInt32(kdv)) / 100;
            int kdvli_toplam = hesaplana_kdv + maliyet;
            read.Close();
            if (Convert.ToInt32(numericUpDown9.Text) > 100)
            {
                MessageBox.Show("Maksimim 100 Adet alınabilir. ", "UYARI!!!");
                int yüz = 100;
                numericUpDown9.Text = yüz.ToString();
            }
            if (Convert.ToInt32(numericUpDown9.Text) == 0)
            {
                MessageBox.Show("Sıfırdan Farklı Sayı Seçiniz ", "UYARI!!!");

            }
            else
            {
                dataGridView1.Rows.Add(ürünadi, adet, maliyet, kdv, hesaplana_kdv, kdvli_toplam);

                SqlCommand komand1 = new SqlCommand("select id,adi,soyadi,mailadresi from Customers where mailadresi = @mailadresi", cntcn);
                komand1.Parameters.AddWithValue("@mailadresi", GlobalClass.mailadresi);
                SqlDataReader kullanıcıveriokuma = komand1.ExecuteReader();
                kullanıcıveriokuma.Read();
                int kullaniciid = Convert.ToInt32(kullanıcıveriokuma["id"].ToString());
                string kullaniciadi = kullanıcıveriokuma["adi"].ToString();
                string kullanicisoyadi = kullanıcıveriokuma["soyadi"].ToString();
                string mailadresi = kullanıcıveriokuma["mailadresi"].ToString();
                string faturaonayı_false = "false";
                kullanıcıveriokuma.Close();

                kullaniciadi = kullaniciadi.TrimEnd();
                kullanicisoyadi = kullanicisoyadi.TrimEnd();
                mailadresi = mailadresi.TrimEnd();




                SqlCommand komand2 = new SqlCommand($"INSERT INTO Orders (kullanıcıid ,kullanıcıad,kullanıcısoyadı,mailadresi,ürünid,ürünadı,adet,maliyet,kdvoranı,faturaonayı,sipariş_numarası,kdvtutarı,kdvlitoplamtutar) VALUES ('{kullaniciid}','{kullaniciadi}','{kullanicisoyadi}','{mailadresi}','9','{ürünadi}','{adet}','{maliyet}','{kdv}','{faturaonayı_false}','{siparişnumarası}','{hesaplana_kdv}','{kdvli_toplam}')", cntcn);

                komand2.ExecuteNonQuery();

            }


            int toplam = 0;
            int toplam1 = 0;
            int toplam2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            toplam_tutar.Text = toplam.ToString();
            for (int x = 0; x < dataGridView1.Rows.Count; ++x)
            {
                toplam1 += Convert.ToInt32(dataGridView1.Rows[x].Cells[5].Value);
            }
            kdvltoplam_tutar.Text = toplam1.ToString();
            for (int y = 0; y < dataGridView1.Rows.Count; ++y)
            {
                toplam2 += Convert.ToInt32(dataGridView1.Rows[y].Cells[4].Value);
            }
            toplam_kdv.Text = toplam2.ToString();

            kdvltoplam_tutar.Show();
            toplam_kdv.Show();
            toplam_tutar.Show();
            button_sepetionayla.Enabled = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {


            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id ='15' ", cntcn);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            string ürünadi;
            string ücret;
            string kdv;
            ücret = read["mayısfiyat"].ToString();
            ürünadi = read["isim"].ToString();
            kdv = read["kdv"].ToString();
            int adet = int.Parse(numericUpDown11.Text);
            int maliyet = Convert.ToInt32(ücret) * adet;
            int hesaplana_kdv = (maliyet * Convert.ToInt32(kdv)) / 100;
            int kdvli_toplam = hesaplana_kdv + maliyet;
            read.Close();
            if (Convert.ToInt32(numericUpDown11.Text) > 100)
            {
                MessageBox.Show("Maksimim 100 Adet alınabilir. ", "UYARI!!!");
                int yüz = 100;
                numericUpDown11.Text = yüz.ToString();
            }
            if (Convert.ToInt32(numericUpDown11.Text) == 0)
            {
                MessageBox.Show("Sıfırdan Farklı Sayı Seçiniz ", "UYARI!!!");

            }
            else
            {
                dataGridView1.Rows.Add(ürünadi, adet, maliyet, kdv, hesaplana_kdv, kdvli_toplam);
                SqlCommand komand1 = new SqlCommand("select id,adi,soyadi,mailadresi from Customers where mailadresi = @mailadresi", cntcn);
                komand1.Parameters.AddWithValue("@mailadresi",  GlobalClass.mailadresi);
                SqlDataReader kullanıcıveriokuma = komand1.ExecuteReader();
                kullanıcıveriokuma.Read();
                int kullaniciid = Convert.ToInt32(kullanıcıveriokuma["id"].ToString());
                string kullaniciadi = kullanıcıveriokuma["adi"].ToString();
                string kullanicisoyadi = kullanıcıveriokuma["soyadi"].ToString();
                string mailadresi = kullanıcıveriokuma["mailadresi"].ToString();
                string faturaonayı_false = "false";
                kullanıcıveriokuma.Close();

                kullaniciadi = kullaniciadi.TrimEnd();
                kullanicisoyadi = kullanicisoyadi.TrimEnd();
                mailadresi = mailadresi.TrimEnd();





                SqlCommand komand2 = new SqlCommand($"INSERT INTO Orders (kullanıcıid ,kullanıcıad,kullanıcısoyadı,mailadresi,ürünid,ürünadı,adet,maliyet,kdvoranı,faturaonayı,sipariş_numarası,kdvtutarı,kdvlitoplamtutar) VALUES ('{kullaniciid}','{kullaniciadi}','{kullanicisoyadi}','{mailadresi}','15','{ürünadi}','{adet}','{maliyet}','{kdv}','{faturaonayı_false}','{siparişnumarası}','{hesaplana_kdv}','{kdvli_toplam}')", cntcn);

                komand2.ExecuteNonQuery();


            }

            int toplam = 0;
            int toplam1 = 0;
            int toplam2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            toplam_tutar.Text = toplam.ToString();
            for (int x = 0; x < dataGridView1.Rows.Count; ++x)
            {
                toplam1 += Convert.ToInt32(dataGridView1.Rows[x].Cells[5].Value);
            }
            kdvltoplam_tutar.Text = toplam1.ToString();
            for (int y = 0; y < dataGridView1.Rows.Count; ++y)
            {
                toplam2 += Convert.ToInt32(dataGridView1.Rows[y].Cells[4].Value);
            }
            toplam_kdv.Text = toplam2.ToString();



            kdvltoplam_tutar.Show();
            toplam_kdv.Show();
            toplam_tutar.Show();
            button_sepetionayla.Enabled = true;

        }

        private void button12_Click(object sender, EventArgs e)
        {


            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id ='17' ", cntcn);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            string ürünadi;
            string ücret;
            string kdv;
            ücret = read["mayısfiyat"].ToString();
            ürünadi = read["isim"].ToString();
            kdv = read["kdv"].ToString();
            int adet = int.Parse(numericUpDown12.Text);
            int maliyet = Convert.ToInt32(ücret) * adet;
            int hesaplana_kdv = (maliyet * Convert.ToInt32(kdv)) / 100;
            int kdvli_toplam = hesaplana_kdv + maliyet;
            read.Close();
            if (Convert.ToInt32(numericUpDown12.Text) > 100)
            {
                MessageBox.Show("Maksimim 100 Adet alınabilir. ", "UYARI!!!");
                int yüz = 100;
                numericUpDown12.Text = yüz.ToString();
            }
            if (Convert.ToInt32(numericUpDown12.Text) == 0)
            {
                MessageBox.Show("Sıfırdan Farklı Sayı Seçiniz ", "UYARI!!!");

            }
            else
            {
                dataGridView1.Rows.Add(ürünadi, adet, maliyet, kdv, hesaplana_kdv, kdvli_toplam);
                SqlCommand komand1 = new SqlCommand("select id,adi,soyadi,mailadresi from Customers where mailadresi = @mailadresi", cntcn);
                komand1.Parameters.AddWithValue("@mailadresi", GlobalClass.mailadresi);
                SqlDataReader kullanıcıveriokuma = komand1.ExecuteReader();
                kullanıcıveriokuma.Read();
                int kullaniciid = Convert.ToInt32(kullanıcıveriokuma["id"].ToString());
                string kullaniciadi = kullanıcıveriokuma["adi"].ToString();
                string kullanicisoyadi = kullanıcıveriokuma["soyadi"].ToString();
                string mailadresi = kullanıcıveriokuma["mailadresi"].ToString();
                string faturaonayı_false = "false";
                kullanıcıveriokuma.Close();

                kullaniciadi = kullaniciadi.TrimEnd();
                kullanicisoyadi = kullanicisoyadi.TrimEnd();
                mailadresi = mailadresi.TrimEnd();




                SqlCommand komand2 = new SqlCommand($"INSERT INTO Orders (kullanıcıid ,kullanıcıad,kullanıcısoyadı,mailadresi,ürünid,ürünadı,adet,maliyet,kdvoranı,faturaonayı,sipariş_numarası,kdvtutarı,kdvlitoplamtutar) VALUES ('{kullaniciid}','{kullaniciadi}','{kullanicisoyadi}','{mailadresi}','17','{ürünadi}','{adet}','{maliyet}','{kdv}','{faturaonayı_false}','{siparişnumarası}','{hesaplana_kdv}','{kdvli_toplam}')", cntcn);

                komand2.ExecuteNonQuery();

            }

            int toplam = 0;
            int toplam1 = 0;
            int toplam2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            toplam_tutar.Text = toplam.ToString();
            for (int x = 0; x < dataGridView1.Rows.Count; ++x)
            {
                toplam1 += Convert.ToInt32(dataGridView1.Rows[x].Cells[5].Value);
            }
            kdvltoplam_tutar.Text = toplam1.ToString();
            for (int y = 0; y < dataGridView1.Rows.Count; ++y)
            {
                toplam2 += Convert.ToInt32(dataGridView1.Rows[y].Cells[4].Value);
            }
            toplam_kdv.Text = toplam2.ToString();


            kdvltoplam_tutar.Show();
            toplam_kdv.Show();
            toplam_tutar.Show();
            button_sepetionayla.Enabled = true;


        }

        private void button13_Click(object sender, EventArgs e)
        {


            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id ='16' ", cntcn);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            string ürünadi;
            string ücret;
            string kdv;
            ücret = read["mayısfiyat"].ToString();
            ürünadi = read["isim"].ToString();
            kdv = read["kdv"].ToString();
            int adet = int.Parse(numericUpDown13.Text);
            int maliyet = Convert.ToInt32(ücret) * adet;
            int hesaplana_kdv = (maliyet * Convert.ToInt32(kdv)) / 100;
            int kdvli_toplam = hesaplana_kdv + maliyet;
            read.Close();
            if (Convert.ToInt32(numericUpDown13.Text) > 100)
            {
                MessageBox.Show("Maksimim 100 Adet alınabilir. ", "UYARI!!!");
                int yüz = 100;
                numericUpDown13.Text = yüz.ToString();
            }
            if (Convert.ToInt32(numericUpDown13.Text) == 0)
            {
                MessageBox.Show("Sıfırdan Farklı Sayı Seçiniz ", "UYARI!!!");

            }
            else
            {
                dataGridView1.Rows.Add(ürünadi, adet, maliyet, kdv, kdvli_toplam);
                SqlCommand komand1 = new SqlCommand("select id,adi,soyadi,mailadresi from Customers where mailadresi = @mailadresi", cntcn);
                komand1.Parameters.AddWithValue("@mailadresi", GlobalClass.mailadresi);
                SqlDataReader kullanıcıveriokuma = komand1.ExecuteReader();
                kullanıcıveriokuma.Read();
                int kullaniciid = Convert.ToInt32(kullanıcıveriokuma["id"].ToString());
                string kullaniciadi = kullanıcıveriokuma["adi"].ToString();
                string kullanicisoyadi = kullanıcıveriokuma["soyadi"].ToString();
                string mailadresi = kullanıcıveriokuma["mailadresi"].ToString();
                string faturaonayı_false = "false";
                kullanıcıveriokuma.Close();

                kullaniciadi = kullaniciadi.TrimEnd();
                kullanicisoyadi = kullanicisoyadi.TrimEnd();
                mailadresi = mailadresi.TrimEnd();




                SqlCommand komand2 = new SqlCommand($"INSERT INTO Orders (kullanıcıid ,kullanıcıad,kullanıcısoyadı,mailadresi,ürünid,ürünadı,adet,maliyet,kdvoranı,faturaonayı,sipariş_numarası,kdvtutarı,kdvlitoplamtutar) VALUES ('{kullaniciid}','{kullaniciadi}','{kullanicisoyadi}','{mailadresi}','16','{ürünadi}','{adet}','{maliyet}','{kdv}','{faturaonayı_false}','{siparişnumarası}','{hesaplana_kdv}','{kdvli_toplam}')", cntcn);

                komand2.ExecuteNonQuery();

            }


            int toplam = 0;
            int toplam1 = 0;
            int toplam2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            toplam_tutar.Text = toplam.ToString();
            for (int x = 0; x < dataGridView1.Rows.Count; ++x)
            {
                toplam1 += Convert.ToInt32(dataGridView1.Rows[x].Cells[5].Value);
            }
            kdvltoplam_tutar.Text = toplam1.ToString();
            for (int y = 0; y < dataGridView1.Rows.Count; ++y)
            {
                toplam2 += Convert.ToInt32(dataGridView1.Rows[y].Cells[4].Value);
            }
            toplam_kdv.Text = toplam2.ToString();



            kdvltoplam_tutar.Show();
            toplam_kdv.Show();
            toplam_tutar.Show();
            button_sepetionayla.Enabled = true;

        }

        private void groupBox_ürünler_Enter(object sender, EventArgs e)
        {

        }


        private void button_sepettençıkar_Click(object sender, EventArgs e)
        {

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;
            numericUpDown11.Value = 0;
            numericUpDown12.Value = 0;
            numericUpDown13.Value = 0;
            dataGridView1.Rows.Clear();

            //dataGridView1.Rows[1].Index = 0;
            SqlConnection sqlconnection = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand sqlCommand = new SqlCommand($"delete Orders where sipariş_numarası='{siparişnumarası}'",sqlconnection);
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();
            







        }


        private void button_sepetionayla_Click(object sender, EventArgs e)
        {




            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Lütfen Ürün ekleyiniz");
            }
            else
            {


                GlobalClass.kdvtoplami = int.Parse(toplam_kdv.Text);
                GlobalClass.kdvlitoplami = int.Parse(kdvltoplam_tutar.Text);
                GlobalClass.maliyet = int.Parse(toplam_tutar.Text);

                Cardİnformation satışonayformu = new Cardİnformation();
                satışonayformu.ShowDialog();


                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
                numericUpDown4.Value = 0;
                numericUpDown5.Value = 0;
                numericUpDown6.Value = 0;
                numericUpDown7.Value = 0;
                numericUpDown8.Value = 0;
                numericUpDown9.Value = 0;
                numericUpDown10.Value = 0;
                numericUpDown11.Value = 0;
                numericUpDown12.Value = 0;
                numericUpDown13.Value = 0;


                
                //dataGridView1.Rows.Clear();




            }





        }

        private void groupBox_sepet_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }







        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void MüşteriFormu_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                DialogResult formukapatma = MessageBox.Show("Sepetinizdeki Products temizlenmiştir ?", "Uyarı", MessageBoxButtons.OK);
                if (formukapatma == DialogResult.OK)
                {
                    SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
                    cntcn.Open();
                    SqlCommand cemede = new SqlCommand($"delete Orders where sipariş_numarası='{siparişnumarası}' and sipariş_tarihi_saati is null", cntcn);
                    cemede.ExecuteNonQuery();

                 

                }
                else
                {
                    return;
                }
            }
            catch
            {
                return;
            }
            
        }

        private void MüşteriFormu_FormClosed(object sender, FormClosedEventArgs e)
        {

            

        }
    }










}
