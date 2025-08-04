namespace Day14Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            DictionaryMethod();
            CustomTypeDictionaryMethod();
            StoredListAndStoredDictionarys();
            GenericStacks();
            GenericQueues();
        }

        public static void DictionaryMethod()
        {
            DictionaryConcepts dictionaryConcepts = new DictionaryConcepts();
            dictionaryConcepts.DictionaryMethods();
        }
        public static void CustomTypeDictionaryMethod()
        {
            CustomTypeDictionary customTypeDictionary = new CustomTypeDictionary();
            customTypeDictionary.CustomTypeDictionaryMethod();
        }
        public static void StoredListAndStoredDictionarys()
        {
            StoredListAndStoredDictionary storedListAndStoredDictionary = new StoredListAndStoredDictionary();
            storedListAndStoredDictionary.StoredListAndStoredDictionaryMethods();
        }
        public static void GenericStacks()
        {
            GenericStack genericStack = new GenericStack();
            genericStack.GenericStackMethod();
        }
        public static void GenericQueues()
        {
            GenericQueue genericQueue = new GenericQueue();
            genericQueue.GenericQueueMethod();
        }
    }
}
