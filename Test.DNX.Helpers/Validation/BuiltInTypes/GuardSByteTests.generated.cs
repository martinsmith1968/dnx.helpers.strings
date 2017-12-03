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
    public class GuardSByteTests
    {
        [TestCaseSource(typeof(GuardSByteTestsSource), "IsBetween_Default")]
        public bool Guard_IsBetween_Default(sbyte value, sbyte min, sbyte max, string messageText)
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

        [TestCaseSource(typeof(GuardSByteTestsSource), "IsBetween_BoundsType")]
        public bool Guard_IsBetween_BoundsType(sbyte value, sbyte min, sbyte max, IsBetweenBoundsType boundsType, string messageText)
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

        [TestCaseSource(typeof(GuardSByteTestsSource), "IsBetween")]
        public bool Guard_IsBetween(sbyte value, sbyte min, sbyte max, bool allowEitherOrder, IsBetweenBoundsType boundsType, string messageText)
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

        [TestCaseSource(typeof(GuardSByteTestsSource), "IsGreaterThan")]
        public bool Guard_IsGreaterThan_Expr(sbyte value, sbyte min, string messageText)
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

        [TestCaseSource(typeof(GuardSByteTestsSource), "IsGreaterThan")]
        public bool Guard_IsGreaterThan_Value(sbyte actualValue, sbyte min, string messageText)
        {
            try
            {
                // Act
                sbyte value = min;
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

        [TestCaseSource(typeof(GuardSByteTestsSource), "IsGreaterThanOrEqualTo")]
        public bool Guard_IsGreaterThanOrEqualTo_Expr(sbyte value, sbyte min, string messageText)
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

        [TestCaseSource(typeof(GuardSByteTestsSource), "IsGreaterThanOrEqualTo")]
        public bool Guard_IsGreaterThanOrEqualTo_Value(sbyte actualValue, sbyte min, string messageText)
        {
            try
            {
                // Act
                sbyte value = min;
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

        [TestCaseSource(typeof(GuardSByteTestsSource), "IsLessThan")]
        public bool Guard_IsLessThan_Expr(sbyte value, sbyte max, string messageText)
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

        [TestCaseSource(typeof(GuardSByteTestsSource), "IsLessThan")]
        public bool Guard_IsLessThan_Value(sbyte actualValue, sbyte max, string messageText)
        {
            try
            {
                // Act
                sbyte value = max;
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

        [TestCaseSource(typeof(GuardSByteTestsSource), "IsLessThanOrEqualTo")]
        public bool Guard_IsLessThanOrEqualTo_Expr(sbyte value, sbyte max, string messageText)
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

        [TestCaseSource(typeof(GuardSByteTestsSource), "IsLessThanOrEqualTo")]
        public bool Guard_IsLessThanOrEqualTo_Value(sbyte actualValue, sbyte max, string messageText)
        {
            try
            {
                // Act
                sbyte value = max;
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
