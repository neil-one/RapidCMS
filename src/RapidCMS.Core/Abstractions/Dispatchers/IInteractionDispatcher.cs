﻿using System.Threading.Tasks;
using RapidCMS.Core.Abstractions.State;

namespace RapidCMS.Core.Abstractions.Dispatchers
{
    internal interface IInteractionDispatcher
    {
    }

    internal interface IInteractionDispatcher<TRequest, TResponse> : IInteractionDispatcher
    {
        Task<TResponse> InvokeAsync(TRequest request, IPageState pageState);
    }
}
