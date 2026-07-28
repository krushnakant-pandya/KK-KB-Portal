using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Shared.Wrappers
{
    public class Result
    {
        public bool Succeeded { get; }
        public IReadOnlyList<string> Errors { get; }

        protected Result(bool succeeded, IReadOnlyList<string> errors)
        {
            Succeeded = succeeded;
            Errors = errors;
        }

        public static Result Success() => new(true, []);
        public static Result Failure(params string[] errors) => new(false, errors);
        public static Result<T> Success<T>(T value) => new(value, true, []);
        public static Result<T> Failure<T>(params string[] errors) => new(default, false, errors);
    }

    public sealed class Result<T> : Result
    {
        public T? Value { get; }

        internal Result(T? value, bool succeeded, IReadOnlyList<string> errors) : base(succeeded, errors)
        {
            Value = value;
        }
    }

}
