using Domain;

namespace Infrastructure;

public class PostService
{
    List<Post> _posts = new List<Post>();

    public List<Post> GetPost()
    {
        return _posts;
    }

    public void AddPost(Post post)
    {
        _posts.Add(post);
    }

    public void UpdatePost(Post post)
    {
        foreach (var item in _posts)
        {
            if (item.ID == post.ID)
            {
                item.Title = post.Title;
                item.Description = post.Description;
                item.VoiceAmount = post.VoiceAmount;
                item.CreatedAt = post.CreatedAt;
            }
        }
    }
    public void Delete(int id)
    {
        foreach (var item in _posts)
        {
            if (item.ID == id)
            {
                _posts.Remove(item); 
                break;
            }
        }
    }
}
