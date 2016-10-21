using System;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class BlogService : IBlogService
    {
        public int AddCategory(string key, string username, string password, ITag category)
        {
            throw new NotImplementedException();
        }

        public string AddPost(string blogid, string username, string password, IBlogPost post, bool publish)
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

        public bool EditPost(string postid, string username, string password, IBlogPost post, bool publish)
        {
            throw new NotImplementedException();
        }

        public ITag[] GetCategories(string blogid, string username, string password)
        {
            throw new NotImplementedException();
        }

        public IBlogPost GetPost(string postid, string username, string password)
        {
            throw new NotImplementedException();
        }

        public IBlogPost[] GetRecentPosts(string blogid, string username, string password, int numberOfPosts)
        {
            throw new NotImplementedException();
        }

        public IUserInfo GetUserInfo(string key, string username, string password)
        {
            throw new NotImplementedException();
        }

        public Core.Blog.IBlog[] GetUsersBlogs(string key, string username, string password)
        {
            throw new NotImplementedException();
        }

        public IMediaObjectInfo NewMediaObject(string blogid, string username, string password, IMediaObject mediaObject)
        {
            throw new NotImplementedException();
        }
    }
}
