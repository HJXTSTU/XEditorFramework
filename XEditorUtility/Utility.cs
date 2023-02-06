using System.Diagnostics.Tracing;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XEditorFramework.Messages;
using XEditorFramework.XEditorAttributes;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorUtility
{
    public static class Utility
    {
        public static bool IsEventCallback(MethodInfo inMethodInfo)
        {
            if (2 != inMethodInfo.GetParameters().Length)
                return false;

            ParameterInfo[] inMethodParamInfos = inMethodInfo.GetParameters();
            if (typeof(EditorMessageParams) != inMethodParamInfos[1].ParameterType)
            {
                return false;
            }
            return true;
        }

        public static void BindEvents(object _this, EventChanel inEventChanel)
        {
            MethodInfo[] methods = _this.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public);
            foreach (MethodInfo method in methods)
            {
                Bind[] bindInfos = (Bind[])method.GetCustomAttributes<Bind>();
                foreach (Bind bindInfo in bindInfos)
                {
                    if (Utility.IsEventCallback(method))
                    {
                        if (bindInfo.BindingType == BindType.BIND_MODEL_EVENT)
                            inEventChanel.RegisterModelEvent(bindInfo.EventType, (Action<object, EditorMessageParams>)method.CreateDelegate(typeof(Action<object, EditorMessageParams>), _this));
                        else if (bindInfo.BindingType == BindType.BIND_VIEW_EVENT)
                            inEventChanel.RegisterViewEvent(bindInfo.EventType, (Action<object, EditorMessageParams>)method.CreateDelegate(typeof(Action<object, EditorMessageParams>), _this));
                    }
                }
            }
        }

        public static void UnBindEvents(object _this, EventChanel inEventChanel)
        {
            MethodInfo[] methods = _this.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public);
            foreach (MethodInfo method in methods)
            {
                Bind[] bindInfos = (Bind[])method.GetCustomAttributes<Bind>();
                foreach (Bind bindInfo in bindInfos)
                {
                    if (Utility.IsEventCallback(method))
                    {
                        if (bindInfo.BindingType == BindType.BIND_MODEL_EVENT)
                            inEventChanel.RemoveModelEvent(bindInfo.EventType, (Action<object, EditorMessageParams>)method.CreateDelegate(typeof(Action<object, EditorMessageParams>), _this));
                        else if (bindInfo.BindingType == BindType.BIND_VIEW_EVENT)
                            inEventChanel.RemoveViewEvent(bindInfo.EventType, (Action<object, EditorMessageParams>)method.CreateDelegate(typeof(Action<object, EditorMessageParams>), _this));
                    }
                }
            }
        }
    }
}