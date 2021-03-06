// <copyright file="FizzBuzzTest.cs">Copyright ©  2017</copyright>
using System;
using FizzBuzzApp;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzApp.Tests
{
    /// <summary>このクラスには、FizzBuzz に対するパラメーター化された単体テストが含まれています</summary>
    [PexClass(typeof(FizzBuzz))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FizzBuzzTest
    {
        /// <summary>Say(Int32) のテスト スタブ </summary>
        [PexMethod(MaxRunsWithoutNewTests = 200)]
        public string SayTest(int i)
        {
            string result = FizzBuzz.Say(i);
            
            if (i % 3 == 0 && i % 5 == 0) Assert.AreEqual("Fizz Buzz", result);
            else if (i % 3 == 0) Assert.AreEqual("Fizz", result);
            else if (i % 5 == 0) Assert.AreEqual("Buzz", result);
            else Assert.AreEqual($"{i}", result);

            return result;
        }
    }
}
