using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DataAccessLibrary.Models
{
    public class ReferralModel : IReferralModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Referral { get; set; }
        public string Company { get; set; }
        public string Website { get; set; }
        public string Instructions { get; set; }
    }
}
