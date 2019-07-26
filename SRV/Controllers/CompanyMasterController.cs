using ClientBLL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRV.Controllers
{
    public class CompanyMasterController : Controller
    {
        // GET: CompanyMaster
        public ActionResult Company()
        {
            return View();
        }
        public ActionResult GetCompanys()
        {
            DataSet ds_Company = new DataSet();
            ItemsBAL objBAL = new ItemsBAL();
            //ds_Company = objBAL.GetItems();
            string jsonData = "";
            try
            {
                ds_Company = objBAL.GetCompany();
                if (ds_Company.Tables[0].Rows.Count > 0)
                {
                    JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
                    serializerSettings.Converters.Add(new DataTableConverter());
                    jsonData = JsonConvert.SerializeObject(ds_Company, Formatting.None, serializerSettings);
                }
                else
                {
                    jsonData = "";

                }
            }
            catch (Exception ex)
            {
                jsonData = "Fail";
            }
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
    }
}