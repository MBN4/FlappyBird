using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int plyerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void addScore() {
        plyerScore = plyerScore + 1;
        scoreText.text = plyerScore.ToString();


    }

}
