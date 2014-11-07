using BlogPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogPost.Controllers
{
    
    public class PostsController : ApiController
    {
        repository dm = repository.GetModelInstance();

        public IEnumerable<Post> Get()
        {
            return dm.posts;
        }

        public Post Get(int id)
        {
            return dm.posts.Where(x => x.ID == id).First();
        }

        public HttpResponseMessage Post(Post p)
        {
            dm.AddBlogPost(p);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage Put(int id, Post p)
        {
            dm.UpdateBlogPost(id, p);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }
        public HttpResponseMessage Delete(int id)
        {
            dm.DeleteBlogPost(id);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }
    }
}
