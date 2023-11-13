using System.Security.Cryptography;
using System.Text;

namespace encryptionDecryption
{
    internal class Program
    {
        static string Encrypt(string input, RijndaelManaged algo)
        {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
            ICryptoTransform transform = algo.CreateEncryptor();
            byte[] transformArray =  transform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            return Convert.ToBase64String(transformArray);
        }

        static string Decrypt(string input,  RijndaelManaged algo) {
            byte[] inputArray = Convert.FromBase64String(input);
            ICryptoTransform transform = algo.CreateDecryptor();
            byte[] transformArray = transform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            return UTF8Encoding.UTF8.GetString(transformArray);

        }

        delegate void Display();
        


        static void Main(string[] args)
        {
            // Anonymous method

            Display objdisp = delegate ()
            {
                Console.WriteLine("This is an anonymous method");
            };

            objdisp();

            objdisp += delegate ()
            {
                Console.WriteLine("Reassignment to anonymous method");
            };

            objdisp();

            RijndaelManaged objAlgo = new RijndaelManaged();
            string text = "Aptech";
            string encryptedtext = Encrypt(text, objAlgo);
            Console.WriteLine("String : "+ text);
            Console.WriteLine("After Encryption : "+encryptedtext);
            string decryptText = Decrypt(encryptedtext, objAlgo);
            Console.WriteLine("After Decryption : "+ decryptText);
        }
    }
}