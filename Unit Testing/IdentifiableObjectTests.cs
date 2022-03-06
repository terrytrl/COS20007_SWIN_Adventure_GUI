//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using SwinAdventure;
//using System;
//using System.Collections.Generic;

//namespace SwinAdventure.Tests
//{
//    [TestClass()]
//    public class IdentifiableObjectTests
//    {
//        IdentifiableObject Id = new IdentifiableObject(new string[] { "id1", "id2" });

//        [TestMethod()]
//        public void AreYouTest()
//        {
//            Assert.IsTrue(Id.AreYou("id2"), "This should return true");
//        }
        
//        [TestMethod()]
//        public void NotAreYou()
//        { 
//            Assert.IsFalse(Id.AreYou("id4"), "This should return false");
//        }

//        [TestMethod()]
//        public void CaseSensativeTest()
//        {

//            Assert.IsTrue(Id.AreYou("ID2"), "This should return true");
//        }

//        [TestMethod()]
//        public void FirstIDTest()
//        {

//            Assert.AreEqual("id1", Id.FirstId, true, "This should return true");
//        }

//        [TestMethod()]
//        public void IsTrueTest()
//        {
//            Id.AddIdentifier("newid");
//            Assert.IsTrue(Id.AreYou("newid"), "This should return true");
//        }
//    }
//}