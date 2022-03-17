using Microsoft.Extensions.Logging;

namespace VisionaryCoder.Framework
{

	/// <summary>
	/// Base class for service components.
	/// Leverage Microsoft.Extensions.Logging.ILogger
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Service<T> where T : IService, new()
	{

		private ILogger logger;

		public Service(ILogger logger)
		{

			this.logger = logger;

		}

	}

}