﻿using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarDbContext>, IColorDal
    {
        
    }
}
