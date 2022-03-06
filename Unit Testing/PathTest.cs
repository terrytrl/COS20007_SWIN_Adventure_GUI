//using SwinAdventure;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using NUnit.Framework;

//namespace SwinAdventure.Tests
//{
//    [TestFixture]
//    public class PathTest
//    {

//        Player player;
//        Locations location1;
//        Locations location2;

//        Path path1;

//        MoveCommand moveCMD;

//        [SetUp]

//        public void Setup()
//        {
//            player = new Player("player", "the player");
//            location1 = new Locations(new string[] { "house" }, "house", "a spooky house");
//            location2 = new Locations(new string[] { "yahyahs" }, "yahyahs", "a fun nightclub");

//            path1 = new Path(new string[] { "yahyahsPath" }, "yahyahsPath", "a path to yahyahs", location2);

//            player.Location = location1;

//            moveCMD = new MoveCommand();
//        }

//        [Test]
//        public void TestPlayerLocation()
//        {
//            Assert.AreEqual("house", player.Location.FirstId);
//        }


//        //Move player. In the case of this example we are also testing our ability
//        //to leave a location. For one to be true so must the other. 
//        [Test]
//        public void PathMovePlayer()
//        {
//            path1.PlayerMove(player);
//            Assert.AreEqual("yahyahs", player.Location.FirstId);
//        }

//        [Test]
//        public void LocationContainsPath()
//        {
//            location1.Paths.Add(path1);
//            Assert.True(location1.Paths.Contains(path1));
//        }


//        [Test]
//        public void moveCMDaction()
//        {
//            location1.Paths.Add(path1);
//            Assert.AreEqual("You head yahyahspath. a path to yahyahs. You arrive in a yahyahs", moveCMD.Execute(player, new string[] {  "move", "yahyahsPath" }));
//        }

//        [Test]
//        public void moveCMDactionFail()
//        {
//            location1.Paths.Add(path1);
//            Assert.AreEqual("That is not a valid path", moveCMD.Execute(player, new string[] { "move", "work" }));
//        }

//        public void FirstWordNotLook()
//        {
//            string expected = "Error in look input";
//            string actual = moveCMD.Execute(player, new string[] { "hi" });
//            Assert.AreEqual(expected, actual, actual);
//        }
        
//        //location1.Paths.Add(path1);

//            //moveCMD.Execute(player, new string[] { "gr", "yahyahs" });


//    }
//}


















