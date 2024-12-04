using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 10f;
        public float strafeSpeed = 5f;
        public float jumpForce = 8f;
        private float gravity = -9.8f;
        private float verticalVelocity; // For jumping and falling
    
        private CharacterController controller;
    
        void Start()
        {
            controller = GetComponent<CharacterController>();
        }
    
        void Update()
        {
            // Forward movement
            Vector3 forwardMovement = transform.forward * forwardSpeed;
    
            // Left-Right movement
            float horizontalInput = Input.GetAxis("Horizontal");
            Vector3 strafeMovement = transform.right * horizontalInput * strafeSpeed;
    
            // Apply gravity
            if (controller.isGrounded)
            {
                verticalVelocity = 0; // Reset when grounded
    
                // Jump
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    verticalVelocity = jumpForce;
                }
            }
            verticalVelocity += gravity * Time.deltaTime; // Apply gravity over time
    
            // Combine movements
            Vector3 movement = forwardMovement + strafeMovement + Vector3.up * verticalVelocity;
            controller.Move(movement * Time.deltaTime);
        }
    }