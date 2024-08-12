using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace satışotomasyonu
{
    public partial class RegistertrationForm : Form
    {
        public RegistertrationForm()
        {

            InitializeComponent();

        }
        public static string ad,soyad,mail,şifre;
        public static bool cinsiyet_erkek,cinsiyet_kadın;


        public static Random sayi = new Random();
        public static int onaykodu = sayi.Next(102635,956321);


        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == ""|| textBox3.Text=="")
            { 
                MessageBox.Show("Ad,Soyad veya mail adresini kontrol ediniz"  ); }
            else
            {

                if (textBox3.Text.EndsWith("@gmail.com") || textBox3.Text.EndsWith("@hotmail.com") || textBox3.Text.EndsWith("@outlook.com") || textBox3.Text.EndsWith("@outlook.com.tr"))
                {

                    SqlDataReader read;

                    SqlConnection conn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select mailadresi  from Customers where mailadresi=@mail   ", conn);
                    cmd.Parameters.AddWithValue("@mail", textBox3.Text);
                   
                    read = cmd.ExecuteReader();
                    if (read.HasRows == true)
                    {
                        MessageBox.Show("bu mail adresi ile kullanıcı kaydı mevcut lütfen farklı mail ile kullanıcı oluşturmayı deneyiniz" ,"Uyarı");
                    }
                    else
                    {
                        MailMessage mailmesaj = new MailMessage();
                        SmtpClient istemci = new SmtpClient()
                        {
                            Credentials = new System.Net.NetworkCredential("cdogrulama@gmail.com", "eznsimizmnjlyjmq"),
                            Port = 587,
                            Host = "smtp.gmail.com",
                            EnableSsl = true
                        };

                        mailmesaj.To.Add($"{textBox3.Text}");
                        mailmesaj.From = new MailAddress($"{textBox3.Text}");
                        mailmesaj.Subject = ("Mail Doğrulama ");
                        mailmesaj.Body = $"sayın {textBox1.Text.Trim()} {textBox2.Text.Trim()} Mail Doğrulama kodunuz: {onaykodu}";
                        

                        try
                        {
                            istemci.Send(mailmesaj);
                            MessageBox.Show("Doğrulama Kodu Gönderildi.");

                        }
                        catch
                        {
                            MessageBox.Show("Mail adresinizi kontrol ediniz.");

                        }




                    }







                }

                else
                {
                    MessageBox.Show("Lütfen mail adresini kontrol ediniz");

                }


            }
           


            

            



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox6.Text == onaykodu.ToString())
            {
                MessageBox.Show("Mail Adresiniz doğrulanmıştır");

                textBox4.Enabled = true;
                textBox5.Enabled = true;
                //textBox6.Enabled = true;
                button1.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;


            }
            else
            {
                MessageBox.Show("Lütfen mail adresinizde ki kodu doğru girdiğinizden emin olunuz");
            }



        }

        private void hesapoluşturmaekranı_Load(object sender, EventArgs e)
        {

            textBox4.Enabled = false;
            textBox5.Enabled = false;
            //textBox6.Enabled = false;
            button1.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;


        }

        public void  button1_Click(object sender, EventArgs e)
        {
        
            if(textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Şifreler aynı olmalıdır");
            }
            if(checkBox1.Checked==false && checkBox2.Checked == false)
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz");

            }
            else
            {
                string erkek = "erkek", kadin = "kadın";
                string girişedön = "Giriş Sayfasına Dön";

                if (checkBox1.Checked == true)
                {

                    SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
                    cntcn.Open();
                    SqlCommand cmd = new SqlCommand("insert into  Customers (adi,soyadi,cinsiyet,mailadresi,sifre) values @ad,@soyadi,@cinsiyet,@mailadresi,@sifre  ", cntcn);
                    cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                    cmd.Parameters.AddWithValue("@soyadi", textBox2.Text);
                    cmd.Parameters.AddWithValue("@cinsiyet", erkek);

                    cmd.Parameters.AddWithValue("@mailadresi", textBox3.Text);
                    cmd.Parameters.AddWithValue("@sifre", textBox4.Text);
                    cmd.ExecuteNonQuery();
                    cntcn.Close();

                    DialogResult dialogResult=  MessageBox.Show("Kaydınız Oluşturuldu","",MessageBoxButtons.OK);
                    this.Close();

                }
                else
                {

                    SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
                    cntcn.Open();
                    SqlCommand cmd = new SqlCommand("insert into  Customers (adi,soyadi,cinsiyet,mailadresi,sifre) values (@adi,@soyadi,@cinsiyet,@mailadresi,@sifre)", cntcn);
                    cmd.Parameters.AddWithValue("@adi", textBox1.Text);
                    cmd.Parameters.AddWithValue("@soyadi", textBox2.Text);
                    cmd.Parameters.AddWithValue("@cinsiyet", erkek);

                    cmd.Parameters.AddWithValue("@mailadresi", textBox3.Text);
                    cmd.Parameters.AddWithValue("@sifre", textBox4.Text);
                    cmd.ExecuteNonQuery();
                    cntcn.Close();


                    MessageBox.Show("Kaydınız Onaylanmıştır");
                    this.Close();


                }



















                MessageBox.Show("Kaydınız onaylanmıştır");
            }

















        }





        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }

        }

    }
}
