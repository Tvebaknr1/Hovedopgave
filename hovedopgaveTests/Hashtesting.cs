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
    public class Hashtesting
    {

        [TestMethod()]
        public void hashtestMD5()
        {
            string[] list = { "0cc175b9c0f1b6a831c399e269772661" };
            IHashFunction hashfunction = new md5();
            Assert.IsTrue(hashfunction.hash("a").Equals(list[0]));
        }
        [TestMethod()]
        public void hashtestSHA1()
        {
            string[] list = { "86f7e437faa5a7fce15d1ddcb9eaeaea377667b8" };
            IHashFunction hashfunction = new sha1();
            Assert.IsTrue(hashfunction.hash("a").Equals(list[0]));
        }
        [TestMethod()]
        public void hashtestSHA2()
        {
            string[] list = { "ca978112ca1bbdcafac231b39a23dc4da786eff8147c4e72b9807785afee48bb" };
            IHashFunction hashfunction = new sha256();
            Assert.IsTrue(hashfunction.hash("a").Equals(list[0]));
        }
        [TestMethod()]
        public void hashtestSHA512()
        {
            string[] list = { "1F40FC92DA241694750979EE6CF582F2D5D7D28E18335DE05ABC54D0560E0F5302860C652BF08D560252AA5E74210546F369FBBBCE8C12CFC7957B2652FE9A75" };
            IHashFunction hashfunction = new sha512();
            Assert.IsTrue(hashfunction.hash("a").Equals(list[0]));
        }
    }
}
