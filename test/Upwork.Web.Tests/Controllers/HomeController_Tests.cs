using System.Threading.Tasks;
using Upwork.Models.TokenAuth;
using Upwork.Web.Controllers;
using Shouldly;
using Xunit;

namespace Upwork.Web.Tests.Controllers
{
    public class HomeController_Tests: UpworkWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}