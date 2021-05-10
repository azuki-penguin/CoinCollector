using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Models;

namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Animator Animator;
        private Rigidbody2D rigidBody;
        private float jumpForce = 400.0f;
        private float walkForce = 20.0f;
        private float maxWalkSpeed = 3.0f;
        private GameObject ScoreManager;

        private bool HasReachedLeftMost =>
            transform.position.x < Camera.main.ScreenToWorldPoint(Vector3.zero).x;
        private bool HasReachedRightMost =>
            transform.position.x > Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;

        // Start is called before the first frame update
        void Start()
        {
            rigidBody = GetComponent<Rigidbody2D>();
            Animator = GetComponent<Animator>();
            ScoreManager = GameObject.Find("ScoreManager");
        }

        // Update is called once per frame
        void Update()
        {
           ObserveAction();
        }

        private void ObserveAction()
        {
            if (Input.GetKeyDown(KeyCode.Space) && rigidBody.velocity.y == 0)
            {
                Jump();
            }

            if (HasReachedLeftMost || HasReachedRightMost)
            {
                Stop();
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Animator.SetTrigger("WalkTrigger");
                if (!HasReachedLeftMost)
                {
                    Move(DirectionModel.Left);
                }
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Animator.SetTrigger("WalkTrigger");
                if (!HasReachedRightMost)
                {
                    Move(DirectionModel.Right);
                }
            }
            if (rigidBody.velocity.x == 0
              && !Input.GetKey(KeyCode.LeftArrow)
              && !Input.GetKey(KeyCode.RightArrow))
            {
                Animator.SetTrigger("IdleTrigger");
            }
        }

        private void Jump()
        {
            rigidBody.AddForce(transform.up * jumpForce);
        }

        private void Move(DirectionModel direction)
        {
            var key = 0;
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

            var velocity = Mathf.Abs(rigidBody.velocity.x);
            if (velocity < maxWalkSpeed)
            {
                rigidBody.AddForce(transform.right * key * walkForce);
            }
        }

        private void Stop()
        {
             rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            other.gameObject.SetActive(false);
            ScoreManager.GetComponent<ScoreManager>().AddPoint();
        }
    }
}

