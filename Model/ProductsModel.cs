using Model.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class ProductsModel
    {
        private dbcontext context = null;
     public ProductsModel()
     {
     context = new dbcontext();
     }
     public List<tbl_products> ListAll()
     {
        var list = context.Database.SqlQuery<tbl_products>("SP_Products_listall").ToList();
        return list;
     }
    }
}

