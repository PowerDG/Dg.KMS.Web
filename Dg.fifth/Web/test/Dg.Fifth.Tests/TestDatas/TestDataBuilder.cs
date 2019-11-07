using Dg.Fifth.EntityFrameworkCore;

namespace Dg.Fifth.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly FifthDbContext _context;

        public TestDataBuilder(FifthDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}