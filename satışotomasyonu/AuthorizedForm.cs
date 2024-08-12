using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satışotomasyonu
{
    public partial class AuthorizedForm : Form
    {

        
        public AuthorizedForm()
        {
            InitializeComponent();
        }
        

        private void Silmedemirleri_Load(object sender, EventArgs e)
        {

        }

        public void  Silmedemirleribilgileri()
        {
            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id = '5'", cntcn);
            SqlDataReader read = cmd.ExecuteReader();
           

            
            


            while (read.Read())
            {

                lbl_ürünadıdeğer.Text = read["isim"].ToString();
                lbl_ürünfiyatınındeğeri.Text = read["mayısfiyat"].ToString();
                lbl_ürünstokunundeğeri.Text = read["mayısstok"].ToString();
                lbl_ürünsatılandeğeri.Text = read["mayıssatılan"].ToString();
                lbl_ürününkdvdeğeri.Text = read["kdv"].ToString();
                label_ürünıd.Text  = read["id"].ToString() ;


                string ocakfiyat, şubatfiyat, martfiyat, nisanfiyat, mayısfiyat ,ocaksatılan , şubatsatılan,martsatılan,nisansatılan,mayıssatılan ;


                ocakfiyat = read["ocakfiyat"].ToString();
                şubatfiyat = read["şubatfiyat"].ToString();
                martfiyat = read["martfiyat"].ToString();
                nisanfiyat = read["nisanfiyat"].ToString();
                mayısfiyat= read["mayısfiyat"].ToString();

                ocaksatılan = read["ocaksatılan"].ToString();
                şubatsatılan = read["şubatsatılan"].ToString();
                martsatılan= read["martsatılan"].ToString();
                nisansatılan = read["nisansatılan"].ToString();
                mayıssatılan = read["mayıssatılan"].ToString();


                this.chart1.Series["Fiyat"].Points.AddY(ocakfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(şubatfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(martfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(nisanfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(mayısfiyat);


                this.chart1.Series["Satılan"].Points.AddY(ocaksatılan);
                this.chart1.Series["Satılan"].Points.AddY(şubatsatılan);
                this.chart1.Series["Satılan"].Points.AddY(martsatılan);
                this.chart1.Series["Satılan"].Points.AddY(nisansatılan);
                this.chart1.Series["Satılan"].Points.AddY(mayıssatılan);


                this.chart1.Series["Fiyat"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Fiyat"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Fiyat"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Fiyat"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Fiyat"].Points[4].AxisLabel = "Mayıs";


                this.chart1.Series["Satılan"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Satılan"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Satılan"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Satılan"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Satılan"].Points[4].AxisLabel = "Mayıs";

         

            }


        }



        public void lamademirleri()
        {

            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id = '6'", cntcn);
            SqlDataReader read = cmd.ExecuteReader();



            while (read.Read())
            {

                lbl_ürünadıdeğer.Text = read["isim"].ToString();
                lbl_ürünfiyatınındeğeri.Text = read["mayısfiyat"].ToString();
                lbl_ürünstokunundeğeri.Text = read["mayısstok"].ToString();
                lbl_ürünsatılandeğeri.Text = read["mayıssatılan"].ToString();
                lbl_ürününkdvdeğeri.Text = read["kdv"].ToString();
                label_ürünıd.Text = read["id"].ToString();

                


                string ocakfiyat, şubatfiyat, martfiyat, nisanfiyat, mayısfiyat, ocaksatılan, şubatsatılan, martsatılan, nisansatılan, mayıssatılan;


                ocakfiyat = read["ocakfiyat"].ToString();
                şubatfiyat = read["şubatfiyat"].ToString();
                martfiyat = read["martfiyat"].ToString();
                nisanfiyat = read["nisanfiyat"].ToString();
                mayısfiyat = read["mayısfiyat"].ToString();

                ocaksatılan = read["ocaksatılan"].ToString();
                şubatsatılan = read["şubatsatılan"].ToString();
                martsatılan = read["martsatılan"].ToString();
                nisansatılan = read["nisansatılan"].ToString();
                mayıssatılan = read["mayıssatılan"].ToString();


                this.chart1.Series["Fiyat"].Points.AddY(ocakfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(şubatfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(martfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(nisanfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(mayısfiyat);


                this.chart1.Series["Satılan"].Points.AddY(ocaksatılan);
                this.chart1.Series["Satılan"].Points.AddY(şubatsatılan);
                this.chart1.Series["Satılan"].Points.AddY(martsatılan);
                this.chart1.Series["Satılan"].Points.AddY(nisansatılan);
                this.chart1.Series["Satılan"].Points.AddY(mayıssatılan);


                this.chart1.Series["Fiyat"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Fiyat"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Fiyat"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Fiyat"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Fiyat"].Points[4].AxisLabel = "Mayıs";


                this.chart1.Series["Satılan"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Satılan"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Satılan"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Satılan"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Satılan"].Points[4].AxisLabel = "Mayıs";





            }






        }
        public void T_profil_Demirleri()
        {

            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id = '7'", cntcn);
            SqlDataReader read = cmd.ExecuteReader();



            while (read.Read())
            {

                lbl_ürünadıdeğer.Text = read["isim"].ToString();
                lbl_ürünfiyatınındeğeri.Text = read["mayısfiyat"].ToString();
                lbl_ürünstokunundeğeri.Text = read["mayısstok"].ToString();
                lbl_ürünsatılandeğeri.Text = read["mayıssatılan"].ToString();
                lbl_ürününkdvdeğeri.Text = read["kdv"].ToString();
                label_ürünıd.Text = read["id"].ToString();


                string ocakfiyat, şubatfiyat, martfiyat, nisanfiyat, mayısfiyat, ocaksatılan, şubatsatılan, martsatılan, nisansatılan, mayıssatılan;


                ocakfiyat = read["ocakfiyat"].ToString();
                şubatfiyat = read["şubatfiyat"].ToString();
                martfiyat = read["martfiyat"].ToString();
                nisanfiyat = read["nisanfiyat"].ToString();
                mayısfiyat = read["mayısfiyat"].ToString();

                ocaksatılan = read["ocaksatılan"].ToString();
                şubatsatılan = read["şubatsatılan"].ToString();
                martsatılan = read["martsatılan"].ToString();
                nisansatılan = read["nisansatılan"].ToString();
                mayıssatılan = read["mayıssatılan"].ToString();


                this.chart1.Series["Fiyat"].Points.AddY(ocakfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(şubatfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(martfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(nisanfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(mayısfiyat);


                this.chart1.Series["Satılan"].Points.AddY(ocaksatılan);
                this.chart1.Series["Satılan"].Points.AddY(şubatsatılan);
                this.chart1.Series["Satılan"].Points.AddY(martsatılan);
                this.chart1.Series["Satılan"].Points.AddY(nisansatılan);
                this.chart1.Series["Satılan"].Points.AddY(mayıssatılan);


                this.chart1.Series["Fiyat"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Fiyat"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Fiyat"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Fiyat"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Fiyat"].Points[4].AxisLabel = "Mayıs";


                this.chart1.Series["Satılan"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Satılan"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Satılan"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Satılan"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Satılan"].Points[4].AxisLabel = "Mayıs";





            }








        }
        public void Kare_dolu_demirler()
        {

            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id = '8'", cntcn);
            SqlDataReader read = cmd.ExecuteReader();



            while (read.Read())
            {

                lbl_ürünadıdeğer.Text = read["isim"].ToString();
                lbl_ürünfiyatınındeğeri.Text = read["mayısfiyat"].ToString();
                lbl_ürünstokunundeğeri.Text = read["mayısstok"].ToString();
                lbl_ürünsatılandeğeri.Text = read["mayıssatılan"].ToString();
                lbl_ürününkdvdeğeri.Text = read["kdv"].ToString();
                label_ürünıd.Text = read["id"].ToString();

               
                string ocakfiyat, şubatfiyat, martfiyat, nisanfiyat, mayısfiyat, ocaksatılan, şubatsatılan, martsatılan, nisansatılan, mayıssatılan;


                ocakfiyat = read["ocakfiyat"].ToString();
                şubatfiyat = read["şubatfiyat"].ToString();
                martfiyat = read["martfiyat"].ToString();
                nisanfiyat = read["nisanfiyat"].ToString();
                mayısfiyat = read["mayısfiyat"].ToString();

                ocaksatılan = read["ocaksatılan"].ToString();
                şubatsatılan = read["şubatsatılan"].ToString();
                martsatılan = read["martsatılan"].ToString();
                nisansatılan = read["nisansatılan"].ToString();
                mayıssatılan = read["mayıssatılan"].ToString();


                this.chart1.Series["Fiyat"].Points.AddY(ocakfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(şubatfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(martfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(nisanfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(mayısfiyat);


                this.chart1.Series["Satılan"].Points.AddY(ocaksatılan);
                this.chart1.Series["Satılan"].Points.AddY(şubatsatılan);
                this.chart1.Series["Satılan"].Points.AddY(martsatılan);
                this.chart1.Series["Satılan"].Points.AddY(nisansatılan);
                this.chart1.Series["Satılan"].Points.AddY(mayıssatılan);


                this.chart1.Series["Fiyat"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Fiyat"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Fiyat"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Fiyat"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Fiyat"].Points[4].AxisLabel = "Mayıs";


                this.chart1.Series["Satılan"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Satılan"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Satılan"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Satılan"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Satılan"].Points[4].AxisLabel = "Mayıs";





            }







        }
        public void İnşaat_demirleri()
        {

            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id = '9'", cntcn);
            SqlDataReader read = cmd.ExecuteReader();



            while (read.Read())
            {

                lbl_ürünadıdeğer.Text = read["isim"].ToString();
                lbl_ürünfiyatınındeğeri.Text = read["mayısfiyat"].ToString();
                lbl_ürünstokunundeğeri.Text = read["mayısstok"].ToString();
                lbl_ürünsatılandeğeri.Text = read["mayıssatılan"].ToString();
                lbl_ürününkdvdeğeri.Text = read["kdv"].ToString();
                label_ürünıd.Text = read["id"].ToString();

                string ocakfiyat, şubatfiyat, martfiyat, nisanfiyat, mayısfiyat, ocaksatılan, şubatsatılan, martsatılan, nisansatılan, mayıssatılan;


                ocakfiyat = read["ocakfiyat"].ToString();
                şubatfiyat = read["şubatfiyat"].ToString();
                martfiyat = read["martfiyat"].ToString();
                nisanfiyat = read["nisanfiyat"].ToString();
                mayısfiyat = read["mayısfiyat"].ToString();

                ocaksatılan = read["ocaksatılan"].ToString();
                şubatsatılan = read["şubatsatılan"].ToString();
                martsatılan = read["martsatılan"].ToString();
                nisansatılan = read["nisansatılan"].ToString();
                mayıssatılan = read["mayıssatılan"].ToString();


                this.chart1.Series["Fiyat"].Points.AddY(ocakfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(şubatfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(martfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(nisanfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(mayısfiyat);


                this.chart1.Series["Satılan"].Points.AddY(ocaksatılan);
                this.chart1.Series["Satılan"].Points.AddY(şubatsatılan);
                this.chart1.Series["Satılan"].Points.AddY(martsatılan);
                this.chart1.Series["Satılan"].Points.AddY(nisansatılan);
                this.chart1.Series["Satılan"].Points.AddY(mayıssatılan);


                this.chart1.Series["Fiyat"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Fiyat"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Fiyat"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Fiyat"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Fiyat"].Points[4].AxisLabel = "Mayıs";


                this.chart1.Series["Satılan"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Satılan"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Satılan"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Satılan"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Satılan"].Points[4].AxisLabel = "Mayıs";





            }








        }
        public void Üçgen_vida_demirleri()
        {
            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id = '10'", cntcn);
            SqlDataReader read = cmd.ExecuteReader();



            while (read.Read())
            {

                lbl_ürünadıdeğer.Text = read["isim"].ToString();
                lbl_ürünfiyatınındeğeri.Text = read["mayısfiyat"].ToString();
                lbl_ürünstokunundeğeri.Text = read["mayısstok"].ToString();
                lbl_ürünsatılandeğeri.Text = read["mayıssatılan"].ToString();
                lbl_ürününkdvdeğeri.Text = read["kdv"].ToString();
                label_ürünıd.Text = read["id"].ToString();

             

                string ocakfiyat, şubatfiyat, martfiyat, nisanfiyat, mayısfiyat, ocaksatılan, şubatsatılan, martsatılan, nisansatılan, mayıssatılan;


                ocakfiyat = read["ocakfiyat"].ToString();
                şubatfiyat = read["şubatfiyat"].ToString();
                martfiyat = read["martfiyat"].ToString();
                nisanfiyat = read["nisanfiyat"].ToString();
                mayısfiyat = read["mayısfiyat"].ToString();

                ocaksatılan = read["ocaksatılan"].ToString();
                şubatsatılan = read["şubatsatılan"].ToString();
                martsatılan = read["martsatılan"].ToString();
                nisansatılan = read["nisansatılan"].ToString();
                mayıssatılan = read["mayıssatılan"].ToString();


                this.chart1.Series["Fiyat"].Points.AddY(ocakfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(şubatfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(martfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(nisanfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(mayısfiyat);


                this.chart1.Series["Satılan"].Points.AddY(ocaksatılan);
                this.chart1.Series["Satılan"].Points.AddY(şubatsatılan);
                this.chart1.Series["Satılan"].Points.AddY(martsatılan);
                this.chart1.Series["Satılan"].Points.AddY(nisansatılan);
                this.chart1.Series["Satılan"].Points.AddY(mayıssatılan);


                this.chart1.Series["Fiyat"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Fiyat"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Fiyat"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Fiyat"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Fiyat"].Points[4].AxisLabel = "Mayıs";


                this.chart1.Series["Satılan"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Satılan"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Satılan"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Satılan"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Satılan"].Points[4].AxisLabel = "Mayıs";





            }






        }
        public void Yuvarlak_vida()
        {
            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id = '11'", cntcn);
            SqlDataReader read = cmd.ExecuteReader();



            while (read.Read())
            {

                lbl_ürünadıdeğer.Text = read["isim"].ToString();
                lbl_ürünfiyatınındeğeri.Text = read["mayısfiyat"].ToString();
                lbl_ürünstokunundeğeri.Text = read["mayısstok"].ToString();
                lbl_ürünsatılandeğeri.Text = read["mayıssatılan"].ToString();
                lbl_ürününkdvdeğeri.Text = read["kdv"].ToString();
                label_ürünıd.Text = read["id"].ToString();

                string ocakfiyat, şubatfiyat, martfiyat, nisanfiyat, mayısfiyat, ocaksatılan, şubatsatılan, martsatılan, nisansatılan, mayıssatılan;


                ocakfiyat = read["ocakfiyat"].ToString();
                şubatfiyat = read["şubatfiyat"].ToString();
                martfiyat = read["martfiyat"].ToString();
                nisanfiyat = read["nisanfiyat"].ToString();
                mayısfiyat = read["mayısfiyat"].ToString();

                ocaksatılan = read["ocaksatılan"].ToString();
                şubatsatılan = read["şubatsatılan"].ToString();
                martsatılan = read["martsatılan"].ToString();
                nisansatılan = read["nisansatılan"].ToString();
                mayıssatılan = read["mayıssatılan"].ToString();


                this.chart1.Series["Fiyat"].Points.AddY(ocakfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(şubatfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(martfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(nisanfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(mayısfiyat);


                this.chart1.Series["Satılan"].Points.AddY(ocaksatılan);
                this.chart1.Series["Satılan"].Points.AddY(şubatsatılan);
                this.chart1.Series["Satılan"].Points.AddY(martsatılan);
                this.chart1.Series["Satılan"].Points.AddY(nisansatılan);
                this.chart1.Series["Satılan"].Points.AddY(mayıssatılan);


                this.chart1.Series["Fiyat"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Fiyat"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Fiyat"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Fiyat"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Fiyat"].Points[4].AxisLabel = "Mayıs";


                this.chart1.Series["Satılan"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Satılan"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Satılan"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Satılan"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Satılan"].Points[4].AxisLabel = "Mayıs";





            }






        }
        public void Trapez_vida()
        {


            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id = '12'", cntcn);
            SqlDataReader read = cmd.ExecuteReader();



            while (read.Read())
            {

                lbl_ürünadıdeğer.Text = read["isim"].ToString();
                lbl_ürünfiyatınındeğeri.Text = read["mayısfiyat"].ToString();
                lbl_ürünstokunundeğeri.Text = read["mayısstok"].ToString();
                lbl_ürünsatılandeğeri.Text = read["mayıssatılan"].ToString();
                lbl_ürününkdvdeğeri.Text = read["kdv"].ToString();
                label_ürünıd.Text = read["id"].ToString();

                

                string ocakfiyat, şubatfiyat, martfiyat, nisanfiyat, mayısfiyat, ocaksatılan, şubatsatılan, martsatılan, nisansatılan, mayıssatılan;


                ocakfiyat = read["ocakfiyat"].ToString();
                şubatfiyat = read["şubatfiyat"].ToString();
                martfiyat = read["martfiyat"].ToString();
                nisanfiyat = read["nisanfiyat"].ToString();
                mayısfiyat = read["mayısfiyat"].ToString();

                ocaksatılan = read["ocaksatılan"].ToString();
                şubatsatılan = read["şubatsatılan"].ToString();
                martsatılan = read["martsatılan"].ToString();
                nisansatılan = read["nisansatılan"].ToString();
                mayıssatılan = read["mayıssatılan"].ToString();


                this.chart1.Series["Fiyat"].Points.AddY(ocakfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(şubatfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(martfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(nisanfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(mayısfiyat);


                this.chart1.Series["Satılan"].Points.AddY(ocaksatılan);
                this.chart1.Series["Satılan"].Points.AddY(şubatsatılan);
                this.chart1.Series["Satılan"].Points.AddY(martsatılan);
                this.chart1.Series["Satılan"].Points.AddY(nisansatılan);
                this.chart1.Series["Satılan"].Points.AddY(mayıssatılan);


                this.chart1.Series["Fiyat"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Fiyat"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Fiyat"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Fiyat"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Fiyat"].Points[4].AxisLabel = "Mayıs";


                this.chart1.Series["Satılan"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Satılan"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Satılan"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Satılan"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Satılan"].Points[4].AxisLabel = "Mayıs";





            }






        }
        public void Kare_vida()
        {

            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id = '13'", cntcn);
            SqlDataReader read = cmd.ExecuteReader();



            while (read.Read())
            {

                lbl_ürünadıdeğer.Text = read["isim"].ToString();
                lbl_ürünfiyatınındeğeri.Text = read["mayısfiyat"].ToString();
                lbl_ürünstokunundeğeri.Text = read["mayısstok"].ToString();
                lbl_ürünsatılandeğeri.Text = read["mayıssatılan"].ToString();
                lbl_ürününkdvdeğeri.Text = read["kdv"].ToString();
                label_ürünıd.Text = read["id"].ToString();

            
                string ocakfiyat, şubatfiyat, martfiyat, nisanfiyat, mayısfiyat, ocaksatılan, şubatsatılan, martsatılan, nisansatılan, mayıssatılan;


                ocakfiyat = read["ocakfiyat"].ToString();
                şubatfiyat = read["şubatfiyat"].ToString();
                martfiyat = read["martfiyat"].ToString();
                nisanfiyat = read["nisanfiyat"].ToString();
                mayısfiyat = read["mayısfiyat"].ToString();

                ocaksatılan = read["ocaksatılan"].ToString();
                şubatsatılan = read["şubatsatılan"].ToString();
                martsatılan = read["martsatılan"].ToString();
                nisansatılan = read["nisansatılan"].ToString();
                mayıssatılan = read["mayıssatılan"].ToString();


                this.chart1.Series["Fiyat"].Points.AddY(ocakfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(şubatfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(martfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(nisanfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(mayısfiyat);


                this.chart1.Series["Satılan"].Points.AddY(ocaksatılan);
                this.chart1.Series["Satılan"].Points.AddY(şubatsatılan);
                this.chart1.Series["Satılan"].Points.AddY(martsatılan);
                this.chart1.Series["Satılan"].Points.AddY(nisansatılan);
                this.chart1.Series["Satılan"].Points.AddY(mayıssatılan);


                this.chart1.Series["Fiyat"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Fiyat"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Fiyat"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Fiyat"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Fiyat"].Points[4].AxisLabel = "Mayıs";


                this.chart1.Series["Satılan"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Satılan"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Satılan"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Satılan"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Satılan"].Points[4].AxisLabel = "Mayıs";





            }






        }
        public void Testere_vida()
        {

            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id = '14'", cntcn);
            SqlDataReader read = cmd.ExecuteReader();



            while (read.Read())
            {

                lbl_ürünadıdeğer.Text = read["isim"].ToString();
                lbl_ürünfiyatınındeğeri.Text = read["mayısfiyat"].ToString();
                lbl_ürünstokunundeğeri.Text = read["mayısstok"].ToString();
                lbl_ürünsatılandeğeri.Text = read["mayıssatılan"].ToString();
                lbl_ürününkdvdeğeri.Text = read["kdv"].ToString();
                label_ürünıd.Text = read["id"].ToString();

               

                string ocakfiyat, şubatfiyat, martfiyat, nisanfiyat, mayısfiyat, ocaksatılan, şubatsatılan, martsatılan, nisansatılan, mayıssatılan;


                ocakfiyat = read["ocakfiyat"].ToString();
                şubatfiyat = read["şubatfiyat"].ToString();
                martfiyat = read["martfiyat"].ToString();
                nisanfiyat = read["nisanfiyat"].ToString();
                mayısfiyat = read["mayısfiyat"].ToString();

                ocaksatılan = read["ocaksatılan"].ToString();
                şubatsatılan = read["şubatsatılan"].ToString();
                martsatılan = read["martsatılan"].ToString();
                nisansatılan = read["nisansatılan"].ToString();
                mayıssatılan = read["mayıssatılan"].ToString();


                this.chart1.Series["Fiyat"].Points.AddY(ocakfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(şubatfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(martfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(nisanfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(mayısfiyat);


                this.chart1.Series["Satılan"].Points.AddY(ocaksatılan);
                this.chart1.Series["Satılan"].Points.AddY(şubatsatılan);
                this.chart1.Series["Satılan"].Points.AddY(martsatılan);
                this.chart1.Series["Satılan"].Points.AddY(nisansatılan);
                this.chart1.Series["Satılan"].Points.AddY(mayıssatılan);


                this.chart1.Series["Fiyat"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Fiyat"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Fiyat"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Fiyat"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Fiyat"].Points[4].AxisLabel = "Mayıs";


                this.chart1.Series["Satılan"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Satılan"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Satılan"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Satılan"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Satılan"].Points[4].AxisLabel = "Mayıs";





            }






        }
        public void Tunç()
        {
            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id = '15'", cntcn);
            SqlDataReader read = cmd.ExecuteReader();



            while (read.Read())
            {

                lbl_ürünadıdeğer.Text = read["isim"].ToString();
                lbl_ürünfiyatınındeğeri.Text = read["mayısfiyat"].ToString();
                lbl_ürünstokunundeğeri.Text = read["mayısstok"].ToString();
                lbl_ürünsatılandeğeri.Text = read["mayıssatılan"].ToString();
                lbl_ürününkdvdeğeri.Text = read["kdv"].ToString();
                label_ürünıd.Text = read["id"].ToString();

            
                string ocakfiyat, şubatfiyat, martfiyat, nisanfiyat, mayısfiyat, ocaksatılan, şubatsatılan, martsatılan, nisansatılan, mayıssatılan;


                ocakfiyat = read["ocakfiyat"].ToString();
                şubatfiyat = read["şubatfiyat"].ToString();
                martfiyat = read["martfiyat"].ToString();
                nisanfiyat = read["nisanfiyat"].ToString();
                mayısfiyat = read["mayısfiyat"].ToString();

                ocaksatılan = read["ocaksatılan"].ToString();
                şubatsatılan = read["şubatsatılan"].ToString();
                martsatılan = read["martsatılan"].ToString();
                nisansatılan = read["nisansatılan"].ToString();
                mayıssatılan = read["mayıssatılan"].ToString();


                this.chart1.Series["Fiyat"].Points.AddY(ocakfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(şubatfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(martfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(nisanfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(mayısfiyat);


                this.chart1.Series["Satılan"].Points.AddY(ocaksatılan);
                this.chart1.Series["Satılan"].Points.AddY(şubatsatılan);
                this.chart1.Series["Satılan"].Points.AddY(martsatılan);
                this.chart1.Series["Satılan"].Points.AddY(nisansatılan);
                this.chart1.Series["Satılan"].Points.AddY(mayıssatılan);


                this.chart1.Series["Fiyat"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Fiyat"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Fiyat"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Fiyat"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Fiyat"].Points[4].AxisLabel = "Mayıs";


                this.chart1.Series["Satılan"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Satılan"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Satılan"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Satılan"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Satılan"].Points[4].AxisLabel = "Mayıs";





            }






        }
        public void Pirinç()
        {

            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id = '16'", cntcn);
            SqlDataReader read = cmd.ExecuteReader();

             

            while (read.Read())
            {

                lbl_ürünadıdeğer.Text = read["isim"].ToString();
                lbl_ürünfiyatınındeğeri.Text = read["mayısfiyat"].ToString();
                lbl_ürünstokunundeğeri.Text = read["mayısstok"].ToString();
                lbl_ürünsatılandeğeri.Text = read["mayıssatılan"].ToString();
                lbl_ürününkdvdeğeri.Text = read["kdv"].ToString();
                label_ürünıd.Text = read["id"].ToString();

            

                string ocakfiyat, şubatfiyat, martfiyat, nisanfiyat, mayısfiyat, ocaksatılan, şubatsatılan, martsatılan, nisansatılan, mayıssatılan;


                ocakfiyat = read["ocakfiyat"].ToString();
                şubatfiyat = read["şubatfiyat"].ToString();
                martfiyat = read["martfiyat"].ToString();
                nisanfiyat = read["nisanfiyat"].ToString();
                mayısfiyat = read["mayısfiyat"].ToString();

                ocaksatılan = read["ocaksatılan"].ToString();
                şubatsatılan = read["şubatsatılan"].ToString();
                martsatılan = read["martsatılan"].ToString();
                nisansatılan = read["nisansatılan"].ToString();
                mayıssatılan = read["mayıssatılan"].ToString();


                this.chart1.Series["Fiyat"].Points.AddY(ocakfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(şubatfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(martfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(nisanfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(mayısfiyat);


                this.chart1.Series["Satılan"].Points.AddY(ocaksatılan);
                this.chart1.Series["Satılan"].Points.AddY(şubatsatılan);
                this.chart1.Series["Satılan"].Points.AddY(martsatılan);
                this.chart1.Series["Satılan"].Points.AddY(nisansatılan);
                this.chart1.Series["Satılan"].Points.AddY(mayıssatılan);


                this.chart1.Series["Fiyat"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Fiyat"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Fiyat"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Fiyat"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Fiyat"].Points[4].AxisLabel = "Mayıs";


                this.chart1.Series["Satılan"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Satılan"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Satılan"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Satılan"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Satılan"].Points[4].AxisLabel = "Mayıs";





            }






        }
        public void Lehim()
        {


            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where id = '17'", cntcn);
            SqlDataReader read = cmd.ExecuteReader();



            while (read.Read())
            {

                lbl_ürünadıdeğer.Text = read["isim"].ToString();
                lbl_ürünfiyatınındeğeri.Text = read["mayısfiyat"].ToString();
                lbl_ürünstokunundeğeri.Text = read["mayısstok"].ToString();
                lbl_ürünsatılandeğeri.Text = read["mayıssatılan"].ToString();
                lbl_ürününkdvdeğeri.Text = read["kdv"].ToString();
                label_ürünıd.Text = read["id"].ToString();

               

                string ocakfiyat, şubatfiyat, martfiyat, nisanfiyat, mayısfiyat, ocaksatılan, şubatsatılan, martsatılan, nisansatılan, mayıssatılan;


                ocakfiyat = read["ocakfiyat"].ToString();
                şubatfiyat = read["şubatfiyat"].ToString();
                martfiyat = read["martfiyat"].ToString();
                nisanfiyat = read["nisanfiyat"].ToString();
                mayısfiyat = read["mayısfiyat"].ToString();

                ocaksatılan = read["ocaksatılan"].ToString();
                şubatsatılan = read["şubatsatılan"].ToString();
                martsatılan = read["martsatılan"].ToString();
                nisansatılan = read["nisansatılan"].ToString();
                mayıssatılan = read["mayıssatılan"].ToString();


                this.chart1.Series["Fiyat"].Points.AddY(ocakfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(şubatfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(martfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(nisanfiyat);
                this.chart1.Series["Fiyat"].Points.AddY(mayısfiyat);


                this.chart1.Series["Satılan"].Points.AddY(ocaksatılan);
                this.chart1.Series["Satılan"].Points.AddY(şubatsatılan);
                this.chart1.Series["Satılan"].Points.AddY(martsatılan);
                this.chart1.Series["Satılan"].Points.AddY(nisansatılan);
                this.chart1.Series["Satılan"].Points.AddY(mayıssatılan);


                this.chart1.Series["Fiyat"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Fiyat"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Fiyat"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Fiyat"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Fiyat"].Points[4].AxisLabel = "Mayıs";


                this.chart1.Series["Satılan"].Points[0].AxisLabel = "Ocak";
                this.chart1.Series["Satılan"].Points[1].AxisLabel = "Şubat";
                this.chart1.Series["Satılan"].Points[2].AxisLabel = "Mart";
                this.chart1.Series["Satılan"].Points[3].AxisLabel = "Nisan";
                this.chart1.Series["Satılan"].Points[4].AxisLabel = "Mayıs";





            }






        }
  







        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("update Products set mayısfiyat=@mayısfiyat where id =@id ", cntcn);
            cmd.Parameters.AddWithValue("@mayısfiyat",textBox_ürünfiyatideğer.Text);
            cmd.Parameters.AddWithValue("@id", label_ürünıd.Text);
            cmd.ExecuteNonQuery();
            cntcn.Close();
            MessageBox.Show("Değişiklikler Kaydedildi. \nLütfen mevcut pencereyi yeniden başlatınız.", "Dikkat");

        }

        public void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("update Products set isim=@isim where id =@id ", cntcn);
            cmd.Parameters.AddWithValue("@isim", textBox_ürünadıdeğer.Text);
            cmd.Parameters.AddWithValue("@id", label_ürünıd.Text);
            cmd.ExecuteNonQuery();
            cntcn.Close();
            MessageBox.Show("Değişiklikler Kaydedildi. \nLütfen mevcut pencereyi yeniden başlatınız.", "Dikkat");




        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("update Products set kdv=@kdv where id =@id ", cntcn);
            cmd.Parameters.AddWithValue("@kdv", textBox_ürünakdvdeğer.Text);
            cmd.Parameters.AddWithValue("@id", label_ürünıd.Text);
            cmd.ExecuteNonQuery();
            cntcn.Close();
            MessageBox.Show("Değişiklikler Kaydedildi. \nLütfen mevcut pencereyi yeniden başlatınız.", "Dikkat");



        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("update Products set mayısstok=@mayısstok where id =@id ", cntcn);
            cmd.Parameters.AddWithValue("@mayısstok", textBox_ürünstokdeğer.Text);
            cmd.Parameters.AddWithValue("@id", label_ürünıd.Text);
            cmd.ExecuteNonQuery();
            cntcn.Close();
            MessageBox.Show("Değişiklikler Kaydedildi. \nLütfen mevcut pencereyi yeniden başlatınız.", "Dikkat");



        }

        private void button5_Click(object sender, EventArgs e)
        {


            SqlConnection cntcn = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");
            cntcn.Open();
            SqlCommand cmd = new SqlCommand("update Products set mayıssatılan=@mayıssatılan where id =@id ", cntcn);
            cmd.Parameters.AddWithValue("@mayıssatılan", textBox_ürünsatılanadet.Text);
            cmd.Parameters.AddWithValue("@id", label_ürünıd.Text);
            cmd.ExecuteNonQuery();
            cntcn.Close();
            MessageBox.Show("Değişiklikler Kaydedildi. \nLütfen mevcut pencereyi yeniden başlatınız.", "Dikkat");



        }


    }
}
