using CSharpEgitimKampi301.BussinesLayer.Abstract;
using CSharpEgitimKampi301.DataAccesLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BussinesLayer.Concrete
{
    public class CustomerManeger : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManeger(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            //if(yetki varsa) { listeleme  yap } else { listeleme  yapma}
            return _customerDal.GetAll();
        }

        public Customer TGetById(int id)
        {
           return _customerDal.GetById(id);
        }

        public void TInsert(Customer entity)
        {
            if (entity.CustomerName!="" && entity.CustomerName.Length>=3 &&
                entity.CustomerCity!=null && entity.CustomerName.Length<= 30)
            {
                _customerDal.Insert(entity);
            }
            else
            {
                //hata mesaji
            }
        }

        public void TUpdate(Customer entity)
        {
          if (entity.CustomerId != 0 && entity.CustomerCity.Length>= 3)
            {
                _customerDal.Update(entity);
            }
            else
            {
                //Hata mesaji
            }
        }
    }
}
