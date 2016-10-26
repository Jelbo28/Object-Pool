using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    [SerializeField]
    Text score;

    float scoreInt = 0;

    public static GM instance = null;

    public void UpdateScore(float value)
    {
        scoreInt = scoreInt + value;
        score.text = "Items Destroyed: " + scoreInt;
    }
}
