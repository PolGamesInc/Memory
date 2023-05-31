using System.Collections;
using UnityEngine;

public class GameManagerYellow : MonoBehaviour
{
    [SerializeField] private GameObject YellowObject;

    [SerializeField] private Material YellowMaterial;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
        if (VariableKeeper.CountYellow == 2)
        {
            StartCoroutine(StartParticleBoom());
            YellowObject.GetComponent<Renderer>().material = YellowMaterial;
        }
    }

    private IEnumerator StartParticleBoom()
    {
        yield return new WaitForSeconds(0.7f);
        YellowObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
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
