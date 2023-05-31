using System.Collections;
using UnityEngine;

public class GameManagerPink : MonoBehaviour
{
    [SerializeField] private GameObject PinkObject;

    [SerializeField] private Material PinkMaterial;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
        if (VariableKeeper.CountPink == 2)
        {
            StartCoroutine(StartParticleBoom());
            PinkObject.GetComponent<Renderer>().material = PinkMaterial;
        }
    }

    private IEnumerator StartParticleBoom()
    {
        yield return new WaitForSeconds(0.7f);
        PinkObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
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
