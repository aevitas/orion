using System;
using System.Diagnostics;

namespace Orion.Common
{
	/// <summary>
	/// Represents a monotonic timer.
	/// </summary>
	public static class MonotonicTimer
	{
		private static readonly Stopwatch _stopwatch = Stopwatch.StartNew();

		/// <summary>
		/// Gets a time stamp relative to the instance's epoch.
		/// </summary>
		/// <returns></returns>
		public static TimeSpan GetTimeStamp()
		{
			return _stopwatch.Elapsed;
		}
	}
}
