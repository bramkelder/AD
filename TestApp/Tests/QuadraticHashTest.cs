﻿using ADLibrary.Hashing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Tests
{
    /// <summary>
    /// Tests for QuadraticHash collection.
    /// </summary>
    /// <typeparam name="TKey">Key type</typeparam>
    /// <typeparam name="TValue">Value type</typeparam>
    class QuadraticHashTest<TKey, TValue> : HashTestBase<TKey, TValue>
    {
        public override string name
        {
            get
            {
                return "Quadratic Hash";
            }
        }

        public override void runTest()
        {
            var hash = new QuadraticHash<TKey, TValue>(testData.Length * 2);

            // Arrange data in dictionary so we can compare results easily
            var dictionary = new Dictionary<TKey, TValue>();
            foreach(var data in testData)
            {
                dictionary[data.Key] = data.Value;
            }

            // Setting
            foreach(var data in dictionary)
            {
                hash.set(data.Key, data.Value);
            }

            // Getting and removing
            foreach(var data in dictionary)
            {
                var result = hash.get(data.Key);
                Assert.AreEqual(data.Value, result);
                result = hash.remove(data.Key);
                Assert.AreEqual(data.Value, result);
            }

            // Ensure all items have been removed
            Assert.AreEqual(0, hash.count());
        }
    }
}
