using System;
namespace XEditorFramework.Messages {
    public delegate void EventCallback(object inSender, EditorMessageParams inParams);
    public class EditorActionEvent {
        //private event EventCallback m_Listeners;
        private event Action<object, EditorMessageParams> m_Listeners;

        public EditorActionEvent()
        {
        }

        public void Send(object inSender, EditorMessageParams inParams) {
            m_Listeners?.Invoke(inSender, inParams);
        }

        public void AddListener(Action<object,EditorMessageParams> inCallback) {
            m_Listeners += inCallback;
        }

        public void RemoveListeners(Action<object, EditorMessageParams> inCallback) {
            m_Listeners -= inCallback;
        }
    }
}