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

        public Rigidbody2D Rigidbody2D
        {
            get { return rigidBody2D; }
            protected set { rigidBody2D = value; }
        }

        private void OnMouseDown()
        {
            Rigidbody2D.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        }
    }
}
