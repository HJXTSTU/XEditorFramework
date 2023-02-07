using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Buttons
{
    public delegate void ButtonClickCallBack(XButton inButton);

    public class XButton : BaseController
    {
        private event ButtonClickCallBack m_Callbacks;
        private string m_Label;
        private Func<bool> m_Predict;
        public XButton(string inLabel, EventChanel inEventChanel, Func<bool> inPredict) : base(inEventChanel)
        {
            m_Label = inLabel;
            m_Predict = inPredict;
        }

        public void AddListener(ButtonClickCallBack inClickCallBack)
        {
            m_Callbacks += inClickCallBack;
        }

        public void RemoveListener(ButtonClickCallBack inClickCallBack)
        {
            m_Callbacks -= inClickCallBack;
        }

        public void OnPaint(ButtonClickCallBack inClickCallBack)
        {
            if ((m_Predict == null || m_Predict()) && GUILayout.Button(new GUIContent(m_Label)))
            {
                inClickCallBack?.Invoke(this);
                m_Callbacks?.Invoke(this);
            }

        }


        public override void OnPaint()
        {

        }
    }
}
