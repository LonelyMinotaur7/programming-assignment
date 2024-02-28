using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


// this script handles the timer

public class TimerScript : MonoBehaviour
{
    public float TimeLeft = 30;
    public bool TimerOn = false;

    public Text TimerTxt;
   
    void Start()
    {
        TimerOn = true;
    }

    void Update()
    {
        if(TimerOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                SceneManager.LoadScene(2);
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
