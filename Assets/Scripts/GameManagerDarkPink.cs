using System.Collections;
using UnityEngine;

public class GameManagerDarkPink : MonoBehaviour
{
    [SerializeField] private GameObject DarkPinkObject;

    [SerializeField] private Material DarkPinkMaterial;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
        if (VariableKeeper.CountDarkPink == 2)
        {
            StartCoroutine(StartParticleBoom());
            DarkPinkObject.GetComponent<Renderer>().material = DarkPinkMaterial;
        }
    }

    private IEnumerator StartParticleBoom()
    {
        yield return new WaitForSeconds(0.5f);
        DarkPinkObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
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