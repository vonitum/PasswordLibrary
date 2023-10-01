using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordLibrary
{
   
    public class PasswordClass
    {
        /// <summary>
        /// В качестве параметра передается строка - пароль
        /// </summary>
        /// <param name="password">
        /// Пароль</param>
        /// <returns>
        /// Метод возвращает целое число, соответствующее сложности пароля
        /// </returns>
        public static int PasswordStrengthCheker(string password)
        {
            if (String.IsNullOrEmpty(password))
            {
                return 0;
            }
            int result = 0;
            //если пароль имеет длину больше 7 символов сложность повышается на 1 балл;
            if (password.Length > 7)
            {
                result++;
            }
            //  если пароль содержит цифры, то сложность повышается ещё на 1 балл;
            if (Regex.Match(password, "[0-9]").Success)
            {
                result++;
            }
            //  если пароль содержит латинские буквы в нижнем регистре, то сложность повышается ещё на 1 балл;
            if (Regex.Match(password, "[a-z]").Success)
            {
                result++;
            }
            //если пароль содержит Заглавные латинские буквы, то сложность повышается ещё на 1 балл;
            if (Regex.Match(password, "[A-Z]").Success)
            {
                result++;
            }
            //если пароль содержит спецсимволы, то сложность повышается ещё на 1 балл
            if (Regex.Match(password, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]").Success)
            {
                result++;
            }
            //если пароль содержит кириллические символы, то выдается исключение «Кириллические символы запрещены при вводе пароля»
            if (Regex.Match(password, "[а-яА-яёЁ]").Success)
            {
                throw new Exception("Пароль не может содеражть кирилические символы");
            }

            return result;
          
        }
        public bool CheckPassword(string password)
        {
            // проверка длины пароля
            if (password.Length < 8 || password.Length > 15)
                return false;
            // проверка наличия цифр
            if (!Regex.IsMatch(password, @"\d"))
                return false;
            // проверка наличия латинских букв в нижнем регистре
            if (!Regex.IsMatch(password, @"[a-z]"))
                return false;
            // проверка наличия латинских букв в верхнем регистре
            if (!Regex.IsMatch(password, @"[A-Z]"))
                return false;
            // проверка наличия спец.символов
            if (!Regex.IsMatch(password, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"))
                return false;
            // проверка отсутствия кириллических символов
            if (Regex.IsMatch(password, @"[а-яА-Я]"))
                return false;
            return true;
        }
    }
}
