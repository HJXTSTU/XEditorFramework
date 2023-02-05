using System;
namespace XEditorFramework.Messages {
    public delegate void EventCallback(object inSender, EditorMessageParams inParams);
    public class EditorActionEvent {
        private event EventCallback m_Listeners;

        public void Send(object inSender, EditorMessageParams inParams) {
            m_Listeners?.Invoke(inSender, inParams);
        }

        public void AddListener(EventCallback inCallback) {
            m_Listeners += inCallback;
        }

        public void RemoveListeners(EventCallback inCallBack) {
            m_Listeners -= inCallBack;
        }
    }
}