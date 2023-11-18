using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperSample.Syncing
{
    public class SyncDebug
    {
        public List<string> InitializeList(IEnumerable<string> items)
        {
            var bag = new ConcurrentBag<string>();
            foreach (var item in items)
            {
                bag.Add(item);
            }
            return bag.ToList();
        }

        public Dictionary<int, string> InitializeDictionary(Func<int, string> getItem)
        {
            var concurrentDictionary = new ConcurrentDictionary<int, string>();

            Parallel.ForEach(Enumerable.Range(0, 100), (item) =>
            {
                concurrentDictionary.GetOrAdd(item, getItem);
            });

            return concurrentDictionary.ToDictionary(kv => kv.Key, kv => kv.Value);
        }
    }
}
