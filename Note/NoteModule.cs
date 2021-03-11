using System.Collections.ObjectModel;

namespace Note
{
    class NoteModule
    {
        private ObservableCollection<Notes> notes = new ObservableCollection<Notes>();
        public ReadOnlyObservableCollection<Notes> Notes;

        public NoteModule()
        {
            Notes = new ReadOnlyObservableCollection<Notes>(notes);
        }

        public void AddToArray(string value)
        {
            Notes newNote = new Notes(value);
            notes.Add(newNote);
        }
    }
}
