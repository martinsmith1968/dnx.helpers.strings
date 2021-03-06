// Code generated by a Template
using System;
using DNX.Helpers.Maths;
using DNX.Helpers.Maths.BuiltInTypes;
using NUnit.Framework;
using Test.DNX.Helpers.Maths.BuiltInTypes.TestsDataSource;

namespace Test.DNX.Helpers.Maths.BuiltInTypes
{
    [TestFixture]
    public class MathsInt64ExtensionsTests
    {
        [TestCaseSource(typeof(MathsInt64ExtensionsTestsSource), "IsBetween_Default")]
        public bool IsBetween_Default(long value, long min, long max)
        {
            return value.IsBetween(min, max);
        }

        [TestCaseSource(typeof(MathsInt64ExtensionsTestsSource), "IsBetween_BoundsType")]
        public bool IsBetween_BoundsType(long value, long min, long max, IsBetweenBoundsType boundsType)
        {
            return value.IsBetween(min, max, boundsType);
        }

        [TestCaseSource(typeof(MathsInt64ExtensionsTestsSource), "IsBetweenEither_Default")]
        public bool IsBetweenEither_Default(long value, long min, long max)
        {
            return value.IsBetweenEither(min, max);
        }

        [TestCaseSource(typeof(MathsInt64ExtensionsTestsSource), "IsBetweenEither_BoundsType")]
        public bool IsBetweenEither_BoundsType(long value, long min, long max, IsBetweenBoundsType boundsType)
        {
            return value.IsBetweenEither(min, max, boundsType);
        }

        [TestCaseSource(typeof(MathsInt64ExtensionsTestsSource), "IsBetween")]
        public bool IsBetween(long value, long min, long max, bool allowEitherOrder, IsBetweenBoundsType boundsType)
        {
            return value.IsBetween(min, max, allowEitherOrder, boundsType);
        }

        [TestCaseSource(typeof(MathsInt64ExtensionsTestsSource), "GetLowerBound")]
        public long GetLowerBound(long min, long max, bool allowEitherOrder)
        {
            return MathsInt64Extensions.GetLowerBound(min, max, allowEitherOrder);
        }

        [TestCaseSource(typeof(MathsInt64ExtensionsTestsSource), "GetUpperBound")]
        public long GetUpperBound(long min, long max, bool allowEitherOrder)
        {
            return MathsInt64Extensions.GetUpperBound(min, max, allowEitherOrder);
        }
    }
}
