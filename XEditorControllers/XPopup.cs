using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers
{
    public class XPopup: BaseController
    {
        private int m_Index;
        private string[] m_DisplayOptions;
        
        public int Index
        {
            get{ return m_Index; }
        }

        public string Option
        {
            get{return m_DisplayOptions[Index];}
        }
        
        public XPopup(string[] inDisplayOptions, EventChanel inEventChanel) : base(inEventChanel)
        {
            m_Index = 0;
            m_DisplayOptions = inDisplayOptions;
        }

        public override void OnPaint()
        {
            m_Index = EditorGUILayout.Popup(m_Index,m_DisplayOptions);
        }
    }
}