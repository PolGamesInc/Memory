using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerHard : MonoBehaviour
{
    [SerializeField] private float Timer = 120f;
    [SerializeField] private Text[] timerText;
    [SerializeField] private string LoseScene = "YouLose";

    private void Update()
    {
        for (int i = 0; i < timerText.Length; i++)
        {
            timerText[i].text = Timer.ToString();
        }

        if(Timer == 0)
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
            Timer--;
        }
    }
}
