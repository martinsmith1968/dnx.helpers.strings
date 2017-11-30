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
    public class GuardByteTests
    {
		[TestCaseSource(typeof(GuardByteTestsSource), "IsBetween_Default")]
		public bool Guard_IsBetween_Default(byte value, byte min, byte max, string messageText)
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

        [TestCaseSource(typeof(GuardByteTestsSource), "IsBetween_BoundsType")]
        public bool Guard_IsBetween_BoundsType(byte value, byte min, byte max, IsBetweenBoundsType boundsType, string messageText)
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

        [TestCaseSource(typeof(GuardByteTestsSource), "IsBetween")]
        public bool Guard_IsBetween(byte value, byte min, byte max, bool allowEitherOrder, IsBetweenBoundsType boundsType, string messageText)
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

		[TestCaseSource(typeof(GuardByteTestsSource), "IsGreaterThan")]
		public bool Guard_IsGreaterThan_Expr(byte value, byte min, string messageText)
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

		[TestCaseSource(typeof(GuardByteTestsSource), "IsGreaterThan")]
		public bool Guard_IsGreaterThan_Value(byte actualValue, byte min, string messageText)
		{
			try
			{
				// Act
				byte value = min;
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

		[TestCaseSource(typeof(GuardByteTestsSource), "IsGreaterThanOrEqualTo")]
		public bool Guard_IsGreaterThanOrEqualTo_Expr(byte value, byte min, string messageText)
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

		[TestCaseSource(typeof(GuardByteTestsSource), "IsGreaterThanOrEqualTo")]
		public bool Guard_IsGreaterThanOrEqualTo_Value(byte actualValue, byte min, string messageText)
		{
			try
			{
				// Act
				byte value = min;
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

		[TestCaseSource(typeof(GuardByteTestsSource), "IsLessThan")]
		public bool Guard_IsLessThan_Expr(byte value, byte max, string messageText)
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

		[TestCaseSource(typeof(GuardByteTestsSource), "IsLessThan")]
		public bool Guard_IsLessThan_Value(byte actualValue, byte max, string messageText)
		{
			try
			{
				// Act
				byte value = max;
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

		[TestCaseSource(typeof(GuardByteTestsSource), "IsLessThanOrEqualTo")]
		public bool Guard_IsLessThanOrEqualTo_Expr(byte value, byte max, string messageText)
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

		[TestCaseSource(typeof(GuardByteTestsSource), "IsLessThanOrEqualTo")]
		public bool Guard_IsLessThanOrEqualTo_Value(byte actualValue, byte max, string messageText)
		{
			try
			{
				// Act
				byte value = max;
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
