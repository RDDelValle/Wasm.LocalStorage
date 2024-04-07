using Microsoft.Extensions.DependencyInjection;

namespace Wasm.LocalStorage;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddWasmLocalStorage(this IServiceCollection services)
        => services.AddScoped<ILocalStorageManager, LocalStorageManager>();
}