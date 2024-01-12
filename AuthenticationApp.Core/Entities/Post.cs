using AuthenticationApp.Core.Entities.Base;

namespace AuthenticationApp.Core.Entities
{
    public class Post : BaseEntity
    {
        public required string Author { get; set; }

        public required string Header { get; set; }

        public required string Body { get; set; }
    }
}
