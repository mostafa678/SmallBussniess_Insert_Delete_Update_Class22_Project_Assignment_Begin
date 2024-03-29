﻿using SmallBusiness.Models.Models;
using SmallBusiness.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusiness.BLL.BLL
{
   public class SupplierManager
    {
        SupplierRepository _supplierRepository = new SupplierRepository();
        public bool Add(Supplier supplier)
        {
            return _supplierRepository.Add(supplier);
        }
        public bool Delete(Supplier supplier)
        {
            return _supplierRepository.Delete(supplier);
        }
        public bool Update(Supplier supplier)
        {
            return _supplierRepository.Update(supplier);
        }
        public Supplier GetByID(Supplier supplier)
        {
            return _supplierRepository.GetByID(supplier);
        }
    }
}
