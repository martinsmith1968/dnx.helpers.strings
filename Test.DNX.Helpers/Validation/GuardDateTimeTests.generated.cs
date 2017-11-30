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
    public class GuardDateTimeTests
    {
		[TestCaseSource(typeof(GuardDateTimeTestsSource), "IsBetween_Default")]
		public bool Guard_IsBetween_Default(DateTime value, DateTime min, DateTime max, string messageText)
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

        [TestCaseSource(typeof(GuardDateTimeTestsSource), "IsBetween_BoundsType")]
        public bool Guard_IsBetween_BoundsType(DateTime value, DateTime min, DateTime max, IsBetweenBoundsType boundsType, string messageText)
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

        [TestCaseSource(typeof(GuardDateTimeTestsSource), "IsBetween")]
        public bool Guard_IsBetween(DateTime value, DateTime min, DateTime max, bool allowEitherOrder, IsBetweenBoundsType boundsType, string messageText)
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

		[TestCaseSource(typeof(GuardDateTimeTestsSource), "IsGreaterThan")]
		public bool Guard_IsGreaterThan_Expr(DateTime value, DateTime min, string messageText)
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

		[TestCaseSource(typeof(GuardDateTimeTestsSource), "IsGreaterThan")]
		public bool Guard_IsGreaterThan_Value(DateTime actualValue, DateTime min, string messageText)
		{
			try
			{
				// Act
				DateTime value = min;
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

		[TestCaseSource(typeof(GuardDateTimeTestsSource), "IsGreaterThanOrEqualTo")]
		public bool Guard_IsGreaterThanOrEqualTo_Expr(DateTime value, DateTime min, string messageText)
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

		[TestCaseSource(typeof(GuardDateTimeTestsSource), "IsGreaterThanOrEqualTo")]
		public bool Guard_IsGreaterThanOrEqualTo_Value(DateTime actualValue, DateTime min, string messageText)
		{
			try
			{
				// Act
				DateTime value = min;
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

		[TestCaseSource(typeof(GuardDateTimeTestsSource), "IsLessThan")]
		public bool Guard_IsLessThan_Expr(DateTime value, DateTime max, string messageText)
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

		[TestCaseSource(typeof(GuardDateTimeTestsSource), "IsLessThan")]
		public bool Guard_IsLessThan_Value(DateTime actualValue, DateTime max, string messageText)
		{
			try
			{
				// Act
				DateTime value = max;
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

		[TestCaseSource(typeof(GuardDateTimeTestsSource), "IsLessThanOrEqualTo")]
		public bool Guard_IsLessThanOrEqualTo_Expr(DateTime value, DateTime max, string messageText)
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

		[TestCaseSource(typeof(GuardDateTimeTestsSource), "IsLessThanOrEqualTo")]
		public bool Guard_IsLessThanOrEqualTo_Value(DateTime actualValue, DateTime max, string messageText)
		{
			try
			{
				// Act
				DateTime value = max;
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
