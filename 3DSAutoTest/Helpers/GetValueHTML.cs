using System.Text.RegularExpressions;

namespace _3DSAutoTest.Helpers
{
    public class GetValueHTML
    {
        /// <summary>
        /// Получить значение VALUE по его name в HTML дереве
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="html">HTML строка</param>
        /// <returns></returns>
        public static string GetValue(string name, string html, bool toUpper = false)
        {
            if (name == "PaRes" || toUpper)
            {
                Regex regex = new Regex(@$"NAME=""{name}"".+?VALUE=""([^""]+)""");
                GroupCollection matches = regex.Match(html).Groups;
                string str = matches[1].Value;
                return str;
            }
            else
            {
                Regex regex = new Regex(@$"name=""{name}"".+?value=""([^""]+)""");
                GroupCollection matches = regex.Match(html).Groups;
                string str = matches[1].Value;
                return str;
            }
        }
        /// <summary>
        /// Получение gid для 3DS
        /// </summary>
        /// <param name="html">HTML строка</param>
        /// <returns></returns>
        public static string GetGid(string html)
        {

            Regex regex = new Regex(@$"FORM.+?ACTION=""https://test\.3ds\.payment\.ru/way4acs/pa\?id=([^""]+)""");
            GroupCollection matches = regex.Match(html).Groups;
            string str = matches[1].Value;
            return str.Substring(0, str.Length - 3);

        }
    }
}