using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Open_ClosedPrinciple
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> _first;
        private ISpecification<T> _second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            _first = first;
            _second = second;
        }
        public bool IsSatisfiedBy(T entity)
        {
            return _first.IsSatisfiedBy(entity) && _second.IsSatisfiedBy(entity);
        }
    }
}
