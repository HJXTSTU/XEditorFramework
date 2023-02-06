using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers
{
    public class XMinMaxSlider : BaseController
    {
        public XMinMaxSlider(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public void OnPaint(string inTitile, ref float inMinValue, ref float inMaxValue, float inLeftLimit, float inRightLimit)
        {
            EditorGUILayout.MinMaxSlider(inTitile, ref inMinValue, ref inMaxValue, inLeftLimit, inRightLimit);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}