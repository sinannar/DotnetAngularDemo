
using System.Threading.Tasks;
using DotnetAngularDemo.Reading.Dto;

namespace DotnetAngularDemo.Reading
{
    public interface IReadingAppService
    {
        Task<bool> CreateCategory(CategoryCreateRequestDto request);
        Task<bool> EditCategory(CategoryEditRequestDto request);
    }
}
