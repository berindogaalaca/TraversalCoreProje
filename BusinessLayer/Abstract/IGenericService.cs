﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService <T>
    {
        void TAdd(T t);
        void Delete (T t);
        void Update (T t);
        List<T> TGetList ();
        T TGetByID(int id);
    }
}
