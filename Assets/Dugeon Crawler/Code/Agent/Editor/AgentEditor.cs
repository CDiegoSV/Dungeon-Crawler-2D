using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


namespace Dante.DungeonCrawler
{

    [CustomEditor(typeof(Agent))]
    public class AgentEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            if (GUILayout.Button("Get References"))
            {
                Agent agent = (Agent)target;
                agent.InitializeAgent();
            }
            if(GUILayout.Button("Deafult Position"))
            {
                Agent agent = (Agent)target;
                agent.transform.position = Vector3.zero;    
            }
        }
    }
}

