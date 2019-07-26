using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClientBLL;
using System.Data;
using ItemsModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SRV.Controllers
{
    public class IteamMasterController : Controller
    {
        // GET: IteamMaster
        public ActionResult Items()
        {
            return View();
        }
        //public ActionResult GetItems()
        //{
        //    DataSet ds_Items = new DataSet();
        //    ItemsBAL objBAL = new ItemsBAL();
        //    ds_Items = objBAL.GetItems();
        //    string jsonData = "";
        //    try
        //    {
        //        ds_Items = objBAL.GetItems();
        //        if (ds_Items.Tables[0].Rows.Count > 0)
        //        {
        //            JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
        //            serializerSettings.Converters.Add(new DataTableConverter());
        //            jsonData = JsonConvert.SerializeObject(ds_Items, Formatting.None, serializerSettings);
        //        }
        //        else
        //        {
        //            jsonData = "";

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        jsonData = "Fail";
        //    }
        //    return Json(jsonData, JsonRequestBehavior.AllowGet);
        //}
    public void GetItemstest()
        {
            DataSet ds_Items = new DataSet();
            ItemsBAL objBAL = new ItemsBAL();
            List<Items> ItemLst = new List<Items>();
            ds_Items = objBAL.GetItems();
            if (ds_Items.Tables[0].Rows.Count > 0)
            {
                Items items = new Items();
                for (int i = 0; i < ds_Items.Tables[0].Rows.Count; i++)
                {
                    items.Name = ds_Items.Tables[0].Rows[i]["Name"].ToString();
                    items.HSNCode = ds_Items.Tables[0].Rows[i]["HSNCode"].ToString();
                    items.compname = ds_Items.Tables[0].Rows[i]["compname"].ToString();
                    items.pack = ds_Items.Tables[0].Rows[i]["pack"].ToString();
                    items.clqty = ds_Items.Tables[0].Rows[i]["clqty"].ToString();
                }


                ItemLst.Add(items);
            }
        }
    }
}