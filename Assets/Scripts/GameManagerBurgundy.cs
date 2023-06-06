using System.Collections;
using UnityEngine;

public class GameManagerBurgundy : MonoBehaviour
{
    [SerializeField] private GameObject BurgundyObject;

    [SerializeField] private Material BurgundyMaterial;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
        if (VariableKeeper.CountBurgundy == 2)
        {
            StartCoroutine(StartParticleBoom());
            BurgundyObject.GetComponent<Renderer>().material = BurgundyMaterial;
        }
    }

    private IEnumerator StartParticleBoom()
    {
        yield return new WaitForSeconds(0.5f);
        BurgundyObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
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
