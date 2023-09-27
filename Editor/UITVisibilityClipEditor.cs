using UnityEditor;

namespace UITTimeline.Editor
{
    [CustomEditor(typeof(UITVisibilityClip))]
    public class UITVisibilityClipEditor : UnityEditor.Editor
    {
        private SerializedProperty visibleOnStart;
        private SerializedProperty visibleOnEnd;

        private void OnEnable()
        {
            visibleOnStart = serializedObject.FindProperty("_template.VisibleOnStart");
            visibleOnEnd = serializedObject.FindProperty("_template.VisibleOnEnd");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(visibleOnStart);
            EditorGUILayout.PropertyField(visibleOnEnd);
            serializedObject.ApplyModifiedProperties();
        }
    }
}