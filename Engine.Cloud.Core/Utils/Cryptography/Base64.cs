﻿using System;
using System.Text;

namespace Utils
{
    public class Base64
    {
        public static string Encrypt(string text)
        {
            Throw.IfIsNullOrEmpty(text);

            byte[] toEncodeAsBytes = ASCIIEncoding.ASCII.GetBytes(text);
            string returnValue = Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }

        public static string Decrypt(string text)
        {
            Throw.IfIsNullOrEmpty(text);

            byte[] encodedDataAsBytes = Convert.FromBase64String(text);
            string returnValue = ASCIIEncoding.ASCII.GetString(encodedDataAsBytes);
            return returnValue;
        }
    }
}
