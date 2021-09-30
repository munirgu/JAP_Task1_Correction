using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_Backend.Extensions
{
    public class AddSwagger
    {
        public static void AddSwaggerConfig(IServiceCollection services)
        {

            services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "JAP_Task1_Correction", Version = "v1" });
                    c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                    {
                        Description = "Standard Authorization header using the Bearer token",
                        In = ParameterLocation.Header,
                        Name = "Authorization",
                        Type = SecuritySchemeType.ApiKey
                    });
                    c.OperationFilter<SecurityRequirementsOperationFilter>();
                });
        }
    }

}