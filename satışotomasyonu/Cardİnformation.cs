using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using iTextSharp.text;
using iTextSharp;
using iTextSharp.text.pdf;
using System.Runtime.InteropServices;
using System.Globalization;
using iTextSharp.text.pdf.security;
using System.Drawing.Printing;



namespace satışotomasyonu
{
    public partial class Cardİnformation : Form
    {
    
        public Cardİnformation()
        {

       

            InitializeComponent();


        

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

    
        string mailadresi2 = GlobalClass.mailadresi.ToString();

        public static Random rndm = new Random();
        public int onay = rndm.Next(100000, 999999);
        string isiminiz;
        string soyisiminiz;

        private void button2_Click(object sender, EventArgs e)
        {

      


            if (String.IsNullOrEmpty(textBox_katuzerindekisim.Text))
            {
                MessageBox.Show("İsim alanı boş bırakılmaz","Uyarı");

            }
            else if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("CCv alanı boş bırakılmaz", "Uyarı");
            }
            else if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Son kullanım Yılı boş bırakılmaz", "Uyarı");
            }
            else if (String.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Son kullanım Ayı boş bırakılmaz", "Uyarı");
            }

            else if (Convert.ToInt32(textBox6.Text) > 12)
            {
                textBox6.Text = null;
                MessageBox.Show("Kart son kullanım Ayı  12'den büyük olamaz");
            }
            else if (Convert.ToInt32(textBox6.Text) < 0)
            {
                textBox6.Text = 1.ToString();
            }
            else if (Convert.ToInt32(textBox5.Text) < 2024)
            {
                textBox5.Text = 2025.ToString();
                MessageBox.Show("Son kullanım kodu 2024'den küçük olamaz");
            }
          
            else if (Convert.ToInt32(textBox5.Text) > 2035)
            {
                textBox5.Text = 2035.ToString();
                MessageBox.Show("Kart son kullanım yılı 2035'den büyük olamaz");

            }
            else
            {


                textBox0.Show();
                label0.Show();
                button0.Show();

               

                SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
                cntcn.Open();
                SqlCommand cmd = new SqlCommand("select * from Customers where mailadresi=@mail", cntcn);
                cmd.Parameters.AddWithValue("@mail", mailadresi2);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    isiminiz = read["adi"].ToString();
                    soyisiminiz = read["soyadi"].ToString();
                }
              



                MailMessage mailmesaj = new MailMessage();
                SmtpClient istemci = new SmtpClient()
                {
                    Credentials = new System.Net.NetworkCredential("cdogrulama@gmail.com", "eznsimizmnjlyjmq"),
                    Port = 587,
                    Host = "smtp.gmail.com",
                    EnableSsl = true
                };

                mailmesaj.To.Add($"{mailadresi2}");
                mailmesaj.From = new MailAddress($"{mailadresi2}");
                mailmesaj.Subject = ("Alışveriş tanımlama ");
                isiminiz = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(isiminiz);
                soyisiminiz = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(soyisiminiz);
                mailmesaj.Body = $"Sayın {isiminiz.Trim()} {soyisiminiz.Trim()} Alışveriş Onay kodunuz: {onay}";

                try
                {
                    istemci.Send(mailmesaj);

                }
                catch
                {
                    MessageBox.Show("Onay Kodu Gönderilemedi");
                }
                
             










            }



        }

        public void satışonayformu_Load(object sender, EventArgs e)
        {

      

            label0.Hide();
            textBox0.Hide();
            button0.Hide();

           

        }
    



        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox0.Text == onay.ToString())
            {




                string sipariştarihi = DateTime.Now.ToString();

                SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
                cntcn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE Orders set faturaonayı='true',sipariş_tarihi_saati='{sipariştarihi}' where sipariş_numarası={GlobalClass.siparişnumarası}", cntcn);
                cmd.ExecuteNonQuery();
                cntcn.Close();



                iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(STF_Helvetica_Turkish, 7, iTextSharp.text.Font.NORMAL);



                SqlConnection connection = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
                SqlCommand cemend = new SqlCommand($"select ürünid,ürünadı,adet,maliyet,kdvtutarı,kdvlitoplamtutar,sipariş_numarası,kdvoranı,kullanıcıad,kullanıcısoyadı,mailadresi from Orders where sipariş_numarası = '{GlobalClass.siparişnumarası}'",connection);

                connection.Open();
                SqlDataReader reader = cemend.ExecuteReader();

                //string filepatch = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ($@"\{ad.siparişnumarası}.pdf");
                string filepatch = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\SatışOtomasyonuGönderilenFaturalar" + ($@"\{GlobalClass.siparişnumarası}.pdf");
                Document doc = new iTextSharp.text.Document(PageSize.A4,5,5,50,5);
                PdfWriter.GetInstance(doc, new FileStream(filepatch, FileMode.Create));
                doc.Open();
                doc.AddCreator("Satış Otomasyonu");
                doc.AddTitle("E-Alışveriş Faturası");
                doc.AddSubject("Sipariş Numaranıza oluşturulan faturanız kaydedilmiştir");


                PdfPTable padftable2 = new PdfPTable(6);

                padftable2.AddCell(new iTextSharp.text.Paragraph("Ürün Adı", fontTitle));
                padftable2.AddCell(new iTextSharp.text.Paragraph("Adet", fontTitle));
                padftable2.AddCell(new iTextSharp.text.Paragraph("Kdv Oranı", fontTitle));
                padftable2.AddCell(new iTextSharp.text.Paragraph("Maliyet", fontTitle));
                padftable2.AddCell(new iTextSharp.text.Paragraph("Kdv Tutarı", fontTitle));
                padftable2.AddCell(new iTextSharp.text.Paragraph("Kdv Dahil Toplam Tutar", fontTitle));


                PdfPTable pdfPTable = new PdfPTable(6);
                while (reader.Read())
                {
                    string ürünadı = reader["ürünadı"].ToString();
                    string adet = reader["adet"].ToString();
                    string maliyet = reader["maliyet"].ToString();
                    string kdvtutarı = reader["kdvtutarı"].ToString();
                    string kdvdahiltoplamtutar = reader["kdvlitoplamtutar"].ToString();
                    string siparişnumarası = reader["sipariş_numarası"].ToString();
                    string kdvoranı = reader["kdvoranı"].ToString();



                    pdfPTable.AddCell(new iTextSharp.text.Paragraph(ürünadı, fontTitle));
                    pdfPTable.AddCell(new iTextSharp.text.Paragraph(adet, fontTitle));
                    pdfPTable.AddCell(new iTextSharp.text.Paragraph(($"%{kdvoranı}"), fontTitle));
                    pdfPTable.AddCell(new iTextSharp.text.Paragraph(($"{maliyet} TL"), fontTitle));
                    pdfPTable.AddCell(new iTextSharp.text.Paragraph(($"{kdvtutarı} TL"), fontTitle));
                    pdfPTable.AddCell(new iTextSharp.text.Paragraph(($"{kdvdahiltoplamtutar} TL"), fontTitle));
                    pdfPTable.SpacingBefore = 5f;



                }
                reader.Close();



                PdfPTable pdfPTable1 = new PdfPTable(3);
                pdfPTable1.AddCell(new iTextSharp.text.Paragraph($"Ürünlerin Toplam Maliyeti = {GlobalClass.maliyet} TL",fontTitle  ));
                pdfPTable1.AddCell(new iTextSharp.text.Paragraph($"Ürünlerin Toplam Kdv Tutarı = {GlobalClass.kdvtoplami} TL",fontTitle));
                pdfPTable1.AddCell(new iTextSharp.text.Paragraph($"Ürünlerin Kdv Dahil Toplam Tutarları = {GlobalClass.kdvlitoplami}  TL",fontTitle));




                doc.Add(padftable2);
                doc.Add(pdfPTable);
                pdfPTable1.SpacingBefore = 50f;
                doc.Add(pdfPTable1);
                doc.Close();
                this.Close();

                SqlConnection sqlconnection = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"select kullanıcıad,kullanıcısoyadı,mailadresi from Orders where sipariş_numarası ='{GlobalClass.siparişnumarası}' ", sqlconnection);
                SqlDataReader read = sqlCommand.ExecuteReader();
                read.Read();



                string siparişvereninad = read["kullanıcıad"].ToString();
                string siparişvereninsoyad = read["kullanıcısoyadı"].ToString();
                string mailadresii = read["mailadresi"].ToString();
      



                SqlConnection sqlconnection1 = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
                sqlconnection1.Open();
                SqlCommand sqlCommand1 = new SqlCommand($"insert into Waiting_Orders (müşteriadi,müşterisoyadi,mailadresi,siparişnumarasi,onaydurumu) values ('{siparişvereninad}','{siparişvereninsoyad}','{mailadresi2}','{GlobalClass.siparişnumarası}','onaybekliyor')", sqlconnection1);
                sqlCommand1.Parameters.AddWithValue("@müşteriadi", siparişvereninad.TrimEnd());
                sqlCommand1.Parameters.AddWithValue("@müşterisoyadi", siparişvereninsoyad.TrimEnd());
                sqlCommand1.Parameters.AddWithValue("@mailadresi", mailadresii.TrimEnd());
                sqlCommand1.Parameters.AddWithValue("@siparişnumarası", GlobalClass.siparişnumarası);
         
                sqlCommand1.ExecuteNonQuery();
                sqlconnection1.Close();

















                MailMessage mailmesaj = new MailMessage();
                SmtpClient istemci = new SmtpClient()
                {
                    Credentials = new System.Net.NetworkCredential("cdogrulama@gmail.com", "eznsimizmnjlyjmq"),
                    Port = 587,
                    Host = "smtp.gmail.com",
                    EnableSsl = true
                };

                mailmesaj.To.Add($"{mailadresi2}");
                mailmesaj.From = new MailAddress($"{mailadresi2}");
                mailmesaj.Subject = ("Yetkili Onay Bekliyor ");
                isiminiz = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(isiminiz);
                soyisiminiz = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(soyisiminiz);
                mailmesaj.Body = $"Sayın {isiminiz.Trim()} {soyisiminiz.Trim()} alışverişiniz listeye eklenmiştir yetkili onay verdikten sonra size fatura gönderilecektir";

                try
                {
                    istemci.Send(mailmesaj);

                }
                catch
                {
                    MessageBox.Show("Mail Gönderilmedi");
                }

            }


            else
            {
                MessageBox.Show("Lütfen Kodu kontrol ediniz", "Uyarı");
            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            
        }

        private void satışonayformu_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (textBox0.Text != onay.ToString())
            {
               

                DialogResult diyalog =  MessageBox.Show("Alışveriş tamamlanmadan çıkmak istediğinize emin misiniz", "Uyarı",MessageBoxButtons.OK);


                SqlConnection conekşın = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
                conekşın.Open();
                SqlCommand comande = new SqlCommand($"delete Orders  where sipariş_numarası='{GlobalClass.siparişnumarası}'",conekşın);
                comande.ExecuteNonQuery();
                conekşın.Close();



                SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
                cntcn.Open();
                SqlCommand cmd = new SqlCommand("select * from Customers where mailadresi=@mail", cntcn);
                cmd.Parameters.AddWithValue("@mail", mailadresi2);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    isiminiz = read["adi"].ToString();
                    soyisiminiz = read["soyadi"].ToString();
                }





                MailMessage mailmesaj = new MailMessage();
                SmtpClient istemci = new SmtpClient()
                {
                    Credentials = new System.Net.NetworkCredential("cdogrulama@gmail.com", "eznsimizmnjlyjmq"),
                    Port = 587,
                    Host = "smtp.gmail.com",
                    EnableSsl = true
                };

                mailmesaj.To.Add($"{mailadresi2}");
                mailmesaj.From = new MailAddress($"{mailadresi2}");
                mailmesaj.Subject = ("Ödemenizi Alamadık ");
                isiminiz = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(isiminiz);
                soyisiminiz = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(soyisiminiz);
                mailmesaj.Body = $"Sayın {isiminiz.Trim()} {soyisiminiz.Trim()} Ödeme sayfasında ki adımları tamalamadığınız için ödemenizi alamadık";

                try
                {
                 
                    istemci.Send(mailmesaj);
                }
                catch
                {
                    return;
                }
                


            }
            else
            {

                MessageBox.Show("Bizi tercih ettiğiniz için teşşekkür ederiz.","Siparişiniz Alındı!");

            }








        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            
            

        }

       
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (textBox6.TextLength == 2)
            {
                if (char.IsDigit(e.KeyChar) == true)
                {
                    textBox5.Focus();
                }

                else { return; }


            }
            else
            {

                if (e.KeyChar == ((char)Keys.Back))
                {
                    kartnumarası4.Focus();
                }
              

            }




        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (textBox5.TextLength == 4)
            {
                if (char.IsDigit(e.KeyChar) == true)
                {
                    textBox3.Focus();
                }

                else { return; }


            }
            else
            {

                if (e.KeyChar == ((char)Keys.Back))
                {
                    textBox6.Focus();
                }


            }



        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (textBox3.TextLength == 3)
            {

                button2.Focus();
            }
            else
            {
                return;
            }


        }

        private void textBox0_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
        }


        private void textBox0_TextChanged(object sender, EventArgs e)
        {

        }

        private void kartnumarası1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                
            if(kartnumarası1.TextLength == 4 )
            {
           

                if (char.IsDigit(e.KeyChar) == true)
                {
                    kartnumarası2.Focus();
                }


            }
            else { return; }

        }

        private void kartnumarası2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (kartnumarası2.TextLength == 4)
            {
                if (char.IsDigit(e.KeyChar) == true)
                {
                    kartnumarası3.Focus();
                }

                
                else { return; }   
            

            }
            else             
            {
                if (kartnumarası2.TextLength == 0)
                {
                    if (e.KeyChar == ((char)Keys.Back))
                    {
                        kartnumarası1.Focus();
                    }
                }
                else { return; }

            }



        }

        private void kartnumarası3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (kartnumarası3.TextLength == 4)
            {
                if (char.IsDigit(e.KeyChar) == true)
                {
                    kartnumarası4.Focus();
                }

                else { return; }


            }
            else
            {
                if(kartnumarası3.TextLength==0)
                { 
                    if (e.KeyChar == ((char)Keys.Back))
                    {
                        kartnumarası2.Focus();
                    }
                }
                else { return;}
             


            }




        }

        private void kartnumarası4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


            if (kartnumarası4.TextLength == 4)
            {
                if (char.IsDigit(e.KeyChar) == true)
                {
                    textBox6.Focus();
                }

                else { return; }


            }
            else
            {
                if (kartnumarası4.TextLength == 0)
                {
                    if (e.KeyChar == ((char)Keys.Back))
                    {
                        kartnumarası3.Focus();
                    }
                }
                else { return; }

            }


        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            
        }
    }


}