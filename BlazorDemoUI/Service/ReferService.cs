using BlazorDemoUI.Data;
using BlazorDemoUI.IService;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoUI.Service
{
    public class ReferService : IReferService
    {
        Refer _oRefer = new Refer();
        public Refer GetSavedRefer()
        {
            _oRefer = new Refer();
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                var oRefer = con.Query<Refer>("SELECT TOP(1)* FROM Referral").ToList();

                if(oRefer != null && oRefer.Count() > 0)
                {
                    _oRefer = oRefer.FirstOrDefault();
                }
            }
            return _oRefer;
        }


        public Refer Save(Refer oRefer)
        {
            _oRefer = new Refer();
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                var oRefers = con.Query<Refer>("procReferral", this.SetParameters(oRefer), commandType: CommandType.StoredProcedure);

                if (oRefers != null && oRefers.Count() > 0)
                {
                    _oRefer = oRefers.FirstOrDefault();
                }
            }
            return _oRefer;
        }

        private DynamicParameters SetParameters(Refer oRefer)
        {
            DynamicParameters parameters = new DynamicParameters();

            // parameters.Add("@Id", oRefer.Id);
            parameters.Add("@Category", oRefer.Category);
            parameters.Add("@Referral", oRefer.Referral);
            // parameters.Add("@Image", oRefer.Image);
            parameters.Add("@Company", oRefer.Company);
            parameters.Add("@Website", oRefer.Website);
            parameters.Add("@Instructions", oRefer.Instructions);

            return parameters;
        }
    }
}
