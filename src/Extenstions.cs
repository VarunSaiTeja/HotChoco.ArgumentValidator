using HotChocolate.Execution.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotChoco.ArgumentValidator
{
    public static class Extenstions
    {
        public static IRequestExecutorBuilder AddArgumentValidator(
            this IRequestExecutorBuilder requestExecutorBuilder)
        {
            requestExecutorBuilder.UseField<ValidationMiddleware>();

            return requestExecutorBuilder;
        }
    }
}
