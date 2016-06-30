namespace Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Comment
    {
        public int CommentId { get; set; }

        public int PostId { get; set; }

        [Required]
        [StringLength(255)]
        public string Content { get; set; }

        public DateTime Created { get; set; }
    }
}
