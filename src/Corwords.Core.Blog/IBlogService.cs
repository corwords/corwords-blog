using System;

namespace Corwords.Core.Blog
{
    public interface IBlogService : IDisposable 
    {
        IUserInfo GetUserInfo(string key, string username, string password);
        IBlog[] GetUsersBlogs(string key, string username, string password);

        IBlogPost GetPost(string postid, string username, string password);
        IBlogPost[] GetRecentPosts(string blogid, string username, string password, int numberOfPosts);

        string AddPost(string blogid, string username, string password, IBlogPost post, bool publish);
        bool DeletePost(string key, string postid, string username, string password, bool publish);
        bool EditPost(string postid, string username, string password, IBlogPost post, bool publish);

        ITag[] GetCategories(string blogid, string username, string password);
        int AddCategory(string key, string username, string password, ITag category);
        
        IMediaObjectInfo NewMediaObject(string blogid, string username, string password, IMediaObject mediaObject);

    }
}