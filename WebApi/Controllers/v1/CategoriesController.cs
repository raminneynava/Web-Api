using AutoMapper;
using Infrastructure.Contracts;
using Infrastructure.Entities;
using Services.Api;
using WebApi.Models;

namespace WebApi.Controllers.v1
{
    public class CategoriesController : CrudController<CategoryDto, Category>
    {
        public CategoriesController(IRepository<Category> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
