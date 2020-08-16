using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CenterCamera))]
public class CenterCameraEditor : Editor
{
  public override void OnInspectorGUI()
  {
    DrawDefaultInspector();
    CenterCamera cc = (CenterCamera)target;

    if (GUILayout.Button("Face Target"))
    {
      cc.Face();
    }
  }
}
