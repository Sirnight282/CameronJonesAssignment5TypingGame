using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{
    private void Awake()
    {
        //reset variables
        Score.score = 0;
        WordDisplay.Multiplier = 1;
        WordTimer.wordDelay = 1.5f;
        WordTimer.nextWordTime = 0f;
    }
}
