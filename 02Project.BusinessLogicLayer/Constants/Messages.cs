using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Project.BusinessLogicLayer.Constants
{
    internal static class Messages
    {
        public static string Added ="Eklendi";
        public static string Updated = "Güncellendi";
        public static string Deleted = "Silindi";
        public static string Removed = "Kaldırıldı";
        public static string Listed = "Veriler listelendi";
        public static string GotById = "Bu Id'ye ait veri listelendi";

        public static string UserNotFound = "Kullanıcı kayıtlı değil";
        public static string Logged = "Giriş yapıldı";
        public static string Registered = "Kayıt olundu";
        public static string IncorrectPassword = "Şifre yanlış";
        public static string UserExist = "Kullanıcı kayıtlı";
        public static string PasswordInvalid = "Şifrenizde en az bir büyük harf,en az bir sayı,en az 8 karakter bulunmalıdır.";
        public static string MailPasswordInvalid = "Email veya şifre hatalı";
        public static string RoleChanged = "Kullanıcı yetkisi değiştirildi";
        public static string NotAuthorized = "Yetkiniz yok!";

    }
}
