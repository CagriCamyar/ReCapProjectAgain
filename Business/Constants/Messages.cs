using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string MaintenanceTime = "Sistem Su Anda Bakimda";

        public static string CarsListed = "Arabalar Listelendi";
        public static string CarAdded = "Arac Eklendi.";
        public static string CarRented = "Bu Arac Su Anda Kiralamada";
        public static string GetCar = "Sectiginiz Araba : ";
        public static string InvalidName = "Eklemek Istenen Aracin Adi 3 Harften Kisa Olamaz";
        public static string InvalidPrice = "Eklemek Istenen Aracin Ucreti 0(sifir)dan Kucuk veya Esit Olamaz";

        public static string BrandMissed = "Markaya Ait Arac Bulunamamistir.";
        public static string GetBrand = "Sectiginiz Marka : ";
        public static string InvalidBrandId = "Sistemde Bulunmayan Bir Marka Girdiniz";
        public static string BrandUpdated = "Marka Guncellendi";
        public static string BrandsListed = "Markalar Listelendi";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";

        public static string GetColour = "Sectiginiz Renk : ";
        public static string ColourAdded = "Renk Eklendi";
        public static string ColourDeleted = "Renk Silindi";
        public static string ColoursListed = "Renkler Listelendi";
        public static string ColourUpdated = "Renk Guncellendi";
        public static string InvalidColourId = "Boyle bir renk yok";

        public static string CustomerUpdated = "Musteri Guncellendi";
        public static string CustomersListed = "Musteriler Listelendi";
        public static string CustomerDeleted = "Musteri Silindi";
        public static string CustomerAdded = "Musteri Eklendi";
        public static string GetCustomer = "Sectiginiz Musteri : ";
        public static string CustomersDetailsListed = "Musteriye Ait Bilgiler Listelendi";

        public static string RentalUpdated = "Kiralama Guncellendi";
        public static string RentalsListed = "Kiralamalar Listelendi";
        public static string GetRental = "Sectiginiz Kiralama Bilgisi : ";
        public static string RentalDeleted = "Kiralama Silindi";
        public static string RentalAdded = "Kiralama Eklendi";
        public static string GetRentalByCarId = "Sectiginiz Aracin Kiralama Bilgisi : ";

        public static string UserUpdated = "Kullanici Guncellendi";
        public static string GetUser = "Aradiginiz Kullanici : ";
        public static string UsersListed = "Kullanicilar Listelendi";
        public static string UserDeleted = "Kullanici Silindi";
        public static string UserAdded = "Kullanici Eklendi";

        public static string CarImageAdded = "Image Eklendi";
        public static string CarImageDeleted = "Image Silindi";
        public static string CarImageUpdated = "Image Guncellendi";
        public static string GetByImageId = "Sectiginiz Resim : ";
        public static string GetImageByCarId = "Sectiginiz Aracin Resmi : ";
        public static string ImagesListed = "Gorseller Listelendi";
        public static string ImageLimitInvalid = "Maksimum Kapasitede Fotograf Zaten Mevcut";
        public static string ImageLimitSucceed = " Fotograf Eklendi";

        public static string AccessTokenCreated = "Token Olusturuldu";

        public static string UserRegistered = "Kayit Basarili";
        public static string UserNotFound = "Kullanici Bulunamadi";
        public static string PasswordError = "Hatali Sifre";
        public static string SuccessfulLogin = "Giris Basarili";
        public static string UserAlreadyExists = "Bu Kullanici Adi Mevcut";
    }
}
