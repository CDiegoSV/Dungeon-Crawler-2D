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

    public enum StateMechanics
    {
        //STOP
        STOP,
        //MOVE
        MOVE_DOWN,
        MOVE_UP,
        MOVE_RIGHT,
        MOVE_LEFT,
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

        [SerializeField, HideInInspector] protected Animator _animator;

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


        #endregion

        #region PublicMethods

        public void StateMechanic(StateMechanics value)
        {
            _animator.SetBool(value.ToString(), true);
        }

        #endregion

        #region GettersSetters



        #endregion

    }
}
