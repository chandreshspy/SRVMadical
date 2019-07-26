using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientDLL;
using System.Data;
using System.Globalization;


namespace ClientBLL
{
    public class ClientBAL
    {
        public int SetHompagedetails(List<HomeDetail> employees)
        {
            ClientDAL objDal = new ClientDAL();
            try
            {
                return 0;
            }
            catch
            {
                throw;
            }
        }
    }
}
