using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;

namespace Daylight_Ajanda
{
    internal class UserProvider
    {
        SqlConnection baglan;
        SqlCommand cmd;
                   

        public  UserProvider() //Kurucu metot
        {
            Baglan();
        }
        public void Baglan()
        {
            baglan = new SqlConnection(@"Data Source=LAPTOP-2BUCSTS1;Initial Catalog=GunlukDB;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = baglan;

        }

        public void Ekle(User u)
        {
            try
            {
                
                cmd.CommandText = "Insert Into [User] (Ad,Soyad,KullaniciAdi,Telefon,Eposta,KullaniciTuru,Sifre) VALUES (@ad,@soyad,@kullaniciAdi,@telefon,@eposta,@kullaniciTuru,@sifre)";
                cmd.CommandType = CommandType.Text; //Çalıştırılacak olan sorgu cümlesi yazılmaktadır
                baglan.Open();
                SqlParameter prmt1 = new SqlParameter("@ad", u.Ad);
                SqlParameter prmt2 = new SqlParameter("@soyad", u.Soyad);
                SqlParameter prmt3 = new SqlParameter("@kullaniciAdi", u.KullaniciAdi);
                SqlParameter prmt4 = new SqlParameter("@telefon", u.Telefon);
                SqlParameter prmt5 = new SqlParameter("@eposta", u.Eposta);
                SqlParameter prmt6 = new SqlParameter("@kullaniciTuru", u.KullaniciTuru);
                SqlParameter prmt7 = new SqlParameter("@sifre", u.Sifre);
                cmd.Parameters.Add(prmt1);
                cmd.Parameters.Add(prmt2);
                cmd.Parameters.Add(prmt3);
                cmd.Parameters.Add(prmt4);
                cmd.Parameters.Add(prmt5);
                cmd.Parameters.Add(prmt6);
                cmd.Parameters.Add(prmt7);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (baglan != null)
                {
                    baglan.Close();
                }
            }

        }
        public void Gunluk(User u)
        {
            try
            {

                cmd.CommandText = "Insert Into [Note] (Tarih,Gunluk) VALUES (@Tarih,@Gunluk)";
                cmd.CommandType = CommandType.Text; 
                baglan.Open();
                SqlParameter prmt1 = new SqlParameter("@Tarih", u.DateTime);
                SqlParameter prmt2 = new SqlParameter("@Gunluk", u.Gunluk);
                cmd.Parameters.Add(prmt1);
                cmd.Parameters.Add(prmt2);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //throw;
            }
            finally
            {
                if (baglan != null)
                {
                    baglan.Close();
                }
            }
        }

        public void Hedef(User u)
        {
            try
            {
                cmd.CommandText = "Insert Into [Hedef] (Kariyer,Aile,Arkadaslik,Saglık,Ev,Ogrenme,Ask,Para,KisiselGelisim,Fiziksel,Sosyal) VALUES (@Kariyer,@Aile,@Arkadaslik,@Saglık,@Ev,@Ogrenme,@Ask,@Para,@KisiselGelisim,@Fiziksel,@Sosyal)";
                cmd.CommandType = CommandType.Text; //Çalıştırılacak olan sorgu cümlesi yazılmaktadır
                baglan.Open();
                SqlParameter prmt1 = new SqlParameter("@Kariyer", u.Kariyer);
                SqlParameter prmt2 = new SqlParameter("@Aile", u.Aile);
                SqlParameter prmt3 = new SqlParameter("@Arkadaslik",u.Arkadaslik);
                SqlParameter prmt4 = new SqlParameter("@Saglık", u.Saglik);
                SqlParameter prmt5 = new SqlParameter("@Ev", u.Ev);
                SqlParameter prmt6 = new SqlParameter("@Ogrenme", u.Ogrenme);
                SqlParameter prmt7 = new SqlParameter("@Ask", u.Ask);
                SqlParameter prmt8 = new SqlParameter("@Para", u.Para);
                SqlParameter prmt9 = new SqlParameter("@KisiselGelisim", u.KisiselGelisim);
                SqlParameter prmt10 = new SqlParameter("@Fiziksel", u.Fiziksel);
                SqlParameter prmt11 = new SqlParameter("@Sosyal", u.Sosyal);
                cmd.Parameters.Add(prmt1);
                cmd.Parameters.Add(prmt2);
                cmd.Parameters.Add(prmt3);
                cmd.Parameters.Add(prmt4);
                cmd.Parameters.Add(prmt5);
                cmd.Parameters.Add(prmt6);
                cmd.Parameters.Add(prmt7);
                cmd.Parameters.Add(prmt8);  
                cmd.Parameters.Add(prmt9);  
                cmd.Parameters.Add(prmt10); 
                cmd.Parameters.Add(prmt11); 
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (baglan != null)
                {
                    baglan.Close();
                }
            }

        }

        public void Not(User u)
        {
            try
            {
                cmd.CommandText = "Insert Into [Notlar] (NotAd) VALUES (@Not)";
                cmd.CommandType = CommandType.Text; 
                baglan.Open();
                SqlParameter prmt1 = new SqlParameter("@Not", u.Not);
                cmd.Parameters.Add(prmt1);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (baglan != null)
                {
                    baglan.Close();
                }
            }
        }
    }
}

