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
//    public class InventoryTests
//    {

//        Inventory inventory;
//        Item lazerstick;
//        Item pewpew;

//        Player jedi;

//        [SetUp]
//        public void setup()
//        {
//            jedi = new Player("me", "inventory");
//            inventory = jedi.Inventory;
//            lazerstick = new Item(new string[] { "lazerstick", "lazerstick" }, "a lazerstick", "a small l50tw deathray, pathetic diodos");
//            inventory.PutItem(lazerstick);

//            pewpew = new Item(new string[] { "blasterblaster", "blaster" }, "a blaster", "Makes the Death Star look like a childrens toy");
//        }

//        [Test]
//        public void FindItem()
//        {
//            Assert.IsTrue(inventory.HasItem("lazerstick"));
//        }


//        [Test]
//        public void NoItemFind()
//        {
//            Assert.IsFalse(inventory.HasItem("apples"), "This is broken");
//        }

//        [Test]
//        public void PutItem()
//        {
//            inventory.PutItem(pewpew);
//            Assert.IsTrue(inventory.HasItem("blasterblaster"), inventory.ItemList);

//        }

//        [Test]
//        public void Take()
//        {
//            inventory.Take("pewpew");
//            Assert.IsFalse(inventory.HasItem("pewpew"));
//        }


//        [Test]
//        public void ListItems()
//        {
//            Assert.AreEqual(inventory.ItemList, "\ta lazerstick (lazerstick)\n");
//        }
//    }
//}


