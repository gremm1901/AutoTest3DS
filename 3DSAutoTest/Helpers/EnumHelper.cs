using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace _3DSAutoTest.Helpers
{
    public class EnumHelper
    {
        /// <summary>
        /// Получить дескрипшен из Enum
        /// </summary>
        /// <param name="value">Enum</param>
        /// <returns></returns>
        public static string GetDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());

            if (field == null) return null;

            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length == 0) return null;

            return ((DescriptionAttribute)attributes[0]).Description;
        }
    }
}