using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_AJC
{
    internal class Crypto
    {
        //decryption exponent public member to be shared between functions
        public static int decrypt;
        public static int rsa_module;


        //Encrypts string using supplied primes p and q to create keys
        public static string RSA_E(int p, int q, string message)
        {
            //random will later be used for picking encryption exponent
            Random r = new Random();
            //because of computational burden of checking for primeness,
            //we leave it to the client to ensure the arguments are prime
            //and just calculate the RSA module
            int module = p * q;
            int totient = (p-1) * (q-1);
            bool done = false;
            int encryption_exponent;
            int decryption_exponent;
            int choice = 1;
            //randomly choose encryption exponent until a valid one is found
            while (!done)
            {
                choice = r.Next(1,totient);
                if (ExtendedEuclid(choice, totient) == 1)
                {
                    done = true;
                }
            }
            encryption_exponent = choice;
            decryption_exponent = (1 % totient) / encryption_exponent;
            rsa_module = module;
            decrypt = decryption_exponent;
            //encrypt the message, converting to bytes, then to an integer, then using public key...
            char[] msg = message.ToCharArray();
            int[] enc_num = new int[msg.Length];
            for (int i = 0; i < enc_num.Length; i++)
            {
                enc_num[i] = ((int)msg[i]^encryption_exponent) % module;
            }
            //then converting back to text
            char[] enc_message = new char[enc_num.Length];
            for (int i = 0; i < enc_message.Length; i++)
            {
                enc_message[i] = (char)enc_num[i];
            }
            string result = new(enc_message);
            return result;
        } 
        public static string RSA_D(string ciphertext)
        {
            char[] msg = ciphertext.ToCharArray();
            int[] cipher_num = new int[msg.Length];
            for(int i = 0;i < cipher_num.Length; i++)
            {
                cipher_num[i]= ((int)msg[i])^decrypt % rsa_module;
            }
            char[] message = new char[msg.Length];
            for(int j = 0; j < message.Length; j++)
            {
                message[j] = (char)cipher_num[j];
            }

            string result = new(message);
            Console.WriteLine(result);
            return result;
        }
        public static int ExtendedEuclid(int a, int b)
        {
            if (a == b) return a;
            int greater;
            int lesser;
            if (a < b)
            {
                greater = b;
                lesser = a;
            }
            else
            {
                greater = a;
                lesser = b;
            }
            int remainder = greater % lesser;
            while (remainder != 0)
            {
                greater = lesser;
                lesser = remainder;
                remainder = greater % greater;
            }
            return lesser;
        }
    }
}
