using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 4f;
    [SerializeField]
    private float jumpForce = 6f;
    public GroundCheck groundCheck;
    private Rigidbody rb;

    float horizontal, vertical;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        if (Input.GetKey(KeyCode.Space) && groundCheck.isGrounded)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0));
        }

        Vector3 move = new Vector3(horizontal, 0, vertical);
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }

}
