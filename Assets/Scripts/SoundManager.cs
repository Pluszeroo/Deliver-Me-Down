using UnityEngine;

public enum SoundType
{
    Jump,
    DoubleJump,
    Land,
    BackGround
}

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] soundList;
    private static SoundManager wasabi;
    private AudioSource audioSource;

    private void Awake()
    {
        wasabi = this;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public static void PlaySound(SoundType sound, float volume = 1.2f)
    {
        wasabi.audioSource.PlayOneShot(wasabi.soundList[(int)sound], volume);
    }
}

