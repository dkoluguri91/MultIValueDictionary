using System;
using System.Collections.Generic;
using System.Text;

namespace MultIValueDictionary
{
    class Operations
    {

        public bool FindValue(IDictionary<string, List<string>> Values, string[] inputKey)
        {
            foreach (var item in Values)
            {
                if (item.Key == inputKey[0] && item.Value.Contains(inputKey[1]))
                    return true;
            }

            return false;
        }
        public IDictionary<string, List<string>> AddValue(IDictionary<string, List<string>> Values, string[] input)
        {
            if (FindValue(Values,input))
            {
                Console.WriteLine("Error, value already exists.");
            }
            else if(Values.ContainsKey(input[0]))
            {
                foreach (var val in Values)
                {
                    if (val.Key == input[0])
                    {
                        val.Value.Add(input[1]);
                    }
                }
                Console.WriteLine("Added");
            }
            else
            {
                Values.Add(new KeyValuePair<string,List<string>>(input[0], new List<string>() { input[1] }));
                Console.WriteLine("Added");
            }
            return Values;
        }
        public void GetAllKeys(IDictionary<string, List<string>> Values)
        {
            if (Values.Count == 0)
            {
                Console.WriteLine("Multi Value Dictionary is empty.");
            }
            else
            {
                foreach (var value in Values)
                {
                    Console.WriteLine(value.Key);
                }
            }
        }
        public void GetMembersWithKey(IDictionary<string, List<string>> Values, string inputKey)
        {
            if (Values.ContainsKey(inputKey))
            {
                foreach (var item in Values)
                {
                    if (item.Key == inputKey)
                    {
                        foreach (var itemVal in item.Value)
                        {
                            Console.WriteLine(itemVal);
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("Error, Key does not exit.");
            }
        }
        public IDictionary<string, List<string>> Remove(IDictionary<string, List<string>> Values, string[] inputKey)
        {
            if (Values.ContainsKey(inputKey[0]) &&FindValue(Values, inputKey))
            {
                foreach (var item in Values)
                {
                    if (item.Key == inputKey[0] && item.Value.Count > 1)
                    {
                        foreach (var itemval in item.Value)
                        {
                            if (itemval == inputKey[1])
                            {
                                item.Value.Remove(inputKey[1]);
                                break;
                            }

                        }
                        Console.WriteLine("Removed");
                    }
                    else if (item.Key == inputKey[0] && item.Value.Count == 1)
                    {
                        Values.Remove(item);
                        Console.WriteLine("Removed");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error, Value does not exit.");
            }
            return Values;
        }
        public IDictionary<string, List<string>> RemoveAll(IDictionary<string, List<string>> Values, string inputKey)
        {
            if (Values.ContainsKey(inputKey))
            {
                Values.Remove(inputKey);
                Console.WriteLine("Removed");
            }
            else
            {
                Console.WriteLine("Error, Key does not exit.");
            }
            return Values;
        }
        public IDictionary<string, List<string>> Clear(IDictionary<string, List<string>> Values)
        {
            return new Dictionary<string, List<string>>();
        }
        public void AllMembers(IDictionary<string, List<string>> Values)
        {
            if (Values.Count > 0)
            {
                foreach (var val in Values)
                {
                    foreach (var item in val.Value)
                    {
                        Console.WriteLine(item);
                    }
                }

            }
            else
            {
                Console.WriteLine("Empty,set");
            }
        }
        public void Items(IDictionary<string, List<string>> Values)
        {
            if (Values.Count > 0)
            {
                foreach (var val in Values)
                {
                    foreach (var item in val.Value)
                    {
                        Console.WriteLine(val.Key + ":" + item);
                    }
                }

            }
            else
            {
                Console.WriteLine("Empty,set");
            }
        }
    }
}
