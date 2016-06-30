namespace Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Post
    {
        public int PostId { get; set; }

        [Required]
        [StringLength(160)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime Created { get; set; }
    }
}
