# Wasm.LocalStorage

1. Add Dependencies in Program.cs
* using Wasm.LocalStorage;
* builder.Services.AddWasmLocalStorage();


2. Inject Service
* @Inject ILocalStorageManager LocalStorage

3. Use one of the built in methods
* LocalStorage.SetItemAsync(Key, Value);
* LocalStorage.GetItemAsync(Key);
* LocalStorage.RemoveItemAsync(Key);
* LocalStorage.ClearAsync();
