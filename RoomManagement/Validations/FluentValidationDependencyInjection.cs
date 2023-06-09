﻿using FluentValidation.AspNetCore;
using FluentValidation;
using System.Reflection;

namespace RoomManagement.Validations
{
    public static class FluentValidationDependencyInjection
    {
        public static WebApplicationBuilder ConfigureFluentValidation(this WebApplicationBuilder builder)
        {
            // Enable client-side integration
            builder.Services.AddFluentValidationClientsideAdapters();

            // Scan and register all validators in given assembly
            builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return builder;
        }
    }
}
