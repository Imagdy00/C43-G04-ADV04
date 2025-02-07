using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 1
            //            using System;
            //            using System.Collections;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                Hashtable hashtable = new Hashtable();
            //                hashtable.Add("Key1", "Value1");
            //                hashtable.Add("Key2", "Value2");

            //                foreach (DictionaryEntry entry in hashtable)
            //                {
            //                    Console.WriteLine($"{entry.Key}: {entry.Value}");
            //                }
            //            }
            //        }
            #endregion


            #region Video 2
            //            using System;
            //            using System.Collections;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                Hashtable hashtable = new Hashtable();
            //                hashtable.Add(1, "Apple");
            //                hashtable.Add(2, "Banana");
            //                hashtable.Add(3, "Cherry");

            //                Console.WriteLine(hashtable[2]); // Output: Banana
            //            }
            //        }
            #endregion


            #region Video 3
            //            using System;
            //            using System.Collections.Generic;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //                dictionary.Add(1, "Red");
            //                dictionary.Add(2, "Green");
            //                dictionary.Add(3, "Blue");

            //                Console.WriteLine(dictionary[2]); // Output: Green
            //            }
            //        }
            #endregion


            #region Video 4
            //            using System;
            //            using System.Collections.Generic;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                HashSet<string> hashSet = new HashSet<string>();
            //                hashSet.Add("Apple");
            //                hashSet.Add("Banana");
            //                hashSet.Add("Apple"); // لن يتم إضافته لأنه مكرر

            //                foreach (var item in hashSet)
            //                {
            //                    Console.WriteLine(item); // Output: Apple, Banana
            //                }
            //            }
            //        }
            #endregion


            #region Video 5
            //            using System;
            //            using System.Collections.Generic;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>();
            //                sortedDict.Add(3, "Three");
            //                sortedDict.Add(1, "One");
            //                sortedDict.Add(2, "Two");

            //                foreach (var item in sortedDict)
            //                {
            //                    Console.WriteLine($"{item.Key}: {item.Value}");
            //                }
            //                // Output:
            //                // 1: One
            //                // 2: Two
            //                // 3: Three
            //            }
            //        }
            #endregion


            #region Video 6
            //            using System;
            //            using System.Collections;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                SortedList sortedList = new SortedList();
            //                sortedList.Add("Zebra", 100);
            //                sortedList.Add("Apple", 200);
            //                sortedList.Add("Banana", 300);

            //                foreach (DictionaryEntry entry in sortedList)
            //                {
            //                    Console.WriteLine($"{entry.Key}: {entry.Value}");
            //                }
            //                // Output:
            //                // Apple: 200
            //                // Banana: 300
            //                // Zebra: 100
            //            }
            //        }
            #endregion


            #region Video 7
            //            using System;

            //class Program
            //        {
            //            public delegate void MyEventHandler(string message);

            //            public class MyClass
            //            {
            //                public event MyEventHandler MyEvent;

            //                public void TriggerEvent(string message)
            //                {
            //                    MyEvent?.Invoke(message);
            //                }
            //            }

            //            static void Main()
            //            {
            //                MyClass obj = new MyClass();
            //                obj.MyEvent += (message) => Console.WriteLine($"Event triggered: {message}");
            //                obj.TriggerEvent("Hello, World!");
            //            }
            //        }
            #endregion


            #region Video 8
            //            using System;

            //class Program
            //        {
            //            public delegate void Notify();

            //            public class Process
            //            {
            //                public event Notify ProcessCompleted;

            //                public void StartProcess()
            //                {
            //                    Console.WriteLine("Process Started!");
            //                    OnProcessCompleted();
            //                }

            //                protected virtual void OnProcessCompleted()
            //                {
            //                    ProcessCompleted?.Invoke();
            //                }
            //            }

            //            static void Main()
            //            {
            //                Process process = new Process();
            //                process.ProcessCompleted += () => Console.WriteLine("Process Completed!");
            //                process.StartProcess();
            //            }
            //        }
            #endregion


            #region Video 9
//            using System;

//class Program
//        {
//            public delegate void MessageHandler(string message);

//            public class Publisher
//            {
//                public event MessageHandler MessagePublished;

//                public void PublishMessage(string message)
//                {
//                    MessagePublished?.Invoke(message);
//                }
//            }

//            static void Main()
//            {
//                Publisher publisher = new Publisher();
//                publisher.MessagePublished += (message) => Console.WriteLine($"Received: {message}");
//                publisher.PublishMessage("Hello, Subscribers!");
//            }
//        }
        #endregion



    }
    }
}
