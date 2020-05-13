using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
namespace PostComment
{
    public partial class Post
    {
        public bool AddPost()
        {
            using (ModelContainer ctx = new ModelContainer())
            {
                bool bResult = false;
                if (this.PostId == 0)
                {
                    var it = ctx.Entry<Post>(this).State = EntityState.Added;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public Post UpdatePost(Post newPost)
        {
            using (ModelContainer ctx = new ModelContainer())
            {
                Post oldPost = ctx.PostSet.Find(newPost.PostId);
                if (oldPost == null) // nu exista in bd
                {
                    return null;
                }
                oldPost.Description = newPost.Description;
                oldPost.Domain = newPost.Domain;
                oldPost.Date = newPost.Date;
                ctx.SaveChanges();
                return oldPost;
            }
        }
        public int DeletePost(int id)
        {
            using (ModelContainer ctx = new ModelContainer())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From PostSet where postid =@p0", id);
            }
        }
        public Post GetPostById(int id)
        {
            using (ModelContainer ctx = new ModelContainer())
            {
                var items = from p in ctx.PostSet where (p.PostId == id) select p;
                if (items != null)
                    return items.Include(c => c.Comment).SingleOrDefault();
                return null; // trebuie verificat in apelant
            }
        }
        public List<Post> GetAllPosts()
        {
            using (ModelContainer ctx = new ModelContainer())
            {
                return ctx.PostSet.Include("Comment").ToList<Post>();
                // Obligatoriu de verificat in apelant rezultatul primit.
            }
        }
    }
}