using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Models
{
    public class Post
    {
        public Post(int id, string title, string content, int categoryId)
        {
            this.Id = id;
            this.Title = title;
            this.Content = content;
            this.CategoryId = categoryId;
        }

        public Post(int id, string title, string content, int authorId, int categoryId, List<int> replies)
            : this(id, title, content,categoryId)
        {
            this.AuthorId = authorId;
            this.Replies = replies;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public ICollection<int> Replies { get; set; }
    }
}
