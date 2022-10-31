using System;

namespace GenericPartialApplication
{
    public static class Mapper
    {
        public static Result GetResultArity2(string oneStr, string twoStr) =>
            MapToType(oneStr)
                .Aggregate(MapToType(twoStr))
                .Invoke(new Target2());

        public static Result GetResultArity3(string oneStr, string twoStr, string threeStr) =>
            MapToType(oneStr)
                .Aggregate(MapToType(twoStr))
                .Aggregate(MapToType(threeStr))
                .Invoke(new Target3());

        public static TypeArguments._1 MapToType(string str) =>
            str switch
            {
                "int" => TypeArguments._1.For<int>(),
                "double" => TypeArguments._1.For<double>(),
                "string" => TypeArguments._1.For<string>(),
                "DateTime" => TypeArguments._1.For<DateTime>(),
                "Version" => TypeArguments._1.For<Version>(),
                _ => throw new NotImplementedException(),
            };

        sealed class Target2 : TypeArguments._2.ICallTarget<Result>
        {
            public Result Invoke<T1, T2>() => new Result.OfType<T1, T2>();
        }

        sealed class Target3 : TypeArguments._3.ICallTarget<Result>
        {
            public Result Invoke<T1, T2, T3>() => new Result.OfType<T1, T2, T3>();
        }
    }
}
