using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XMaskField : XBaseFieldController<int>
    {
        public string[] m_DisplayedOptions;
        public XMaskField(string[] inDisplayedOptions, EventChanel inEventChanel) : base(inEventChanel)
        {
            m_DisplayedOptions = inDisplayedOptions;
        }

        public override int OnPaint(string inTitle, int inValue)
        {
            return EditorGUILayout.MaskField(inTitle, inValue,m_DisplayedOptions);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}