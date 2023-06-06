using System.Collections;
using UnityEngine;

public class GameManagerLightGreen : MonoBehaviour
{
    [SerializeField] private GameObject LightGreenObject;

    [SerializeField] private Material LightGreenMaterial;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
        if (VariableKeeper.CountLightGreen == 2)
        {
            StartCoroutine(StartParticleBoom());
            LightGreenObject.GetComponent<Renderer>().material = LightGreenMaterial;
        }
    }

    private IEnumerator StartParticleBoom()
    {
        yield return new WaitForSeconds(0.5f);
        LightGreenObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
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
