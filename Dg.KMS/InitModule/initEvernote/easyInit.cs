using Evernote.EDAM.NoteStore;
using EvernoteSDK;
using EvernoteSDK.Advanced;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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
            ////list<Types.Tag> NoteStore. listTags
            //var c = NoteStore.listTags_result;

            //ENNoteStoreClient
            //NoteStore. listTags(GetAuthenticationToken());
            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }

        public static void SetNSession()
        {
            ENSession.SetSharedSessionConsumerKey("wangshuxin", "500dd1466d35b2e5");
            ENSession.SetSharedSessionDeveloperToken("S=s1:U=94d05:E=1787845f5a9:C=1712094c950:P=1cd:A=en-devtoken:V=2:H=a0cde57efad83817e20eb310c9ff5830", "https://sandbox.evernote.com/shard/s1/notestore");

            //ListTags();
        }

        public static void SetENSessionAdvanced()
        {
            ENSessionAdvanced.SetSharedSessionConsumerKey("wangshuxin", "500dd1466d35b2e5");
            ENSessionAdvanced.SetSharedSessionDeveloperToken("S=s1:U=94d05:E=1787845f5a9:C=1712094c950:P=1cd:A=en-devtoken:V=2:H=a0cde57efad83817e20eb310c9ff5830", "https://sandbox.evernote.com/shard/s1/notestore");

            ListTags();
        }
        public static void ListTags()
        {
            ENSessionAdvanced.SharedSession.Startup();
            ENNoteStoreClient store =
             //ENNoteStoreClient.NoteStoreClient("https://sandbox.evernote.com/shard/s1/notestore", "S=s1:U=94d05:E=1787845f5a9:C=1712094c950:P=1cd:A=en-devtoken:V=2:H=a0cde57efad83817e20eb310c9ff5830");
             ENSessionAdvanced.SharedSession.PrimaryNoteStore ;//.BusinessNoteStore;
            //Note resultNote = store.CreateNote(myNote);
            var list = store.ListTags();

            Console.WriteLine("【store】");
            Console.WriteLine($"Hello World! {JsonConvert.SerializeObject(store)}");
            if (list.Any())
            {
                list.ForEach(x=>
                {
                    //Console.WriteLine($"N{JsonConvert.SerializeObject(x)}"); 
                    Console.WriteLine($"N{x.Name}==={x.UpdateSequenceNum}==={x.__isset}");
                    x.Name = $"Dg{x.Name}";
                    store.UpdateTag(x);
                    Console.WriteLine($"N{ x.Guid}@@@{ x.ParentGuid}");
                });
                //store.UntagAll();

                 var currentTag = list.FirstOrDefault();

                store.CreateTag(currentTag);
                store.GetTag(currentTag.Guid); 
                store.UpdateTag(currentTag); 
                store.ExpungeTag(currentTag.Guid);
                store.ListTagsByNotebook(currentTag.Guid );

                store.GetNoteTagNames(currentTag.Guid);
                //store.UpdateTag(currentTag);
                Console.WriteLine("【List】");
                Console.WriteLine($"Hello World! {JsonConvert.SerializeObject(list)}");
            }
            Console.WriteLine("Hello World!");
        }

        internal static ENNoteStoreClient NoteStoreClient(string url, string authenticationToken)
        {
            ENNoteStoreClient enClient = new ENNoteStoreClient();
            //enClient.CachedNoteStoreUrl = url;
            //enClient.CachedAuthenticationToken = authenticationToken;
            return enClient;
        }

        public static void FindNotes()
        {
            List<ENSessionFindNotesResult> myNotesList = ENSession.SharedSession.FindNotes(ENNoteSearch.NoteSearch("redwood"), null, ENSession.SearchScope.All, ENSession.SortOrder.RecentlyUpdated, 20);

            if (myNotesList.Count > 0)
            {
                foreach (ENSessionFindNotesResult result in myNotesList)
                {
                    // Each ENSessionFindNotesResult has a noteRef along with other important metadata.
                    Console.WriteLine("Found note with title: " + result.Title);
                }
            }

            Console.WriteLine($"Hello World! {JsonConvert.SerializeObject(myNotesList)}");
            //EasyInit.Test(); 
            //ENNoteStoreClient store = ENSessionAdvanced.SharedSession.BusinessNoteStore;
            ////Note resultNote = store.CreateNote(myNote);
            //var list = store.ListTags();

            //Console.WriteLine($"Hello World! {JsonConvert.SerializeObject(list)}");

            Console.WriteLine("Hello World!");
        }
        public static string GetAuthenticationToken()
        {
            //ENSession.SetSharedSessionConsumerKey("wangshuxin", "500dd1466d35b2e5");
            //ENSession.SetSharedSessionDeveloperToken("S=s1:U=94d05:E=1787845f5a9:C=1712094c950:P=1cd:A=en-devtoken:V=2:H=a0cde57efad83817e20eb310c9ff5830", "https://sandbox.evernote.com/shard/s1/notestore");

            return "S=s1:U=94d05:E=1787845f5a9:C=1712094c950:P=1cd:A=en-devtoken:V=2:H=a0cde57efad83817e20eb310c9ff5830";
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