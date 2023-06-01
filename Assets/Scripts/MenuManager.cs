using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string NameScene = "HardLevel";

    public void LoadHardLevel()
    {
        SceneManager.LoadScene(NameScene);
    }
}
