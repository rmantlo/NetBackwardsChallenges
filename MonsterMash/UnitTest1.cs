using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MonsterMash
{
    [TestClass]
    public class UnitTest1
    {
        //NO CODING CHANGES TO DO HERE
        //DO NOT CHANGE ANY CODE IN THIS FILE
        [TestMethod]
        public void Test1()
        {
            int eyes = 3;
            Monster monster = new Monster(eyes, 7);

            monster.MonsterSkills(true, false);

            Assert.IsTrue(monster.CanFly);
            Assert.IsFalse(monster.DoesEatPeople);
        }
        [TestMethod]
        public void Test2()
        {
            Monster monster = new Monster();
            string color = monster.MonsterColorGenerator();
            if (color == "Red")
            {
                Assert.AreEqual(true, monster.CanFly);
            }
            else if (color == "Blue")
            {
                Assert.AreEqual(false, monster.DoesEatPeople);
            }
            else if (color == "Green")
            {
                Assert.AreNotEqual(7, monster.Eyes);
            }
            else if (color == "Purple")
            {
                Assert.AreEqual(1, monster.Eyes);
                Assert.AreEqual(1, monster.Horns);
                Assert.AreEqual(true, monster.CanFly);
                Assert.AreEqual(true, monster.DoesEatPeople);
            }
        }
        [TestMethod]
        public void Test3()
        {
            Monster monsterOne = new Monster(1, 1);
            monsterOne.MonsterSkills(true, true);
            Monster monsterTwo = new Monster(6, 2);
            monsterTwo.MonsterSkills(false, true);

            Assert.AreNotEqual(monsterTwo.MonsterMash(), "One Eyed, One Horned, Flying Purple People Eater!!");
            Assert.AreNotEqual(monsterOne.MonsterMash(), "Normal Monster");
        }
    }
}
