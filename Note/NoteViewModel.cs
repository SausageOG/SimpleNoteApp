using Prism.Commands;
using System.Collections.ObjectModel;

namespace Note
{
    class NoteViewModel
    {
        NoteModule noteM;


        public ReadOnlyObservableCollection<Notes> NoteView => noteM.Notes;

        public DelegateCommand<string> AddToList { get; private set; }
        public DelegateCommand CheckCommand { get; private set; }

        public NoteViewModel()
        {            
            noteM = new NoteModule();

            AddToList = new DelegateCommand<string>(noteM.AddToArray);
            CheckCommand = new DelegateCommand(noteM.Check);
        }
    }
}
