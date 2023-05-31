using System.Collections;
using UnityEngine;

public class GameManagerDarkGreen : MonoBehaviour
{
    [SerializeField] private GameObject DarkGreenObject;

    [SerializeField] private Material DarkGreenMaterial;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
        if (VariableKeeper.CountDarkGreen == 2)
        {
            StartCoroutine(StartParticleBoom());
            DarkGreenObject.GetComponent<Renderer>().material = DarkGreenMaterial;
        }
    }

    private IEnumerator StartParticleBoom()
    {
        yield return new WaitForSeconds(0.7f);
        DarkGreenObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
        gameObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
        for (int i = 0; i < CartoonBoom.Length; i++)
        {
            CartoonBoom[i].Play();
            Invoke("StopParticleBoom", 1f);
        }
    }

    private void StopParticleBoom()
    {
        for (int i = 0; i < CartoonBoom.Length; i++)
        {
            CartoonBoom[i].Stop();
        }
    }
}