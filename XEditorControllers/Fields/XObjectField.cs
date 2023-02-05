using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XObjectField : XBaseFieldController<UnityEngine.Object>
    {
        private Type m_ObjectType;
        private bool m_AllowSceneObject;
        public XObjectField(Type inObjectType, bool inAllowSceneObject, EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override UnityEngine.Object OnPaint(string inTitle, UnityEngine.Object inValue)
        {
            return EditorGUILayout.ObjectField(inTitle, inValue, m_ObjectType, m_AllowSceneObject);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}