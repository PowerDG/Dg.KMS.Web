using System.Threading.Tasks;
using Dg.Fifth.Web.Controllers;
using Shouldly;
using Xunit;

namespace Dg.Fifth.Web.Tests.Controllers
{
    public class HomeController_Tests: FifthWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
