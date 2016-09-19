//------------------------------------------------------------------------------
// <auto-generated>
//	 This code was generated by a tool.
//
//	 Changes to this file may cause incorrect behavior and will be lost if
//	 the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace JavaScriptEngineSwitcher.Jint.Resources
{
	using System;
	using System.Globalization;
	using System.Reflection;
	using System.Resources;

	/// <summary>
	/// A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	public class Strings
	{
		private static Lazy<ResourceManager> _resourceManager =
			new Lazy<ResourceManager>(() => new ResourceManager(
				"JavaScriptEngineSwitcher.Jint.Resources.Strings",
#if NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETCOREAPP1_0 || NET451 || NET452 || NET46 || NET461 || NET462 || NET463
				typeof(Strings).GetTypeInfo().Assembly
#elif NET40
				typeof(Strings).Assembly
#else
#error No implementation for this target
#endif
			));

		private static CultureInfo _resourceCulture;

		/// <summary>
		/// Returns a cached ResourceManager instance used by this class
		/// </summary>
		public static ResourceManager ResourceManager
		{
			get
			{
				return _resourceManager.Value;
			}
		}

		/// <summary>
		/// Overrides a current thread's CurrentUICulture property for all
		/// resource lookups using this strongly typed resource class
		/// </summary>
		public static CultureInfo Culture
		{
			get
			{
				return _resourceCulture;
			}
			set
			{
				_resourceCulture = value;
			}
		}

		/// <summary>
		/// Looks up a localized string similar to "Maximum execution time exceeded."
		/// </summary>
		public static string Runtime_ExecutionTimeout
		{
			get { return GetString("Runtime_ExecutionTimeout"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Recursion is forbidden by script host: {0}"
		/// </summary>
		public static string Runtime_RecursionDepthOverflow
		{
			get { return GetString("Runtime_RecursionDepthOverflow"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Maximum number of statements executed have been reached."
		/// </summary>
		public static string Runtime_StatementsCountOverflow
		{
			get { return GetString("Runtime_StatementsCountOverflow"); }
		}

			private static string GetString(string name)
			{
				string value = ResourceManager.GetString(name, _resourceCulture);

				return value;
			}
		}
	}