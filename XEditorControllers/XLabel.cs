using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers
{
    public class XLabel:BaseController
    {
        public XLabel(EventChanel inEventChanel):base(inEventChanel)
        {
        }

        public void OnPaint(string inLabel){
            GUILayout.Label(inLabel);
        }

        public override void OnPaint()
        {

        }
    }
}