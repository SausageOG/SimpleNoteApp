using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Note
{
    class NoteModule
    {
        private List<string> notes = new List<string>();
        public ReadOnlyCollection<string> Notes;

        public NoteModule()
        {
            Notes = new ReadOnlyCollection<string>(notes);
        }

        public void AddToArray(string value)
        {
            notes.Add(value);
        }
    }
}
