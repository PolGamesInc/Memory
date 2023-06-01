using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class GoWinScene : MonoBehaviour
{
    [SerializeField] private List<GameObject> AllObject;
    [SerializeField] private float _target;

    private string NameScene = "YouWin";

    private void Update()
    {
        if (AllObject.All(obj => obj.transform.position.x.Equals(_target)))
        {
            SceneManager.LoadScene(NameScene);
        }
    }
}
