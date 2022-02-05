using HomeCine.Data.Base;
using HomeCine.Data.ViewModels;
using HomeCine.Models;
using System.Threading.Tasks;

namespace HomeCine.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues(); 
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateNewMovieAsync(NewMovieVM data);
    }
}
