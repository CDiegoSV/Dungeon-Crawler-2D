using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Dante.FSM
{
    #region Enum
    public enum PlayerIndex
    {
        ONE, TWO, THREE, FOUR
    }

    #endregion


    public class Avatar : MonoBehaviour
    {
        #region Knobs
        public PlayerIndex playerIndex;

        #endregion

        #region Runtime Variables
        protected Rigidbody _rb;
        protected Vector2 _moveDirection;

        #endregion

        #region Unity Methods
        void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            _rb.velocity = _moveDirection;
        }

        #endregion

        #region Public Methods
        public void OnMOVE(InputAction.CallbackContext value)
        {
            if(value.performed)
            {
                _moveDirection = value.ReadValue<Vector2>();
            }
            else if (value.canceled)
            {
                _moveDirection = Vector2.zero;
            }
        }

        #endregion
    }
}
