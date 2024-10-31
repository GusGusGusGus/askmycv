using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    [Table("Documents")]
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ContentType { get; set; }
        public string TextContent { get; set; }
        public DateTime UploadedDate { get; set; }
        // Foreign key to the AppUser
        public int? AppUserId { get; set; }
        public int? JobPostId { get; set; }

        // Navigation property to the AppUser entity
        public AppUser AppUser { get; set; }
        public JobPost JobPost { get; set; }
        

    }
}