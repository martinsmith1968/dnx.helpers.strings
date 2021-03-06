// Code generated by a Template
using System;
using DNX.Helpers.Maths;
using DNX.Helpers.Validation;
using NUnit.Framework;
using Shouldly;
using Test.DNX.Helpers.Validation.TestsDataSource;

namespace Test.DNX.Helpers.Validation
{
    [TestFixture]
    public class GuardInt16Tests
    {
        [TestCaseSource(typeof(GuardInt16TestsSource), "IsBetween_Default")]
        public bool Guard_IsBetween_Default(short value, short min, short max, string messageText)
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

        [TestCaseSource(typeof(GuardInt16TestsSource), "IsBetween_BoundsType")]
        public bool Guard_IsBetween_BoundsType(short value, short min, short max, IsBetweenBoundsType boundsType, string messageText)
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

        [TestCaseSource(typeof(GuardInt16TestsSource), "IsBetween")]
        public bool Guard_IsBetween(short value, short min, short max, bool allowEitherOrder, IsBetweenBoundsType boundsType, string messageText)
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

        [TestCaseSource(typeof(GuardInt16TestsSource), "IsGreaterThan")]
        public bool Guard_IsGreaterThan_Expr(short value, short min, string messageText)
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

        [TestCaseSource(typeof(GuardInt16TestsSource), "IsGreaterThan")]
        public bool Guard_IsGreaterThan_Value(short actualValue, short min, string messageText)
        {
            try
            {
                // Act
                short value = min;
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

        [TestCaseSource(typeof(GuardInt16TestsSource), "IsGreaterThanOrEqualTo")]
        public bool Guard_IsGreaterThanOrEqualTo_Expr(short value, short min, string messageText)
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

        [TestCaseSource(typeof(GuardInt16TestsSource), "IsGreaterThanOrEqualTo")]
        public bool Guard_IsGreaterThanOrEqualTo_Value(short actualValue, short min, string messageText)
        {
            try
            {
                // Act
                short value = min;
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

        [TestCaseSource(typeof(GuardInt16TestsSource), "IsLessThan")]
        public bool Guard_IsLessThan_Expr(short value, short max, string messageText)
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

        [TestCaseSource(typeof(GuardInt16TestsSource), "IsLessThan")]
        public bool Guard_IsLessThan_Value(short actualValue, short max, string messageText)
        {
            try
            {
                // Act
                short value = max;
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

        [TestCaseSource(typeof(GuardInt16TestsSource), "IsLessThanOrEqualTo")]
        public bool Guard_IsLessThanOrEqualTo_Expr(short value, short max, string messageText)
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

        [TestCaseSource(typeof(GuardInt16TestsSource), "IsLessThanOrEqualTo")]
        public bool Guard_IsLessThanOrEqualTo_Value(short actualValue, short max, string messageText)
        {
            try
            {
                // Act
                short value = max;
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
