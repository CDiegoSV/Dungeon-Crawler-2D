using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(AgentFactoryTest))]
public class AgentFactoryTest_Editor : Editor
{
    void OnInspectorGUI()
    {
        DrawDefaultInspector();
        if (GUILayout.Button("Generate Agents in this level"))
        {
            AgentFactoryTest script = (AgentFactoryTest)target;
        }
    }
    
}
