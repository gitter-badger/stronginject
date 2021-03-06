﻿using System;
using System.Threading.Tasks;

namespace StrongInject
{
    public static class Helpers
    {
        public static void Dispose<T>(T instance)
        {
            if (instance is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }

        public static ValueTask DisposeAsync<T>(T instance)
        {
            if (instance is IAsyncDisposable asyncDisposable)
            {
                return asyncDisposable.DisposeAsync();
            }

            if (instance is IDisposable disposable)
            {
                disposable.Dispose();
            }

            return default;
        }
    }
}
