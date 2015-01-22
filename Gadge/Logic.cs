using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadge
{
    public static class Logic
    {
        private static List<string> notes = new List<string>();

        public static List<string> getNotes()
        {
            return notes;
        }

        public static void addNote(string note)
        {
            notes.Add(note);
        }


    }
}
