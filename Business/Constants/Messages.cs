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
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu ürün  adı zaten var";
        public static string CheckIfCategoryCount = "kategory sınırı";
        public static string AuthorizationDenied = "yetkiniz yok";
        public static string UserRegistered = "Kayıt Başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "şifre hatalı";
        public static string SuccessfulLogin= "giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten kayıtlı";
        public static string AccessTokenCreated = "başarılı";
    }
}
