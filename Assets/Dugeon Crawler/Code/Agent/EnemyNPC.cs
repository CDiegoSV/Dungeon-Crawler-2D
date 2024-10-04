using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dante.DungeonCrawler
{
    #region Enums

    public enum EnemyBehaviourState
    {
        PATROL, PERSECUTION
    }

    #endregion

    #region Structs

    #endregion

    public class EnemyNPC : Agent
    {
        #region Knobs

        public EnemyBehaviours_ScriptableObject scriptBehaviours;

        #endregion

        #region References

        #endregion

        #region RuntimeVariables

        protected EnemyBehaviourState _currentEnemyBehaviourState;
        protected EnemyBehaviour _currentEnemyBehaviour;
        protected int _currentEnemyBehaviourIndex;

        #endregion

        #region LocalMethods

        protected void InvokeStateMechanic()
        {
            switch(_currentEnemyBehaviour.type)
            {
                case EnemyBehaviourType.STOP:
                    _fsm.StateMechanic(StateMechanics.STOP);
                    break;
                case EnemyBehaviourType.FIRE:
                    break;
                case EnemyBehaviourType.MOVE_TO_RANDOM_DIRECTION:
                case EnemyBehaviourType.PERSECUTE_AVATAR:
                    _fsm.StateMechanic(StateMechanics.MOVE_RIGHT);
                    break;
            }
        }

        #endregion

        #region UnityMethods

        void Start()
        {
            InitializeAgent();
        }


        protected IEnumerator TimerForEnemyBehaviour()
        {

            yield return new WaitForSeconds(_currentEnemyBehaviour.time);
            GoToNextEnemyBehaviour();
        }

        protected void GoToNextEnemyBehaviour()
        {
            if(_currentEnemyBehaviourState == EnemyBehaviourState.PATROL)
            {
                if(_currentEnemyBehaviourIndex >= scriptBehaviours.patrolBehaviours.Length)
                {
                    _currentEnemyBehaviourIndex = 0;
                }
                _currentEnemyBehaviour = scriptBehaviours.patrolBehaviours[_currentEnemyBehaviourIndex];
            }
            else
            {
                if (_currentEnemyBehaviourIndex >= scriptBehaviours.persecutionBehaviours.Length)
                {
                    _currentEnemyBehaviourIndex = 0;
                }
                _currentEnemyBehaviour = scriptBehaviours.persecutionBehaviours[_currentEnemyBehaviourIndex];
            }
            InvokeStateMechanic();
            if (_currentEnemyBehaviour.time > 0)
            {
                StartCoroutine(TimerForEnemyBehaviour());
            }
        }

        #endregion

        #region PublicMethods

        public override void InitializeAgent()
        {
            _currentEnemyBehaviourState = EnemyBehaviourState.PATROL;
            _currentEnemyBehaviourIndex = 0;

            if (scriptBehaviours.patrolBehaviours.Length > 0)
            {
                _currentEnemyBehaviour = scriptBehaviours.patrolBehaviours[0];
            }
            else
            {
                _currentEnemyBehaviour.type = EnemyBehaviourType.STOP;
                _currentEnemyBehaviour.time = -1;
            }

            InvokeStateMechanic();
            if (_currentEnemyBehaviour.time > 0)
            {
                StartCoroutine(TimerForEnemyBehaviour());
            }
        }

        #endregion

        #region GettersSetters

        #endregion

    }
}
