using Project.DataAccessLayer.Abstract;
using Project.DataAccessLayer.Concrete;
using Project.DataAccessLayer.Repositories;
using ProjectAPI.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.EntityFramework
{
    public class EfSikayetDal : GenericRepository<Sikayet>, ISikayetDal
    {
        public EfSikayetDal(Context context) : base(context)
        {

        }
    }
}
