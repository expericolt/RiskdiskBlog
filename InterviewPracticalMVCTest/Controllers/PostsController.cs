//using Domain.Repositories;
//using Infrastructure.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace InterviewPracticalMVCTest.Controllers
{
    public class PostsController : Controller
    {
        //private readonly PostsRepository _postsRepository;
            
        public PostsController()
        {
            //_postsRepository = new PostsRepository(new Context());
        }

        // GET: Posts
        public ActionResult Index()
        {
            // Implement requirement 1
            //var posts = _postsRepository.GetAllPosts();

            return View();
        }
    }
}
