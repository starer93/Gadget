using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadge
{
    public partial class Form_Note : Form
    {
        private List<Note> notes = new List<Note>();

        public Form_Note()
        {
            InitializeComponent();
            loadList();
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string note = TextBox_Note.Text;
            string subject = textbox_subject.Text;
            if (!string.IsNullOrEmpty(subject))
            {
                Note newNote = new Note(note, subject);
                notes.Add(newNote);
                loadList();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadList()
        {
            if (notes.Count != 0)
            {
                foreach (Note note in notes)
                {
                    list_note.Items.Add(note.subject);
                }
            }
            else
            {
                list_note.Items.Add("None");
            }
        }
    }
}
