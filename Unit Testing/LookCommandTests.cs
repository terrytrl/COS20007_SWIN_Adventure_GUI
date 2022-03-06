//using SwinAdventure;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using NUnit.Framework;


//namespace SwinAdventure.Tests
//{
//    [TestFixture]
//    public class LookCommandTests
//    {

//        Player jedi;
//        Player jedi2;

//        Bag bag;
//        Item Item;
//        Item Item2;
//        Item Item3;

//        LookCommand look;

//        [SetUp]
//        public void Setup()
//        {
//            Item = new Item(new string[] { "StartRevolutionToken" }, "Start revolution Token", "To Start a revolution click here");
            
//            Item2 = new Item(new string[] { "Item" }, "Item", "Item");
//            Item3 = new Item(new string[] { "Item3" }, "Item3", "Item3");

            
//            bag = new Bag(new string[] { "bag" }, "Rucksack", "seems to contain multiple small pocket dimensions");
            
//            jedi = new Player("The People", "Represent us all");
//            jedi2 = new Player("jedi2", "jedi2");


//            look = new LookCommand();

//            bag.Inventory.PutItem(Item);

//            jedi2.Inventory.PutItem(Item);
//            jedi.Inventory.PutItem(bag);
//        }

//        [Test]
//        public void LookAtMe()
//        {
//            string expected = "You are The People, The People (me)\nYou are carrying\n\tRucksack (bag)\n";
//            string actual = look.Execute(jedi, new string[] { "look", "at", "me" });

//            Assert.AreEqual(expected, actual, actual);
//        }

//        [Test]
//        public void LookAtGem()
//        {
//            string expected = "To Start a revolution click here";
//            string actual = look.Execute(jedi, new string[] { "look", "at", "StartRevolutionToken", "in", "bag" });
            
//            Assert.AreEqual(expected, actual, actual);
//        }

//        [Test]
//        public void NoItemFound()
//        {
//            string expected = "Item";
//            string actual = look.Execute(jedi, new string[] { "look", "at", "Item", "in", "bag" });
//            Assert.AreNotEqual(expected, actual, actual);
//        }

//        [Test]
//        public void ItemDiscription()
//        {
//            string expected = "To Start a revolution click here";
//            string actual = look.Execute(jedi2, new string[] { "look", "at", "StartRevolutionToken" });
//            Assert.AreEqual(expected, actual, actual);
//        }


//        [Test]
//        public void LookAtBag()
//        {
//            string expected = "You are The People, The People (me)\nYou are carrying\n\tRucksack (bag)\n";
//            string actual = look.Execute(jedi, new string[] { "look", "at", "me" });
//            Assert.AreEqual(expected, actual, actual);
//        }

//        [Test]
//        public void LookAtNoGemInBag()
//        {
//            string expected = "I can not find the Item2in the Rucksack";
//            string actual = look.Execute(jedi, new string[] { "look", "at", "Item2", "in", "bag" });
//            Assert.AreEqual(expected, actual, actual);
//        }

//        [Test]
//        public void TestInvalidLook()
//        {
//            Assert.AreEqual("I dont know how to look at that", look.Execute(jedi, new string[] { "loot", "at", "Item2", "in", "bag" }));
//            Assert.AreEqual("I dont know how to look at that", look.Execute(jedi, new string[] { "loot", "around", "bag", "in", "bag" }));
//            Assert.AreEqual("I dont know how to look at that", look.Execute(jedi, new string[] { "loot", "bag"}));
//            Assert.AreEqual("I dont know how to look at that", look.Execute(jedi, new string[] { "loot", "at", "Item", "in", "the", "bag"}));
//        }
//    }
//}