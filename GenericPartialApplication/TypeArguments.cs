namespace GenericPartialApplication
{
    public abstract class TypeArguments
    {
        public abstract class _1
        {
            public static _1 For<T>() => _<T>.Instance;

            _1()
            {
            }

            public abstract _2 Aggregate(_1 typeWrapper);
            private protected abstract _2 AddToTypes<T1>();
            public abstract _3 AddToTypes<T1, T2>();

            public sealed class _<T> : _1
            {
                public static _<T> Instance = new _<T>();

                _()
                {
                }

                public override _2 Aggregate(_1 typeWrapper) => typeWrapper.AddToTypes<T>();
                private protected override _2 AddToTypes<T1>() => _2._<T1, T>.Instance;
                public override _3 AddToTypes<T1, T2>() => _3._<T1, T2, T>.Instance;
            }
        }

        public abstract class _2
        {
            public abstract _3 Aggregate(_1 typeWrapper);
            public abstract TResult Invoke<TResult>(ICallTarget<TResult> callTarget);

            public sealed class _<T1, T2> : _2
            {
                public static _<T1, T2> Instance = new _<T1, T2>();

                _()
                {
                }

                public override _3 Aggregate(_1 typeWrapper) => typeWrapper.AddToTypes<T1, T2>();
                public override TResult Invoke<TResult>(ICallTarget<TResult> callTarget) => callTarget.Invoke<T1, T2>();
            }

            public interface ICallTarget<TResult>
            {
                TResult Invoke<T1, T2>();
            }
        }

        public abstract class _3
        {
            public abstract TResult Invoke<TResult>(ICallTarget<TResult> callTarget);

            public sealed class _<T1, T2, T3> : _3
            {
                public static _<T1, T2, T3> Instance = new _<T1, T2, T3>();

                _()
                {
                }

                public override TResult Invoke<TResult>(ICallTarget<TResult> callTarget) => callTarget.Invoke<T1, T2, T3>();
            }

            public interface ICallTarget<TResult>
            {
                TResult Invoke<T1, T2, T3>();
            }
        }
    }
}
