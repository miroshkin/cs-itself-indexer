using System;

namespace CS.Itself.Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomCollectionWithIndexer<string> collection = new CustomCollectionWithIndexer<string>(5);

            collection[0] = "First element of a collection";
            collection[1] = "Second element of a collection";
            collection[2] = "Third element of a collection";

            Console.WriteLine($"collection[0] : {collection[0]}");
        }
    }
}
