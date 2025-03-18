
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using System.Collections; // Ensure this is included for IEnumerator

public class JumpController : MonoBehaviour
{
    private Animator anim;
    private AudioSource audioSource;
    public VideoPlayer videoPlayer; // Assign your VideoPlayer in the Inspector
    public Button playButton; // Assign your UI Button in the Inspector

    void Start()
    {
        anim = GetComponent<Animator>();
        if (anim == null)
        {
            Debug.LogError("Animator component not found! Ensure your GameObject has an Animator component.");
        }

        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component not found! Ensure your GameObject has an AudioSource.");
        }

        if (playButton != null)
        {
            playButton.onClick.AddListener(PlayVideo);
        }
    }

    public void TriggerJump()
    {
        if (anim != null)
        {
            anim.SetTrigger("Jump");
        }

        StartCoroutine(PlaySoundWithDelay(0.5f)); // Adjust delay as needed
    }

    private IEnumerator PlaySoundWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogError("AudioSource or AudioClip is missing in JumpController.");
        }
    }

    public void PlayVideo()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Play();
        }
        else
        {
            Debug.LogError("Video Player is not assigned!");
        }
    }
}
