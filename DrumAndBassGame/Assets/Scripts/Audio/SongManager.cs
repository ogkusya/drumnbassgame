using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SongManager : MonoBehaviour
{
    [SerializeField] private float bpm;
    [SerializeField] private float[] notes;

    private int nextIndex = 0;

    private AudioSource audioSource;
    private float songPosition;
    private float songPosInBeats;
    private float secPerBeat;
    private float dspTimeSong;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        secPerBeat = 60f / bpm;
        dspTimeSong = (float)AudioSettings.dspTime;
        audioSource.Play();
    }

    // Update is called once per frame
    private void Update()
    {
        songPosition = (float)(AudioSettings.dspTime - dspTimeSong);
        songPosInBeats = songPosition / secPerBeat;

        if (nextIndex < notes.Length && notes[nextIndex] < songPosInBeats)
        {
            //Instantiate( /* ןנופאב םמעû */ );
            nextIndex++;
        }
    }
}
