// Code generated by a Template
using System;
using System.Linq.Expressions;
using DNX.Helpers.Reflection;

namespace DNX.Helpers.Maths.BuiltInTypes
{
    /// <summary>
    /// Guard Extensions.
    /// </summary>
    public static partial class Guard
    {
        /// <summary>
        /// Determines whether [is greater than] [the specified exp].
        /// </summary>
        /// <param name="exp">The exp.</param>
        /// <param name="min">The minimum.</param>
        public static void IsGreaterThan(Expression<Func<decimal>> exp, decimal min)
        {
            IsGreaterThan(exp, exp.Compile().Invoke(), min);
        }

        /// <summary>
        /// Determines whether [is greater than] [the specified exp].
        /// </summary>
        /// <param name="exp">The exp.</param>
        /// <param name="val">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public static void IsGreaterThan(Expression<Func<decimal>> exp, decimal val, decimal min)
        {
            if (val > min)
            {
                return;
            }

            var memberName = ReflectionExtensions.GetMemberName(exp);

            throw new ArgumentOutOfRangeException(
                memberName,
                val,
                string.Format("{0} must be greater than {1}",
                    memberName,
                    min
                )
            );
        }

        /// <summary>
        /// Determines whether [is greater than] [the specified exp].
        /// </summary>
        /// <param name="exp">The exp.</param>
        /// <param name="min">The minimum.</param>
        public static void IsGreaterThanOrEqualTo(Expression<Func<decimal>> exp, decimal min)
        {
            IsGreaterThanOrEqualTo(exp, exp.Compile().Invoke(), min);
        }

        /// <summary>
        /// Determines whether [is greater than] [the specified exp].
        /// </summary>
        /// <param name="exp">The exp.</param>
        /// <param name="val">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public static void IsGreaterThanOrEqualTo(Expression<Func<decimal>> exp, decimal val, decimal min)
        {
            if (val >= min)
            {
                return;
            }

            var memberName = ReflectionExtensions.GetMemberName(exp);

            throw new ArgumentOutOfRangeException(
                memberName,
                val,
                string.Format("{0} must be greater than or equal to {1}",
                    memberName,
                    min
                )
            );
        }

        /// <summary>
        /// Determines whether [is Less than] [the specified exp].
        /// </summary>
        /// <param name="exp">The exp.</param>
        /// <param name="max">The maximum.</param>
        public static void IsLessThan(Expression<Func<decimal>> exp, decimal max)
        {
            IsLessThan(exp, exp.Compile().Invoke(), max);
        }

        /// <summary>
        /// Determines whether [is Less than] [the specified exp].
        /// </summary>
        /// <param name="exp">The exp.</param>
        /// <param name="val">The value.</param>
        /// <param name="max">The minimum.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public static void IsLessThan(Expression<Func<decimal>> exp, decimal val, decimal max)
        {
            if (val < max)
            {
                return;
            }

            var memberName = ReflectionExtensions.GetMemberName(exp);

            throw new ArgumentOutOfRangeException(
                memberName,
                val,
                string.Format("{0} must be less than {1}",
                    memberName,
                    max
                )
            );
        }

        /// <summary>
        /// Determines whether [is Less than] [the specified exp].
        /// </summary>
        /// <param name="exp">The exp.</param>
        /// <param name="max">The maximum.</param>
        public static void IsLessThanOrEqualTo(Expression<Func<decimal>> exp, decimal max)
        {
            IsLessThanOrEqualTo(exp, exp.Compile().Invoke(), max);
        }

        /// <summary>
        /// Determines whether [is Less than] [the specified exp].
        /// </summary>
        /// <param name="exp">The exp.</param>
        /// <param name="val">The value.</param>
        /// <param name="max">The maximum.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public static void IsLessThanOrEqualTo(Expression<Func<decimal>> exp, decimal val, decimal max)
        {
            if (val <= max)
            {
                return;
            }

            var memberName = ReflectionExtensions.GetMemberName(exp);

            throw new ArgumentOutOfRangeException(
                memberName,
                val,
                string.Format("{0} must be less than or equal to {1}",
                    memberName,
                    max
                )
            );
        }

        /// <summary>
        /// Verifies an expression is between 2 values
        /// </summary>
        /// <param name="exp">The linq expression of the argument to check</param>
        /// <param name="min">minimum allowed value</param>
        /// <param name="max">maximum allowed value</param>
        public static void IsBetween(Expression<Func<decimal>> exp, decimal min, decimal max)
        {
            IsBetween(exp, min, max, IsBetweenBoundsType.Inclusive);
        }

        /// <summary>
        /// Verifies an expression is between 2 values
        /// </summary>
        /// <param name="exp">The exp.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="boundsType">Type of the bounds.</param>
        public static void IsBetween(Expression<Func<decimal>> exp, decimal min, decimal max, IsBetweenBoundsType boundsType)
        {
            IsBetween(exp, min, max, false, boundsType);
        }

        /// <summary>
        /// Verifies an expression is between 2 values
        /// </summary>
        /// <param name="exp">The exp.</param>
        /// <param name="bound1">The bound1.</param>
        /// <param name="bound2">The bound2.</param>
        /// <param name="allowEitherOrder">if set to <c>true</c> [allow either order].</param>
        /// <param name="boundsType">Type of the bounds.</param>
        public static void IsBetween(Expression<Func<decimal>> exp, decimal bound1, decimal bound2, bool allowEitherOrder, IsBetweenBoundsType boundsType)
        {
            IsBetween(exp, exp.Compile().Invoke(), bound1, bound2, allowEitherOrder, boundsType);
        }

        /// <summary>
        /// Verifies an expression is between 2 values
        /// </summary>
        /// <param name="exp">The exp.</param>
        /// <param name="val">The value.</param>
        /// <param name="bound1">The bound1.</param>
        /// <param name="bound2">The bound2.</param>
        /// <param name="allowEitherOrder">if set to <c>true</c> [allow either order].</param>
        /// <param name="boundsType">Type of the bounds.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public static void IsBetween(Expression<Func<decimal>> exp, decimal val, decimal bound1, decimal bound2, bool allowEitherOrder, IsBetweenBoundsType boundsType)
        {
            if (val.IsBetween(bound1, bound2, allowEitherOrder, boundsType))
            {
                return;
            }

            var memberName = ReflectionExtensions.GetMemberName(exp);

            throw new ArgumentOutOfRangeException(
                memberName,
                val,
                string.Format("{0} must be {1}",
                    memberName,
                    string.Format(boundsType.GetLimitDescriptionFormat(),
                        MathDecimalExtensions.GetLowerBound(bound1, bound2, allowEitherOrder),
                        MathDecimalExtensions.GetUpperBound(bound1, bound2, allowEitherOrder)
                        )
                    )
                );
        }
    }
}
