namespace Wasm.LocalStorage;

public interface ILocalStorageManager
{
    ValueTask<string?> GetItemAsync(string key);
    ValueTask SetItemAsync(string key, string value);
    ValueTask RemoveItemAsync(string key);
    ValueTask ClearAsync();
}