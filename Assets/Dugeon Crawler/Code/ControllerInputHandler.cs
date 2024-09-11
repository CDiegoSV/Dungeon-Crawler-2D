using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Dante.DungeonCrawler
{
    public class ControllerInputHandler : MonoBehaviour
    {
        #region Runtime Variables
        protected PlayerInput _playerInput;
        protected PlayersAvatar[] _allAvatars;
        protected PlayersAvatar _avatar;
        #endregion
        #region Unity Methods

        void Start()
        {
            _playerInput = GetComponent<PlayerInput>();
            _allAvatars = GameObject.FindObjectsOfType<PlayersAvatar>(true);
            foreach (PlayersAvatar avatar in _allAvatars)
            {
                if ((int)avatar.playerIndex == _playerInput.playerIndex)
                {
                    _avatar = avatar;
                    _avatar.gameObject.SetActive(true);
                }
            }
        }

        #endregion

        #region Input Callback Methods

        public void OnMOVE(InputAction.CallbackContext value)
        {
            _avatar.OnMOVE(value);
        }

        #endregion
    }
}

