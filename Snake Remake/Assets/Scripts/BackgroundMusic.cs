using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource bmusic;
    private IEnumerator coroutine;


    private void Start()
    {
        bmusic = GetComponent<AudioSource>();
        bmusic.Play();
        coroutine = replayAudio(96f);
        StartCoroutine(coroutine);
        DontDestroyOnLoad(this);

    }

    private IEnumerator replayAudio(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        bmusic.Play();
    }
}
