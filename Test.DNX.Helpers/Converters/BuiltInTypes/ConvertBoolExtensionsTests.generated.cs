// Code generated by a Template
using System;
using DNX.Helpers.Converters.BuiltInTypes;
using DNX.Helpers.Exceptions;
using NUnit.Framework;
using Test.DNX.Helpers.Converters.BuiltInTypes.TestsDataSource;

namespace Test.DNX.Helpers.Converters.BuiltInTypes
{
    [TestFixture]
    public class ConvertBoolExtensionsTests
    {
        [TestCaseSource(typeof(ConvertBoolExtensionsTestsSource), "IsBool")]
        public bool Test_IsBool(string text)
        {
            var result = text.IsBool();

            return result;
        }

        [TestCaseSource(typeof(ConvertBoolExtensionsTestsSource), "ToBool")]
        public bool Test_ToBool(string text)
        {
            var result = text.ToBool();

            return result;
        }

        [TestCaseSource(typeof(ConvertBoolExtensionsTestsSource), "ToBoolThrows")]
        public bool Test_ToBool_Throws(string text)
        {
            try
            {
                text.ToBool();
            }
            catch (ConversionException ex)
            {
                Assert.AreEqual(text, ex.Value);

                return false;
            }

            return true;
        }

        [TestCaseSource(typeof(ConvertBoolExtensionsTestsSource), "ToBoolWithDefault")]
        public bool Test_ToBool_with_default(string text, bool defaultValue)
        {
            var result = text.ToBool(defaultValue);

            return result;
        }
    }
}