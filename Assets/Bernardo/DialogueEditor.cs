using UnityEngine;
using UnityEditor;


namespace DialogueSystemCollection
{
    [CustomEditor(typeof(Dialogue))]
    public class DialogueEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            Dialogue ds = (Dialogue)target;
            if (GUILayout.Button("Send Dialogue to DialogueSystem"))
            {

                DialogueSystem._instance.Dialogue(ds);
            }
        }
    }
}
