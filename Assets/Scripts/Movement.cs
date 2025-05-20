using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float jumpForce = 8f;
    public int maxjumps = 2;
    public GroundCheck groundCheck;
    private Rigidbody rb;
    private int jumpCount = 0;
    [SerializeField] private GameObject playerbody;
    private Animator osake;
    float vertical;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        osake = playerbody.GetComponent<Animator>();
    }
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        FallAnimation();

        //check for jump input
        if (Input.GetKeyDown(KeyCode.Space)/* && groundCheck.isGrounded */)
        {
            if (jumpCount < maxjumps)
            {
                osake.SetBool("IsJumping", true);
                //if(jumpCount == 0)
                //{
                //    rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
                //}

                //if(jumpCount == 1)
                //{
                //    rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
                //}

                rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);

                jumpCount++;

                groundCheck.isGrounded = false;

            }
        }

        if (groundCheck.isGrounded)
        {
            jumpCount = 0;

            osake.SetBool("IsJumping", false);
        }


        //Vector3 move = new Vector3(horizontal, 0, vertical);
        //transform.Translate(move * moveSpeed * Time.deltaTime);
    }

    private void FallAnimation()
    {
        if (rb.linearVelocity.y < 0.1)
        {
            osake.SetFloat("Movement", -0.2f);
        }

        else if (rb.linearVelocity.y > 0.1)
        {
            osake.SetFloat("Movement", 0.2f);
        }

    }

}
