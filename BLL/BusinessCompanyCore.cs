using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BusinessCompanyCore
    {
         public List<Categorie> GetListCategorie()
        {
            var context = new CompanyDBContext();
            var list = context.Categories.ToList();
            return list ;
        }
    }
}
