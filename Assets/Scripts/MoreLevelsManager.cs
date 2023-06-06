using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoreLevelsManager : MonoBehaviour
{
    [SerializeField] private string[] Menu = {"Menu", "MenuTwo", "MenuThree"};

   public void GoMenuTwo()
   {
        SceneManager.LoadScene(Menu[1]);
   }

    public void GoMenuOne()
    {
        SceneManager.LoadScene(Menu[0]);
    }

    public void GoMenuThree()
    {
        SceneManager.LoadScene(Menu[2]);
    }
}
