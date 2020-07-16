﻿using System.Threading.Tasks;

namespace StrongInject.Runtime
{
    public interface IInstanceProvider<T>
    {
        ValueTask<T> GetAsync();
    }
}