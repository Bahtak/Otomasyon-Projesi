using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;



namespace satışotomasyonu
{
    public partial class AuthorizedMainForm : Form
    {
        public AuthorizedMainForm()
        {
            InitializeComponent();


        }

        private void button_silmedemirleri_Click(object sender, EventArgs e)
        {

            AuthorizedForm yetkilideğergünceleme = new AuthorizedForm();
            yetkilideğergünceleme.Silmedemirleribilgileri();
            yetkilideğergünceleme.ShowDialog();
           
            
        }

        private void button_lamademirleri_Click(object sender, EventArgs e)
        {
            AuthorizedForm yetkiliformu = new AuthorizedForm();
            yetkiliformu.lamademirleri();
            yetkiliformu.ShowDialog();

        }

        private void button_tprofildemirleri_Click(object sender, EventArgs e)
        {
            AuthorizedForm yetkiliformu = new AuthorizedForm();
            yetkiliformu.T_profil_Demirleri();
            yetkiliformu.ShowDialog();


        }

        private void button_karedoludemirler_Click(object sender, EventArgs e)
        {
            AuthorizedForm yetkiliformu = new AuthorizedForm();
            yetkiliformu.Kare_dolu_demirler();
            yetkiliformu.ShowDialog();

        }

        private void button_inşaatdemirleri_Click(object sender, EventArgs e)
        {
            AuthorizedForm yetkiliformu = new AuthorizedForm();
            yetkiliformu.İnşaat_demirleri();
            yetkiliformu.ShowDialog();

        }

        private void button_üçgenvida_Click(object sender, EventArgs e)
        {
            AuthorizedForm yetkiliformu = new AuthorizedForm();
            yetkiliformu.Üçgen_vida_demirleri();
            yetkiliformu.ShowDialog();
        }

        private void button_yuvarlakvida_Click(object sender, EventArgs e)
        {
            AuthorizedForm yetkiliformu = new AuthorizedForm();
            yetkiliformu.Yuvarlak_vida();
            yetkiliformu.ShowDialog();

        }

        private void button_trapezvida_Click(object sender, EventArgs e)
        {
            AuthorizedForm yetkiliformu = new AuthorizedForm();
            yetkiliformu.Trapez_vida();
            yetkiliformu.ShowDialog();

        }

        private void button_karevida_Click(object sender, EventArgs e)
        {
            AuthorizedForm yetkiliformu = new AuthorizedForm();
            yetkiliformu.Kare_vida();
            yetkiliformu.ShowDialog();

        }

        private void button_testerevida_Click(object sender, EventArgs e)
        {
            AuthorizedForm yetkiliformu = new AuthorizedForm();
            yetkiliformu.Testere_vida();
            yetkiliformu.ShowDialog();

        }

        private void button_tunç_Click(object sender, EventArgs e)
        {
            AuthorizedForm yetkiliformu = new AuthorizedForm();
            yetkiliformu.Tunç();
            yetkiliformu.ShowDialog();

        }

        private void button_pirinç_Click(object sender, EventArgs e)
        {
            AuthorizedForm yetkiliformu = new AuthorizedForm();
            yetkiliformu.Pirinç();
            yetkiliformu.ShowDialog();

        }

        private void button_lehim_Click(object sender, EventArgs e)
        {
            AuthorizedForm yetkiliformu = new AuthorizedForm();
            yetkiliformu.Lehim();
            yetkiliformu.ShowDialog();

        }

        private void groupBox_kategoriler_Enter(object sender, EventArgs e)
        {

        }

        private void yetkiliformu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'satisotomaosyonuDataSet5.Waiting_Orders' table. You can move, or remove it, as needed.
            this.waiting_OrdersTableAdapter.Fill(this.satisotomaosyonuDataSet5.Waiting_Orders);
     


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "true" || dataGridView1.CurrentRow.Cells[4].Value.ToString() == "false")
            {
                MessageBox.Show("Bir fatura 2 kez sonuçlandırılamaz", "Uyarı");
            }
            else
            {
                string deger = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string mailadresi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string isiminiz = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string soyisiminiz = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                SqlConnection sqlConnection = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"update Orders set mail_gönderim_durumu='true'  where sipariş_numarası='{deger}'", sqlConnection);
                SqlCommand sqlCommand2 = new SqlCommand($"update Waiting_Orders set onaydurumu='true'  where siparişnumarasi='{deger}'", sqlConnection);

                sqlCommand.ExecuteNonQuery();
                sqlCommand2.ExecuteNonQuery();
                sqlConnection.Close();
                MailMessage mailmesaj = new MailMessage();
                SmtpClient istemci = new SmtpClient()
                {
                    Credentials = new System.Net.NetworkCredential("cdogrulama@gmail.com", "eznsimizmnjlyjmq"),
                    Port = 587,
                    Host = "smtp.gmail.com",
                    EnableSsl = true
                };

                mailmesaj.To.Add($"{mailadresi}");
                mailmesaj.From = new MailAddress($"{mailadresi}");
                mailmesaj.Subject = ("Alışveriş tammalandı ");
                string attachmentPath = $@"C:\Users\Yusuf\OneDrive\Masaüstü\SatışOtomasyonuGönderilenFaturalar\{deger}.pdf";
                mailmesaj.Attachments.Add(new Attachment(attachmentPath));
                isiminiz = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(isiminiz);
                soyisiminiz = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(soyisiminiz);
                mailmesaj.Body = $"Sayın {isiminiz.Trim()} {soyisiminiz.Trim()} siparişiniz onaylanmıştır faturanız ekte'dir";

                try
                {
                    istemci.Send(mailmesaj);
                    MessageBox.Show("Fatura Müşteriye gönderildi\nLütfen değişikleri için yeniden başlatınız", "İşlem onaylandı");

                }
                catch
                {
                    MessageBox.Show("Onay Kodu Gönderilemedi");
                }


            }
        



        }

        private void onay_Click(object sender, EventArgs e)
        {
            string deger = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            AuthorizedSalesForm yetkilisatışonayformu = new AuthorizedSalesForm();

            using (SqlConnection connection = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"select * from Orders where sipariş_numarası='{deger}'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {



                            string kullaniciid = reader["kullanıcıid"].ToString();
                            string kullanıcıad = reader["kullanıcıad"].ToString();
                            string kullanıcısoyadı = reader["kullanıcısoyadı"].ToString();
                            string mailadres = reader["mailadresi"].ToString();
                            string alışverişid = reader["alışverişid"].ToString();
                            string ürünid  = reader["ürünid"].ToString();
                            string ürünadı = reader["ürünadı"].ToString();
                            string adet = reader["adet"].ToString();
                            string maliyet = reader["maliyet"].ToString();
                            string kdvoranı = reader["kdvoranı"].ToString();
                            string kdvtutarı = reader["kdvtutarı"].ToString();
                            string kdvlitoplamtutar = reader["kdvlitoplamtutar"].ToString();
                            string faturaonayı = reader["faturaonayı"].ToString();
                            string sipariş_numarası = deger;
                            string sipariş_tarihi_saati = reader["sipariş_tarihi_saati"].ToString();
                            string mail_gönderme_durumu = reader["mail_gönderim_durumu"].ToString();












                            yetkilisatışonayformu.yetkilionaydatagridview.Rows.Add(kullaniciid,kullanıcıad,kullanıcısoyadı,mailadres,alışverişid,ürünid,ürünadı,adet,maliyet,kdvoranı,kdvtutarı,kdvlitoplamtutar,faturaonayı,sipariş_numarası,sipariş_tarihi_saati,mail_gönderme_durumu);






                        }
                    }
                }
            }












            yetkilisatışonayformu.ShowDialog();

        }

        private void ürünpdfgörüntüle_Click(object sender, EventArgs e)
        {

            string deger = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //Process.Start($"C:\\Users\\Yusuf\\OneDrive\\Masaüstü\\SatışOtomasyonuGönderilenFaturalar\\{deger}.pdf");


            try
            {
                Process.Start($"C:\\Users\\Yusuf\\OneDrive\\Masaüstü\\SatışOtomasyonuGönderilenFaturalar\\{deger}.pdf");

            }
            catch
            {
                MessageBox.Show("Dosya Silinmiş","Fatura Görüntülenemiyor");
            }

        }

        private void reddet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "true" || dataGridView1.CurrentRow.Cells[4].Value.ToString() == "false")
            {
                MessageBox.Show("Bir fatura 2 kez sonuçlandırılamaz", "Uyarı");


            }
            else
            {
                string deger = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string mailadresi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string isiminiz = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string soyisiminiz = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                SqlConnection sqlConnection = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"update Orders set mail_gönderim_durumu='false'  where sipariş_numarası='{deger}'", sqlConnection);
                SqlCommand sqlCommand2 = new SqlCommand($"update Waiting_Orders set onaydurumu='false'  where siparişnumarasi='{deger}'", sqlConnection);

                sqlCommand.ExecuteNonQuery();
                sqlCommand2.ExecuteNonQuery();
                sqlConnection.Close();
                MailMessage mailmesaj = new MailMessage();
                SmtpClient istemci = new SmtpClient()
                {
                    Credentials = new System.Net.NetworkCredential("cdogrulama@gmail.com", "eznsimizmnjlyjmq"),
                    Port = 587,
                    Host = "smtp.gmail.com",
                    EnableSsl = true
                };

                mailmesaj.To.Add($"{mailadresi}");
                mailmesaj.From = new MailAddress($"{mailadresi}");
                mailmesaj.Subject = ("Alışveriş Reddedildi ");

                isiminiz = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(isiminiz);
                soyisiminiz = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(soyisiminiz);
                mailmesaj.Body = $"Sayın {isiminiz.Trim()} {soyisiminiz.Trim()} siparişiniz onaylanmamıştır lütfen iletişime geçiniz ";

                try
                {
                    istemci.Send(mailmesaj);
                    MessageBox.Show("Alışveriş Reddedildi\nLütfen değişikleri için yeniden başlatınız", "İşlem Tamamlandı");

                }
                catch
                {
                    MessageBox.Show("Bağlantı Hatası");
                }

            }
        

        }
    }
   
}
