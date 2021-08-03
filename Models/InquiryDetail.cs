using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class InquiryDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int InquaryHeaderId { get; set; }
        [ForeignKey("InquaryHeaderId")]
        public InquiryHeader InquaryHeader { get; set; }
        [Required]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }
}
