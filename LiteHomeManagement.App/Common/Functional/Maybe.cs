﻿
namespace LiteHomeManagement.App.Common
{
    public sealed class Maybe<T>
    {
        public bool IsMissing { get; }
        public bool IsPresent => !IsMissing;
        public T Value { get; }

        private Maybe(bool isMissing, T value)
        {
            IsMissing = isMissing;
            Value = value;
        }

        public static Maybe<T> Missing => new Maybe<T>(true, default(T));

        public static implicit operator Maybe<T>(T obj)
        {
            return new Maybe<T>(false, obj);
        }
    }
}
