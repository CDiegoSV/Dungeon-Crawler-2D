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

        [SerializeField]
        protected int maxHealthPoints;

        #endregion

        #region References

        [SerializeField, HideInInspector]
        protected Rigidbody2D _rigidbody2D;

        [SerializeField, HideInInspector] protected FiniteStateMachine _fsm;

        #endregion

        #region RuntimeVariables

        #endregion

        #region LocalMethods

        

        #endregion

        #region UnityMethods

        void Start()
        {
             //InitializeAgent();
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

        public virtual void InitializeAgent()
        {
            //_rigidbody2D = GetComponent<Rigidbody2D>();
            //if (_rigidbody2D == null )
            //{
            //    Debug.LogError("Rigidbody has not been assigned to " + gameObject.name);
            //}
        }

        #endregion

        #region GettersSetters

        #endregion

    }
}
