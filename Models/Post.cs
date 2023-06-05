using Dapper.Contrib.Extensions;

namespace ProjeAcessoDadosDapper.Models
{
    [Table("[Post]")]
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }    
    }
}