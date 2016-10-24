using System;

namespace Corwords.Core.Blog
{
    public interface IBlogService<TPostTag> : IDisposable 
        where TPostTag : IPostTag<TPostTag>
    {
        IUserInfo GetUserInfo(string key, string username, string password);
        IBlog<TPostTag>[] GetUsersBlogs(string key, string username, string password);

        IBlogPost<TPostTag> GetPost(string postid, string username, string password);
        IBlogPost<TPostTag>[] GetRecentPosts(string blogid, string username, string password, int numberOfPosts);

        string AddPost(string blogid, string username, string password, IBlogPost<TPostTag> post, bool publish);
        bool DeletePost(string key, string postid, string username, string password, bool publish);
        bool EditPost(string postid, string username, string password, IBlogPost<TPostTag> post, bool publish);

        ITag<TPostTag>[] GetCategories(string blogid, string username, string password);
        int AddCategory(string key, string username, string password, ITag<TPostTag> category);
        
        IMediaObjectInfo NewMediaObject(string blogid, string username, string password, IMediaObject mediaObject);

    }
}