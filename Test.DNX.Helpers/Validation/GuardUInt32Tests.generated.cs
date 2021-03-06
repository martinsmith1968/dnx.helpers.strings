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
    public class GuardUInt32Tests
    {
        [TestCaseSource(typeof(GuardUInt32TestsSource), "IsBetween_Default")]
        public bool Guard_IsBetween_Default(uint value, uint min, uint max, string messageText)
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

        [TestCaseSource(typeof(GuardUInt32TestsSource), "IsBetween_BoundsType")]
        public bool Guard_IsBetween_BoundsType(uint value, uint min, uint max, IsBetweenBoundsType boundsType, string messageText)
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

        [TestCaseSource(typeof(GuardUInt32TestsSource), "IsBetween")]
        public bool Guard_IsBetween(uint value, uint min, uint max, bool allowEitherOrder, IsBetweenBoundsType boundsType, string messageText)
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

        [TestCaseSource(typeof(GuardUInt32TestsSource), "IsGreaterThan")]
        public bool Guard_IsGreaterThan_Expr(uint value, uint min, string messageText)
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

        [TestCaseSource(typeof(GuardUInt32TestsSource), "IsGreaterThan")]
        public bool Guard_IsGreaterThan_Value(uint actualValue, uint min, string messageText)
        {
            try
            {
                // Act
                uint value = min;
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

        [TestCaseSource(typeof(GuardUInt32TestsSource), "IsGreaterThanOrEqualTo")]
        public bool Guard_IsGreaterThanOrEqualTo_Expr(uint value, uint min, string messageText)
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

        [TestCaseSource(typeof(GuardUInt32TestsSource), "IsGreaterThanOrEqualTo")]
        public bool Guard_IsGreaterThanOrEqualTo_Value(uint actualValue, uint min, string messageText)
        {
            try
            {
                // Act
                uint value = min;
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

        [TestCaseSource(typeof(GuardUInt32TestsSource), "IsLessThan")]
        public bool Guard_IsLessThan_Expr(uint value, uint max, string messageText)
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

        [TestCaseSource(typeof(GuardUInt32TestsSource), "IsLessThan")]
        public bool Guard_IsLessThan_Value(uint actualValue, uint max, string messageText)
        {
            try
            {
                // Act
                uint value = max;
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

        [TestCaseSource(typeof(GuardUInt32TestsSource), "IsLessThanOrEqualTo")]
        public bool Guard_IsLessThanOrEqualTo_Expr(uint value, uint max, string messageText)
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

        [TestCaseSource(typeof(GuardUInt32TestsSource), "IsLessThanOrEqualTo")]
        public bool Guard_IsLessThanOrEqualTo_Value(uint actualValue, uint max, string messageText)
        {
            try
            {
                // Act
                uint value = max;
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
