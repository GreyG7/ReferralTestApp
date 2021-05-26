using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class ReferralData : IReferralData
    {
        private readonly ISqlDataAccess db;

        public ReferralData(ISqlDataAccess db)
        {
            this.db = db;
        }

        // Add parameter based on sorting button values
        public Task<List<ReferralModel>> GetReferral(string column, string sortBy)
        {
            string sql = "SELECT * FROM dbo.Referral ORDER BY "+ column + " " + sortBy;

            return db.LoadData<ReferralModel, dynamic>(sql, new { });
        }

        public Task InsertReferral(ReferralModel referral)
        {
            string sql = @"INSERT INTO dbo.Referral (Category, Referral, Company, Website, Instructions)
                           VALUES(@Category, @Referral, @Company, @Website, @Instructions)";

            return db.SaveData(sql, referral);
        }

        public Task UpdateReferral(ReferralModel referral)
        {
            string sql = @"UPDATE dbo.Referral SET @Category, @Referral, @Company, @Website, @Instructions WHERE Id = @Id";

            return db.SaveData(sql, referral);

        }
    }
}
