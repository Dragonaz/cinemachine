using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;

public class CutsceneController : MonoBehaviour
{

    public PlayableDirector director;

    public PlayableAsset introTimeline;
    public PlayableAsset endingTimeline;



    bool playing = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        director.playableAsset = introTimeline;
        PlaycutScene();
        playing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            director.playableAsset = endingTimeline;
            PlaycutScene();
        }

    }


    public void PlaycutScene()
    {
        director.Play();
    }

    public void StopcutScene()
    {
        director.Pause();
    }
}
