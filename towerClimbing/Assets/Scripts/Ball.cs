using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.Scripts
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(CircleCollider2D))]
    [RequireComponent(typeof(SpriteRenderer))]
    public class Ball : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D rigidBody2D;

        private bool OnGround
        {
            get;set;
        }

        private void Awake()
        {
            OnGround = false;
        }

        public Rigidbody2D Rigidbody2D
        {
            get { return rigidBody2D; }
            protected set { rigidBody2D = value; }
        }

        private void OnMouseDown()
        {
            Rigidbody2D.AddForce(new Vector2(OnGround? 3:0, 5), ForceMode2D.Impulse);
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            OnGround = false;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            OnGround = true;
        }
    }
}
