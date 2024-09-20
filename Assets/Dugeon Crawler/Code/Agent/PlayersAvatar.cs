using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Dante.DungeonCrawler
{
    #region Enums
    public enum PlayerIndexes
    {
        ONE,
        TWO,
        THREE,
        FOUR
    }
    #endregion

    #region Structs

    #endregion

    public class PlayersAvatar : Agent
    {
        #region Knobs
        public PlayerIndexes playerIndex;

        #endregion

        #region References

        #endregion

        #region RuntimeVariables

        protected Vector2 _movementInputVector;

        #endregion

        #region LocalMethods

        

        #endregion

        #region UnityMethods

        void Start()
        {
            InitializeAgent();
        }

        void Update()
        {

        }

        private void FixedUpdate()
        {
            _rigidbody2D.velocity = _movementInputVector;
        }

        #endregion

        #region PublicMethods

        public void OnMOVE(InputAction.CallbackContext value)
        {
            if (value.performed)
            {
                _rigidbody2D.velocity = value.ReadValue<Vector2>();
            }
            else if (value.canceled)
            {
                _rigidbody2D.velocity = Vector2.zero;
            }
        }

        public override void InitializeAgent()
        {
            base.InitializeAgent();
            _movementInputVector = Vector2.zero;
        }

        #endregion

        #region GettersSetters

        #endregion

    }
}
