using Evernote.EDAM.NoteStore;
using EvernoteSDK;
using EvernoteSDK.Advanced;
using System;
using System.Collections.Generic;
using System.Text;

namespace initEvernote
{
    public class EasyInit
    {
        public static void Test()
        {
            Console.WriteLine("Hello World!");
            SetNSession();

            Console.WriteLine("SetNSession World!");
            //ENSession.SetSharedSessionConsumerKey("wangshuxin", "500dd1466d35b2e5", "sandbox.evernote.com");

            //ENSession.SetSharedSessionConsumerKey("wangshuxin", "500dd1466d35b2e5");
            ////if (ENSession.SharedSession.IsAuthenticated == false)
            ////{
            ////    ENSession.SharedSession.AuthenticateToEvernote();
            ////}
            //ENSession.SetSharedSessionDeveloperToken("S=s1:U=94d05:E=1787845f5a9:C=1712094c950:P=1cd:A=en-devtoken:V=2:H=a0cde57efad83817e20eb310c9ff5830", "https://sandbox.evernote.com/shard/s1/notestore");
            ENNote myPlainNote = new ENNote();
            //myPlainNote.
            var fileTimeUtc = DateTime.Now.ToLocalTime().ToString();
            myPlainNote.Title = $"My plain text note22 {fileTimeUtc}";
            myPlainNote.Content = ENNoteContent.NoteContentWithString("Hello, world!");
            ENNoteRef myPlainNoteRef = ENSession.SharedSession.UploadNote(myPlainNote, null);
            var c = new NoteStore();
            //list<Types.Tag> NoteStore. listTags
            var c=NoteStore.listTags_result;
            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }

        public static void SetNSession()
        {
            ENSession.SetSharedSessionConsumerKey("wangshuxin", "500dd1466d35b2e5");
            ENSession.SetSharedSessionDeveloperToken("S=s1:U=94d05:E=1787845f5a9:C=1712094c950:P=1cd:A=en-devtoken:V=2:H=a0cde57efad83817e20eb310c9ff5830", "https://sandbox.evernote.com/shard/s1/notestore");


        }

            public void open()
        {
            // Be sure to put your own consumer key and consumer secret here.
            ENSession.SetSharedSessionConsumerKey("wangshuxin", "500dd1466d35b2e5");

            //if (ENSession.SharedSession.IsAuthenticated == false)
            //{
            //    ENSession.SharedSession.AuthenticateToEvernote();
            //}
            ENNote myPlainNote = new ENNote();
            //myPlainNote.
            myPlainNote.Title = "My plain text note";
            myPlainNote.Content = ENNoteContent.NoteContentWithString("Hello, world!");
            ENNoteRef myPlainNoteRef = ENSession.SharedSession.UploadNote(myPlainNote, null);
        }

    }
}
