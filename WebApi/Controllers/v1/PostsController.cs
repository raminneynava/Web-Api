using AutoMapper;
using Infrastructure.Contracts;
using Infrastructure.Entities;
using Services.Api;
using System;
using WebApi.Models;

namespace MyApi.Controllers.v1
{
    public class PostsController : CrudController<PostDto, PostSelectDto, Post>
    {
        public PostsController(IRepository<Post> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
