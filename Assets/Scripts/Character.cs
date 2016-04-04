using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public class Character : MonoBehaviour
    {
        public float health;
        public float startHealth = 100.0f;
        public float speed = 2.0f;

        public enum PlayerType
        {
            Player1,
            Player2
        }

        public PlayerType PlayerNumber;


        void Start()
        {
            health = startHealth;
        }

        void Update()
        {
            float horizontalMove;
            float verticalMove;

            switch (PlayerNumber)
            {
                case PlayerType.Player1:
                    horizontalMove = Input.GetAxis("Horizontal");
                    verticalMove = Input.GetAxis("Vertical");
                    break;
                case PlayerType.Player2:
                    horizontalMove = Input.GetAxis("Horizontal2");
                    verticalMove = Input.GetAxis("Vertical2");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Vector3 delta = new Vector3(horizontalMove, 0.0f, verticalMove)*speed;
            Vector3 newPos = transform.position += delta*Time.deltaTime;

            transform.position = newPos;
        }
    }
}
