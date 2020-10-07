// Copyright (C) 2015-2020 aevitas
// See the file LICENSE for copying permission.

using Microsoft.Extensions.Logging;

namespace Orion.Common
{
	public static class Log
    {
        private static readonly ILoggerFactory _loggerFactory;

        static Log()
        {
            _loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        }

		/// <summary>
		///     Gets a logging instance for the calling type.
		/// </summary>
		/// <returns></returns>
		public static ILogger<T> Get<T>() =>  _loggerFactory.CreateLogger<T>();

        public static ILogger Get() => _loggerFactory.CreateLogger("General");
    }
}