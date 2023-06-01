using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private string HardLevel = "HardLevel";
    private string EasilyLevel = "EasilyLevel";
    private string NormalLevel = "NormalLevel";

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
