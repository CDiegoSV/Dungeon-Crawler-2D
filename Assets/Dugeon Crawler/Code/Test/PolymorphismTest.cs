using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dante.DungeonCrawler;

public class PolymorphismTest : MonoBehaviour
{

    #region Knobs

    public Agent[] agentsInGame;

    #endregion

    #region Runtime Variables
    [SerializeField]
    int countAvatars;
    [SerializeField]
    int countEnemies;
    [SerializeField]
    int countDestroyableObjects;

    #endregion

    #region Unity Methods  

    private void Start()
    {
        ManageAgents();
    }

    #endregion

    #region Runtime Methods

    protected void ManageAgents()
    {
        foreach (Agent agent in agentsInGame)
        {
            if (agent as EnemyNPC)
            {
                EnemyNPC enemy = (EnemyNPC)agent;
                countEnemies++;
            }
            else if(agent as PlayersAvatar)
            {
                PlayersAvatar avatar = (PlayersAvatar)agent;
                countAvatars++;
            }
            else if(agent as DestroyableObjects)
            {
                DestroyableObjects destroyableObject = (DestroyableObjects)agent;
                countDestroyableObjects++;
            }
        }
    }

    #endregion
}
