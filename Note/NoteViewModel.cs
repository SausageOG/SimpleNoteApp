using Prism.Commands;
using System.Collections.ObjectModel;

namespace Note
{
    class NoteViewModel
    {
        NoteModule noteM;

        public ReadOnlyCollection<string> NoteView => noteM.Notes;

        DelegateCommand

        public NoteViewModel()
        {
            noteM = new NoteModule();
        }
    }
}
