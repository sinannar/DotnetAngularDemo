


using System;
using System.Threading.Tasks;
using DotnetAngularDemo.Reading.Dto;

namespace DotnetAngularDemo.Reading
{
    public class ReadingAppService : DotnetAngularDemoAppServiceBase, IReadingAppService
    {
        public async Task<bool> CreateCategory(CategoryCreateRequestDto request)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> EditCategory(CategoryEditRequestDto request)
        {
            throw new NotImplementedException();
        }

    }
}
