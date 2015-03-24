using System.Linq;
using NUnit.Framework;
using Shouldly;

namespace ToDo.Tests
{
    [TestFixture]
    public class WhenIAddAThing : GivenAListOfThingsToDo
    {
        [Test]
        public void ThenTheNewThingShouldBeAdded()
        {
            const string thingToAdd = "Another thing";
            MainViewModel.ThingToAdd = thingToAdd;
            MainViewModel.AddThingToList();
            Things.Any(t => t.Description == thingToAdd).ShouldBe(true);
        }

        protected override void AddMoreThings()
        {
        }
    }
}