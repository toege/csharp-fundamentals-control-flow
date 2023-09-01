using csharp_fundamentals_control_flow.Main;
using NUnit.Framework;

namespace csharp_fundamentals_control_flow.Test
{
    public class CoreTests
    {
              

        [Test]
        public void answer1()
        {
            Core exercise = new Core();
            Assert.AreEqual("Good day!", exercise.one());
        }

        [Test]
        public void answer2()
        {
            Core exercise = new Core();
            Assert.AreEqual("Good morning!", exercise.two());
        }

        [Test]
        public void answer3()
        {
            Core exercise = new Core();
            Assert.AreEqual("Good morning!", exercise.three());
        }

        [Test]
        public void answer4()
        {

            Core exercise = new Core();
            Assert.AreEqual("Good morning!", exercise.four());
        }

        [Test]
        public void answer5()
        {
            Core exercise = new Core();
            Assert.AreEqual("Good day!", exercise.five());
        }

        [Test]
        public void answer6()
        {
            Core exercise = new Core();
            Assert.AreEqual("Correct!", exercise.six(8));
            Assert.AreEqual("Wrong!", exercise.six(6));
            Assert.AreEqual("Wrong!", exercise.six(7));
        }

        [Test]
        public void answer7()
        {
            Core exercise = new Core();
            Assert.AreEqual("Correct!", exercise.seven(false));
            Assert.AreEqual("Wrong!", exercise.seven(true));
        }

        [Test]
        public void answer8()
        {
            Core exercise = new Core();
            Assert.AreEqual("Correct!", exercise.eight(8, 8));
            Assert.AreEqual("Correct!", exercise.eight(10, 8));
            Assert.AreEqual("Wrong!", exercise.eight(6, 8));
        }

        [Test]
        public void answer9()
        {
            Core exercise = new Core();
            Assert.True(exercise.nine(new int[] { 3, 6, 7 }));
            Assert.False(exercise.nine(new int[0]));
        }

        [Test]
        public void answer10()
        {
            Core exercise = new Core();
            Assert.True(exercise.ten("I need to buy milk and coffee"));
            Assert.False(exercise.ten("I need to buy tea and coffee"));
        }

        [Test]
        public void answer11()
        {
            Core exercise = new Core();
            Assert.AreEqual(3, exercise.eleven("I need to buy milk"));
            Assert.AreEqual(6, exercise.eleven("I need to buy coffee"));
            Assert.AreEqual(9, exercise.eleven("I need to buy milk and coffee"));
            Assert.AreEqual(0, exercise.eleven("I need to buy a video game"));
        }

        [Test]
        public void answer12()
        {
            Core exercise = new Core();
            Assert.True(exercise.twelve(5, 5, 5));
            Assert.True(exercise.twelve(5, 3, 7));
            Assert.True(exercise.twelve(5, 5, 7));
            Assert.True(exercise.twelve(5, 3, 5));
            Assert.False(exercise.twelve(5, 6, 5));
            Assert.False(exercise.twelve(5, 3, 4));
        }

        [Test]
        public void answer13()
        {
            Core exercise = new Core();
            Assert.AreEqual("Baby", exercise.thirteen(0));
            Assert.AreEqual("Toddler", exercise.thirteen(1));
            Assert.AreEqual("Toddler", exercise.thirteen(2));
            Assert.AreEqual("Toddler", exercise.thirteen(3));
            Assert.AreEqual("Toddler", exercise.thirteen(4));
            Assert.AreEqual("Child", exercise.thirteen(5));
            Assert.AreEqual("Child", exercise.thirteen(8));
            Assert.AreEqual("Child", exercise.thirteen(12));
            Assert.AreEqual("Teenager", exercise.thirteen(13));
            Assert.AreEqual("Teenager", exercise.thirteen(15));
            Assert.AreEqual("Teenager", exercise.thirteen(19));
            Assert.AreEqual("Adult", exercise.thirteen(20));
            Assert.AreEqual("Adult", exercise.thirteen(32));
            Assert.AreEqual("Adult", exercise.thirteen(1928));
        }
    }
}