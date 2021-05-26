using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoUI.Models
{
    public class DisplayReferralModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Category is too long.")]
        [MinLength(1, ErrorMessage = "Category is too short.")]
        public string Category { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Referral is too long.")]
        [MinLength(1, ErrorMessage = "Referral is too short.")]
        public string Referral { get; set; }

        // public byte[] Image { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Company is too long.")]
        [MinLength(1, ErrorMessage = "Company is too short.")]
        public string Company { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Website is too long.")]
        [MinLength(4, ErrorMessage = "Website is too short.")]
        public string Website { get; set; }

        [Required]
        [StringLength(1500, ErrorMessage = "Instructions is too long.")]
        [MinLength(1, ErrorMessage = "Instructions is too short.")]
        public string Instructions { get; set; }
    }
}
