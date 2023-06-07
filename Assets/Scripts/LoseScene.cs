using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseScene : MonoBehaviour
{
    private float TimeExit = 5;

    [SerializeField] private string MenuScene = "Menu";
    [SerializeField] private Text TimerExitText;

    private void Start()
    {
        StartCoroutine(subtractTimer());
    }

    private void Update()
    {
        TimerExitText.text = TimeExit.ToString();
        if(TimeExit == 0)
        {
            SceneManager.LoadScene(MenuScene);
        }
    }

    private IEnumerator subtractTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            TimeExit--;
        }
    }
}
