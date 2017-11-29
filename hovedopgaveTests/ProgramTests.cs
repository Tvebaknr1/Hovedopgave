using Microsoft.VisualStudio.TestTools.UnitTesting;
using hovedopgave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hovedopgave.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void dictinaryfile()
        {
            string file = System.IO.File.ReadAllText(Fileloader.dictinaryfile);
            Assert.IsFalse(String.IsNullOrEmpty(file));
            file = System.IO.File.ReadAllText(Fileloader.passwordfile);
            Assert.IsFalse(String.IsNullOrEmpty(file));
        }
        [TestMethod()]
        public void rainbowfileSha1()
        {
            string file = System.IO.File.ReadAllText(Fileloader.RainbowfileSha1);
            if (String.IsNullOrEmpty(file))
            {
                RainbowTableGenerator.generateRainbow(Fileloader.passwordfile, Fileloader.RainbowfileSha1, new sha1());
                file = System.IO.File.ReadAllText(Fileloader.RainbowfileSha1);
            }
            Assert.IsFalse(String.IsNullOrEmpty(file));
        }
        [TestMethod()]
        public void rainbowfileSha256()
        {
            string file = System.IO.File.ReadAllText(Fileloader.RainbowfileSha256);
            if (String.IsNullOrEmpty(file))
            {
                RainbowTableGenerator.generateRainbow(Fileloader.passwordfile, Fileloader.RainbowfileSha256, new sha256());
                file = System.IO.File.ReadAllText(Fileloader.RainbowfileSha256);
            }
            Assert.IsFalse(String.IsNullOrEmpty(file));
        }
        [TestMethod()]
        public void rainbowfileSha512()
        {
            string file = System.IO.File.ReadAllText(Fileloader.RainbowfileSha512);
            if (String.IsNullOrEmpty(file))
            {
                RainbowTableGenerator.generateRainbow(Fileloader.passwordfile, Fileloader.RainbowfileSha512, new sha512());
                file = System.IO.File.ReadAllText(Fileloader.RainbowfileSha512);
            }
            Assert.IsFalse(String.IsNullOrEmpty(file));
        }
        [TestMethod()]
        public void rainbowfileMD5()
        {
            string file = System.IO.File.ReadAllText(Fileloader.RainbowfileMD5);
            if (String.IsNullOrEmpty(file))
            {
                RainbowTableGenerator.generateRainbow(Fileloader.passwordfile, Fileloader.RainbowfileMD5, new md5());
                file = System.IO.File.ReadAllText(Fileloader.RainbowfileMD5);
            }
            Assert.IsFalse(String.IsNullOrEmpty(file));
        }
        //test metode til at teste hvormange den få i en password batch
        [TestMethod()]
        public void MainTest()
        {
            //test if can get passwords file
            //test if can get dictionary of most used passwords
            //test if dicsinary can get "password" password
            //test if dicsinary can not get "sfhshfgshfhoifaofh0sfåhiug"
            //test if dicsinary can get ""
            //test if bruteforce can get them
            //test how fast it is at getting them hashed 
            //test with rainbow table
            //test 
        }
        
        
    }
}