using Core.Entities.Concrete;
using Core.Utilities.Security.JWT;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Ekleme işlemi başarıyla tamamlandı.";
        public static string Deleted = "Silme işlemi başarıyla tamamlandı.";
        public static string Updated = "Güncelleme işlemi başarıyla tamamlandı.";
        public static string Listed = "Listeleme işlemi başarıyla tamamlandı.";
        public static string Error = "İşlem başarısız.";
        public static string OperationClaimsListed = "Kullanıcı yetkileri listelendi.";

        public static string UserAlreadyExistError = "Bu email üzerine kayıtlı bir kullanıcı bulunmaktadır.";
        public static string UserRegistered = "Kullanıcı kayıt işlemi başarıyla tamamlandı.";
        public static string IncorrectEmailOrPassword = "Hatalı Email ya da Parola girişi.";
        public static string SuccessUserLogin = "Kullanıcı girişi başarıyla tamamlandı.";
        public static string AccessTokenCreated = "Access Token oluşturma işlemi başarıyla tamamlandı.";
        public static string AuthorizationDenied = "Sistemde bu işlem için yetkiniz bulunmamaktadır.";
    }
}
