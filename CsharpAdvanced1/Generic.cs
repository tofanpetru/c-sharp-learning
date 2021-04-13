namespace CsharpAdvanced1
{
    class Generic<T>
    {
        private T value;

        public T Value { get => value; set => this.value = value; }

        public override string ToString()
        {
            return ($"{this.GetType().Name}: {this.Value}");
        }
    }
}
