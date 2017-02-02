using System;
using System.Linq;

namespace RattrapDev.Common
{
	public static class MaybeExtensions
	{
		public static void Do<T>(this Maybe<T> item, Action<T> action)
		{
			foreach (T optionalItem in item)
			{
				action(optionalItem);
			}
		}
	}
}
