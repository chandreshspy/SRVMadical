using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientDLL;
using System.Data;
using System.Globalization;


namespace ClientBLL
{
    public class ItemsBAL
    {
        public DataSet GetItems()
        {
            ItemsDAL objDal = new ItemsDAL();
            try
            {
                return objDal.GetItems();
            }
            catch
            {
                throw;
            }
        }

        public DataSet GetCompany()
        {
            ItemsDAL objDal = new ItemsDAL();
            try
            {
                return objDal.GetCompany();
            }
            catch
            {
                throw;
            }
        }
    }
}
