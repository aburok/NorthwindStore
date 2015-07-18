using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace NorthwindStore.Common.Extensions
{
    public static class ReflectionExtensions
    {
        public static MemberInfo GetMethodInfo<T>(Expression<Action<T>> expression)
        {
            var unaryExpression = (UnaryExpression)expression.Body;
            var methodCallExpression = (MethodCallExpression)unaryExpression.Operand;
            var methodInfoExpression = (ConstantExpression)methodCallExpression.Arguments.Last();
            var methodInfo = (MemberInfo)methodInfoExpression.Value;
            return methodInfo;
        }
    }
}