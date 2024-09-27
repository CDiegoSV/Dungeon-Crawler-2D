using System.Collections;
using System.Collections.Generic;
using UnityEngine;


#region Structs

[System.Serializable]
public struct CharacterProperties
{
    [Header("Base Character Definition")]
    [SerializeField] public string name;
    [SerializeField] public int maxHealth;
    [SerializeField] public int currentHealth;
    [SerializeField] public Vector2 spawnPosition;
    [Header("Referenced Assets")]
    [SerializeField] public Sprite characterSprite;
    [SerializeField] public GameObject prefabAgent;
}

#endregion

[CreateAssetMenu(menuName = "ScriptableObjectTest/New SOT")]
public class ScriptableObjectTest : ScriptableObject
{
    [SerializeField] CharacterProperties characterProperties;
}
