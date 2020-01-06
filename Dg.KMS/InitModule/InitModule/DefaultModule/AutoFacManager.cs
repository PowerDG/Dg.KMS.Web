namespace InitModule.DefaultModule
{
    internal class AutoFacManager
    {
        private Worker worker;
        private IPerson person;

        public AutoFacManager(Worker worker)
        {
            this.worker = worker;
        }

        public AutoFacManager(IPerson person)
        {
            this.person = person;
        }
        public AutoFacManager( )
        { 
        }
    }
}