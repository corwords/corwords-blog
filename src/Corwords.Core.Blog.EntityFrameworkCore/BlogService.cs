using System;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class BlogService : IBlogService<Blog, BlogPost, PostTag>
    {
        public int AddCategory(string key, string username, string password, ITag<Blog, BlogPost, PostTag> category)
        {
            throw new NotImplementedException();
        }

        public string AddPost(string blogid, string username, string password, IBlogPost<Blog, BlogPost, PostTag> post, bool publish)
        {
            throw new NotImplementedException();
        }

        public bool ChangeBlogPermissions(string name, string username, bool allowWrite)
        {
            throw new NotImplementedException();
        }

        public bool CreateBlog(string name, string url)
        {
            throw new NotImplementedException();
        }

        public bool DeletePost(string key, string postid, string username, string password, bool publish)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool EditPost(string postid, string username, string password, IBlogPost<Blog, BlogPost, PostTag> post, bool publish)
        {
            throw new NotImplementedException();
        }

        public ITag<Blog, BlogPost, PostTag>[] GetCategories(string blogid, string username, string password)
        {
            throw new NotImplementedException();
        }

        public IBlogPost<Blog, BlogPost, PostTag> GetPost(string postid, string username, string password)
        {
            throw new NotImplementedException();
        }

        public IBlogPost<Blog, BlogPost, PostTag>[] GetRecentPosts(string blogid, string username, string password, int numberOfPosts)
        {
            throw new NotImplementedException();
        }

        public IBlogUser GetUserInfo(string key, string username, string password)
        {
            throw new NotImplementedException();
        }

        public Core.Blog.IBlog<Blog, BlogPost, PostTag>[] GetUsersBlogs(string key, string username, string password)
        {
            throw new NotImplementedException();
        }

        public IMediaObjectInfo NewMediaObject(string blogid, string username, string password, IMediaObject mediaObject)
        {
            throw new NotImplementedException();
        }
    }
}
