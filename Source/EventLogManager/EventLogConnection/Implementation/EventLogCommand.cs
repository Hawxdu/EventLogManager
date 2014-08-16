﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using EventLogManager.Command.Exceptions;
using Microsoft.Win32;

namespace EventLogManager.Command
{
   /// <summary>
   /// Encapsulate logic for managing Windows Event Logs
   /// </summary>
   public class EventLogCommand : IEventLogCommand
   {
      /// <summary>
      /// Checks for existence of event log with given name
      /// </summary>
      /// <param name="eventLogName">Name of event log to lookup</param>
      /// <returns>true if exists, false otherwise</returns>
      public bool DoesEventLogExist( string eventLogName )
      {
         return EventLog.Exists( eventLogName );
      }

      /// <summary>
      /// Look at the event log and retrieve all the event log names
      /// </summary>
      /// <returns>Collection of event log names</returns>
      public Collection<string> GetEventLogs()
      {
         // TODO: Handle SystemException which can be thrown by EventLog.GetEventLogs()
         // http://msdn.microsoft.com/en-us/library/74e2ybbs(v=vs.110).aspx

         var eventLogNames = new List<string>();

         eventLogNames.AddRange( from EventLog eventLog in EventLog.GetEventLogs()
                                 select eventLog.Log );

         return new Collection<string>( eventLogNames );
      }

      /// <summary>
      /// Looks in the registry to retrieve a collection of all event sources
      /// for a given event log
      /// </summary>
      /// <param name="eventLogName">event log to list sources of</param>
      /// <returns>Collection of event source names</returns>
      public Collection<string> GetEventLogSources( string eventLogName )
      {
         // TODO: Handle exceptions thrown by OpenSubKey
         // http://msdn.microsoft.com/en-us/library/microsoft.win32.registrykey.getsubkeynames(v=vs.110).aspx

         if( !DoesEventLogExist( eventLogName ) )
         {
            throw new EventLogNotFoundException( string.Format( CultureInfo.CurrentCulture, EventLogExceptionString.EventLogNotFoundException, eventLogName ) );
         }

         var eventSourceNames = new List<string>();
         string registryLocation = string.Format( CultureInfo.InvariantCulture, @"SYSTEM\CurrentControlSet\Services\Eventlog\{0}", eventLogName );

         using( RegistryKey registryKey = Registry.LocalMachine.OpenSubKey( registryLocation ) )
         {
            if( registryKey == null )
            {
               return new Collection<string>( eventSourceNames );
            }

            eventSourceNames.AddRange( registryKey.GetSubKeyNames() );
         }

         return new Collection<string>( eventSourceNames );
      }
   }
}