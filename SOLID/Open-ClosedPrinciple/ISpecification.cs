﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_ClosedPrinciple
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity);
    }
}
