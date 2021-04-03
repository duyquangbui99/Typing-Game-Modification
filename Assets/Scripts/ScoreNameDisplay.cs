using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreNameDisplay : MonoBehaviour
{
    public Text displayName;

    public Text displayScore;

    public Text displayLive;
    private void Update()
    {
        displayName.text = SaveData.playerName;

        displayScore.text = "Score: " + SaveData.score;

        displayLive.text = "Live: " + SaveData.live;
    }
}
