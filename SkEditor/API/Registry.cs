﻿using System.Collections.Generic;

namespace SkEditor.API;

/// <summary>
/// Represent a registry, which is a collection of key-value pairs,
/// each being linked with a registry key (= the IAddon instance).
/// </summary>
public class Registry<TValue>
{
    
    /// <summary>
    /// Object representing a registry key, based on an IAddon instance and a string key.
    /// </summary>
    /// <param name="Addon">The IAddon instance linked to the key.</param>
    /// <param name="Key">The string key.</param>
    public record RegistryKey(IAddon Addon, string Key);
    
    private readonly Dictionary<RegistryKey, TValue> _registry = new();
    
    /// <summary>
    /// Get the value associated with the given key.
    /// </summary>
    /// <param name="key">The key to look for.</param>
    /// <returns>The value associated with the key, or the default value if the key is not found.</returns>
    public TValue GetValue(RegistryKey key)
    {
        return _registry.GetValueOrDefault(key);
    }
    
    /// <summary>
    /// Registers a new key-value pair in the registry.
    /// </summary>
    /// <param name="key">The key to register.</param>
    /// <param name="value">The value to associate with the key.</param>
    /// <returns>True if the key-value pair was added successfully, false if the key already exists.</returns>
    public bool Register(RegistryKey key, TValue value)
    {
        return _registry.TryAdd(key, value);
    }

    /// <summary>
    /// Checks if a key exists in the registry.
    /// </summary>
    /// <param name="key">The key to check for.</param>
    /// <returns>True if the key exists, false otherwise.</returns>
    public bool HasKey(RegistryKey key)
    {
        return _registry.ContainsKey(key);
    }

    /// <summary>
    /// Retrieves all values in the registry.
    /// </summary>
    /// <returns>An IEnumerable of all values in the registry.</returns>
    public IEnumerable<TValue> GetValues()
    {
        return _registry.Values;
    }
    
}