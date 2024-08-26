using System.Security.Cryptography;
using System.Text;

namespace _3DSAutoTest.Helpers
{
    public class PasswordSalt
    {
        /// <summary>
        /// двойная посолка и хэширование пароля
        /// </summary>
        /// <param name="pwd">Сам пароль</param>
        /// <param name="salt">PassworSalt</param>
        /// <param name="sessSalt">SessionSalt</param>
        /// <returns></returns>
        public static string SaltPassword(string pwd, string salt, string sessSalt)
        {
            // Преобразуем пароль в байты с использованием UTF-16LE
            byte[] pwdBytes = Encoding.Unicode.GetBytes(pwd);

            // Декодируем соль из Base64 и объединяем её с паролем
            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] combinedBytes = new byte[saltBytes.Length + pwdBytes.Length];
            Buffer.BlockCopy(saltBytes, 0, combinedBytes, 0, saltBytes.Length);
            Buffer.BlockCopy(pwdBytes, 0, combinedBytes, saltBytes.Length, pwdBytes.Length);

            // Хэшируем объединённые данные с помощью SHA256
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(combinedBytes);

                // Декодируем сессионную соль из Base64
                byte[] sessSaltBytes = Convert.FromBase64String(sessSalt);

                // Применяем PBKDF2
                using (var pbkdf2 = new Rfc2898DeriveBytes(hash, sessSaltBytes, 10000))
                {
                    // Возвращаем результат в Base64
                    return Convert.ToBase64String(pbkdf2.GetBytes(32)); // keySize: 64 байта (512 бит)
                }
            }
        }
    }
}
