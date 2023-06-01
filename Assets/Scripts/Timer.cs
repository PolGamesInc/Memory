using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private float TimerGame;
    [SerializeField] private Text[] timerText;

    private string LoseScene = "YouLose";

    private void Update()
    {
        for (int i = 0; i < timerText.Length; i++)
        {
            timerText[i].text = TimerGame.ToString();
        }

        if(TimerGame == 0)
        {
            SceneManager.LoadScene(LoseScene);
        }
    }

    private void Start()
    {
        StartCoroutine(subtractTimer());
    }

    private IEnumerator subtractTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            TimerGame--;
        }
    }
}
