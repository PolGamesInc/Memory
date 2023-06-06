using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinScene : MonoBehaviour
{
    private string NameScene = "Menu";
    private float TimeExit = 5;

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
            SceneManager.LoadScene(NameScene);
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
