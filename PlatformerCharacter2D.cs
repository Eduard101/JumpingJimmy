using UnityEngine;

namespace UnitySampleAssets._2D
{

    public class PlatformerCharacter2D : MonoBehaviour
    {
        private bool facingRight = true; // For determining which way the player is currently facing.

        [SerializeField] private float maxSpeed = 10f; // The fastest the player can travel in the x axis.
        [SerializeField] private float jumpForce = 400f; // Amount of force added when the player jumps.	

        [Range(0, 1)] [SerializeField] private float crouchSpeed = .36f;
                                                     // Amount of maxSpeed applied to crouching movement. 1 = 100%

        [SerializeField] private bool airControl = false; // Whether or not a player can steer while jumping;
        [SerializeField] private LayerMask whatIsGround; // A mask determining what is ground to the character

        private Transform groundCheck; // A position marking where to check if the player is grounded.
        private float groundedRadius = .2f; // Radius of the overlap circle to determine if grounded
        private bool grounded = false; // Whether or not the player is grounded.
        private Transform ceilingCheck; // A position marking where to check for ceilings
        private float ceilingRadius = .01f; // Radius of the overlap circle to determine if the player can stand up
        private Animator anim; // Reference to the player's animator component.

		bool doubleJump = false;
		private int jumpCounter = 0;

        private void Awake()
        {
            // Setting up references.
            groundCheck = transform.Find("GroundCheck");
            ceilingCheck = transform.Find("CeilingCheck");
            anim = GetComponent<Animator>();
        }

		private bool isGrounded;
		
		void OnCollisionStay(Collision coll){
			isGrounded = true;
		}
		void OnCollisionExit(Collision coll){
			if(isGrounded){
				isGrounded = false;   
			}
		}

        private void FixedUpdate()
        {
            
            grounded = Physics2D.OverlapCircle(groundCheck.position, groundedRadius, whatIsGround);
            anim.SetBool("ground", grounded);
			if (grounded)
								doubleJump = false;
        }


        public void Move(float move, bool crouch, bool jump)
        {

			  if (grounded || airControl)
            {
        
                move = (crouch ? move*crouchSpeed : move);

               

                rigidbody2D.velocity = new Vector2(move*maxSpeed, rigidbody2D.velocity.y);

                
                if (move > 0 && !facingRight)
                    // ... flip the player.
                    Flip();
                    // Otherwise if the input is moving the player left and the player is facing right...
                else if (move < 0 && facingRight)
                    // ... flip the player.
                    Flip();
            }
            // If the player should jump...

			if(grounded && jumpCounter != 0){
				
				jumpCounter = 0;
			}
			
			 
			if ((grounded && jump) || (!grounded && jumpCounter < 1 && jump)) { 
				
										anim.SetBool ("Ground", false);
										rigidbody2D.AddForce (new Vector2 (0f, jumpForce));
										grounded = false;
										jumpCounter += 1;
								} 

						


        }


        private void Flip()
        {
           
            facingRight = !facingRight;

           
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}