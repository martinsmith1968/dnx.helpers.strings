﻿using System;
using System.IO;
using System.Linq;
using System.Text;
using Bogus;
using DNX.Helpers.Streams;
using NUnit.Framework;
using Shouldly;

namespace Test.DNX.Helpers.Streams
{
    [TestFixture]
    public class StreamExtensionsTests
    {
        private Faker _faker;

        [SetUp]
        public void TestSetup()
        {
            _faker = new Faker();
        }

        [Test]
        public void ReadAllText_should_read_text_successfully()
        {
            // Arrange
            var text = _faker.Lorem.Sentences(_faker.Random.Int(5, 10));
            var bytes = Encoding.UTF8.GetBytes(text);

            var stream = new MemoryStream(bytes);

            // Act
            var result = stream.ReadAllText();
            stream.Dispose();

            // Assert
            result.ShouldNotBeNull();
            result.ShouldNotBeEmpty();
            result.ShouldBe(text);
        }

        [Test]
        public void ReadAllText_handles_null_streams_appropriately()
        {
            // Arrange
            var stream = (MemoryStream)null;

            // Act
            var result = stream.ReadAllText();

            // Assert
            result.ShouldBeNull();
        }

        [Test]
        public void ReadAllLines_should_read_lines_successfully()
        {
            // Arrange
            var textLines = Enumerable.Range(5, 10)
                .Select(f => _faker.Lorem.Slug(_faker.Random.Int(5, 10)))
                .ToList();
            var bytes = Encoding.UTF8.GetBytes(string.Join(Environment.NewLine, textLines));

            var stream = new MemoryStream(bytes);

            // Act
            var result = stream.ReadAllLines();
            stream.Dispose();

            // Assert
            result.ShouldNotBeNull();
            result.Count.ShouldBeGreaterThan(0);
            result.Count.ShouldBe(textLines.Count);
            result.ShouldBe(textLines);
        }

        [Test]
        public void ReadAllLines_handles_null_streams_appropriately()
        {
            // Arrange
            var stream = (MemoryStream)null;

            // Act
            var result = stream.ReadAllLines();

            // Assert
            result.ShouldBeNull();
        }

        [Test]
        public void ReadAllBytes_should_read_bytes_successfully()
        {
            // Arrange
            var text = _faker.Lorem.Sentences(_faker.Random.Int(5, 10));
            var bytes = Encoding.UTF8.GetBytes(text);

            var stream = new MemoryStream(bytes);

            // Act
            var result = stream.ReadAllBytes();
            stream.Dispose();

            // Assert
            result.ShouldNotBeNull();
            result.Length.ShouldBeGreaterThan(0);
            result.ShouldBe(bytes);
        }

        [Test]
        public void ReadAllBytes_handles_null_streams_appropriately()
        {
            // Arrange
            var stream = (MemoryStream)null;

            // Act
            var result = stream.ReadAllBytes();

            // Assert
            result.ShouldBeNull();
        }
    }
}
