using initEvernote;
using System;
using EvernoteSDK;
using EvernoteSDK.Advanced;
namespace eTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //(new EasyInit()).open();

            ENSession.SetSharedSessionConsumerKey("wangshuxin", "500dd1466d35b2e5", "sandbox.evernote.com");

            if (ENSession.SharedSession.IsAuthenticated == false)
            {
                ENSession.SharedSession.AuthenticateToEvernote();
            }
            ENNote myPlainNote = new ENNote();
            //myPlainNote.
            myPlainNote.Title = "My plain text note";
            myPlainNote.Content = ENNoteContent.NoteContentWithString("Hello, world!");
            ENNoteRef myPlainNoteRef = ENSession.SharedSession.UploadNote(myPlainNote, null);


            Console.WriteLine("Hello World!");
        }
    }
}
