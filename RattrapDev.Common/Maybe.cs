using System;
using System.Collections;
using System.Collections.Generic;

namespace RattrapDev.Common
{
	public class Maybe<T> : IEnumerable<T>
	{
		private List<T> items;

		private Maybe(T item)
		{
			if (item == null)
			{
				throw new ArgumentNullException(nameof(item), "The provided item cannot be null!");
			}

			items = new List<T> { item };
		}

		private Maybe()
		{
			items = new List<T>();
		}

		public static Maybe<T> Some(T item) => new Maybe<T>(item);

		public static Maybe<T> None() => new Maybe<T>();

		public IEnumerator<T> GetEnumerator() => items.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
	}
}