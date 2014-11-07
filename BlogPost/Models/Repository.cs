using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogPost.Models
{
    public sealed class repository
    {
        private static repository instance = null;
        public List<Post> posts = new List<Post>(new Post[] {
            new Post {ID = 1, Author = "Jon", Title = "Blogging For Dummies", 
                        Body = "A very short blog post", Tags = new string[] {"soft skills", "beginner"}},
            new Post {ID = 2, Author = "Lee", Title = "Blogging For Smart People", 
                        Body = "A shorter blog post", Tags = new string[] {"soft skills", "Expert"}}
        });

        public static repository GetModelInstance()
        {
            if(instance == null)
            {
                instance = new repository();
            }
            return instance;
        }

        public void AddBlogPost(Post p)
        {
            p.ID = posts.OrderByDescending(x => x.ID).First().ID + 1;
            posts.Add(p);
        }

        public void UpdateBlogPost(int id, Post p)
        {
            Post post = posts.Where(x => x.ID == id).First();
            post.Author = p.Author;
            post.Body = p.Body;
            post.Title = p.Title;
        }

        public void DeleteBlogPost(int id)
        {
            Post p = posts.Where(x => x.ID == id).First();
            posts.Remove(p);
        }
    }
}