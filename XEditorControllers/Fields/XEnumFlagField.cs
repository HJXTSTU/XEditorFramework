using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;
using XEditorFramework.XEditorControllers.Fields;

namespace EditorTest.Assets.Editor.XEditorFramework.XEditorControllers.Fields
{
    public abstract class XEnumFlagField<T> : XBaseFieldController<T> where T:Enum
    {
        private T m_Value;
        public XEnumFlagField(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override T OnPaint(string inTitle, T inValue)
        {
            m_Value = (T)EditorGUILayout.EnumFlagsField(inTitle, m_Value);
            return m_Value;
        }

        public override void OnPaint()
        {
            
        }
    }
}