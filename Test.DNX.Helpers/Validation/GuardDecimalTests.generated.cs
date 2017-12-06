// Code generated by a Template
using System;
using DNX.Helpers.Maths;
using DNX.Helpers.Validation;
using NUnit.Framework;
using Should;
using Test.DNX.Helpers.Validation.TestsDataSource;

namespace Test.DNX.Helpers.Validation
{
    [TestFixture]
    public class GuardDecimalTests
    {
        [TestCaseSource(typeof(GuardDecimalTestsSource), "IsBetween_Default")]
        public bool Guard_IsBetween_Default(decimal value, decimal min, decimal max, string messageText)
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

        [TestCaseSource(typeof(GuardDecimalTestsSource), "IsBetween_BoundsType")]
        public bool Guard_IsBetween_BoundsType(decimal value, decimal min, decimal max, IsBetweenBoundsType boundsType, string messageText)
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

        [TestCaseSource(typeof(GuardDecimalTestsSource), "IsBetween")]
        public bool Guard_IsBetween(decimal value, decimal min, decimal max, bool allowEitherOrder, IsBetweenBoundsType boundsType, string messageText)
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

        [TestCaseSource(typeof(GuardDecimalTestsSource), "IsGreaterThan")]
        public bool Guard_IsGreaterThan_Expr(decimal value, decimal min, string messageText)
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

        [TestCaseSource(typeof(GuardDecimalTestsSource), "IsGreaterThan")]
        public bool Guard_IsGreaterThan_Value(decimal actualValue, decimal min, string messageText)
        {
            try
            {
                // Act
                decimal value = min;
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

        [TestCaseSource(typeof(GuardDecimalTestsSource), "IsGreaterThanOrEqualTo")]
        public bool Guard_IsGreaterThanOrEqualTo_Expr(decimal value, decimal min, string messageText)
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

        [TestCaseSource(typeof(GuardDecimalTestsSource), "IsGreaterThanOrEqualTo")]
        public bool Guard_IsGreaterThanOrEqualTo_Value(decimal actualValue, decimal min, string messageText)
        {
            try
            {
                // Act
                decimal value = min;
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

        [TestCaseSource(typeof(GuardDecimalTestsSource), "IsLessThan")]
        public bool Guard_IsLessThan_Expr(decimal value, decimal max, string messageText)
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

        [TestCaseSource(typeof(GuardDecimalTestsSource), "IsLessThan")]
        public bool Guard_IsLessThan_Value(decimal actualValue, decimal max, string messageText)
        {
            try
            {
                // Act
                decimal value = max;
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

        [TestCaseSource(typeof(GuardDecimalTestsSource), "IsLessThanOrEqualTo")]
        public bool Guard_IsLessThanOrEqualTo_Expr(decimal value, decimal max, string messageText)
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

        [TestCaseSource(typeof(GuardDecimalTestsSource), "IsLessThanOrEqualTo")]
        public bool Guard_IsLessThanOrEqualTo_Value(decimal actualValue, decimal max, string messageText)
        {
            try
            {
                // Act
                decimal value = max;
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