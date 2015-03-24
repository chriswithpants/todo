using System.Collections.ObjectModel;
using NUnit.Framework;
using ToDo.Models;
using ToDo.ViewModel;

namespace ToDo.Tests
{
    [TestFixture]
    public abstract class GivenAListOfThingsToDo
    {
        [SetUp]
        public void CreateAListOfThings()
        {
            Things = new ObservableCollection<ThingToDo>
            {
                new ThingToDo("Something", false),
                new ThingToDo("Something Else", false)
            };

            AddMoreThings();

            MainViewModel = new MainViewModel
            {
                ThingsToDo = Things
            };
        }

        protected abstract void AddMoreThings();

        protected MainViewModel MainViewModel { get; set; }

        protected ObservableCollection<ThingToDo> Things { get; set; }
    }
}