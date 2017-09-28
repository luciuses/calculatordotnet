using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace CalcWebUI.Components
{
	public static class EnumHelper
	{
		public static string GetDescription(this Enum value)
		{
			FieldInfo fi = value.GetType().GetField(value.ToString());
			DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
			return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
		}

		public static string GetDescription<T>(this T value) where T : struct
		{
			var enumValue = value as Enum;
			if (enumValue == null)
			{
				throw new Exception("Type given T must be an Enum");
			}

			return enumValue.GetDescription();
		}

		public static IEnumerable<T> GetValues<T>() where T : struct 
		{
			return Enum.GetValues(typeof(T)).Cast<T>();
		}

		public static IEnumerable<SelectListItem> GetSelectList<T>() where T : struct
		{
			if (!typeof(T).IsEnum)
			{
				throw new Exception("Type given T must be an Enum");
			}

			return GetValues<T>().Select(e => new SelectListItem { Text = e.GetDescription(), Value = e.ToString() });
		}
	}
}