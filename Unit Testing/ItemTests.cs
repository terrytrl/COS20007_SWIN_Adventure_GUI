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
//    public class ItemTests
//    {
//        Player jedi;
//        Inventory inventory;
//        Item lazerStick;

//        [SetUp]
//        public void SetUp()
//        {
//            jedi = new Player("me", "inventory");
//            inventory = new Inventory();
//            lazerStick = new Item(new string[] { "lazerstick", "Lightboi" }, "a lazerStick", "A small l50TW beam of light, pathetic diodos mate");
//        }

//        [Test]
//        public void IsIdentifiable()
//        {
//            Assert.IsTrue(lazerStick.AreYou("lazerstick"));
//        }

//        [Test]
//        public void ShortDesc()
//        {
//            Assert.AreEqual(lazerStick.ShortDescription, "a lazerStick (lazerstick)");
//        }

//        [Test]
//        public void FullDesc()
//        {
//            Assert.AreEqual(lazerStick.FullDescription, "A small l50TW beam of light, pathetic diodos mate");
//        }


//    }
//}