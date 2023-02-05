using System;

namespace XEditorFramework.XEditorAttributes {
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class Property: Attribute {
        public string PropertyType{get;set;}
        public string Value{get;set;}
        
        public Property(string inType, string inValue) {
            PropertyType = inType;
            Value = inValue;
        }
    }
}