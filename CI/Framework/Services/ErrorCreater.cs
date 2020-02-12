using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Services
{
    class ErrorCreater
    {
        static readonly string captchaError = "Подтвердите, что вы не робот";
        static readonly string emptyOrInvalidEmail = "Не все обязательные поля были заполнены, либо поле E-mail заполнено некорректно.";
        static readonly string startDateLeaseEndDate = "Дата начала аренды позже даты окончания.";
        static readonly string incorrectLoginOrPassword = "Неверный логин или пароль.";
        static readonly string withoutCorrectData = "Возникли ошибки заполнения полей. Поле Email заполнено некорректно, либо не заполнены обязательные поля \"Телефон\".";
        public static string MessageWithInvalidEMail()
        {
            return emptyOrInvalidEmail;
        }
        public static string MessageWithValidEMail()
        {
            return captchaError;
        }
        public static string CorrectData()
        {
            return captchaError;
        }
        public static string WithoutCorrectData()
        {
            return withoutCorrectData;
        }
        public static string IncorrectLoginOrPassword()
        {
            return incorrectLoginOrPassword;
        }

        public static string MessageWithEmptyFields()
        {
            return emptyOrInvalidEmail;
        }

        public static string StartDateLeaseEndDate()
        {
            return "×\r\n" + startDateLeaseEndDate;
        }
    }
}
