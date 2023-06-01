using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
    private string NameScene = "Menu";

    private void Start()
    {
        StartCoroutine(WaitRestartMenu());
    }

    private IEnumerator WaitRestartMenu()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(NameScene);
    }
}
