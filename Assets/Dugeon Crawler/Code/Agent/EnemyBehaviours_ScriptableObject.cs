using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dante.DungeonCrawler
{
    //To store the interactive script of enemyNPC in order to simulate AI

    #region Enums

    public enum EnemyBehaviourType
    {
        STOP, MOVE_TO_RANDOM_DIRECTION, FIRE,  PERSECUTE_AVATAR
    }

    #endregion

    #region Structs

    [System.Serializable]
    public struct EnemyBehaviour
    {
        public EnemyBehaviourType type;
        public float speed;
        public float time;
    }

    #endregion

    [CreateAssetMenu(menuName = "Dungeon Crawler/New Enemy Behaviour")]
    public class EnemyBehaviours_ScriptableObject : ScriptableObject
    {
        [SerializeField] public EnemyBehaviour[] patrolBehaviours;

        [SerializeField] public EnemyBehaviour[] persecutionBehaviours;
    }
}