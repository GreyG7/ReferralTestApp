using BlazorDemoUI.Data;
using BlazorDemoUI.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoUI.PageClass
{
    public class ReferPage
    {
        /*
        IReferService _referService = null;
        public ReferPage(IReferService referService)
        {
            _referService = referService;
        }

        public string SaveInformation(byte[] fileBytes, Refer oRefer)
        {
            oRefer.Image = fileBytes;
            oRefer = _referService.Save(oRefer);
            if(oRefer.Id > 0)
            {
                return "Saved";
            }
            return "Failed";
        }

        public Refer GetSavedRefer()
        {
            var refer = _referService.GetSavedRefer();
            refer.Image = this.GetImage(Convert.ToBase64String(refer.Image));
            refer.ImageUrl = string.Format("data:image/jpg;base64,{0}",Convert.ToBase64String(refer.Image));
            return refer;
        }

        public byte[] GetImage(string sBase64String)
        {
            byte[] bytes = null;
            if (!string.IsNullOrEmpty(sBase64String))
            {
                bytes = Convert.FromBase64String(sBase64String);
            }
            return bytes;
        }
        */
    }
}
