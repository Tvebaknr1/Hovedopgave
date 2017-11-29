using hovedopgave;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hovedopgaveTests
{
    [TestClass()]
    public class AttackTests
    {
        [TestMethod()]
        public void attackTestSimplePasswordDictinaryBasic()
        {
            string[] list = { "password" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 1);
            
        }
        [TestMethod()]
        public void attackTestSimplePasswordDictinary()
        {
            string[] list = { "password" };
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
        }
        [TestMethod()]
        public void attackTestSimplePasswordBruteforce()
        {
            string[] list = { "password" };
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        
        [TestMethod()]
        public void attackTestRandomPasswordDictinaryBasic()
        {
            string[] list = { "sfhshfgshfhoifaofh0sfåhiug" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
        }
        [TestMethod()]
        public void attackTestRandomPasswordDictinary()
        {
            string[] list = { "sfhshfgshfhoifaofh0sfåhiug" };
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 0);
        }
        [TestMethod()]
        public void attackTestRandomPasswordBruteforce()
        {
            string[] list = { "sfhshfgshfhoifaofh0sfåhiug" };
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTestRepeatWordDictinaryBasic()
        {
            string[] list = { "passwordpassword" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
            
        }
        [TestMethod()]
        public void attackTestRepeatWordDictinary()
        {
            string[] list = { "passwordpassword" };
            IAttackMethod attackmethod = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, attackmethod) == 1);
        }
        [TestMethod()]
        public void attackTestRepeatWordBruteforce()
        {
            string[] list = { "passwordpassword" };
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        
        [TestMethod()]
        public void attackTestshortnotwordDictinaryBasic()
        {
            string[] list = { "bgw" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
        }
        [TestMethod()]
        public void attackTestshortnotwordDictinary()
        {
            string[] list = { "bgw" };
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 0);
        }
        [TestMethod()]
        public void attackTestshortnotwordBruteforce()
        {
            string[] list = { "bgw" };
            IAttackMethod bruteforce = new bruteforce(10);
            Assert.IsTrue(Program.attack(list, bruteforce) == 1);
        }
        [TestMethod()]
        public void attackTestNumberAtEndDictinaryBasic()
        {
            string[] list = { "password1" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
        }
        [TestMethod()]
        public void attackTestNumberAtEndDictinary()
        {
            string[] list = { "password1" };
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
        }
        [TestMethod()]
        public void attackTestNumberAtEndBruteforce()
        {
            string[] list = { "password1" };
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTestNumberAtStartDictinaryBasic()
        {
            string[] list = { "1password" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
        }
        [TestMethod()]
        public void attackTestNumberAtStartDictinary()
        {
            string[] list = { "1password" };
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
        }
        [TestMethod()]
        public void attackTestNumberAtStartBruteforce()
        {
            string[] list = { "1password" };
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTest1995DictinaryBasic()
        {
            string[] list = { "password1995" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
        }
        [TestMethod()]
        public void attackTest1995Dictinary()
        {
            string[] list = { "password1995" };
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
        }
        [TestMethod()]
        public void attackTest1995Bruteforce()
        {
            string[] list = { "password1995" };
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTestyearatstartDictinaryBasic()
        {
            string[] list = { "1995password" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
        }
        [TestMethod()]
        public void attackTestyearatstartDictinary()
        {
            string[] list = { "1995password" };
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
        }
        [TestMethod()]
        public void attackTestyearatstartBruteforce()
        {
            string[] list = { "1995password" };
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTestLeatDictinaryBasic()
        {
            string[] list = { "P455W0RD" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
        }
        [TestMethod()]
        public void attackTestLeatDictinary()
        {
            string[] list = { "P455W0RD" };
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
        }
        [TestMethod()]
        public void attackTestLeatBruteforce()
        {
            string[] list = { "P455W0RD" };
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTestCAPSDictinaryBasic()
        {
            string[] list = { "PASSWORD" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
        }
        [TestMethod()]
        public void attackTestCAPSDictinary()
        {
            string[] list = { "PASSWORD" };
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
        }
        [TestMethod()]
        public void attackTestCAPSBruteforce()
        {
            string[] list = { "PASSWORD" };
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attackTestSemiCAPSDictinaryBasic()
        {
            string[] list = { "PaSsWoRd" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
        }
        [TestMethod()]
        public void attackTestSemiCAPSDictinary()
        {
            string[] list = { "PaSsWoRd" };
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
        }
        [TestMethod()]
        public void attackTestSemiCAPSBruteforce()
        {
            string[] list = { "PaSsWoRd" };
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attacktesttwowordsDictinaryBasic()
        {
            string[] list = { "passworddragon" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
        }
        [TestMethod()]
        public void attacktesttwowordsDictinary()
        {
            string[] list = { "passworddragon" };
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
        }
        [TestMethod()]
        public void attacktesttwowordsBruteforce()
        {
            string[] list = { "passworddragon" };
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attacktestTwoWordsDictinaryBasic()
        {
            string[] list = { "PasswordDragon" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
        }
        [TestMethod()]
        public void attacktestTwoWordsDictinary()
        {
            string[] list = { "PasswordDragon" };
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
        }
        [TestMethod()]
        public void attacktestTwoWordsBruteforce()
        {
            string[] list = { "PasswordDragon" };
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attacktestThreeWordsDictinaryBasic()
        {
            string[] list = { "letmein" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
        }
        [TestMethod()]
        public void attacktestThreeWordsDictinary()
        {
            string[] list = { "letmein" };
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
        }
        [TestMethod()]
        public void attacktestThreeWordsBruteforce()
        {
            string[] list = { "letmein" };
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attacktestTwoWordsWithNumberDictinaryBasic()
        {
            string[] list = { "PasswordDragon1" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
        }
        [TestMethod()]
        public void attacktestTwoWordsWithNumberDictinary()
        {
            string[] list = { "PasswordDragon1" };
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
        }
        [TestMethod()]
        public void attacktestTwoWordsWithNumberBruteforce()
        {
            string[] list = { "PasswordDragon1" };
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void attacktestTwoWordsWithyearDictinaryBasic()
        {
            string[] list = { "PasswordDragon1995" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            Assert.IsTrue(Program.attack(list, DictinaryAttackBasic) == 0);
        }
        [TestMethod()]
        public void attacktestTwoWordsWithyearDictinary()
        {
            string[] list = { "PasswordDragon1995" };
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attack(list, DictinaryAttack) == 1);
        }
        [TestMethod()]
        public void attacktestTwoWordsWithyearBruteforce()
        {
            string[] list = { "PasswordDragon1995" };
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attack(list, bruteforce) == 0);
        }
        [TestMethod()]
        public void hashedattacktestDictinaryBasic()
        {
            //password hashed in MD5
            string[] list = { "5f4dcc3b5aa765d61d8327deb882cf99" };
            IAttackMethod DictinaryAttackBasic = new DictinaryAttackBasic();
            IHashFunction md5 = new md5();
            Assert.IsTrue(Program.attackhash(list, DictinaryAttackBasic, md5.hash) == 1);
        }
        [TestMethod()]
        public void hashedattacktestDictinary()
        {
            //password hashed in MD5
            string[] list = { "5f4dcc3b5aa765d61d8327deb882cf99" };
            IHashFunction md5 = new md5();
            IAttackMethod DictinaryAttack = new DictinaryAttack();
            Assert.IsTrue(Program.attackhash(list, DictinaryAttack, md5.hash) == 1);
        }
        [TestMethod()]
        public void hashedattacktestBruteforce()
        {
            //password hashed in MD5
            string[] list = { "5f4dcc3b5aa765d61d8327deb882cf99" };
            IHashFunction md5 = new md5();
            IAttackMethod bruteforce = new bruteforce(0);
            Assert.IsTrue(Program.attackhash(list, bruteforce, md5.hash) == 0);
        }
    }
}
