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
            string file = System.IO.File.ReadAllText(Program.dictinaryfile);
            Assert.IsFalse(String.IsNullOrEmpty(file));
            file = System.IO.File.ReadAllText(Program.passwordfile);
            Assert.IsFalse(String.IsNullOrEmpty(file));
        }

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
        
        [TestMethod()]
        public void attackTestSimplePassword()
        {
            string[] list = { "password" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 1);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTestRandomPassword()
        {
            string[] list = { "sfhshfgshfhoifaofh0sfåhiug" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 0);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTestRepeatWord()
        {
            string[] list = { "passwordpassword" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            attackMethod attackmethod = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, attackmethod) == 1);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTestshortnotword()
        {
            string[] list = { "abc" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 0);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 1);
        }
        [TestMethod()]
        public void attackTestNumberAtEnd()
        {
            string[] list = { "password1" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTestNumberAtStart()
        {
            string[] list = { "1password" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTest1995()
        {
            string[] list = { "password1995" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTestyearatstart()
        {
            string[] list = { "1995password" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTestLeat()
        {
            string[] list = { "P455W0RD" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTestCAPS()
        {
            string[] list = { "PASSWORD" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTestSemiCAPS()
        {
            string[] list = { "PaSsWoRd" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attacktesttwowords()
        {
            string[] list = { "passworddragon" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attacktestTwoWords()
        {
            string[] list = { "PasswordDragon" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attacktestThreeWords()
        {
            string[] list = { "letmein" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attacktestTwoWordsWithNumber()
        {
            string[] list = { "PasswordDragon1" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attacktestTwoWordsWithyear()
        {
            string[] list = { "PasswordDragon1995" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void hashedattacktest()
        {
            //password hashed in MD5
            string[] list = { "5f4dcc3b5aa765d61d8327deb882cf99" };
            attackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            hashfunction md5 = new md5();
            Assert.IsTrue(Program.attackhash(list, DictinaryAttackBasic,md5.hash) == 1);
            attackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attackhash(list, DictinaryAttack,md5.hash) == 1);
            attackMethod bruteforce = new bruteforce();
            Assert.IsTrue(Program.attackhash(list, bruteforce,md5.hash) == 0);
        }
    }
}