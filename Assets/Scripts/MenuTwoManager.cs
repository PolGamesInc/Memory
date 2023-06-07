using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTwoManager : MonoBehaviour
{
    private string HardLevel = "HardLevelTwo";
    private string EasilyLevel = "EasilyLevelTwo";
    private string NormalLevel = "NormalLevelTwo";

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
