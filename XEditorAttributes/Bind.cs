using System;
namespace XEditorFramework.XEditorAttributes 
{
    public enum BindType{
        BIND_MODEL_EVENT,
        BIND_VIEW_EVENT
    }

    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public class Bind: Attribute {
        public string EventType{get;set;}
        public BindType BindingType{get;set;}
        public Bind(string inEventType, BindType inBindType) {
            EventType = inEventType;
            BindingType = inBindType;
        }
    }
}