using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip[] audioes;
    public AudioSource backgroundAudio;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (backgroundAudio.isPlaying == false)
        {
            backgroundAudio.PlayOneShot(audioes[UnityEngine.Random.RandomRange(0, 4)]);
        }
    }
}
