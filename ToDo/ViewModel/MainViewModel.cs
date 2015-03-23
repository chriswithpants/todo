using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using ToDo.Models;

namespace ToDo.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
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

        public string ThingToAdd { get; set; }

        public void AddThingToList()
        {
            ThingsToDo.Add(new ThingToDo(ThingToAdd, false));
            ThingToAdd = string.Empty;
        }

        public ObservableCollection<ThingToDo> ThingsToDo { get; set; }
    }
}