﻿using System.Diagnostics.Contracts;

namespace VisionaryCoder.Framework.Extension
{

	public static class HashSetEx
	{

		/// <summary>
		/// Extend the HashSet to enable adding multiple objects to the collection.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="target"></param>
		/// <param name="collection"></param>
		public static void AddRange<T>(this HashSet<T> target, ICollection<T> collection)
		{

			Contract.Assert(target != null, "Input target is null.");

			if (collection == null)
			{
				return;
			}

			foreach (var item in collection)
			{
				target.Add(item);
			}

		}

	}

}