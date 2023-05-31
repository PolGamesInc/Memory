using System.Collections;
using UnityEngine;

public class GameManagerLightBlue : MonoBehaviour
{
    [SerializeField] private GameObject LightBlueObject;

    [SerializeField] private Material LightBlueMaterial;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
        if (VariableKeeper.CountLightBlue == 2)
        {
            StartCoroutine(StartParticleBoom());
            LightBlueObject.GetComponent<Renderer>().material = LightBlueMaterial;
        }
    }

    private IEnumerator StartParticleBoom()
    {
        yield return new WaitForSeconds(0.7f);
        LightBlueObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
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
