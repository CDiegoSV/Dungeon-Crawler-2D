using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjectTest/New SOT List")]
public class ScriptableObjectListTest : ScriptableObject
{
    [SerializeField] public ScriptableObjectTest[] scriptableObjectList;
}
