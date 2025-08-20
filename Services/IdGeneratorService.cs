using System.Security.Cryptography; //cryptographically secure random number generator
using System.Text;

namespace WebPhim.Services
{
    public class IdGeneratorService
    {

        //Bang ki tu
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public string GenerateId(string prefix, int length = 7)
        {
            var bytes = new byte[length];
            RandomNumberGenerator.Fill(bytes);

            var sb = new StringBuilder(prefix);
            for (int i = 0; i < length; i++)
            {
                sb.Append(chars[bytes[i] % chars.Length]);

            }
            return sb.ToString();
        }
    }
}
