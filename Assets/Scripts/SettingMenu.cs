using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer musicMixer;
    public AudioMixer soundMixer;

    public void SetMusic (float volume)
    {
        musicMixer.SetFloat("Volume", volume);
    }

    public void SetSound (float volume)
    {
        soundMixer.SetFloat("Volume", volume);
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
