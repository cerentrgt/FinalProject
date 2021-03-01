using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryCorrectError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Aynı isimden ürün ekleyemezsiniz";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenmiyor.";
        public static string AuthorizationDenied = "Yetkin yok.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatası.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string SuccessfulLogin="Başarılı giriş.";
        public static string UserRegistered ="Kayıt oldu.";
        internal static string AccessTokenCreated = "Token oluşturuldu.";
    }
}
