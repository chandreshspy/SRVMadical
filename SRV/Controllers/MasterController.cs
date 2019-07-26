using ClientBLL;
using ClientDLL;
using EntityModel;
using ItemsModel;
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
    public class MasterController : Controller
    {
        // GET: Master
        public ActionResult AddUpdateItems()
        {
            ViewBag.ItemCode= Request.QueryString["xyz"];
            return View();
        }
        [HttpPost]
        [ActionName("AddUpdateItems")]
        public ActionResult AddUpdateItemsEdit()
        {
            return View();
        }
        public ActionResult ItemDetail()
        {
            return View();
        }
        public ActionResult GetItems()
        {
            DataSet ds_Items = new DataSet();
            ItemsBAL objBAL = new ItemsBAL();
            //ds_Items = objBAL.GetItems();
            string jsonData = "";
            try
            {
                ds_Items = objBAL.GetItems();
                if (ds_Items.Tables[0].Rows.Count > 0)
                {
                    JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
                    serializerSettings.Converters.Add(new DataTableConverter());
                    jsonData = JsonConvert.SerializeObject(ds_Items, Formatting.None, serializerSettings);
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
        public ActionResult itemEdit(string code)
        {
            DataTable ds = new DataTable();
            ClientDAL objBAL = new ClientDAL();
            string jsonData = "";
            try
            {
                DataSet dsItem = objBAL.getItemdetails(code);
                if (dsItem.Tables[0].Rows.Count > 0)
                {
                    JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
                    serializerSettings.Converters.Add(new DataTableConverter());
                    jsonData = JsonConvert.SerializeObject(dsItem.Tables[0], Formatting.None, serializerSettings);
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

            string JSONString = string.Empty;
            //JSONString = JsonConvert.SerializeObject(table);
            return Json(new
            {
                redirectTo = Url.Action("AddUpdateItems", "Master"),
                redirectTo1 = jsonData,
            }, jsonData, JsonRequestBehavior.AllowGet);
            //return Json(jsonData, JsonRequestBehavior.AllowGet);
         // return View("~/Views/Master/AddUpdateItems.cshtml", jsonData);
        }
        public ActionResult AddIteamDetails(Iteams ObjItems)
        {
            DataSet ds = new DataSet();
            ClientDAL objBAL = new ClientDAL();
            string jsonData = "";
            try
            {
                string count = objBAL.AddIteams(ObjItems);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
                    serializerSettings.Converters.Add(new DataTableConverter());
                    jsonData = JsonConvert.SerializeObject(ds, Formatting.None, serializerSettings);
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