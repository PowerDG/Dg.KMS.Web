
using System;
using System.Collections.Generic;
using System.Text;

using EvernoteSDK;
using Thrift.Protocol;
using Thrift.Transport;
using Evernote.EDAM.Type;
using Evernote.EDAM.UserStore;
using Evernote.EDAM.NoteStore;
using Evernote.EDAM.Error;
using System.Runtime.InteropServices;

namespace initEvernote
{
    public class TagManger
    {


        private string CachedNoteStoreUrl { get; set; }

        private string CachedAuthenticationToken { get; set; }
        protected internal virtual string NoteStoreUrl()
        {
            return CachedNoteStoreUrl;
        }
        private NoteStore.Client _client;
        private NoteStore.Client Client
        {
            get
            {
                if (_client == null)
                {
                    Uri url = new Uri(NoteStoreUrl());
                    THttpClient transport = new THttpClient(url);
                    TBinaryProtocol protocol = new TBinaryProtocol(transport);
                    _client = new NoteStore.Client(protocol, protocol);
                }
                return _client;
            }
            set
            {
                _client = value;
            }
        }
        protected internal virtual string AuthenticationToken()
        {
            return CachedAuthenticationToken;
        }
        /// <summary>
        ///  //        Function: NoteStore.listTags 
        //List<Evernote.EDAM.Type.Tag> list = listTags(authenticationToken);
        //    throws Errors.EDAMUserException, Errors.EDAMSystemException
        //Returns a list of the tags in the account. Evernote does not support the undeletion of tags, so this will only include active tags.
        //Function: NoteStore.listTagsByNotebook
        /// </summary>
        /// <returns></returns>
        [ComVisible(false)]
        public List<Tag> ListTags()
        {
            return Client.listTags(AuthenticationToken());
        }
        public void tags()
        {

            Console.WriteLine("Hello World!");
            //ENSession.SetSharedSessionConsumerKey("wangshuxin", "500dd1466d35b2e5", "sandbox.evernote.com");

            ENSession.SetSharedSessionConsumerKey("wangshuxin", "500dd1466d35b2e5");
            //if (ENSession.SharedSession.IsAuthenticated == false)
            //{
            //    ENSession.SharedSession.AuthenticateToEvernote();
            //}
            var authenticationToken = "S=s1:U=94d05:E=1787845f5a9:C=1712094c950:P=1cd:A=en-devtoken:V=2:H=a0cde57efad83817e20eb310c9ff5830";
            ENSession.SetSharedSessionDeveloperToken("S=s1:U=94d05:E=1787845f5a9:C=1712094c950:P=1cd:A=en-devtoken:V=2:H=a0cde57efad83817e20eb310c9ff5830", "https://sandbox.evernote.com/shard/s1/notestore");
            ENNote myPlainNote = new ENNote();
            //myPlainNote.
            myPlainNote.Title = "My plain text note22";
            myPlainNote.Content = ENNoteContent.NoteContentWithString("Hello, world!");
            ENNoteRef myPlainNoteRef = ENSession.SharedSession.UploadNote(myPlainNote, null);


            Console.WriteLine("Hello World!");

            Console.ReadKey();


            //List<Evernote.EDAM.Type.Tag> mylist=NoteStore. listTagsByNotebook(string authenticationToken,
            //                                   Types.Guid notebookGuid)
            //    throws Errors.EDAMUserException, Errors.EDAMSystemException, Errors.EDAMNotFoundException

            //Returns a list of the tags that are applied to at least one note within the provided notebook.If the notebook is public, the authenticationToken may be ignored.

            //@param notebookGuid the GUID of the notebook to use to find tags

            //@throws EDAMNotFoundException

            //    "Notebook.guid" - notebook not found by GUID

        }
    }
}