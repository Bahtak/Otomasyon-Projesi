using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satışotomasyonu
{
    public partial class ForgetMyPassword : Form
    {
        public ForgetMyPassword()
        {
            InitializeComponent();
        }
        public static Random şifreunuttumonaykodu = new Random();
        int şifreunututmonaykodu2 = şifreunuttumonaykodu.Next(152369,987265);
        public static string ad;
        public static string soyad;
        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text != "" && textBox1.Text.EndsWith ("@gmail.com") || textBox1.Text.EndsWith("@hotmail.com")   || textBox1.Text.EndsWith("@outlook.com.tr") || textBox1.Text.EndsWith("@outlook.com"))
            {

                SqlDataReader read;

                SqlConnection conn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select concat_ws(' ', adi,soyadi)  from Customers where mailadresi=@mail   ", conn);
                cmd.Parameters.AddWithValue("@mail", textBox1.Text);
                string fullName = cmd.ExecuteScalar()?.ToString();


                if (String.IsNullOrEmpty(fullName))
                {
                    DialogResult  result = MessageBox.Show("Mail adresiniz sistemde kayıtlı değil \nYeni bir hesap oluşturmak istermisiniz", "Mail bulunamadı",MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        RegistertrationForm hesapoluşturmaekranı = new RegistertrationForm();
                        hesapoluşturmaekranı.ShowDialog();
                        
                    }
                }
               
                else
                {


                    label2.Enabled = true;
                    textBox2.Enabled = true;
                    button2.Enabled = true;
                    MailMessage mailmesaj = new MailMessage();
                    SmtpClient istemci = new SmtpClient()
                    {
                        Credentials = new System.Net.NetworkCredential("Mail Adresi", "Mail Kodu"),
                        Port = 587,
                        Host = "smtp.gmail.com",
                        EnableSsl = true
                    };

                    mailmesaj.To.Add(textBox1.Text);
                    mailmesaj.From = new MailAddress("Mail Adresi");
                    mailmesaj.Subject = ("Mail Şifre Değiştirme Kodu ");
                    mailmesaj.Body = $"sayın {fullName.Trim()}\n şifre değiştirme kodunuz : {şifreunututmonaykodu2}";


                    try
                    {
                        istemci.Send(mailmesaj);
                        Console.WriteLine("Mail Gönderildi");
                    }
                    catch
                    {
                        MessageBox.Show("Mail Adresine Gönderim yapılamadı");
                    }



                }




            }
            else
            {
                MessageBox.Show("Hatalı Mail adresi girişi","Hatalı mail adresi");
            }












        }

        private void şifremiunuttum_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;

            button2.Enabled = false;
            button3.Enabled = false;



        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if(textBox2.Text == şifreunututmonaykodu2.ToString())
            {
                label3.Enabled = true;
                label4.Enabled = true;
                textBox3.Enabled=true;
                textBox4.Enabled=true;
                button3.Enabled = true;

            }
            else
            {
                MessageBox.Show("Kodu yanlış girdiniz lütfen kontrol ediniz");
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox3.Text!="" || textBox4.Text!="" && textBox3.Text == textBox4.Text)
            {

                SqlConnection conn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Customers set sifre=@şifre where mailadresi=@mail   ", conn);
                cmd.Parameters.AddWithValue("@mail", textBox1.Text);
                cmd.Parameters.AddWithValue("@şifre", textBox3.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Şifreniz Değiştirildi");
                this.Close();

            }
            else
            {
                MessageBox.Show("Lütfen şifreleri kontrol ediniz");
            }
        }
    }
}
