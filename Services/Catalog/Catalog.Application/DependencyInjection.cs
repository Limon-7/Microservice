﻿using System.Reflection;
using Catalog.Application.Common.Behaviours;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddScoped(typeof(IPipelineBehavior<,>),typeof(LoggingBehavior<,>));
        services.AddScoped(typeof(IPipelineBehavior<,>),typeof(PerformanceBehavior<,>));

        return services;
    }
}