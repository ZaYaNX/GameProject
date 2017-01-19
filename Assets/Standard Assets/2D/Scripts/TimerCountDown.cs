using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCountDown : MonoBehaviour
{

    [SerializeField]
    float CountdownFrom;
    [SerializeField]
    Text CountdownText;

    void Start()
    {
        if (CountdownText == null)
        {
            Debug.LogError("STATUS INDICATOR: No text object referenced!");
        }
    }
    void Update()
    {
        float time = CountdownFrom - Time.timeSinceLevelLoad;
        CountdownText.text = "Timer: " + time.ToString("0") + "s";

        if (time <= 0f)
        {
            TimeUp();
        }
    }

    void TimeUp()
    {
        SceneManager.LoadScene(0);
    }
}