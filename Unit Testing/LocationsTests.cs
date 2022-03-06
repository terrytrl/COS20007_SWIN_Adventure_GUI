
//using SwinAdventure;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using NUnit.Framework;

//namespace SwinAdventure.Tests
//{


//    [TestFixture]
//    public class LocationsTests
//    {
//        Player player;
//        Locations location;

//        Item item;

//        [SetUp()]
//        public void LocateTest()
//        {
//            location = new Locations(new string[] { "house" }, "house", "A small well kept shack");
//            item = new Item(new string[] { "table" }, "table", "a small mohogany table");

//            location.Inventory.PutItem(item);
//        }

//        //Locations can identify themselves.
//        [Test]
//        public void locationidentifies()
//        {
//            Assert.IsTrue(location.AreYou("house"), "Should be true");
//        }

//        //Locations can locate items they have.
//        [Test]
//        public void LocationLocatesItem()
//        {
//            Assert.AreEqual(item, location.Locate("table"));
//        }
//    }
//}









