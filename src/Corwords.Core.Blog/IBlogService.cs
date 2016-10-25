using System;

namespace Corwords.Core.Blog
{
    public interface IBlogService<TBlog, TBlogPost, TPostTag> : IDisposable
        where TBlog : class, IBlog<TBlog, TBlogPost, TPostTag>
        where TBlogPost : class, IBlogPost<TBlog, TBlogPost, TPostTag>
        where TPostTag : class, IPostTag<TBlog, TBlogPost, TPostTag>
    {
        IUserInfo GetUserInfo(string key, string username, string password);
        IBlog<TBlog, TBlogPost, TPostTag>[] GetUsersBlogs(string key, string username, string password);

        IBlogPost<TBlog, TBlogPost, TPostTag> GetPost(string postid, string username, string password);
        IBlogPost<TBlog, TBlogPost, TPostTag>[] GetRecentPosts(string blogid, string username, string password, int numberOfPosts);

        string AddPost(string blogid, string username, string password, IBlogPost<TBlog, TBlogPost, TPostTag> post, bool publish);
        bool DeletePost(string key, string postid, string username, string password, bool publish);
        bool EditPost(string postid, string username, string password, IBlogPost<TBlog, TBlogPost, TPostTag> post, bool publish);

        ITag<TBlog, TBlogPost, TPostTag>[] GetCategories(string blogid, string username, string password);
        int AddCategory(string key, string username, string password, ITag<TBlog, TBlogPost, TPostTag> category);
        
        IMediaObjectInfo NewMediaObject(string blogid, string username, string password, IMediaObject mediaObject);

    }
}