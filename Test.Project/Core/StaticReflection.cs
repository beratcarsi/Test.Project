using System;
using System.Linq.Expressions;

namespace Test.Project.Core
{
    public static class StaticReflection
    {
        public static string GetPropertyName<T>(this T instance, Expression<Func<T, object>> expression)
        {
            return GetPropertyName(expression);
        }

        public static string GetPropertyName<T>(Expression<Func<T, object>> expression)
        {
            if (expression == null)
                throw new ArgumentException("The expression cannot be null.");

            return GetPropertyName(expression.Body);
        }

        public static string GetPropertyName<T>(this T instance, Expression<Action<T>> expression)
        {
            return GetPropertyName(expression);
        }

        public static string GetPropertyName<T>(Expression<Action<T>> expression)
        {
            if (expression == null)
                throw new ArgumentException("The expression cannot be null.");

            return GetPropertyName(expression.Body);
        }

        private static string GetPropertyName(Expression expression)
        {
            if (expression == null)
                throw new ArgumentException("The expression cannot be null.");

            if (expression is MemberExpression)
            {
                // Reference type property or field
                var memberExpression = (MemberExpression)expression;
                return memberExpression.Member.Name;
            }

            if (expression is MethodCallExpression)
            {
                // Reference type method
                var methodCallExpression = (MethodCallExpression)expression;
                return methodCallExpression.Method.Name;
            }

            if (expression is UnaryExpression)
            {
                // Property, field of method returning value type
                var unaryExpression = (UnaryExpression)expression;
                return GetPropertyName(unaryExpression);
            }

            throw new ArgumentException("Invalid expression");
        }

        private static string GetPropertyName(UnaryExpression unaryExpression)
        {
            if (unaryExpression.Operand is MethodCallExpression)
            {
                var methodExpression = (MethodCallExpression)unaryExpression.Operand;
                return methodExpression.Method.Name;
            }

            return ((MemberExpression)unaryExpression.Operand).Member.Name;
        }

    }
}