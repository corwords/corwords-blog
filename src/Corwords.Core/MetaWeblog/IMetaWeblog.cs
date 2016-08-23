using Corwords.Data.MetaWeblog;

namespace Corwords.Core.MetaWeblog
{
    public interface IMetaWeblog
    {
        // metaWeblog.newPost
        string AddPost(string blogid, string username, string password, Post post, bool publish);
        // metaWeblog.editPost
        bool EditPost(string postid, string username, string password, Post post, bool publish);
        // metaWeblog.getPost
        Post GetPost(string postid, string username, string password);
        // blogger.deletePost
        bool DeletePost(string key, string postid, string username, string password, bool publish);
        // metaWeblog.getRecentPosts
        Post[] GetRecentPosts(string blogid, string username, string password, int numberOfPosts);

        // wp.newCategory 
        int AddCategory(string key, string username, string password, NewCategory category);
        // metaWeblog.getCategories
        Category[] GetCategories(string blogid, string username, string password);

        // metaWeblog.newMediaObject 
        MediaObjectInfo NewMediaObject(string blogid, string username, string password, MediaObject mediaObject);

        // blogger.getUsersBlogs
        Blog[] GetUsersBlogs(string key, string username, string password);
        // blogger.getUserInfo 
        UserInfo GetUserInfo(string key, string username, string password);
    }
}