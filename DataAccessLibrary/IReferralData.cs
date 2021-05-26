using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IReferralData
    {
        Task<List<ReferralModel>> GetReferral(string column, string sortBy);
        Task InsertReferral(ReferralModel referral);
        Task UpdateReferral(ReferralModel referral);
    }
}