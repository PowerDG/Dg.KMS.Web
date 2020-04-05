using System;
using Evernote.EDAM.Type;
using EvernoteSDK;
using EvernoteSDK.Advanced;
namespace En
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ENSessionAdvanced.SetSharedSessionConsumerKey("your key", "your secret");
            ENNoteStoreClient PrimaryNoteStore;
            ENNoteStoreClient BusinessNoteStore;

            //static ENNoteStoreClient NoteStoreForLinkedNotebook(linkedNotebook);


            //LinkedNotebook linkedNotebook = (LinkedNotebook)Preferences.ObjectForKey(ENSessionPreferencesLinkedAppNotebook);
            // First create the ENML content for the note.
            ENMLWriter writer = new ENMLWriter();
            writer.WriteStartDocument();
            writer.WriteString("Hello again, world.");
            writer.WriteEndDocument();

            // Create a note locally.
            Note myNote = new Note();
            myNote.Title = "Sample note from the Advanced world";
            myNote.Content = writer.Contents.ToString();

            // Create the note in the service, in the user's personal, default notebook.
            ENNoteStoreClient store = ENSessionAdvanced.SharedSession.PrimaryNoteStore;
            Note resultNote = store.CreateNote(myNote);

            //myNoteAdv.EdamAttributes["ReminderOrder"] = DateTime.Now.ToEdamTimestamp();

            DateTime noteCreatedOn = myNote.Created.ToDateTime();

        }
    }
}
