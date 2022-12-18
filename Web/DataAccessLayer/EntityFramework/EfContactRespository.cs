﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repositores;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactRespository : GenericRepository<Contact>,IContactDal
    {
    }
}
