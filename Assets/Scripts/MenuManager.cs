using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string HardLevel;
    [SerializeField] private string EasilyLevel;
    [SerializeField] private string NormalLevel;

    public void LoadHardLevel()
    {
        SceneManager.LoadScene(HardLevel);
    }

    public void LoadEasilyLevel()
    {
        SceneManager.LoadScene(EasilyLevel);
    }

    public void LoadNormalLevel()
    {
        SceneManager.LoadScene(NormalLevel);
    }
}
