using System;

namespace SpecificationPattern
{
    public class ExpressionSpecification<T> : CompositeSpecification<T>
    {
        private readonly Func<T, bool> _expression;
        public ExpressionSpecification(Func<T, bool> expression)
        {
            _expression = expression ?? throw new ArgumentNullException("Expression can not be null.");
        }

        public override bool IsSatisfiedBy(T o)
        {
            return _expression(o);
        }
    } 
}