using System;
using System.Collections.Generic;
using System.Text;

namespace Kin.Base.tools
{
    public class Base58
    {
        private static readonly char[] ALPHABET = "123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz".ToCharArray();
        private static readonly char ENCODED_ZERO = ALPHABET[0];
        private static readonly int[] INDEXES = new int[128];

        private class AddressFormatException : ArgumentException
        {
            public AddressFormatException(string message = null)
            {

            }
        }

        sealed class InvalidCharacter : AddressFormatException
        {

        }

        sealed class InvalidDataLength : AddressFormatException
        {

        }

        sealed class InvalidChecksum : AddressFormatException
        {
            public InvalidChecksum()
            {

            }

        }

        string encode(byte[] input)
        {
            var inputCopy = input;
            if (inputCopy.Length == 0)
            {
                return "";
            }

            var zeros = 0;
            while (zeros < inputCopy.Length && inputCopy[zeros] == Convert.ToByte(0))
            {
                ++zeros;
            }

            Array.Copy(inputCopy, inputCopy, inputCopy.Length);
            char[] encoded = new char[inputCopy.Length * 2];
            var outputStart = encoded.Length;
            var inputStart = zeros;
            while (inputStart < inputCopy.Length)
            {
                encoded[--outputStart] = ALPHABET[divmod(inputCopy, inputStart, 256, 58)];
                if(inputCopy[inputStart] == Convert.ToByte(0))
                {
                    ++inputStart;
                }
            }

            while (outputStart < encoded.Length && encoded[outputStart] == ENCODED_ZERO)
            {
                ++outputStart;
            }
            while (--zeros >= 0)
            {
                encoded[--outputStart] = ENCODED_ZERO;
            }
            StringBuilder stringBuilder = new StringBuilder(encoded.ToString(), outputStart, encoded.Length - outputStart, encoded.Length - outputStart);

            return stringBuilder.ToString();
        }

        private byte divmod(byte[] number, int firstDigit, int baseOf, int divisor)
        {
            // this is just long division which accounts for the base of the input digits
            var remainder = 0;
            for (int i = firstDigit; i < number.Length; i++)
            {
                var digit = int.Parse(number[i].ToString());
                var temp = remainder * baseOf + digit;
                number[i] = Convert.ToByte((temp / divisor));
                remainder = temp % divisor;
            }
            return Convert.ToByte(remainder);
        }
    }
}
