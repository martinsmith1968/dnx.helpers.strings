// Code generated by a Template
using System;
using System.Linq;
using System.Collections.Generic;
using DNX.Helpers.Maths;
using NUnit.Framework;

namespace Test.DNX.Helpers.Maths.BuiltInTypes.TestsDataSource
{
    [TestFixture]
    public class MathsDecimalExtensionsTestsSource
    {
		private static object CreateDataValue(decimal value)
		{
			if (typeof(decimal) == typeof(DateTime))
			{
				var epoch = new DateTime(2017, 01, 01);

				return epoch.AddDays(Convert.ToInt32(value));
			}

			return value;
		}

        public static IEnumerable<TestCaseData> IsBetween_Default
        {
            get
            {
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10)).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10)).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10)).Returns(true);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1)).Returns(false);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1)).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1)).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10)).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10)).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1)).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1)).Returns(false);
            }
        }

        public static IEnumerable<TestCaseData> IsBetween_BoundsType
        {
            get
            {
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Inclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Inclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Inclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Inclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Inclusive).Returns(false);

                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Exclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Exclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Exclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Exclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Exclusive).Returns(false);

                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);

                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
            }
        }

        public static IEnumerable<TestCaseData> IsBetweenEither_Default
        {
            get
            {
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10)).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10)).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10)).Returns(true);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1)).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1)).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1)).Returns(true);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10)).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10)).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1)).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1)).Returns(false);
            }
        }

        public static IEnumerable<TestCaseData> IsBetweenEither_BoundsType
        {
            get
            {
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Inclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Inclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Inclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Inclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Inclusive).Returns(false);

                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Exclusive).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Exclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Exclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Exclusive).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Exclusive).Returns(false);

                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);

                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
            }
        }

        public static IEnumerable<TestCaseData> IsBetween()
        {
            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Inclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Inclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Inclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Inclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Inclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Inclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Inclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Inclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Inclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Inclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Inclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Inclusive).Returns(false);

            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Exclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Exclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Exclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Exclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Exclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Exclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Exclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Exclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Exclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Exclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Exclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Exclusive).Returns(false);

            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);

            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);


            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Inclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Inclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Inclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Inclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Inclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Inclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Inclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Inclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Inclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Inclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Inclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Inclusive).Returns(false);

            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Exclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Exclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Exclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Exclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Exclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Exclusive).Returns(true);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Exclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Exclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Exclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Exclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Exclusive).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Exclusive).Returns(false);

            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper).Returns(false);

            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(true);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
            yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper).Returns(false);
        }

        public static IEnumerable<TestCaseData> GetLowerBound
        {
            get
            {
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), true).Returns(CreateDataValue(1));
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), false).Returns(CreateDataValue(1));
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), true).Returns(CreateDataValue(1));
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), false).Returns(CreateDataValue(10));
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), true).Returns(CreateDataValue(10));
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), false).Returns(CreateDataValue(10));
            }
        }

        public static IEnumerable<TestCaseData> GetUpperBound
        {
            get
            {
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), true).Returns(CreateDataValue(10));
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), false).Returns(CreateDataValue(10));
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), true).Returns(CreateDataValue(10));
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), false).Returns(CreateDataValue(1));
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), true).Returns(CreateDataValue(10));
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), false).Returns(CreateDataValue(10));
            }
        }
    }
}
