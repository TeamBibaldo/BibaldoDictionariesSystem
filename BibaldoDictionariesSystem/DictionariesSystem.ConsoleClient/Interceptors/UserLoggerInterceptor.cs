﻿using System;
using Ninject.Extensions.Interception;
using DictionariesSystem.Contracts.Core.Providers;
using Bytes2you.Validation;

namespace DictionariesSystem.ConsoleClient.Interceptors
{
    public class UserLoggerInterceptor : IInterceptor
    {
        private readonly ILogger logger;

        public UserLoggerInterceptor(ILogger logger)
        {
            Guard.WhenArgument(logger, "logger").IsNull().Throw();

            this.logger = logger;
        }

        public void Intercept(IInvocation invocation)
        {
            throw new NotImplementedException();
        }
    }
}