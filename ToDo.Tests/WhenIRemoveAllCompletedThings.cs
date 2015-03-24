using System.Linq;
using NUnit.Framework;
using Shouldly;
using ToDo.Models;

namespace ToDo.Tests
{
    [TestFixture]
    public class WhenIRemoveAllCompletedThings : GivenAListOfThingsToDo
    {
        protected override void AddMoreThings()
        {
            Things.Add(new ThingToDo("Completed Thing", true));
            Things.Add(new ThingToDo("Another Completed Thing", true));
        }

        [Test]
        public void ThereShouldBeNoCompletedThings()
        {
            MainViewModel.ClearCompletedThings();
            Things.Any(t => t.Completed).ShouldBe(false);
        }
    }
}