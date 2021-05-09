using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Models;

namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D rigidBody;
        private float jumpForce = 400.0f;
        private float walkForce = 20.0f;
        private float maxWalkSpeed = 3.0f;

        // Start is called before the first frame update
        void Start()
        {
            rigidBody = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            ObserveAction();
        }

        private void ObserveAction()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Move(DirectionModel.Left);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Move(DirectionModel.Right);
            }
        }

        private void Jump()
        {
            rigidBody.AddForce(transform.up * jumpForce);
        }

        private void Move(DirectionModel direction)
        {
            int key = 0;
            if (direction == DirectionModel.Left)
            {
                key = -1;
            }
            if (direction == DirectionModel.Right)
            {
                key = 1;
            }
            if (key != 0)
            {
                transform.localScale = new Vector3(key, 1, 1);
            }

            float velocity = Mathf.Abs(rigidBody.velocity.x);
            if (velocity < maxWalkSpeed)
            {
                rigidBody.AddForce(transform.right * key * walkForce);
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            other.gameObject.SetActive(false);
        }
    }
}

