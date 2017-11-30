// Code generated by a Template
using System;
using System.Linq;
using System.Collections.Generic;
using DNX.Helpers.Maths;
using NUnit.Framework;

namespace Test.DNX.Helpers.Validation.BuiltInTypes.TestsDataSource
{
    [TestFixture]
    public class GuardByteTestsSource
    {
        private static object CreateDataValue(byte value)
        {
            if (typeof(byte) == typeof(DateTime))
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
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), null).Returns(true);
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), string.Format("value must be between {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
				yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), string.Format("value must be between {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
				yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), string.Format("value must be between {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
				yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), string.Format("value must be between {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
				yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), string.Format("value must be between {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
				yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), string.Format("value must be between {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
				yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), string.Format("value must be between {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
            }
        }

        public static IEnumerable<TestCaseData> IsBetween_BoundsType
        {
            get
            {
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);

                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);

                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);

                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
            }
        }

        public static IEnumerable<TestCaseData> IsBetween
        {
			get
			{
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Inclusive, null).Returns(true);
				yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Inclusive, null).Returns(true);
				yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Inclusive, null).Returns(true);
				yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Inclusive, null).Returns(true);
				yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Inclusive, null).Returns(true);
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
				yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
				yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
				yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
				yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
				yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
				yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);

                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Exclusive, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Exclusive, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Exclusive, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);

                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);

                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), false, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(10), CreateDataValue(1))).Returns(false);


				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Inclusive, null).Returns(true);
				yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Inclusive, null).Returns(true);
				yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Inclusive, null).Returns(true);
				yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Inclusive, null).Returns(true);
				yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Inclusive, null).Returns(true);
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Inclusive, null).Returns(true);
				yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Inclusive, null).Returns(true);
				yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Inclusive, null).Returns(true);
				yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
				yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
				yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
				yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Inclusive, string.Format("value must be between {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);

                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Exclusive, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Exclusive, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Exclusive, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Exclusive, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.Exclusive, string.Format("value must be between but not including {0} and {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);

                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanOrEqualToLowerLessThanUpper, string.Format("value must be greater than or equal to {0} but less than {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);

                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(2), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(9), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(1), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(10), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, null).Returns(true);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(1), CreateDataValue(10), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(20), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
                yield return new TestCaseData(CreateDataValue(0), CreateDataValue(10), CreateDataValue(1), true, IsBetweenBoundsType.GreaterThanLowerLessThanOrEqualToUpper, string.Format("value must be greater than {0} but less than or equal to {1}", CreateDataValue(1), CreateDataValue(10))).Returns(false);
			}
        }

        public static IEnumerable<TestCaseData> IsGreaterThan
        {
			get
			{
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), null).Returns(true);
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(5), string.Format("value must be greater than {0}", CreateDataValue(5))).Returns(false);
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), string.Format("value must be greater than {0}", CreateDataValue(10))).Returns(false);
			}
		}

        public static IEnumerable<TestCaseData> IsGreaterThanOrEqualTo
        {
			get
			{
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), null).Returns(true);
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(5), null).Returns(true);
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), string.Format("value must be greater than or equal to {0}", CreateDataValue(10))).Returns(false);
			}
		}

        public static IEnumerable<TestCaseData> IsLessThan
        {
			get
			{
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), null).Returns(true);
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(5), string.Format("value must be less than {0}", CreateDataValue(5))).Returns(false);
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), string.Format("value must be less than {0}", CreateDataValue(1))).Returns(false);
			}
		}

        public static IEnumerable<TestCaseData> IsLessThanOrEqualTo
        {
			get
			{
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(10), null).Returns(true);
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(5), null).Returns(true);
				yield return new TestCaseData(CreateDataValue(5), CreateDataValue(1), string.Format("value must be less than or equal to {0}", CreateDataValue(1))).Returns(false);
			}
		}
    }
}
