namespace WhyUseIsNull
{
    internal class TestClass
    {
        internal TestClass(string content) 
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentNullException(nameof(content));
            }

            this.Content = content;
        }

        public static bool operator == (TestClass? a, TestClass? b)
        {
            if (a is null)
                return b is not null;
            else
                return !a.Equals(b);
        }

        public static bool operator !=(TestClass? a, TestClass? b)
        {
            if (a is null)
                return b is null;
            else
                return a.Equals(b);
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string Content { get; init; }
    }
}
