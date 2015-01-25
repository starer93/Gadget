using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadge
{
    class Note
    {
        public string note { set; get; }
        public string subject { set; get; }

        public Note(string note, string subject)
        {
            this.note = note;
            this.subject = subject;
        }
    }
}
