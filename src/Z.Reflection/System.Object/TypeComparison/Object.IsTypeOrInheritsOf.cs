// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that query if '@this' is type or inherits of.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="type">The type.</param>
    /// <returns>true if type or inherits of, false if not.</returns>
    public static bool IsTypeOrInheritsOf<T>(this T @this, Type type)
    {
        Type objectType = @this.GetType();

        while (true)
        {
            if (objectType.Equals(type))
            {
                return true;
            }

            if ((objectType == objectType.BaseType) || (objectType.BaseType == null))
            {
                return false;
            }

            objectType = objectType.BaseType;
        }
    }
}