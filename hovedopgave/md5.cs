﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace hovedopgave
{
    public class md5 : IHashFunction
    {
        private MD5 myMD5;
        public md5()
        {
            myMD5 = MD5.Create();
        }
        public string hash(string str)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = myMD5.ComputeHash(Encoding.UTF8.GetBytes(str));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
            //return Encoding.UTF8.GetString(myMD5.ComputeHash(Encoding.UTF8.GetBytes(str)));
        }

        public string hash32(string str)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = myMD5.ComputeHash(Encoding.UTF32.GetBytes(str));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        
            //return Encoding.UTF32.GetString(myMD5.ComputeHash(Encoding.UTF32.GetBytes(str)));
        }

        public string hashASCII(string str)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = myMD5.ComputeHash(Encoding.ASCII.GetBytes(str));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
            //return Encoding.ASCII.GetString(myMD5.ComputeHash(Encoding.ASCII.GetBytes(str)));
        }
    }
}