// <auto-generated>
using System.Reflection;


namespace Microsoft.Extensions.DependencyInjection.Abstractions
{
    internal static partial class Resources
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(Resources)));
        internal static global::System.Globalization.CultureInfo Culture { get; set; }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal static string GetResourceString(string resourceKey, string defaultValue = null) =>  ResourceManager.GetString(resourceKey, Culture);

        private static string GetResourceString(string resourceKey, string[] formatterNames)
        {
           var value = GetResourceString(resourceKey);
           if (formatterNames != null)
           {
               for (var i = 0; i < formatterNames.Length; i++)
               {
                   value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
               }
           }
           return value;
        }

        /// <summary>Multiple constructors accepting all given argument types have been found in type '{0}'. There should only be one applicable constructor.</summary>
        internal static string AmbiguousConstructorMatch => GetResourceString("AmbiguousConstructorMatch");
        /// <summary>Multiple constructors accepting all given argument types have been found in type '{0}'. There should only be one applicable constructor.</summary>
        internal static string FormatAmbiguousConstructorMatch(object p0)
           => string.Format(Culture, GetResourceString("AmbiguousConstructorMatch"), p0);

        /// <summary>Unable to locate implementation '{0}' for service '{1}'.</summary>
        internal static string CannotLocateImplementation => GetResourceString("CannotLocateImplementation");
        /// <summary>Unable to locate implementation '{0}' for service '{1}'.</summary>
        internal static string FormatCannotLocateImplementation(object p0, object p1)
           => string.Format(Culture, GetResourceString("CannotLocateImplementation"), p0, p1);

        /// <summary>Unable to resolve service for type '{0}' while attempting to activate '{1}'.</summary>
        internal static string CannotResolveService => GetResourceString("CannotResolveService");
        /// <summary>Unable to resolve service for type '{0}' while attempting to activate '{1}'.</summary>
        internal static string FormatCannotResolveService(object p0, object p1)
           => string.Format(Culture, GetResourceString("CannotResolveService"), p0, p1);

        /// <summary>A suitable constructor for type '{0}' could not be located. Ensure the type is concrete and services are registered for all parameters of a public constructor.</summary>
        internal static string NoConstructorMatch => GetResourceString("NoConstructorMatch");
        /// <summary>A suitable constructor for type '{0}' could not be located. Ensure the type is concrete and services are registered for all parameters of a public constructor.</summary>
        internal static string FormatNoConstructorMatch(object p0)
           => string.Format(Culture, GetResourceString("NoConstructorMatch"), p0);

        /// <summary>No service for type '{0}' has been registered.</summary>
        internal static string NoServiceRegistered => GetResourceString("NoServiceRegistered");
        /// <summary>No service for type '{0}' has been registered.</summary>
        internal static string FormatNoServiceRegistered(object p0)
           => string.Format(Culture, GetResourceString("NoServiceRegistered"), p0);

        /// <summary>Implementation type cannot be '{0}' because it is indistinguishable from other services registered for '{1}'.</summary>
        internal static string TryAddIndistinguishableTypeToEnumerable => GetResourceString("TryAddIndistinguishableTypeToEnumerable");
        /// <summary>Implementation type cannot be '{0}' because it is indistinguishable from other services registered for '{1}'.</summary>
        internal static string FormatTryAddIndistinguishableTypeToEnumerable(object p0, object p1)
           => string.Format(Culture, GetResourceString("TryAddIndistinguishableTypeToEnumerable"), p0, p1);


    }
}
