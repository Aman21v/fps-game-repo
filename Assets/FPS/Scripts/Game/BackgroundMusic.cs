
using UnityEngine;

namespace Unity.FPS.Game
{
    public class BackgroundMusic : MonoBehaviour
    {
        public AudioClip backgroundMusic;
        private AudioSource audioSource;

        void Start()
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = backgroundMusic;
            audioSource.loop = true;
            audioSource.playOnAwake = true;
            audioSource.volume = 0.5f; // Adjust volume as needed
            audioSource.Play();

            DontDestroyOnLoad(gameObject);
        }
    }
}
