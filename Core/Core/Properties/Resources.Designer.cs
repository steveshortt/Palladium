﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Suplex.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Suplex.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to span.suplex body
        ///{
        ///	font-size: 10pt;
        ///	font-family: Verdana, Tahoma;
        ///}
        ///span.suplex .HeaderTitle
        ///{
        ///	background-color: #ff6600;
        ///	color: #ffff00;
        ///	font-weight: bolder;
        ///	font-size: 12pt;
        ///}
        ///span.suplex TABLE
        ///{
        ///	margin: 2px;
        ///	font-size: 10pt;
        ///	font-family: Verdana, Tahoma;
        ///	border-collapse: collapse;
        ///	width: 100%;
        ///}
        ///span.suplex TABLE.Inner
        ///{
        ///}
        ///span.suplex TABLE.tLevel0
        ///{
        ///	border: #000000 1px solid;
        ///	background-color: #dddddd;
        ///}
        ///span.suplex .Level0
        ///{
        ///	background-color: #000000;
        ///	color [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string diagsCSS {
            get {
                return ResourceManager.GetString("diagsCSS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; standalone=&quot;yes&quot;?&gt;
        ///&lt;xs:schema id=&quot;SuplexSecurity&quot; xmlns=&quot;&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot; xmlns:msdata=&quot;urn:schemas-microsoft-com:xml-msdata&quot;&gt;
        ///  &lt;xs:element name=&quot;SuplexSecurity&quot; msdata:IsDataSet=&quot;true&quot; msdata:UseCurrentLocale=&quot;true&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:choice minOccurs=&quot;0&quot; maxOccurs=&quot;unbounded&quot;&gt;
        ///        &lt;xs:element name=&quot;GroupMembership&quot;&gt;
        ///          &lt;xs:complexType&gt;
        ///            &lt;xs:sequence&gt;
        ///              &lt;xs:element name=&quot;SPLX_GROUP_ID&quot; msdata:DataType=&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SecuritySchema {
            get {
                return ResourceManager.GetString("SecuritySchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; standalone=&quot;yes&quot;?&gt;
        ///&lt;xs:schema id=&quot;SuplexValidation&quot; xmlns=&quot;&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot; xmlns:msdata=&quot;urn:schemas-microsoft-com:xml-msdata&quot;&gt;
        ///  &lt;xs:element name=&quot;SuplexValidation&quot; msdata:IsDataSet=&quot;true&quot; msdata:UseCurrentLocale=&quot;true&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:choice minOccurs=&quot;0&quot; maxOccurs=&quot;unbounded&quot;&gt;
        ///        &lt;xs:element name=&quot;UIElements&quot;&gt;
        ///          &lt;xs:complexType&gt;
        ///            &lt;xs:sequence&gt;
        ///              &lt;xs:element name=&quot;SPLX_UI_ELEMENT_ID&quot; msdata:DataTy [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ValidationSchema {
            get {
                return ResourceManager.GetString("ValidationSchema", resourceCulture);
            }
        }
    }
}
