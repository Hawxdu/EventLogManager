﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventLogManager {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ResponseString {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResponseString() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EventLogManager.ResponseString", typeof(ResponseString).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event Log {0} does not exist..
        /// </summary>
        public static string EventLogDoesNotExist {
            get {
                return ResourceManager.GetString("EventLogDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event Source {0} already exists..
        /// </summary>
        public static string EventSourceAlreadyExists {
            get {
                return ResourceManager.GetString("EventSourceAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event Source {0} created in {1} Event Log..
        /// </summary>
        public static string EventSourceCreated {
            get {
                return ResourceManager.GetString("EventSourceCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing arguments for command {0}.
        ///Type &apos;Help&apos; for help.
        /// </summary>
        public static string MissingArgument {
            get {
                return ResourceManager.GetString("MissingArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown command {0}.
        ///Type &apos;Help&apos; for help..
        /// </summary>
        public static string UnknownCommand {
            get {
                return ResourceManager.GetString("UnknownCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Manage Event Logs and Event Sources.
        ///
        ///Commands:
        ///List - List existing event logs on computer
        ///List &quot;event log name&quot; - List event sources for event log
        ///CreateSource &quot;NewEventSourceName&quot; &quot;TargetEventLog&quot; - Create new event source in event log.
        /// </summary>
        public static string UseageStatement {
            get {
                return ResourceManager.GetString("UseageStatement", resourceCulture);
            }
        }
    }
}
