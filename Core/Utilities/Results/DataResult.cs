namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            this.data = data;
        }
        public DataResult(T data, bool success) : base(success)
        {
            this.data = data;
        }

        public T data { get; }
    }
}
