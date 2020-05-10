using System;
using System.Runtime.Serialization;

namespace ReviewManagement.App.Commands.Common
{
	[Serializable]
	internal class EnityNotFountException : Exception
	{
		public EnityNotFountException()
		{
		}

		public EnityNotFountException(string message) : base(message)
		{
		}

		public EnityNotFountException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected EnityNotFountException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}