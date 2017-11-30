﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

// ReSharper disable once ConvertIfStatementToReturnStatement
namespace DNX.Helpers.Reflection
{
    /// <summary>
    /// Reflection Extensions.
    /// </summary>
    public static class ReflectionExtensions
    {
        /// <summary>
        /// Gets the object properties as a dictionary.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>IDictionary&lt;System.String, System.Object&gt;.</returns>
        public static IDictionary<string, object> GetPropertiesDictionary(object obj)
        {
            var dictionary = GetPropertiesDictionary(obj,
                BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance
                );

            return dictionary;
        }

        /// <summary>
        /// Gets the object properties as a dictionary.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="bindingFlags">The binding flags.</param>
        /// <returns>IDictionary&lt;System.String, System.Object&gt;.</returns>
        public static IDictionary<string, object> GetPropertiesDictionary(object obj, BindingFlags bindingFlags)
        {
            if (obj == null)
            {
                return null;
            }

            var dictionary = GetPropertiesForType(obj.GetType(), bindingFlags)
                .ToDictionary(
                    pi => pi.Name,
                    pi => pi.GetValue(obj)
                );

            return dictionary;
        }

        /// <summary>
        /// Gets the properties for the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>IList&lt;PropertyInfo&gt;.</returns>
        public static IList<PropertyInfo> GetPropertiesForType(Type type)
        {
            var list = GetPropertiesForType(
                type,
                BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance
                );

            return list;
        }

        /// <summary>
        /// Gets the properties for the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="bindingFlags">The binding flags.</param>
        /// <returns>IList&lt;PropertyInfo&gt;.</returns>
        public static IList<PropertyInfo> GetPropertiesForType(Type type, BindingFlags bindingFlags)
        {
            var propertyInfos = type.GetProperties(bindingFlags);

            return propertyInfos;
        }

        /// <summary>
        /// Gets the properties for the specified types.
        /// </summary>
        /// <param name="types">The types.</param>
        /// <returns>IList&lt;PropertyInfo&gt;.</returns>
        public static IList<PropertyInfo> GetPropertiesForTypes(IEnumerable<Type> types)
        {
            var list = GetPropertiesForTypes(
                types,
                BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance
                );

            return list;
        }

        /// <summary>
        /// Gets the properties for the specified types.
        /// </summary>
        /// <param name="types">The types.</param>
        /// <param name="bindingFlags">The binding flags.</param>
        /// <returns>IList&lt;PropertyInfo&gt;.</returns>
        public static IList<PropertyInfo> GetPropertiesForTypes(IEnumerable<Type> types, BindingFlags bindingFlags)
        {
            var properties = types
                .SelectMany(t => GetPropertiesForType(t, bindingFlags))
                .ToList();

            return properties;
        }

        /// <summary>
        /// Gets an objects property info by name. Supports dot notation for child properties
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>PropertyInfo.</returns>
        public static PropertyInfo GetPropertyInfoByName(this object instance, string propertyName)
        {
            var propertyNames = propertyName.Split(".".ToCharArray());

            var instancePropertyName = propertyNames
                .FirstOrDefault();

            var childPropertyNames = propertyNames
                .Skip(1)
                .ToList();

            var childPropertyNamesText = childPropertyNames.Any()
                ? string.Join(".", childPropertyNames)
                : string.Empty;

            var propertyInfo = instance == null
                ? null
                : GetPropertiesForType(instance.GetType())
                    .FirstOrDefault(p => p.Name.Equals(instancePropertyName, StringComparison.CurrentCultureIgnoreCase));

            var instanceValue = propertyInfo == null
                ? null
                : propertyInfo.GetValue(instance, null);

            var returnValue = childPropertyNames.Any()
                ? GetPropertyInfoByName(instanceValue, childPropertyNamesText)
                : propertyInfo;

            return returnValue;
        }

        /// <summary>
        /// Determines whether the specified property name is valid for the specified object
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>System.Boolean.</returns>
        public static bool IsPropertyNameValid(this object instance, string propertyName)
        {
            var propertyInfo = GetPropertyInfoByName(instance, propertyName);

            var exists = propertyInfo != null;

            return exists;
        }

        /// <summary>
        /// Gets he value of an objects property by name
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>System.Object.</returns>
        public static object GetPropertyValueByName(this object instance, string propertyName)
        {
            var propertyNames = propertyName.Split(".".ToCharArray());

            var instancePropertyName = propertyNames
                .FirstOrDefault();

            var childPropertyNames = propertyNames
                .Skip(1)
                .ToList();
            var childPropertyNamesText = childPropertyNames.Any()
                ? string.Join(".", childPropertyNames)
                : string.Empty;

            var propertyInfo = GetPropertiesForType(instance.GetType())
                .FirstOrDefault(p => p.Name.Equals(instancePropertyName, StringComparison.CurrentCultureIgnoreCase));

            var instanceValue = propertyInfo == null
                ? null
                : propertyInfo.GetValue(instance, null);

            var returnValue = childPropertyNames.Any()
                ? GetPropertyValueByName(instanceValue, childPropertyNamesText)
                : instanceValue;

            return returnValue;
        }

        /// <summary>
        /// Serialises an object instance to a Dictionary
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance">The instance.</param>
        /// <param name="bindingFlags">The binding flags.</param>
        /// <returns>IDictionary&lt;System.String, System.Object&gt;.</returns>
        public static IDictionary<string, object> ToDictionaryTyped<T>(this T instance, BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty)
        {
            if (instance == null)
            {
                return null;
            }

            return instance.ToDictionary();
        }

        /// <summary>
        /// Serialises an object instance to a Dictionary
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="bindingFlags">The binding flags.</param>
        /// <returns>IDictionary&lt;System.String, System.Object&gt;.</returns>
        public static IDictionary<string, object> ToDictionary(this object instance, BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty)
        {
            if (instance == null)
            {
                return null;
            }

            var properties = instance.GetType().GetProperties(bindingFlags);

            var dict = new Dictionary<string, object>();

            foreach (var property in properties)
            {
                dict.Add(property.Name, property.GetValue(instance));
            }

            return dict;
        }

        /// <summary>
        /// Creates a populated object instance from a Dictionary
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dict">The dictionary.</param>
        /// <param name="bindingFlags">The binding flags.</param>
        /// <returns>T.</returns>
        public static T ToInstance<T>(this IDictionary<string, object> dict, BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty)
            where T : new()
        {
            if (dict == null)
            {
                return default(T);
            }

            var instance = new T();

            instance.PopulateFrom(dict, bindingFlags);

            return instance;
        }

        /// <summary>
        /// Populates an object instance from a Dictionary
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance">The instance.</param>
        /// <param name="dict">The dictionary.</param>
        /// <param name="bindingFlags">The binding flags.</param>
        /// <returns>T.</returns>
        public static T PopulateFrom<T>(this T instance, IDictionary<string, object> dict, BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty)
            where T : new()
        {
            if (dict == null)
            {
                return instance;
            }

            var properties = typeof(T).GetProperties(bindingFlags)
                .Where(p => p.CanWrite)
                .ToList();

            foreach (var property in properties)
            {
                if (!dict.ContainsKey(property.Name))
                {
                    continue;
                }

                property.SetValue(instance, dict[property.Name]);
            }

            return instance;
        }
    }
}
