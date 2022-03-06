//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using SwinAdventure;



//namespace SwinAdventure.Tests
//{
//    [TestFixture]
//    public class PlayerTests
//    {

//        Player jedi;
//        Inventory inventory;
//        Item lazerstick;
                
//        [SetUp]
//        public void setup()
//        {
//            jedi = new Player("me", "a jedi");
//            inventory = jedi.Inventory;
//            lazerstick = new Item(new string[] { "lazerstick", "lazerstick" }, "a lazerstick", "a small l50tw deathray, pathetic diodos");
//            inventory.PutItem(lazerstick);
//        }

//        [Test]
//        public void IsIdentifiable()
//        {
//            Assert.IsTrue(jedi.AreYou("me"), "This should be true");
//        }


//        [Test]
//        public void LocateItem()
//        {
//            Assert.AreEqual(lazerstick, jedi.Locate("lazerstick"));
//        }

//        [Test]
//        public void LocatNothing()
//        {
//            Assert.AreEqual(null, jedi.Locate("holocron"));
//        }

//        [Test]
//        public void LocateSelf()
//        {
//            Assert.AreEqual(jedi, jedi.Locate("me"));
//        }

//        [Test]
//        public void LocateDiscription()
//        {
//            Assert.AreEqual("a small l50tw deathray, pathetic diodos", lazerstick.FullDescription);
//        }
//    }
//}
