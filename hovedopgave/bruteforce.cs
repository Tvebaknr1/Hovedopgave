using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace hovedopgave
{
    public class bruteforce : attackMethod
    {
        public string attack(string clearText)
        {
            Regex reg = new Regex(@"[A-Za-z0-9]");
            DateTime start = DateTime.Now;
            List<char> password = new List<char>();
            password.Add(char.MinValue);
            while ((DateTime.Now - start).TotalMinutes < 10)
            {
                //iresse to next legal char
                increaseToNextLegalChar(password, reg);
                //test if password

                if (string.Join("", password.ToArray()).Equals(clearText))
                    return string.Join("", password.ToArray());
            }
            return "";
        }

        private static void increaseToNextLegalChar(List<char> password, Regex reg, int index = 0)
        {
            while (true)
            {
                password[index]++;
                //if first password is max
                if (password[index] >= char.MaxValue)
                {
                    password[index] = char.MinValue;
                    if (password.Count <= index + 1)
                        password.Add(char.MinValue);
                    increaseToNextLegalChar(password, reg, index + 1);
                }
                //is in regex
                else if (reg.IsMatch(char.ToString(password[index])))
                {
                    return;
                }
            }
        }

        public string attackhash(string HashedPassword, Func<string, string> hash )
        {
            Regex reg = new Regex(@"[A-Za-z0-9]");
            DateTime start = DateTime.Now;
            List<char> password = new List<char>();
            password.Add(char.MinValue);
            while ((DateTime.Now - start).TotalMinutes < 10)
            {
                //iresse to next legal char
                increaseToNextLegalChar(password, reg);
                //test if password

                if (hash(string.Join("", password.ToArray())).Equals(HashedPassword))
                    return string.Join("", password.ToArray());
            }
            return "false";
        }


        //private static void increaseToNextLegalChar(List<char> password, Regex reg, int index = 0)
        //{
        //    password[index]++;
        //    //if first password is max
        //    if (password[index] >= char.MaxValue)
        //    {
        //        index++;
        //        increaseToNextLegalChar(password, reg, index);
        //    }
        //    //is in regex
        //    else if (reg.Matches(char.ToString(password[index])).Count == password.Count)
        //    {
        //        return;
        //    }
        //    //basecase
        //    else
        //    {
        //        increaseToNextLegalChar(password, reg, index);
        //    }
        //}
    }
}