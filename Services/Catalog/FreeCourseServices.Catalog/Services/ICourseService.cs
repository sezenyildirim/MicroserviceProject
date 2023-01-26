using FreeCourseServices.Catalog.Dtos;
using FreeCourseServices.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourseServices.Catalog.Services
{
    public interface ICourseService
    {
        Task<Response<NoContent>> DeleteAsync(string id);
        Task<Response<NoContent>> UpdateAsync(CourseUpdateDto courseUpdateDto);
        Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);
        Task<Response<List<CourseDto>>> GetAllByUserIdAsync(string userId);
        Task<Response<CourseDto>> GetByIdAsync(string id);
        Task<Response<List<CourseDto>>> GetAllAsync();
    }
}
