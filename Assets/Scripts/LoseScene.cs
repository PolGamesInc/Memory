using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScene : MonoBehaviour
{
    [SerializeField] private string MenuScene = "Menu";

    private void Start()
    {
        StartCoroutine(WaitRestartMenu());
    }

    private IEnumerator WaitRestartMenu()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(MenuScene);
    }
}
