﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBDiff.Schema.SQLServer.Generates.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("sa")]
        public string SQLServerUserOrigen {
            get {
                return ((string)(this["SQLServerUserOrigen"]));
            }
            set {
                this["SQLServerUserOrigen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("sa")]
        public string SQLServerUserDestino {
            get {
                return ((string)(this["SQLServerUserDestino"]));
            }
            set {
                this["SQLServerUserDestino"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int SQLServerConnectionTypeOrigen {
            get {
                return ((int)(this["SQLServerConnectionTypeOrigen"]));
            }
            set {
                this["SQLServerConnectionTypeOrigen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int SQLServerConnectionTypeDestino {
            get {
                return ((int)(this["SQLServerConnectionTypeDestino"]));
            }
            set {
                this["SQLServerConnectionTypeDestino"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SQLServerNameOrigen {
            get {
                return ((string)(this["SQLServerNameOrigen"]));
            }
            set {
                this["SQLServerNameOrigen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SQLServerNameDestino {
            get {
                return ((string)(this["SQLServerNameDestino"]));
            }
            set {
                this["SQLServerNameDestino"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int SQLServerDatabaseOrigen {
            get {
                return ((int)(this["SQLServerDatabaseOrigen"]));
            }
            set {
                this["SQLServerDatabaseOrigen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int SQLServerDatabaseDestino {
            get {
                return ((int)(this["SQLServerDatabaseDestino"]));
            }
            set {
                this["SQLServerDatabaseDestino"] = value;
            }
        }
    }
}
