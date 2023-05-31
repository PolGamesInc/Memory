using System.Collections;
using UnityEngine;

public class GameManagerBlack : MonoBehaviour
{
    [SerializeField] private GameObject BlackObject;

    [SerializeField] private Material BlackMaterial;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
        if (VariableKeeper.CountBlack == 2)
        {
            StartCoroutine(StartParticleBoom());
            BlackObject.GetComponent<Renderer>().material = BlackMaterial;
        }
    }

    private IEnumerator StartParticleBoom()
    {
        yield return new WaitForSeconds(0.7f);
        BlackObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
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
