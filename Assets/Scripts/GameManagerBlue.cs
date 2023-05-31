using System.Collections;
using UnityEngine;

public class GameManagerBlue : MonoBehaviour
{
    [SerializeField] private GameObject BlueObject;

    [SerializeField] private Material BlueMaterial;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
        if (VariableKeeper.CountBlue == 2)
        {
            StartCoroutine(StartParticleBoom());
            BlueObject.GetComponent<Renderer>().material = BlueMaterial;
        }
    }

    private IEnumerator StartParticleBoom()
    {
        yield return new WaitForSeconds(0.7f);
        BlueObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
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