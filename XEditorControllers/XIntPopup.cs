using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers
{
    public class XIntPopup : BaseController
    {
        private string[] m_DisplayNames;
        private int[] m_Values;
        private int m_SelectedValue;
        public int SelectedValue{
            get{
                return m_SelectedValue;
            }
        }
        public XIntPopup(string[] inDisplayNames, int[] inValues, EventChanel inEventChanel) : base(inEventChanel)
        {
            m_DisplayNames = new string[inDisplayNames.Length];
            Array.Copy(inDisplayNames, m_DisplayNames, inDisplayNames.Length);
            m_Values = new int[inValues.Length];
            Array.Copy(inValues, m_Values, inValues.Length);

            if(m_Values.Length>0)
            {
                m_SelectedValue = m_Values[0];
            }else
            {
                m_SelectedValue = 0;
            }
        }

        public override void OnPaint()
        {
            m_SelectedValue = EditorGUILayout.IntPopup(m_SelectedValue, m_DisplayNames, m_Values);
        }
    }
}