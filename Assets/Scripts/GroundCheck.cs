using Unity.VisualScripting;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGrounded;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            SoundManager.PlaySound(SoundType.Land);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }

    }


}
