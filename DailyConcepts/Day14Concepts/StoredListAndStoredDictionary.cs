using System;
using System.Collections.Generic;

namespace Day14Concepts
{
    class StoredListAndStoredDictionary
    {
        public void StoredListAndStoredDictionaryMethods()
        {
            var fileInfo = new SortedDictionary<string , string>();
            fileInfo.Add("txt", "notepad.exe");
            fileInfo.Add("doc", "wordpad.exe");

            foreach (var kvp in fileInfo )
            {
                Console.WriteLine($"Key: {kvp.Key}, value: {kvp.Value}");
            }
           
            Console.WriteLine("press any key to add anothe file extention....");
            Console.ReadLine();

            fileInfo.Add("bmp", "print.exe");

            Console.WriteLine("Upload file info list : ");
            foreach(var kvp in fileInfo )
            {
                Console.WriteLine($"key :{kvp.Key}, value : {kvp.Value}");
            }
            Console.ReadKey();
        }
    }
}
