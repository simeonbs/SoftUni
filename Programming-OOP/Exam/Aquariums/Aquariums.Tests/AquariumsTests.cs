namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;

    public class AquariumsTests
    {
        private Aquarium aq;
        [SetUp]
        public void SetUp()
        {
            Aquarium aq = new Aquarium("Moni", 50);
        }
        //problem
        [Test]
        public void Ctor()
        {
            Aquarium aq = new Aquarium("Moni", 2);
            aq.Add(new Fish("Mali"));
            Assert.That(aq.Name, Is.EqualTo("Moni"));
            Assert.That(aq.Capacity, Is.EqualTo(2));
        }

        [Test]
        public void ShouldReturnName()
        {
            Aquarium aq = new Aquarium("Moni", 10);
            Assert.That(aq.Name, Is.EqualTo("Moni"));
        }

        [Test]
        public void CtorTwo()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var aq = new Aquarium(null, 3);
                var fish = new Fish("Moni");
            });
            
        }

        [Test]
        public void CtorThree()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Aquarium aquarium = new Aquarium("Moncho", -1);
                var fish = new Fish("Moni");
            });
        }

        [Test]
        public void AquariumEmptyName()
        {

            Assert.Throws<ArgumentNullException>(() =>
                {
                    Aquarium aq2 = new Aquarium(string.Empty, 50);
                });
        }

        [Test]
        public void GetCapacity()
        {
            Aquarium aq = new Aquarium("Moni", 10);
            Assert.That(aq.Capacity, Is.EqualTo(10));
        }

        [Test]
        public void CapacityValue()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Aquarium aq2 = new Aquarium("Moni", -2);
            });
        }

        [Test]
        public void Count()
        {
            Aquarium aq = new Aquarium("Moni", 10);
            aq.Add(new Fish("Moni"));
            Assert.That(aq.Count, Is.EqualTo(1));
        }

        [Test]
        public void FullAq()
        {
            Aquarium aq2 = new Aquarium("Moni", 1);
            var fish1 = new Fish("Moni");
            var fish2 = new Fish("Mali");
            aq2.Add(fish1);
            Assert.Throws<InvalidOperationException>(() => aq2.Add(fish2));
        }
        //Add fish
        [Test]
        public void AddFish()
        {
            Aquarium aq3 = new Aquarium("Moni", 2);
            aq3.Add(new Fish("Mima"));
            Assert.That(aq3.Count, Is.EqualTo(1));
        }

        [Test]
        public void RemoveNoActualFish()
        {
            var aquarium = new Aquarium("Moni", 10);
            var fish = new Fish("Mali");
            var message = "Fish with the name Nasko doesn't exist!";
            //ne trqbva
        }

        [Test]
        public void RemoveFish()
        {
            var akvarium = new Aquarium("Aquarium", 10);
            var fish = new Fish("Fish1");
            var secondFish = new Fish("Fish2");

            akvarium.Add(fish);
            akvarium.Add(secondFish);

            akvarium.RemoveFish("Fish1");

            var expectedCount = 1;
            var actualCount = akvarium.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void RemoveNoFish()
        {
            var aquarium = new Aquarium("Aquarium", 10);
            var fish = new Fish("Moni");

            aquarium.Add(fish);

            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium.RemoveFish("askdkasdka");
            });
        }

        [Test]
        public void SellFishShouldChangeFishAvailableToFalse()
        {
            var aquarium = new Aquarium("Moni", 10);
            var fish = new Fish("Mali");

            aquarium.Add(fish);
            var sellFish = aquarium.SellFish("Mali");

            var expected = false;
            var actual = sellFish.Available;
            Assert.That(expected, Is.EqualTo(actual));

        }

        [Test]
        public void SellFish()
        {
            Aquarium aq = new Aquarium("Moni", 2);
            aq.Add(new Fish("Moni"));
            Assert.Throws<InvalidOperationException>(() => aq.SellFish("dskfskdfk"));

        }

        [Test]
        public void Report()
        {
            var aquarium = new Aquarium("Aquarium", 10);
            var fish = new Fish("Marko");

            aquarium.Add(fish);

            var expectedMessage = $"Fish available at {aquarium.Name}: Marko";
            var actualMessage = aquarium.Report();
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
