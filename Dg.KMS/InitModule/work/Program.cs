using EvernoteSDK;
using System;


namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); 
            //ENSession.SetSharedSessionConsumerKey("wangshuxin", "500dd1466d35b2e5", "sandbox.evernote.com");

            ENSession.SetSharedSessionConsumerKey("wangshuxin", "500dd1466d35b2e5");
            //if (ENSession.SharedSession.IsAuthenticated == false)
            //{
            //    ENSession.SharedSession.AuthenticateToEvernote();
            //}
            ENSession.SetSharedSessionDeveloperToken("S=s1:U=94d05:E=1787845f5a9:C=1712094c950:P=1cd:A=en-devtoken:V=2:H=a0cde57efad83817e20eb310c9ff5830", "https://sandbox.evernote.com/shard/s1/notestore");
            ENNote myPlainNote = new ENNote();
            //myPlainNote.
            myPlainNote.Title = "My plain text note22";
            myPlainNote.Content = ENNoteContent.NoteContentWithString("Hello, world!");
            ENNoteRef myPlainNoteRef = ENSession.SharedSession.UploadNote(myPlainNote, null);


            Console.WriteLine("Hello World!");

            Console.ReadKey(); 
        }
    }
}
