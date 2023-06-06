using System.Collections;
using UnityEngine;

public class GameManagerBrown : MonoBehaviour
{
    [SerializeField] private GameObject BrownObject;

    [SerializeField] private Material BrownMaterial;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
        if (VariableKeeper.CountBrown == 2)
        {
            StartCoroutine(StartParticleBoom());
            BrownObject.GetComponent<Renderer>().material = BrownMaterial;
        }
    }

    private IEnumerator StartParticleBoom()
    {
        yield return new WaitForSeconds(0.5f);
        BrownObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
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