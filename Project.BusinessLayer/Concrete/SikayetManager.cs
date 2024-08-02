using Project.BusinessLayer.Abstract;
using Project.DataAccessLayer.Abstract;
using ProjectAPI.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Concrete
{
    public class SikayetManager : ISikayetService 
    {
        private readonly ISikayetDal _sikayetDal;

        public SikayetManager(ISikayetDal sikayetDal)
        {
            _sikayetDal = sikayetDal;
        }

        public void TDelete(Sikayet entity)
        {
            _sikayetDal.Delete(entity);
            
        }

        public Sikayet TGetByID(int id)
        {
            return _sikayetDal.GetByID(id);
        }

        public List<Sikayet> TGetList()
        {
            return _sikayetDal.GetList();
        }

        public void TInsert(Sikayet entity)
        {
            _sikayetDal.Insert(entity);
        }

        public void TUpdate(Sikayet entity)
        {
            _sikayetDal.Update(entity);
        }
    }
}
