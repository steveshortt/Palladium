﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfRowLevelSecurityAdmin.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WpfRowLevelSecurityAdmin.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to USE [Suplex_Example]
        ///GO
        ////****** Object:  ForeignKey [FK_FooData_FooLookup]    Script Date: 11/07/2012 19:01:19 ******/
        ///ALTER TABLE [dbo].[FooData] DROP CONSTRAINT [FK_FooData_FooLookup]
        ///GO
        ////****** Object:  StoredProcedure [dbo].[del_foodata_trunc]    Script Date: 11/07/2012 19:01:20 ******/
        ///DROP PROCEDURE [dbo].[del_foodata_trunc]
        ///GO
        ////****** Object:  StoredProcedure [dbo].[ins_foodata]    Script Date: 11/07/2012 19:01:20 ******/
        ///DROP PROCEDURE [dbo].[ins_foodata]
        ///GO
        ////****** Object:  StoredProcedu [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ddl {
            get {
                return ResourceManager.GetString("ddl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT	C.COLUMN_NAME
        ///		,C.DATA_TYPE
        ///		,C.CHARACTER_MAXIMUM_LENGTH
        ///		,C.IS_NULLABLE
        ///		,PKL.CONSTRAINT_TYPE
        ///  FROM INFORMATION_SCHEMA.COLUMNS	C
        ///  LEFT OUTER JOIN
        ///                  (SELECT     TC.CONSTRAINT_NAME, TC.CONSTRAINT_TYPE, KCU.COLUMN_NAME, 1 IS_PRIMARY_KEY
        ///	  FROM	INFORMATION_SCHEMA.TABLE_CONSTRAINTS TC 
        ///	 INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU 
        ///	        ON	TC.CONSTRAINT_NAME = KCU.CONSTRAINT_NAME
        ///	     AND	TC.TABLE_CATALOG  = KCU.TABLE_CATALOG
        ///	     AND	TC.CONSTRAINT_SCHEMA = [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tableInfo {
            get {
                return ResourceManager.GetString("tableInfo", resourceCulture);
            }
        }
    }
}
