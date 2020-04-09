
using DgKMS.Cube.CubeCore;
using DgKMS.Cube.CubeCore.Dtos;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DgKMS.Cube.Tests.EvernoteTags
{
    public class EvernoteTagAppService_Tests : CubeTestBase
    {
        private readonly IEvernoteTagAppService _evernoteTagAppService;

        public EvernoteTagAppService_Tests()
        {
            _evernoteTagAppService = Resolve<IEvernoteTagAppService>();
        }

        [Fact]
        public async Task CreateEvernoteTag_Test()
        {
            await _evernoteTagAppService.CreateOrUpdate(new CreateOrUpdateEvernoteTagInput
            {
                 EvernoteTag = new EvernoteTagEditDto    
                {
						   

                            Guid = "test",
                            Name = "test",
                            ParentGuid = "test",
                            //CreationTime = DateTime.Now,


                }
            });

            await UsingDbContextAsync(async context =>
            {
                var dystopiaEvernoteTag = await context.EvernoteTags.FirstOrDefaultAsync();
                dystopiaEvernoteTag.ShouldNotBeNull();
            }
            );
        }

        [Fact]
        public async Task GetEvernoteTags_Test()
        {
            // Act
            var output = await _evernoteTagAppService.GetPaged(new GetEvernoteTagsInput
            {
                MaxResultCount = 20,
                SkipCount = 0
            });

            // Assert
            output.Items.Count.ShouldBeGreaterThanOrEqualTo(0);
        }

		
							//// custom codes
									
							

							//// custom codes end


    }
}