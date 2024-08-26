using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DSAutoTest.Framework
{
    /// <summary>
    /// Класс с генерацией различных данных
    /// </summary>
    public static class GenerationData
    {
        private const string charsNumbers = "1234567890";
        private const string charsSymbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZqwertyuiopasdfghjklzxcvbnm";
        private const string charsSpecial = "!@#$%^&*()_+=|/?.,m";
        private static readonly string[] charsRole = ["admin", "customer"];
        /// <summary>
        /// Генерация строки без спец символов
        /// </summary>
        /// <param name="length">Длина строки</param>
        /// <returns></returns>
        public static string GenerationString(int length)
        {
            string str = "";
            Random random = new Random();
            //return new string(Enumerable.Repeat(chars, length)
            //    .Select(s => s[random.Next(s.Length)]).ToArray()); нашел в инете и не понял как оно работает поэтому сохранил 

            for (int i = 0; i < length; i++)
            {
                str = str + charsSymbols[random.Next(charsSymbols.Length)];
            }
            return str;
        }
        /// <summary>
        /// Генерация строки из спец символов
        /// </summary>
        /// <param name="length">длина строки</param>
        /// <returns></returns>
        public static string GenerationSpecialCharacters(int length)
        {
            Random random = new Random();
            string str = "";
            for (int i = 0; i < length; i++)
            {
                str += charsSpecial[random.Next(charsSpecial.Length)];
            }
            return str;
        }
        /// <summary>
        /// Генерация почты
        /// </summary>
        /// <param name="length">примерная длина строки</param>
        /// <returns></returns>
        public static string GenerationEmail(int length = 21)
        {
            Random random = new Random();
            string str = "";
            string strDomen = "";
            for (int i = 0; i < (length - 3) / 2; i++)
            {
                str += charsSymbols[random.Next(charsSymbols.Length)];
            }
            for (int i = 0; i < (length - 3) / 2; i++)
            {
                strDomen += charsSymbols[random.Next(charsSymbols.Length)];
            }
            return str + "@" + strDomen + ".ru";
        }
        /// <summary>
        /// Генерация случайного положительного числа, длиною 9 символов
        /// </summary>
        /// <param name="length">длинна числа</param>
        /// <returns></returns>
        public static int GenerationInt(int length)
        {
            Random random = new Random();
            string str = "";
            for (int i = 0; i < length; i++)
            {
                str += charsNumbers[random.Next(charsNumbers.Length)];
            }
            return Convert.ToInt32(str);
        }
        /// <summary>
        /// Генерация случайного положительного числа, длиною 18 символов
        /// </summary>
        /// <param name="length">длинна числа</param>
        /// <returns></returns>
        public static long GenerationLong(int length)
        {
            Random random = new Random();
            string str = "";
            for (int i = 0; i < length; i++)
            {
                str += charsNumbers[random.Next(charsNumbers.Length)];
            }
            return Convert.ToInt64(str);
        }
        /// <summary>
        /// Создает номер телефона начинающийся с 79
        /// </summary>
        /// <param name="lengt">Длина номер без учета 79</param>
        /// <returns></returns>
        public static string GenerationMobilePhone(int lengt = 9)
        {
            return "79" + GenerationLong(lengt).ToString();
        }
        /// <summary>
        /// Создает номер телефона начинающийся с 495
        /// </summary>
        /// <param name="lengt">Длина номер без учета 495</param>
        /// <returns></returns>
        public static string GenerationHomePhone(int lengt = 7)
        {
            return "495" + GenerationLong(lengt).ToString();
        }
        /// <summary>
        /// Создает URL "https://" случайный набор символов ".ru"
        /// </summary>
        /// <param name="lengt">Длина URL без учета "https://" ".ru"</param>
        /// <returns></returns>
        public static string GenerationUrl(int lengt = 12)
        {
            return "https://" + GenerationString(lengt) + ".ru";
        }
        /// <summary>
        /// Возвращает роль 0 = admin, 1 = customer
        /// </summary>
        /// <param name="role"> 0 = admin, 1 = customer </param>
        /// <returns></returns>
        public static string GenerationRole(int role)
        {
            return role switch
            {
                0 => charsRole[0],
                1 => charsRole[1],
                _ => charsRole[0],
            };
        }
    }
}
