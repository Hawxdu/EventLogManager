﻿using System;
using System.Runtime.Serialization;

namespace EventLogManager.Command.Exceptions
{
   [Serializable]
   public class EventLogNotFoundException : Exception
   {
      public EventLogNotFoundException()
      {
      }

      public EventLogNotFoundException( string message )
         : base( message )
      {
      }

      public EventLogNotFoundException( string message, Exception inner )
         : base( message, inner )
      {
      }

      protected EventLogNotFoundException(
         SerializationInfo info,
         StreamingContext context )
         : base( info, context )
      {
      }
   }
}
