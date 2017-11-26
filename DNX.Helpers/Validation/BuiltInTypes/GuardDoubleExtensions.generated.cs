// Code generated by a Template
using System;
using System.Linq.Expressions;
using DNX.Helpers.Maths;
using DNX.Helpers.Maths.BuiltInTypes;
using DNX.Helpers.Reflection;

namespace DNX.Helpers.Validation
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
        public static void IsGreaterThan(Expression<Func<double>> exp, double min)
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
        public static void IsGreaterThan(Expression<Func<double>> exp, double val, double min)
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
        public static void IsGreaterThanOrEqualTo(Expression<Func<double>> exp, double min)
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
        public static void IsGreaterThanOrEqualTo(Expression<Func<double>> exp, double val, double min)
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
        public static void IsLessThan(Expression<Func<double>> exp, double max)
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
        public static void IsLessThan(Expression<Func<double>> exp, double val, double max)
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
        public static void IsLessThanOrEqualTo(Expression<Func<double>> exp, double max)
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
        public static void IsLessThanOrEqualTo(Expression<Func<double>> exp, double val, double max)
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
        public static void IsBetween(Expression<Func<double>> exp, double min, double max)
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
        public static void IsBetween(Expression<Func<double>> exp, double min, double max, IsBetweenBoundsType boundsType)
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
        public static void IsBetween(Expression<Func<double>> exp, double bound1, double bound2, bool allowEitherOrder, IsBetweenBoundsType boundsType)
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
        public static void IsBetween(Expression<Func<double>> exp, double val, double bound1, double bound2, bool allowEitherOrder, IsBetweenBoundsType boundsType)
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
                        MathsDoubleExtensions.GetLowerBound(bound1, bound2, allowEitherOrder),
                        MathsDoubleExtensions.GetUpperBound(bound1, bound2, allowEitherOrder)
                        )
                    )
                );
        }
    }
}
