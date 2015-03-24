using System.Linq;
using NUnit.Framework;
using Shouldly;

namespace ToDo.Tests
{
    [TestFixture]
    public class WhenIRemoveAThing : GivenAListOfThingsToDo
    {
        [Test]
        public void ThenTheThingShouldBeRemoved()
        {
            var thingToRemove = Things.First();
            MainViewModel.RemoveThing(thingToRemove);
            Things.Any(t => t == thingToRemove).ShouldBe(false);
        }

        protected override void AddMoreThings()
        {
        }
    }
}