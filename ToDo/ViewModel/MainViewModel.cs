using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using ToDo.Stuff;

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
        }

        public ObservableCollection<ThingToDo> ThingsToDo { get; set; }
    }
}