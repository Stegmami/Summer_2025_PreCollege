using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public int CurrentScore;
    public int ValueOfAHit;
    public TMP_Text ScoreValue_Text;

    /// <summary>
    ///  Adds ValueOfAHit to CurrentScore and updates the ScoreValue in the UI
    /// </summary>
    public void AddOneHitToScore()
    {
        // Assign Current Score a new value.  
        CurrentScore = CurrentScore + ValueOfAHit;

        // Assign the value
        ScoreValue_Text.text = CurrentScore.ToString();
    }

}
