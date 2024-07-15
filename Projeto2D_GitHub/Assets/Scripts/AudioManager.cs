using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;

    [SerializeField] private AudioClip background;
    [SerializeField] private AudioClip closeBook;
    [SerializeField] private AudioClip closeLetter;
    [SerializeField] private AudioClip openBook;
    [SerializeField] private AudioClip openLetter;
    [SerializeField] private AudioClip openDoor;
    [SerializeField] private AudioClip ladder;
    [SerializeField] private AudioClip openBookshelf;
    [SerializeField] private AudioClip closeBookshelf;



    public static AudioManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();    
    }

    public void PlayCloseLetter()
    {
        sfxSource.PlayOneShot(closeLetter);
    }

    public void PlayCloseBook()
    {
        sfxSource.PlayOneShot(closeBook);
    }

    public void PlayOpenLetter()
    {
        sfxSource.PlayOneShot(openLetter);
    }

    public void PlayOpenBook()
    {
        sfxSource.PlayOneShot(openBook);
    }

    public void PlayOpenDoor()
    {
        sfxSource.PlayOneShot(openDoor);
    }

    public void PlayLadder()
    {
        sfxSource.PlayOneShot(ladder);  
    }

    public void PlayOpenBookshelf()
    {
        sfxSource.PlayOneShot(openBookshelf);
    }

    public void PlayCloseBookshelf()
    {
        sfxSource.PlayOneShot(closeBookshelf);
    }

}
    