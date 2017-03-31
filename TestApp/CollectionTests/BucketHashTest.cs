﻿using ADLibrary.Hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Tests
{
    class BucketHashTest<TKey, TValue> : ITestable
    {
        protected KeyValuePair<TKey, TValue>[] testData;

        public string name
        {
            get
            {
                return "Bucket Hash";
            }
        }

        public virtual void setTestData(KeyValuePair<TKey, TValue>[] testData)
        {
            this.testData = testData;
        }

        public bool runTest()
        {
            var hash = new BucketHash<TKey, TValue>(testData.Length);

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
                if(!result.Equals(data.Value))
                {
                    return false;
                }
                hash.remove(data.Key);
            }

            // Ensure all items have been removed
            if(hash.count() > 0)
            {
                Console.WriteLine(hash.count());
                return false;
            }

            return true;
        }
    }
}
