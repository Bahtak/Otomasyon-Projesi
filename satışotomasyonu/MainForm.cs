using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace satışotomasyonu
{
        
    

    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();





        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            if(comboBox1.SelectedIndex == 0)
            {



                if(textBox_kullaniciadi.Text == "")
                {
                    MessageBox.Show("Kullanıcı adı boş bırakılmaz");
                }



                else if(textBox_sifre.Text == "")
                {
                    MessageBox.Show("Şifre alanı boş bırakılmaz");

                }




                SqlDataReader read;
                GlobalClass.sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("select adi,soyadi,mailadresi,sifre from Customers where mailadresi=@mail ", GlobalClass.sqlConnection);
                cmd.Parameters.AddWithValue("@mail", textBox_kullaniciadi.Text);
                read = cmd.ExecuteReader();
                read.Read();



                if (read.HasRows == true)
                {
                    string isim = read["adi"].ToString();
                    string soyisim = read["soyadi"].ToString();
                    string mailadresi = read["mailadresi"].ToString();
                    string şifre = read["sifre"].ToString();



                    if (textBox_kullaniciadi.Text == mailadresi && textBox_sifre.Text != şifre)
                    {

                        MessageBox.Show("Lütfen şifrenizi kontrol ediniz","Hesap Bilgileri uyuşmadı");

                    }



                    else if(textBox_kullaniciadi.Text == mailadresi.TrimEnd() && textBox_sifre.Text == şifre.TrimEnd())
                    {
                        GlobalClass.mailadresi = mailadresi;
                        isim = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(isim);
                        soyisim = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(soyisim);
                        string full_name = ($"{isim.TrimEnd()} {soyisim.TrimEnd()}");
                        GlobalClass.Isim = full_name;
                        SalesForm müşteriFormu = new SalesForm();
                        müşteriFormu.ShowDialog();
                    }
                }


                else
                {

                    DialogResult = MessageBox.Show("Kullanıcı bulunamadı \nHesap oluşturmak ister misiniz ? ", "Uyarı", MessageBoxButtons.OKCancel);


                    if (DialogResult == DialogResult.OK)
                    {
                        RegistertrationForm hesapekranı = new RegistertrationForm();
                        hesapekranı.ShowDialog();
                        this.Close();
                    }


                }
               GlobalClass.sqlConnection.Close();
                read.Close();
            }
            if (comboBox1.SelectedIndex == 1)
            {


                SqlDataReader read;
                GlobalClass.sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("select kullanıcıadı,şifre  from Users where kullanıcıadı=@mail AND şifre=@sifre  ", GlobalClass.sqlConnection);
                cmd.Parameters.AddWithValue("@mail", textBox_kullaniciadi.Text);
                cmd.Parameters.AddWithValue("@sifre", textBox_sifre.Text);
                read = cmd.ExecuteReader();
                if (read.HasRows == true)
                {
                    MessageBox.Show("Yetkili Menüsüne yönlendiriliyorsunuz","Kullanıcı girişi başarılı");
                    AuthorizedMainForm yetkiliformu = new AuthorizedMainForm();
                    yetkiliformu.ShowDialog();
                    GlobalClass.sqlConnection.Close();
                }



                else
                {


                    MessageBox.Show("Sql Bağlantısı kurulamadı");
                    return;

                }






            }
      


            if (comboBox1.SelectedItem==null)
            {

                    MessageBox.Show(Text ="Lütfen giriş yöntemi seçniz","Seçim Hatası");




            }
            GlobalClass.sqlConnection.Close();
           
        }
        
        SalesForm müşteri = new SalesForm();
   


        private void Çıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        



        }



        private void button2_Click(object sender, EventArgs e)
        {
            RegistertrationForm hesapoluşturmaform = new RegistertrationForm();
            hesapoluşturmaform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ForgetMyPassword şifremiunuttum = new ForgetMyPassword();
            şifremiunuttum.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != 0)
            {
                MessageBox.Show("LÜtfen giriş yöntemi olarak kullanıcı girişini seçip verileri eksiksiz ve doğru bir biçimde doldurunuz", "Uyarı");
            }
            else if(textBox_kullaniciadi.Text == "" && textBox_sifre.Text == "")
            {
                MessageBox.Show("Sayın kullanıcımız hesap bilgileri değiştirmek için Kullanıcı ve mail adresini bu sekmeden giriniz","Uyarı");
            }
            else if(comboBox1.SelectedIndex== 0)
            {
                SqlDataReader reader;
                GlobalClass.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select adi,soyadi,cinsiyet,mailadresi,sifre  from Customers where mailadresi=@mail AND sifre=@sifre  ", GlobalClass.sqlConnection);
                sqlCommand.Parameters.AddWithValue("@mail", textBox_kullaniciadi.Text);
                sqlCommand.Parameters.AddWithValue("@sifre", textBox_sifre.Text);
                reader = sqlCommand.ExecuteReader();
                if (reader.HasRows == true)
                {
                    AccounSettings kullanıcıbilgilerideğiştirme = new AccounSettings();
                    kullanıcıbilgilerideğiştirme.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("kullanıcı adı veya şifre yanlış");
                }


            }
            GlobalClass.sqlConnection.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
            }

        }
        


    }


}
