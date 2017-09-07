﻿using System;
using System.Collections.Generic;
using System.Globalization;
using DNX.Helpers.Strings;
using NUnit.Framework;

namespace Test.DNX.Helpers.Strings
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [TestCase(null, "hello", ExpectedResult = "hello")]
        [TestCase("", "", ExpectedResult = "")]
        [TestCase("hello", null, ExpectedResult = "hello")]
        [TestCase("hello", "h", ExpectedResult = "hello")]
        [TestCase("hello", "he", ExpectedResult = "hello")]
        [TestCase("hello", "hel", ExpectedResult = "hello")]
        [TestCase("hello", "hell", ExpectedResult = "hello")]
        [TestCase("hello", "hello", ExpectedResult = "hello")]
        [TestCase("hello", " ", ExpectedResult = " hello")]
        [TestCase(" hello", " ", ExpectedResult = " hello")]
        [TestCase(" hello", "  ", ExpectedResult = "   hello")]
        public string Test_EnsureStartsWith(string text, string prefix)
        {
            var result = text.EnsureStartsWith(prefix);

            return result;
        }

        [TestCase(null, "hello", ExpectedResult = "hello")]
        [TestCase("", "", ExpectedResult = "")]
        [TestCase("hello", null, ExpectedResult = "hello")]
        [TestCase("hello", "o", ExpectedResult = "hello")]
        [TestCase("hello", "lo", ExpectedResult = "hello")]
        [TestCase("hello", "llo", ExpectedResult = "hello")]
        [TestCase("hello", "ello", ExpectedResult = "hello")]
        [TestCase("hello", "hello", ExpectedResult = "hello")]
        [TestCase("hello", " ", ExpectedResult = "hello ")]
        [TestCase("hello ", " ", ExpectedResult = "hello ")]
        [TestCase("hello ", "  ", ExpectedResult = "hello   ")]
        public string Test_EnsureEndsWith(string text, string suffix)
        {
            var result = text.EnsureEndsWith(suffix);

            return result;
        }

        [TestCase("hello", "#", ExpectedResult = "#hello#")]
        [TestCase("hello", "", ExpectedResult = "hello")]
        [TestCase("hello", null, ExpectedResult = "hello")]
        [TestCase("hello", "_", ExpectedResult = "_hello_")]
        [TestCase("", "_", ExpectedResult = "_")]
        public string Test_EnsureStartsAndEndsWith(string text, string prefixsuffix)
        {
            var result = text.EnsureStartsAndEndsWith(prefixsuffix);

            return result;
        }

        [TestCase("hello", "[", "]", ExpectedResult = "[hello]")]
        [TestCase("hello", "", ":", ExpectedResult = "hello:")]
        [TestCase("hello", null, ":", ExpectedResult = "hello:")]
        [TestCase("hello", ":", "", ExpectedResult = ":hello")]
        [TestCase("hello", ":", null, ExpectedResult = ":hello")]
        [TestCase("", "[", "]", ExpectedResult = "[]")]
        public string Test_EnsureStartsAndEndsWith_prefix_and_suffix(string text, string prefix, string suffix)
        {
            var result = text.EnsureStartsAndEndsWith(prefix, suffix);

            return result;
        }

        [TestCase(null, "hello", ExpectedResult = null)]
        [TestCase("", "hello", ExpectedResult = "")]
        [TestCase("hello", "", ExpectedResult = "hello")]
        [TestCase("hello", null, ExpectedResult = "hello")]
        [TestCase("hello", "h", ExpectedResult = "ello")]
        [TestCase("00099", "0", ExpectedResult = "99")]
        public string Test_RemoveStartsWith(string text, string prefix)
        {
            var result = text.RemoveStartsWith(prefix);

            return result;
        }

        [TestCase(null, "hello", ExpectedResult = null)]
        [TestCase("", "hello", ExpectedResult = "")]
        [TestCase("hello", "", ExpectedResult = "hello")]
        [TestCase("hello", null, ExpectedResult = "hello")]
        [TestCase("hello", "o", ExpectedResult = "hell")]
        [TestCase("00099", "9", ExpectedResult = "000")]
        [TestCase("123232323", "23", ExpectedResult = "1")]
        public string Test_RemoveEndsWith(string text, string suffix)
        {
            var result = text.RemoveEndsWith(suffix);

            return result;
        }

        [TestCase("hello", null, ExpectedResult = "hello")]
        [TestCase("hello", "", ExpectedResult = "hello")]
        [TestCase("", "h", ExpectedResult = "")]
        [TestCase(null, "h", ExpectedResult = null)]
        [TestCase("hello", "h", ExpectedResult = "ello")]
        [TestCase("hello", "o", ExpectedResult = "hell")]
        [TestCase("bob", "b", ExpectedResult = "o")]
        public string Test_RemoveStartsAndEndsWith(string text, string prefixsuffix)
        {
            var result = text.RemoveStartsAndEndsWith(prefixsuffix);

            return result;
        }

        [TestCase("hello", null, null, ExpectedResult = "hello")]
        [TestCase("hello", "", "", ExpectedResult = "hello")]
        [TestCase("", "h", "e", ExpectedResult = "")]
        [TestCase(null, "h", "e", ExpectedResult = null)]
        [TestCase("hello", "h", "o", ExpectedResult = "ell")]
        [TestCase("hello", "o", "h", ExpectedResult = "hello")]
        [TestCase("bob", "b", "b", ExpectedResult = "o")]
        public string Test_RemoveStartsAndEndsWith_prefix_and_suffix(string text, string prefix, string suffix)
        {
            var result = text.RemoveStartsAndEndsWith(prefix, suffix);

            return result;
        }

        [TestCase("bob", "b", StringComparison.CurrentCultureIgnoreCase, ExpectedResult = true)]
        [TestCase("BOB", "o", StringComparison.CurrentCultureIgnoreCase, ExpectedResult = true)]
        [TestCase("bob", "b", StringComparison.CurrentCulture, ExpectedResult = true)]
        [TestCase("BOB", "o", StringComparison.CurrentCulture, ExpectedResult = false)]
        [TestCase("BOB", "", StringComparison.CurrentCulture, ExpectedResult = true)]
        [TestCase("BOB", null, StringComparison.CurrentCulture, ExpectedResult = true)]
        [TestCase("", "b", StringComparison.CurrentCulture, ExpectedResult = false)]
        [TestCase(null, "o", StringComparison.CurrentCulture, ExpectedResult = false)]
        public bool Test_ContainsText(string text, string searchText, StringComparison comparison)
        {
            var result = text.ContainsText(searchText, comparison);

            return result;
        }

        [TestCase("hello", "helo", ExpectedResult = true)]
        [TestCase("1234.56", "1234567890.", ExpectedResult = true)]
        [TestCase("1,234.56", "1234567890.", ExpectedResult = false)]
        [TestCase("1,234.56", "", ExpectedResult = false)]
        [TestCase("1,234.56", null, ExpectedResult = false)]
        public bool Test_ContainsOnly(string text, string characters)
        {
            var result = text.ContainsOnly(characters);

            return result;
        }

        [TestCase("1234.56", new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.' }, ExpectedResult = true)]
        [TestCase("1,234.56", new [] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.' }, ExpectedResult = false)]
        [TestCase("1,234.56", new char[] {}, ExpectedResult = false)]
        [TestCase("1,234.56", null, ExpectedResult = false)]
        [TestCase(null, new[] { 'a', 'e', 'i', 'o', 'u' }, ExpectedResult = false)]
        public bool Test_ContainsOnlyCharacterArray(string text, IList<char> characters)
        {
            var result = text.ContainsOnly(characters);

            return result;
        }

        [TestCase("obviously this piece of text contains at least one of every vowel", "aeiou", ExpectedResult = "bvsly ths pc f txt cntns t lst n f vry vwl")]
        [TestCase("123,456,789.00", ",.", ExpectedResult = "12345678900")]
        public string Test_RemoveAny(string text, string charsToRemove)
        {
            var result = text.RemoveAny(charsToRemove);

            return result;
        }

        [TestCase("", new [] { 'a', 'e', 'i', 'o', 'u' }, ExpectedResult = "")]
        [TestCase(null, new[] { 'a', 'e', 'i', 'o', 'u' }, ExpectedResult = null)]
        [TestCase("aeiou", new char[] { }, ExpectedResult = "aeiou")]
        [TestCase("aeiou", null, ExpectedResult = "aeiou")]
        [TestCase("obviously this piece of text contains at least one of every vowel", new[] { 'a', 'e', 'i', 'o', 'u' }, ExpectedResult = "bvsly ths pc f txt cntns t lst n f vry vwl")]
        [TestCase("123,456,789.00", new [] { ',', '.' }, ExpectedResult = "12345678900")]
        public string Test_RemoveAny_char_array(string text, char[] charsToRemove)
        {
            var result = text.RemoveAny(charsToRemove);

            return result;
        }

        [TestCase("", "1234567890.", ExpectedResult = "")]
        [TestCase(null, "1234567890.", ExpectedResult = null)]
        [TestCase("hello", "", ExpectedResult = "")]
        [TestCase("hello", null, ExpectedResult = "")]
        [TestCase("The amount to pay is: 123,456.00", "1234567890.", ExpectedResult = "123456.00")]
        public string Test_RemoveAnyExcept(string text, string charsToKeep)
        {
            var result = text.RemoveAnyExcept(charsToKeep);

            return result;
        }

        // GB
        [TestCase("0", "en-gb", ExpectedResult = true)]
        [TestCase("1", "en-gb", ExpectedResult = true)]
        [TestCase("-1", "en-gb", ExpectedResult = true)]
        [TestCase("+1", "en-gb", ExpectedResult = true)]
        [TestCase("123.72", "en-gb", ExpectedResult = true)]
        [TestCase("-123.72", "en-gb", ExpectedResult = true)]
        [TestCase("+123.72", "en-gb", ExpectedResult = true)]
        [TestCase("3,123.451", "en-gb", ExpectedResult = true)]
        [TestCase("-3,123.451", "en-gb", ExpectedResult = true)]
        [TestCase("+3,123.451", "en-gb", ExpectedResult = true)]
        [TestCase("3412123.76543", "en-gb", ExpectedResult = true)]
        [TestCase("-3412123.76543", "en-gb", ExpectedResult = true)]
        [TestCase("+3412123.76543", "en-gb", ExpectedResult = true)]
        [TestCase("7,034.989", "en-gb", ExpectedResult = true)]
        [TestCase("-7,034.989", "en-gb", ExpectedResult = true)]
        [TestCase("+7,034.989", "en-gb", ExpectedResult = true)]
        // DE
        [TestCase("3,123.451", "de-DE", ExpectedResult = false)]
        [TestCase("3.123,451", "de-DE", ExpectedResult = true)]
        public bool Test_IsValidNumber(string text, string cultureInfoName)
        {
            var cultureInfo = CultureInfo.GetCultureInfo(cultureInfoName);

            var result = text.IsValidNumber(cultureInfo);

            return result;
        }

        [TestCase("hello world", ExpectedResult = "dlrow olleh")]
        [TestCase("12345", ExpectedResult = "54321")]
        [TestCase("abcba", ExpectedResult = "abcba")]
        [TestCase("", ExpectedResult = "")]
        [TestCase(null, ExpectedResult = null)]
        public string Test_Reverse(string text)
        {
            var result = text.Reverse();

            return result;
        }

        [TestCase("a-b-c-d-e", "-", StringSplitOptions.None, ExpectedResult = "a,b,c,d,e")]
        [TestCase("a-b[c]d=e", "-[]=", StringSplitOptions.None, ExpectedResult = "a,b,c,d,e")]
        [TestCase("a-b--d-e", "-", StringSplitOptions.RemoveEmptyEntries, ExpectedResult = "a,b,d,e")]
        [TestCase("a-b[]d=e", "-[]=", StringSplitOptions.RemoveEmptyEntries, ExpectedResult = "a,b,d,e")]
        public string Test_Split(string text, string delimiters, StringSplitOptions options)
        {
            var result = text.Split(delimiters, options);

            return string.Join(",", result);
        }

        [TestCase("a", "b", "c", ExpectedResult = "a")]
        [TestCase("a", null, null, ExpectedResult = "a")]
        [TestCase(null, "b", "c", ExpectedResult = "b")]
        [TestCase(null, null, "c", ExpectedResult = "c")]
        [TestCase(null, null, null, ExpectedResult = null)]
        [TestCase("a", "b", "c", ExpectedResult = "a")]
        [TestCase("a", "", "", ExpectedResult = "a")]
        [TestCase("", "b", "c", ExpectedResult = "b")]
        [TestCase("", "", "c", ExpectedResult = "c")]
        [TestCase("", "", "", ExpectedResult = null)]

        public string Test_CoalesceNullOrEmpty(string a, string b, string c)
        {
            var result = StringExtensions.CoalesceNullOrEmpty(a, b, c);

            return result;
        }

        [TestCase("a", "b", "c", ExpectedResult = "a")]
        [TestCase(" ", "b", "c", ExpectedResult = "b")]
        [TestCase("  ", "   ", "c", ExpectedResult = "c")]
        [TestCase(" ", "  ", null, ExpectedResult = null)]

        public string Test_CoalesceNullOrWhitespace(string a, string b, string c)
        {
            var result = StringExtensions.CoalesceNullOrWhitespace(a, b, c);

            return result;
        }
    }
}