using System.Diagnostics;
using log4net;
using log4net.Core;

namespace Orion.Common
{
	public static class Log
	{
		/// <summary>
		/// Gets a logging instance for the calling type.
		/// </summary>
		/// <returns></returns>
		public static ILog Get()
		{
			return LogManager.GetLogger(new StackTrace().GetFrames()[1].GetMethod().DeclaringType);
		}
	}

	public static class LogExtensions
	{
		public static void LogFormatted(this ILog log, Level level, string message, params object[] args)
		{
			log.Logger.Log(null, level, string.Format(message, args), null);
		}

		public static void NoticeFormat(this ILog log, string message, params object[] args)
		{
			log.LogFormatted(Level.Notice, message, args);
		}

		public static void InfoFormat(this ILog log, string message, params object[] args)
		{
			log.LogFormatted(Level.Info, message, args);
		}

		public static void WarningFormat(this ILog log, string message, params object[] args)
		{
			log.LogFormatted(Level.Warn, message, args);
		}

		public static void TraceFormat(this ILog log, string message, params object[] args)
		{
			log.LogFormatted(Level.Trace, message, args);
		}
	}
}
