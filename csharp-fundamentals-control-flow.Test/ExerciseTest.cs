using csharp_fundamentals_control_flow.Main;
using NUnit.Framework;

namespace csharp_fundamentals_control_flow.Test
{
    public class ExerciseTest
    {
        Exercise exercise;

        public ExerciseTest()
        {
            this.exercise = new Exercise();
        }

        [Test]
        public void answer1()
        {
            Assert.AreEqual("Good day!", this.exercise.one());
        }

        [Test]
        public void answer2()
        {
            Assert.AreEqual("Good morning!", this.exercise.two());
        }

        [Test]
        public void answer3()
        {
            Assert.AreEqual("Good morning!", this.exercise.three());
        }

        [Test]
        public void answer4()
        {
            Assert.AreEqual("Good morning!", this.exercise.four());
        }

        [Test]
        public void answer5()
        {
            Assert.AreEqual("Good day!", this.exercise.five());
        }

        [Test]
        public void answer6()
        {
            Assert.AreEqual("Correct!", this.exercise.six(8));
            Assert.AreEqual("Wrong!", this.exercise.six(6));
            Assert.AreEqual("Wrong!", this.exercise.six(7));
        }

        [Test]
        public void answer7()
        {
            Assert.AreEqual("Correct!", this.exercise.seven(false));
            Assert.AreEqual("Wrong!", this.exercise.seven(true));
        }

        [Test]
        public void answer8()
        {
            Assert.AreEqual("Correct!", this.exercise.eight(8, 8));
            Assert.AreEqual("Correct!", this.exercise.eight(10, 8));
            Assert.AreEqual("Wrong!", this.exercise.eight(8, 6));
        }

        [Test]
        public void answer9()
        {
            Assert.True(this.exercise.nine(new int[] { 3, 6, 7 }));
            Assert.False(this.exercise.nine(new int[0]));
        }

        [Test]
        public void answer10()
        {
            Assert.True(this.exercise.ten("I need to buy milk and coffee"));
            Assert.False(this.exercise.ten("I need to buy tea and coffee"));
        }

        [Test]
        public void answer11()
        {
            Assert.AreEqual(3, this.exercise.eleven("I need to buy milk"));
            Assert.AreEqual(6, this.exercise.eleven("I need to buy coffee"));
            Assert.AreEqual(9, this.exercise.eleven("I need to buy milk and coffee"));
            Assert.AreEqual(0, this.exercise.eleven("I need to buy a video game"));
        }

        [Test]
        public void answer12()
        {
            Assert.True(this.exercise.twelve(5, 5, 5));
            Assert.True(this.exercise.twelve(5, 3, 7));
            Assert.True(this.exercise.twelve(5, 5, 7));
            Assert.True(this.exercise.twelve(5, 3, 5));
            Assert.False(this.exercise.twelve(5, 6, 5));
            Assert.False(this.exercise.twelve(5, 3, 4));
        }

        [Test]
        public void answer13()
        {
            Assert.AreEqual("Baby", this.exercise.thirteen(0));
            Assert.AreEqual("Toddler", this.exercise.thirteen(1));
            Assert.AreEqual("Toddler", this.exercise.thirteen(2));
            Assert.AreEqual("Toddler", this.exercise.thirteen(3));
            Assert.AreEqual("Toddler", this.exercise.thirteen(4));
            Assert.AreEqual("Child", this.exercise.thirteen(5));
            Assert.AreEqual("Child", this.exercise.thirteen(8));
            Assert.AreEqual("Child", this.exercise.thirteen(12));
            Assert.AreEqual("Teenager", this.exercise.thirteen(13));
            Assert.AreEqual("Teenager", this.exercise.thirteen(15));
            Assert.AreEqual("Teenager", this.exercise.thirteen(19));
            Assert.AreEqual("Adult", this.exercise.thirteen(20));
            Assert.AreEqual("Adult", this.exercise.thirteen(32));
            Assert.AreEqual("Adult", this.exercise.thirteen(1928));
        }
    }
}