using System.Collections;
using UnityEngine;

public class GameManagerDarkBlue : MonoBehaviour
{
    [SerializeField] private GameObject DarkBlueObject;

    [SerializeField] private Material DarkBlueMaterial;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
        if (VariableKeeper.CountDarkBlue == 2)
        {
            StartCoroutine(StartParticleBoom());
            DarkBlueObject.GetComponent<Renderer>().material = DarkBlueMaterial;
        }
    }

    private IEnumerator StartParticleBoom()
    {
        yield return new WaitForSeconds(0.5f);
        DarkBlueObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
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

