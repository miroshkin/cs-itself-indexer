namespace CS.Itself.Indexer
{
    class CustomCollectionWithIndexer <T>
    {
        private T[] _collection;

        public CustomCollectionWithIndexer(uint capacity)
        {
            _collection = new T[capacity];
        }

        public T this[int index]
        {
            get => _collection[index];
            set => _collection[index] = value;
        }
    }
}
