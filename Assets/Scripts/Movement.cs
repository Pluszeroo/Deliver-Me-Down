using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 4f;
    [SerializeField]
    private float jumpForce = 6f;
    public int maxjumps = 2;
    public GroundCheck groundCheck;
    private Rigidbody rb;
    private int jumpCount = 0;

    float horizontal, vertical;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        //check for jump input
        if (Input.GetKeyDown(KeyCode.Space)/* && groundCheck.isGrounded */)
        {
            if(jumpCount < maxjumps)
            {
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

            }
        }

        if (groundCheck.isGrounded)
        {
            jumpCount = 0;
        }

        Vector3 move = new Vector3(horizontal, 0, vertical);
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }

}
