using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç kayıt işlemi başarılı";
        public static string CarNameInvalid = "Araç  ismi geçersiz";
        public static string CarDeleted = "Araç silme işlemi başarılı";
        public static string CarUpdated = "Araç güncelleme işlemi başarılı";
        public static string FailedCarAddOrUpdate = "Lütfen araba isminin uzunluğu 2 karakterden fazla giriniz";

        public static string ColorAdded = "Renk başarıyla eklendi.";
        public static string ColorDeleted = "Renk başarıyla silindi.";
        public static string ColorUpdated = "Renk başarıyla güncellendi.";

        public static string BrandAdded = "Marka başarıyla eklendi";
        public static string BrandDeleted = "Marka başarıyla silindi";
        public static string BrandUpdated = "Marka başarıyla güncellendi";
        public static string FailedBrandAddOrUpdate = "Lütfen marka isminin uzunluğunu 2 karakterden fazla giriniz.";

        public static string RentalAdded = "Araba kiralama işlemi başarıyla gerçekleşti";
        public static string RentalDeleted = "Araba kiralama işlemi iptal edildi";
        public static string RentalUpdated = "Araba kiralama işlemi güncellendi";
        public static string RentalReturned = "Kiraladığınız araç teslim edildi";
        public static string FailedRentalAddOrUpdate = "Bu araba henüz teslim edilmediği için kiralayamazsınız.";

        public static string CustomerAdded = "Müşteri başarıyla eklendi.";
        public static string CustomerDeleted = "Müşteri başarıyla silindi.";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi.";

        public static string CarImageLimitExceeded = "Resim ekleme limiti aşıldı";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kayıt olundu";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "Parola Hatası";
        public static string SuccessfullLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
