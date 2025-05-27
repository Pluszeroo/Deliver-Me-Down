using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    public bool hasWon;
    [SerializeField] GameObject winGameUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hasWon = true;
            Debug.Log("Has won");
        }

        winGameUI.SetActive(true);
        //*SceneManager.LoadScene("Wingame");*//
    }

}
