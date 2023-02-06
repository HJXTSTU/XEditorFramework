using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers
{
    public class XEnumPopup<T> : BaseController where T : Enum
    {
        private T m_Value;
        public T EnumFlag
        {
            get { return m_Value; }
        }

        public XEnumPopup(EventChanel inEventChanel): base(inEventChanel) 
        {
                
        }

        public override void OnPaint() 
        {
            m_Value = (T)EditorGUILayout.EnumPopup(m_Value);
        }
    }
}
