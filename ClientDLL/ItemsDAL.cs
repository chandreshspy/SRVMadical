using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClientDLL
{
    public class ItemsDAL
    {
        public DataSet GetItems()
        {
            ClientHome homedetl = new ClientHome();
            try
            {
                SqlParameter[] P = new SqlParameter[] {
                //new SqlParameter("@file", detail[0].file),
                //  new SqlParameter("@Heding", detail[0].Heding),
                //  new SqlParameter("@subHeding", detail[0].subHeding),

                };
                return DataLib.GetStoredProcData(DataLib.Connection.ConnectionString, SpKeys.srv_GetItems, P);
            }

            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet GetCompany()
        {
            ClientHome homedetl = new ClientHome();
            try
            {
                SqlParameter[] P = new SqlParameter[] {
                //new SqlParameter("@file", detail[0].file),
                //  new SqlParameter("@Heding", detail[0].Heding),
                //  new SqlParameter("@subHeding", detail[0].subHeding),

                };
                return DataLib.GetStoredProcData(DataLib.Connection.ConnectionString, SpKeys.srv_GetCompany, P);
            }

            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
