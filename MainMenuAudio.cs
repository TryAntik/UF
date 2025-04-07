using UnityEngine;

public class MainMenuAudio : MonoBehaviour {
    [SerializeField] private AudioSource audioSource;

    private void Play() => audioSource.Play();
}
