using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNote : MonoBehaviour
{
    private float SpawnPos;
    private float RemovePos;

    private void Update()
    {
        //transform.position = Vector2.Lerp(SpawnPos, RemovePos, (BeatsShownInAdvance - (beatOfThisNote - songPosInBeats)) / BeatsShownInAdvance);
    }
}
