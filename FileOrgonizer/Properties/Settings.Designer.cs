﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileOrgonizer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\Public\\Pictures")]
        public string DestinationPath {
            get {
                return ((string)(this["DestinationPath"]));
            }
            set {
                this["DestinationPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\Public\\Desktop")]
        public string SourcePath {
            get {
                return ((string)(this["SourcePath"]));
            }
            set {
                this["SourcePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<YYYY>\\<MM>\\<DD>\\<YYYY><MM><DD>_<hh><mm><ss>.<ex>")]
        public string PatternMP4 {
            get {
                return ((string)(this["PatternMP4"]));
            }
            set {
                this["PatternMP4"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<YYYY>\\<MM>\\<DD>\\<YYYY><MM><DD>_<hh><mm><ss>.<ex>")]
        public string PatternJPG {
            get {
                return ((string)(this["PatternJPG"]));
            }
            set {
                this["PatternJPG"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<YYYY>-<MM>-<DD>\\<YYYY><TITLE>.<ex>")]
        public string PatternEML {
            get {
                return ((string)(this["PatternEML"]));
            }
            set {
                this["PatternEML"] = value;
            }
        }
    }
}
