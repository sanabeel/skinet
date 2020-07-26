using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        // give expression in Iqueryable manner which will get executed in db
        // Here criteria's return vale will be boolean (where clause). ie whether a data to be selected or not
        Expression<Func<T, bool>> Criteria { get; } 
        // here for this express a list of navigation data in the format of basic data type 'object'
        List<Expression<Func<T, object>>> Includes { get; }
        // Here we want to add expression for sorting, so output will be an object ( in sorted manner , that does nt affect expression)
        Expression<Func<T, object>> OrderBy {get;}
        Expression<Func<T, object>> OrderByDescending {get;}
        int Take { get;}
        int Skip { get; }
        bool IsPagingEnabled {get;}
    }
}