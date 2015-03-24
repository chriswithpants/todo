using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using ToDo.Models;

namespace ToDo.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _thingToAdd;

        public MainViewModel()
        {
            ThingsToDo = new ObservableCollection<ThingToDo>
            {
                new ThingToDo("Learn WPF", true),
                new ThingToDo("Build ToDo App", true),
                new ThingToDo("Make it look awesome", false)
            };
            AddThingCommand = new RelayCommand(AddThingToList);
        }

        public ICommand AddThingCommand { get; set; }

        public string ThingToAdd
        {
            get { return _thingToAdd; }
            set
            {
                if (value == _thingToAdd) return;
                _thingToAdd = value; 
                RaisePropertyChanged(() => ThingToAdd);
            }
        }

        public void AddThingToList()
        {
            ThingsToDo.Add(new ThingToDo(ThingToAdd, false));
            ThingToAdd = string.Empty;
        }

        public ObservableCollection<ThingToDo> ThingsToDo { get; set; }

        public void RemoveThing(ThingToDo thingToRemove)
        {
            ThingsToDo.Remove(thingToRemove);
        }

        public void ClearCompletedThings()
        {
            var completedThings = ThingsToDo.Where(t => t.Completed).ToArray();
            foreach (var completedThing in completedThings)
            {
                ThingsToDo.Remove(completedThing);
            }
        }
    }
}