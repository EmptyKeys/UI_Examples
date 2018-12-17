// -----------------------------------------------------------
//  
//  This file was generated, please do not modify.
//  
// -----------------------------------------------------------
namespace EmptyKeys.UserInterface.Generated.Dictionary_Bindings {
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using EmptyKeys.UserInterface;
    using EmptyKeys.UserInterface.Charts;
    using EmptyKeys.UserInterface.Data;
    using EmptyKeys.UserInterface.Controls;
    using EmptyKeys.UserInterface.Controls.Primitives;
    using EmptyKeys.UserInterface.Input;
    using EmptyKeys.UserInterface.Interactions.Core;
    using EmptyKeys.UserInterface.Interactivity;
    using EmptyKeys.UserInterface.Media;
    using EmptyKeys.UserInterface.Media.Animation;
    using EmptyKeys.UserInterface.Media.Imaging;
    using EmptyKeys.UserInterface.Shapes;
    using EmptyKeys.UserInterface.Renderers;
    using EmptyKeys.UserInterface.Themes;
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "3.1.0.0")]
    public class CustomWindow_TextData_PropertyInfo : IPropertyInfo {
        
        public System.Type PropertyType {
            get {
                return typeof(string);
            }
        }
        
        public bool IsResolved {
            get {
                return true;
            }
        }
        
        public object GetValue(object obj) {
            return ((GameData.CustomWindow)(obj)).TextData;
        }
        
        public object GetValue(object obj, object[] index) {
            return null;
        }
        
        public void SetValue(object obj, object value) {
            ((GameData.CustomWindow)(obj)).TextData = ((string)(value));
        }
        
        public void SetValue(object obj, object value, object[] index) {
        }
    }
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "3.1.0.0")]
    public class CustomWindow_HideCommand_PropertyInfo : IPropertyInfo {
        
        public System.Type PropertyType {
            get {
                return typeof(EmptyKeys.UserInterface.Input.ICommand);
            }
        }
        
        public bool IsResolved {
            get {
                return true;
            }
        }
        
        public object GetValue(object obj) {
            return ((GameData.CustomWindow)(obj)).HideCommand;
        }
        
        public object GetValue(object obj, object[] index) {
            return null;
        }
        
        public void SetValue(object obj, object value) {
            ((GameData.CustomWindow)(obj)).HideCommand = ((EmptyKeys.UserInterface.Input.ICommand)(value));
        }
        
        public void SetValue(object obj, object value, object[] index) {
        }
    }
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "3.1.0.0")]
    public class DragDropItem_Name_PropertyInfo : IPropertyInfo {
        
        public System.Type PropertyType {
            get {
                return typeof(string);
            }
        }
        
        public bool IsResolved {
            get {
                return true;
            }
        }
        
        public object GetValue(object obj) {
            return ((GameData.DragDropItem)(obj)).Name;
        }
        
        public object GetValue(object obj, object[] index) {
            return null;
        }
        
        public void SetValue(object obj, object value) {
            ((GameData.DragDropItem)(obj)).Name = ((string)(value));
        }
        
        public void SetValue(object obj, object value, object[] index) {
        }
    }
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "3.1.0.0")]
    public class TestTreeDataItem_Name_PropertyInfo : IPropertyInfo {
        
        public System.Type PropertyType {
            get {
                return typeof(string);
            }
        }
        
        public bool IsResolved {
            get {
                return true;
            }
        }
        
        public object GetValue(object obj) {
            return ((GameData.TestTreeDataItem)(obj)).Name;
        }
        
        public object GetValue(object obj, object[] index) {
            return null;
        }
        
        public void SetValue(object obj, object value) {
            ((GameData.TestTreeDataItem)(obj)).Name = ((string)(value));
        }
        
        public void SetValue(object obj, object value, object[] index) {
        }
    }
}
