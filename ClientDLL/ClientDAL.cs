using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientDLL;
using System.Data;
using System.Data.SqlClient;
using EntityModel;

namespace ClientDLL
{
    public class ClientDAL
    {
        public string AddIteams(Iteams objItems)
        {
            try
            {
                SqlParameter[] P = new SqlParameter[] {
                    new SqlParameter("@Name", objItems.Name),
                    new SqlParameter("@Company", objItems.Company),
                    new SqlParameter("@CompanySubName", objItems.CompanySubName),
                    new SqlParameter("@CompanySubName2", objItems.CompanySubName2),
                    new SqlParameter("@Packing", objItems.Packing),
                    new SqlParameter("@Unit", objItems.Unit),
                    new SqlParameter("@SubUnit", objItems.SubUnit),
                    new SqlParameter("@Status", objItems.Status),
                    new SqlParameter("@MfgBy", objItems.MfgBy),
                    new SqlParameter("@BarCode", objItems.BarCode),
                    new SqlParameter("@Schedule", objItems.Schedule),
                    new SqlParameter("@BoxQty", objItems.BoxQty),
                    new SqlParameter("@CaseQty", objItems.CaseQty ),
                    new SqlParameter("@MinLevel", objItems.MinLevel),
                    new SqlParameter("@MaxLevel", objItems.MaxLevel),
                    new SqlParameter("@Location", objItems.Location),
                    new SqlParameter("@Division", objItems.Division),
                    new SqlParameter("@UPC", objItems.UPC),
                    new SqlParameter("@LockInv", objItems.LockInv),
                    new SqlParameter("@Flage", objItems.Flage),
                    new SqlParameter("@SRate", objItems.SRate),
                    new SqlParameter("@SCPercentage", objItems.SCPercentage),
                    new SqlParameter("@MRP", objItems.MRP),
                    new SqlParameter("@WSRate", objItems.WSRate),
                    new SqlParameter("@WSRate2", objItems.WSRate2),
                    new SqlParameter("@SplRate", objItems.SplRate),
                    new SqlParameter("@SplRate2", objItems.SplRate2),
                    new SqlParameter("@MinGP", objItems.MinGP),
                    new SqlParameter("@PRate", objItems.PRate),
                    new SqlParameter("@PurchaseSCPerce", objItems.PurchaseSCPercentage),
                    new SqlParameter("@Excise", objItems.Excise),
                    new SqlParameter("@Scheme", objItems.Scheme),
                    new SqlParameter("@Scheme2", objItems.Scheme2),
                    new SqlParameter("@NR", objItems.NR),
                    new SqlParameter("@GST_HSNCode", objItems.GST_HSNCode),
                    new SqlParameter("@GST_CGSTPer", objItems.GST_CGSTPer),
                    new SqlParameter("@GST_SGSTPer", objItems.GST_SGSTPer),
                    new SqlParameter("@GST_IGSTPer", objItems.GST_IGSTPer),
                    new SqlParameter("@GST_CessPer", objItems.GST_CessPer),
                    new SqlParameter("@OD_VATPer", objItems.OD_VATPer),
                    new SqlParameter("@OD_Expiry", objItems.OD_Expiry),
                    new SqlParameter("@OD_Generic", objItems.OD_Generic),
                    new SqlParameter("@FixedDis", objItems.FixedDis),
                    new SqlParameter("@Inclusive", objItems.Inclusive),
                    new SqlParameter("@MaxInvQty", objItems.MaxInvQty),
                    new SqlParameter("@Locks", objItems.Locks),
                    new SqlParameter("@MaxDis", objItems.MaxDis),
                    new SqlParameter("@BarCode2", objItems.BarCode2),
                    new SqlParameter("@DefQty", objItems.DefQty),
                    new SqlParameter("@Volume", objItems.Volume),
                    new SqlParameter("@CompNameBC", objItems.CompNameBC),
                    new SqlParameter("@CommanItem", objItems.CommanItem),
                    new SqlParameter("@PrescriptionReq", objItems.PrescriptionReq),
                    new SqlParameter("@SeriesLock", objItems.SeriesLock),
                    new SqlParameter("@CurrentScheme", objItems.CurrentScheme),
                    new SqlParameter("@Category", objItems.Category),
                    new SqlParameter("@Category2", objItems.Category2),
                    new SqlParameter("@CommodityCode", objItems.CommodityCode),
                    new SqlParameter("@CommodityCode2", objItems.CommodityCode2),
                    new SqlParameter("@Generics1", objItems.Generics1),
                    new SqlParameter("@Generics11", objItems.Generics11),
                    new SqlParameter("@Generics12", objItems.Generics12),
                    new SqlParameter("@Generics21", objItems.Generics21),
                    new SqlParameter("@Generics22", objItems.Generics22),
                    new SqlParameter("@Generics3", objItems.Generics3),
                    new SqlParameter("@Generics31", objItems.Generics31),
                    new SqlParameter("@Generics32", objItems.Generics32),
                    new SqlParameter("@Generics4", objItems.Generics4),
                    new SqlParameter("@Generics41", objItems.Generics41),
                    new SqlParameter("@Generics42", objItems.Generics42),
                    new SqlParameter("@OtherGenerics5", objItems.OtherGenerics5 ),
                    new SqlParameter("@OtherGenerics51", objItems.OtherGenerics51),
                    new SqlParameter("@OtherGenerics52", objItems.OtherGenerics52),
                    new SqlParameter("@OtherGenerics6", objItems.OtherGenerics6 ),
                    new SqlParameter("@OtherGenerics61", objItems.OtherGenerics61),
                    new SqlParameter("@OtherGenerics62", objItems.OtherGenerics62)

                };
                return DataLib.GetScalarStringStoredProcData(DataLib.Connection.ConnectionString, SpKeys.AddItems, P);
            }

            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet getItemdetails(string strQuery)
        {
            SqlParameter[] P = new SqlParameter[] {
                    new SqlParameter("@itemCode", strQuery) };
           DataSet dt = DataLib.GetStoredProcData(DataLib.Connection.ConnectionString, SpKeys.getItemsDetail, P);

            return dt;
        }
    }
}
