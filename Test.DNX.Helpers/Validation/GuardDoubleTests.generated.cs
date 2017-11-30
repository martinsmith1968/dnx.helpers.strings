// Code generated by a Template
using System;
using DNX.Helpers.Maths;
using DNX.Helpers.Validation.BuiltInTypes;
using NUnit.Framework;
using Should;
using Test.DNX.Helpers.Validation.BuiltInTypes.TestsDataSource;

namespace Test.DNX.Helpers.Validation.BuiltInTypes
{
    [TestFixture]
    public class GuardDoubleTests
    {
		[TestCaseSource(typeof(GuardDoubleTestsSource), "IsBetween_Default")]
		public bool Guard_IsBetween_Default(double value, double min, double max, string messageText)
		{
			try
			{
				// Act
				Guard.IsBetween(() => value, min, max);

				return true;
			}
			catch (ArgumentOutOfRangeException ex)
			{
                Assert.IsNotNull(messageText);
                Assert.IsNotEmpty(messageText);
				ex.Message.ShouldStartWith(messageText);
				return false;
			}
			catch (Exception ex)
			{
				// Assert
				Assert.Fail(ex.Message);
				return false;
			}
		}

        [TestCaseSource(typeof(GuardDoubleTestsSource), "IsBetween_BoundsType")]
        public bool Guard_IsBetween_BoundsType(double value, double min, double max, IsBetweenBoundsType boundsType, string messageText)
        {
			try
			{
				// Act
				Guard.IsBetween(() => value, min, max, boundsType);

				return true;
			}
			catch (ArgumentOutOfRangeException ex)
			{
                Assert.IsNotNull(messageText);
                Assert.IsNotEmpty(messageText);
				ex.Message.ShouldStartWith(messageText);
				return false;
			}
			catch (Exception ex)
			{
				// Assert
				Assert.Fail(ex.Message);
				return false;
			}
        }

        [TestCaseSource(typeof(GuardDoubleTestsSource), "IsBetween")]
        public bool Guard_IsBetween(double value, double min, double max, bool allowEitherOrder, IsBetweenBoundsType boundsType, string messageText)
        {
			try
			{
				// Act
				Guard.IsBetween(() => value, min, max, allowEitherOrder, boundsType);

				return true;
			}
			catch (ArgumentOutOfRangeException ex)
			{
                Assert.IsNotNull(messageText);
                Assert.IsNotEmpty(messageText);
				ex.Message.ShouldStartWith(messageText);
				return false;
			}
			catch (Exception ex)
			{
				// Assert
				Assert.Fail(ex.Message);
				return false;
			}
        }

		[TestCaseSource(typeof(GuardDoubleTestsSource), "IsGreaterThan")]
		public bool Guard_IsGreaterThan_Expr(double value, double min, string messageText)
		{
			try
			{
				// Act
				Guard.IsGreaterThan(() => value, min);

				return true;
			}
			catch (ArgumentOutOfRangeException ex)
			{
                Assert.IsNotNull(messageText);
                Assert.IsNotEmpty(messageText);
				ex.Message.ShouldStartWith(messageText);
				return false;
			}
			catch (Exception ex)
			{
				// Assert
				Assert.Fail(ex.Message);
				return false;
			}
		}

		[TestCaseSource(typeof(GuardDoubleTestsSource), "IsGreaterThan")]
		public bool Guard_IsGreaterThan_Value(double actualValue, double min, string messageText)
		{
			try
			{
				// Act
				double value = min;
				Guard.IsGreaterThan(() => value, actualValue, min);

				return true;
			}
			catch (ArgumentOutOfRangeException ex)
			{
                Assert.IsNotNull(messageText);
                Assert.IsNotEmpty(messageText);
				ex.Message.ShouldStartWith(messageText);
				return false;
			}
			catch (Exception ex)
			{
				// Assert
				Assert.Fail(ex.Message);
				return false;
			}
		}

		[TestCaseSource(typeof(GuardDoubleTestsSource), "IsGreaterThanOrEqualTo")]
		public bool Guard_IsGreaterThanOrEqualTo_Expr(double value, double min, string messageText)
		{
			try
			{
				// Act
				Guard.IsGreaterThanOrEqualTo(() => value, min);

				return true;
			}
			catch (ArgumentOutOfRangeException ex)
			{
                Assert.IsNotNull(messageText);
                Assert.IsNotEmpty(messageText);
				ex.Message.ShouldStartWith(messageText);
				return false;
			}
			catch (Exception ex)
			{
				// Assert
				Assert.Fail(ex.Message);
				return false;
			}
		}

		[TestCaseSource(typeof(GuardDoubleTestsSource), "IsGreaterThanOrEqualTo")]
		public bool Guard_IsGreaterThanOrEqualTo_Value(double actualValue, double min, string messageText)
		{
			try
			{
				// Act
				double value = min;
				Guard.IsGreaterThanOrEqualTo(() => value, actualValue, min);

				return true;
			}
			catch (ArgumentOutOfRangeException ex)
			{
                Assert.IsNotNull(messageText);
                Assert.IsNotEmpty(messageText);
				ex.Message.ShouldStartWith(messageText);
				return false;
			}
			catch (Exception ex)
			{
				// Assert
				Assert.Fail(ex.Message);
				return false;
			}
		}

		[TestCaseSource(typeof(GuardDoubleTestsSource), "IsLessThan")]
		public bool Guard_IsLessThan_Expr(double value, double max, string messageText)
		{
			try
			{
				// Act
				Guard.IsLessThan(() => value, max);

				return true;
			}
			catch (ArgumentOutOfRangeException ex)
			{
                Assert.IsNotNull(messageText);
                Assert.IsNotEmpty(messageText);
				ex.Message.ShouldStartWith(messageText);
				return false;
			}
			catch (Exception ex)
			{
				// Assert
				Assert.Fail(ex.Message);
				return false;
			}
		}

		[TestCaseSource(typeof(GuardDoubleTestsSource), "IsLessThan")]
		public bool Guard_IsLessThan_Value(double actualValue, double max, string messageText)
		{
			try
			{
				// Act
				double value = max;
				Guard.IsLessThan(() => value, actualValue, max);

				return true;
			}
			catch (ArgumentOutOfRangeException ex)
			{
                Assert.IsNotNull(messageText);
                Assert.IsNotEmpty(messageText);
				ex.Message.ShouldStartWith(messageText);
				return false;
			}
			catch (Exception ex)
			{
				// Assert
				Assert.Fail(ex.Message);
				return false;
			}
		}

		[TestCaseSource(typeof(GuardDoubleTestsSource), "IsLessThanOrEqualTo")]
		public bool Guard_IsLessThanOrEqualTo_Expr(double value, double max, string messageText)
		{
			try
			{
				// Act
				Guard.IsLessThanOrEqualTo(() => value, max);

				return true;
			}
			catch (ArgumentOutOfRangeException ex)
			{
                Assert.IsNotNull(messageText);
                Assert.IsNotEmpty(messageText);
				ex.Message.ShouldStartWith(messageText);
				return false;
			}
			catch (Exception ex)
			{
				// Assert
				Assert.Fail(ex.Message);
				return false;
			}
		}

		[TestCaseSource(typeof(GuardDoubleTestsSource), "IsLessThanOrEqualTo")]
		public bool Guard_IsLessThanOrEqualTo_Value(double actualValue, double max, string messageText)
		{
			try
			{
				// Act
				double value = max;
				Guard.IsLessThanOrEqualTo(() => value, actualValue, max);

				return true;
			}
			catch (ArgumentOutOfRangeException ex)
			{
                Assert.IsNotNull(messageText);
                Assert.IsNotEmpty(messageText);
				ex.Message.ShouldStartWith(messageText);
				return false;
			}
			catch (Exception ex)
			{
				// Assert
				Assert.Fail(ex.Message);
				return false;
			}
		}
    }
}
