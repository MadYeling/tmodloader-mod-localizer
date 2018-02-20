﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mod.Localizer.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Mod.Localizer.Resources.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Exception occurred when dumping {0}.
        /// </summary>
        internal static string DumpExceptionOccur {
            get {
                return ResourceManager.GetString("DumpExceptionOccur", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid content item encountered: cannot find type &quot;{0}&quot;.
        /// </summary>
        internal static string InvalidContent {
            get {
                return ResourceManager.GetString("InvalidContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default: Chinese. Wrong language inputted may cause mod loading FAILURE!!.
        /// </summary>
        internal static string LanguageDesc {
            get {
                return ResourceManager.GetString("LanguageDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please specify the mod file to be processed..
        /// </summary>
        internal static string NoFileSpecified {
            get {
                return ResourceManager.GetString("NoFileSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please specify the content folder for mod patching..
        /// </summary>
        internal static string NoSourceFolderSpecified {
            get {
                return ResourceManager.GetString("NoSourceFolderSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception occurred when patching {0}.
        /// </summary>
        internal static string PatchExceptionOccur {
            get {
                return ResourceManager.GetString("PatchExceptionOccur", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path.
        /// </summary>
        internal static string PathArgumentName {
            get {
                return ResourceManager.GetString("PathArgumentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The location of mod to be patched OR dumped.
        /// </summary>
        internal static string PathDesc {
            get {
                return ResourceManager.GetString("PathDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set program mode: DUMP mod content or PATCH content to mod.
        /// </summary>
        internal static string ProgramModeDesc {
            get {
                return ResourceManager.GetString("ProgramModeDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set the folder of localized content for PATCHING mod.
        /// </summary>
        internal static string SourceFolderDesc {
            get {
                return ResourceManager.GetString("SourceFolderDesc", resourceCulture);
            }
        }
    }
}
