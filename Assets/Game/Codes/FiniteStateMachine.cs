using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dante.DungeonCrawler
{
    #region Enums
    public enum States { 
        //IDLE
        IDLE_DOWN, 
        IDLE_UP, 
        IDLE_RIGHT, 
        IDLE_LEFT,
        //MOVING
        MOVING_DOWN,
        MOVING_UP,
        MOVING_RIGHT,
        MOVING_LEFT,
    }
    #endregion

    #region Structs

    #endregion


    [RequireComponent(typeof(Rigidbody2D))]
    public class FiniteStateMachine : MonoBehaviour
    {
        #region Knobs


        #endregion

        #region References
        #endregion

        #region RuntimeVariables

        protected States _state;
        
        #endregion

        #region LocalMethods

        protected void InitializeFSM()
        {

        }

        #endregion

        #region UnityMethods

        void Start()
        {
             InitializeFSM();
        }

        void Update()
        {

        }

        private void FixedUpdate()
        {
            //_rigidbody2D.velocity = Vector3.right;  
        }

        #endregion

        #region PublicMethods

        #endregion

        #region GettersSetters

        #endregion

    }
}
