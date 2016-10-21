using System;

namespace Corwords.Core.Blog
{
    public interface IBlogStore<TBlog> : IDisposable where TBlog : class
    {
        //Task<TBlog> FindByNameAsync(string normalizedBlogName, CancellationToken cancellationToken);
        //public int AddCategory(string key, string username, string password, NewCategory category)
        //public string AddPost(string blogid, string username, string password, Post post, bool publish)
        //public bool DeletePost(string key, string postid, string username, string password, bool publish)
        //public bool EditPost(string postid, string username, string password, Post post, bool publish)
        //public CategoryInfo[] GetCategories(string blogid, string username, string password)
        //public Post GetPost(string postid, string username, string password)
        //public Post[] GetRecentPosts(string blogid, string username, string password, int numberOfPosts)
        //public UserInfo GetUserInfo(string key, string username, string password)
        //public BlogInfo[] GetUsersBlogs(string key, string username, string password)
        //public MediaObjectInfo NewMediaObject(string blogid, string username, string password, MediaObject mediaObject)
    }
}