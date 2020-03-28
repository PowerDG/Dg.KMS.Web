using EvernoteSDK;
using EvernoteSDK.Advanced;
using System;
using System.Collections.Generic;
using System.Text;

namespace initEvernote
{
    public class EasyInit
    {
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
