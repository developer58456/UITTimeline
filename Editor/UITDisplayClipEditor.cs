using UnityEditor;

namespace UITTimeline.Editor
{
    [CustomEditor(typeof(UITDisplayClip))]
    public class UITDisplayClipEditor : UnityEditor.Editor
    {
        private SerializedProperty displayOnStart;
        private SerializedProperty displayOnEnd;

        private void OnEnable()
        {
            displayOnStart = serializedObject.FindProperty("_template.DisplayOnStart");
            displayOnEnd = serializedObject.FindProperty("_template.DisplayOnEnd");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(displayOnStart);
            EditorGUILayout.PropertyField(displayOnEnd);
            serializedObject.ApplyModifiedProperties();
        }
    }
}