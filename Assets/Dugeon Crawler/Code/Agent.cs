using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dante.DungeonCrawler
{
    #region Enums

    #endregion

    #region Structs

    #endregion


    [RequireComponent(typeof(Rigidbody2D))]
    public class Agent : MonoBehaviour
    {
        #region Knobs


        #endregion

        #region References
        protected Rigidbody2D _rigidbody2D;
        #endregion

        #region RuntimeVariables

        #endregion

        #region LocalMethods

        protected virtual void InitializeAgent()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

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
            //_rigidbody2D.velocity = Vector3.right;  
        }

        #endregion

        #region PublicMethods

        #endregion

        #region GettersSetters

        #endregion

    }
}
