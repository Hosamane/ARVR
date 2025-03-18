using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    public Text timerDisplay;  // Assign in Inspector
    private float timeLeft = 300f; // 5 minutes

    void Update()
    {
        timeLeft -= Time.deltaTime;

        int minutes = Mathf.FloorToInt(timeLeft / 60);
        int seconds = Mathf.FloorToInt(timeLeft % 60);
        timerDisplay.text = "Time Left: " + minutes.ToString("00") + ":" + seconds.ToString("00");

        if (timeLeft <= 0)
        {
            timerDisplay.text = "Time's Up!";
            enabled = false; // Stop the script
        }
    }
}