using System.Collections;
using UnityEngine;

public class GameManagerOrange : MonoBehaviour
{
    [SerializeField] private GameObject OrangeObject;

    [SerializeField] private Material OrangeMaterial;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
        if (VariableKeeper.CountOrange == 2)
        {
            StartCoroutine(StartParticleBoom());
            OrangeObject.GetComponent<Renderer>().material = OrangeMaterial;
        }
    }

    private IEnumerator StartParticleBoom()
    {
        yield return new WaitForSeconds(0.5f);
        OrangeObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
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