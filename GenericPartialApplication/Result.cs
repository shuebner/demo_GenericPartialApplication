namespace GenericPartialApplication
{
public abstract class Result
{
    Result()
    {
    }

    public sealed class OfType<T1, T2> : Result
    {
    }

        public sealed class OfType<T1, T2, T3> : Result
        {
        }
    }
}
