﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Library
{
    public interface IRepository<T> where T : class, IEntity
    {
        IList<T> GetAll();
    }
}