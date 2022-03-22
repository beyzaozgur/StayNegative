using UnityEngine;

public class MyCharacterController : MonoBehaviour
{

    private Vector3 currentJumpVelocity;
    private bool isJumping;
    public float speed;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        Vector3 moveVelocity = Vector3.zero;

        moveVelocity.z = -Input.GetAxis("Horizontal");
        moveVelocity.x = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump"))
        {
            if (!isJumping)
            {
                isJumping = true;
                currentJumpVelocity = Vector3.up * 5;
            }
        }

        if (isJumping)
        {
            controller.Move((speed * moveVelocity + currentJumpVelocity) * Time.deltaTime);
            currentJumpVelocity += Physics.gravity * Time.deltaTime;
            if (controller.isGrounded)
            {
                isJumping = false;
            }
        } else
        {
            controller.SimpleMove(speed * moveVelocity);
        }

    }

}
