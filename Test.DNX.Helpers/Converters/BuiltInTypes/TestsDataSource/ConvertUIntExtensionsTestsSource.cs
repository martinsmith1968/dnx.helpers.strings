﻿using System.Collections.Generic;
using NUnit.Framework;

namespace Test.DNX.Helpers.Converters.BuiltInTypes.TestsDataSource
{
    public class ConvertUIntExtensionsTestsSource
    {
        public static IEnumerable<TestCaseData> IsUInt
        {
            get
            {
                yield return new TestCaseData("0").Returns(true);
                yield return new TestCaseData("1").Returns(true);
                yield return new TestCaseData("-1").Returns(false);
                yield return new TestCaseData("100").Returns(true);
                yield return new TestCaseData("200").Returns(true);
                yield return new TestCaseData("-100").Returns(false);
                yield return new TestCaseData("-200").Returns(false);
                yield return new TestCaseData(" 100").Returns(true);
                yield return new TestCaseData("100 ").Returns(true);
                yield return new TestCaseData("1.5").Returns(false);
                yield return new TestCaseData("£100").Returns(false);
            }
        }

        public static IEnumerable<TestCaseData> ToUInt
        {
            get
            {
                yield return new TestCaseData(uint.MinValue.ToString()).Returns(uint.MinValue);
                yield return new TestCaseData(uint.MaxValue.ToString()).Returns(uint.MaxValue);
                yield return new TestCaseData("0").Returns(0);
                yield return new TestCaseData("100").Returns(100);
                yield return new TestCaseData("10").Returns(10);
                yield return new TestCaseData("10 ").Returns(10);
            }
        }

        public static IEnumerable<TestCaseData> ToUIntThrows
        {
            get
            {
                yield return new TestCaseData("abcdef").Returns(false);
                yield return new TestCaseData("50.5").Returns(false);
                yield return new TestCaseData("-10").Returns(false);
                yield return new TestCaseData("100,000").Returns(false);
                yield return new TestCaseData(double.MaxValue.ToString("0.0")).Returns(false);
                yield return new TestCaseData("100").Returns(true);
            }
        }

        public static IEnumerable<TestCaseData> ToUIntWithDefault
        {
            get
            {
                yield return new TestCaseData("abcdef", (uint)25).Returns(25);
                yield return new TestCaseData("50.5", (uint)25).Returns(25);
                yield return new TestCaseData("100,000", (uint)100).Returns(100);
                yield return new TestCaseData("100", (uint)25).Returns(100);
            }
        }
    }
}
