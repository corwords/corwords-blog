using System;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class BlogService : IBlogService<PostTag>
    {
        public int AddCategory(string key, string username, string password, ITag<PostTag> category)
        {
            throw new NotImplementedException();
        }

        public string AddPost(string blogid, string username, string password, IBlogPost<PostTag> post, bool publish)
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

        public bool EditPost(string postid, string username, string password, IBlogPost<PostTag> post, bool publish)
        {
            throw new NotImplementedException();
        }

        public ITag<PostTag>[] GetCategories(string blogid, string username, string password)
        {
            throw new NotImplementedException();
        }

        public IBlogPost<PostTag> GetPost(string postid, string username, string password)
        {
            throw new NotImplementedException();
        }

        public IBlogPost<PostTag>[] GetRecentPosts(string blogid, string username, string password, int numberOfPosts)
        {
            throw new NotImplementedException();
        }

        public IUserInfo GetUserInfo(string key, string username, string password)
        {
            throw new NotImplementedException();
        }

        public Core.Blog.IBlog<PostTag>[] GetUsersBlogs(string key, string username, string password)
        {
            throw new NotImplementedException();
        }

        public IMediaObjectInfo NewMediaObject(string blogid, string username, string password, IMediaObject mediaObject)
        {
            throw new NotImplementedException();
        }
    }
}
