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
//    public class BagTests
//    {

//        Bag _bag;
//        Bag _bag2;

//        Item item1;
//        Item item2;
//        Item item3;

//        [SetUp]
//        public void setup()
//        {
//            item1 = new Item(new string[] { "H2O" }, "Water", "Great if you are thirsty");
//            item2 = new Item(new string[] { "lazer" }, "pewpew", "Great for vaporising");
//            item3 = new Item(new string[] { "Deathstar" }, "A large moon", "Harry, i am your father. Join the dark side");

//            _bag = new Bag(new string[] { "backpack" }, "backpack", "A backpack");
//            _bag2 = new Bag(new string[] { "backpack2" }, "backpack2", "Another backpack");

//            _bag.Inventory.PutItem(item1);
//            _bag2.Inventory.PutItem(item2);
//            _bag.Inventory.PutItem(_bag2);
//        }

//        [Test]
//        public void BagLocatesItem()
//        {
//            Assert.AreEqual(item1, _bag.Locate("H2O"));
//        }

//        [Test]
//        public void BagLocatesItself()
//        {
//            Assert.AreEqual(_bag, _bag.Locate("backpack"));
//        }

//        [Test]
//        public void BagLocatesNothing()
//        {
//            Assert.IsNull(_bag.Locate("tritium_Deuterium Fuel"));
//        }

//        [Test]
//        public void BagFullDescription()
//        {
//            Assert.AreEqual("in the backpack you can see backpack (backpack).", _bag.FullDescription);
//        }

//        [Test]
//        public void BagInBag()
//        {
//            Assert.AreEqual(_bag2, _bag.Locate("backpack2"));
//        }
//    }
//}


