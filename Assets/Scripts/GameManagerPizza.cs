using System.Collections;
using UnityEngine;

public class GameManagerPizza : MonoBehaviour
{
    [SerializeField] private GameObject PizzaObject;

    [SerializeField] private Material[] PizzaMaterial;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
        if (VariableKeeper.CountPizza == 2)
        {
            StartCoroutine(StartParticleBoom());
            PizzaObject.GetComponent<Renderer>().material = PizzaMaterial[1];
        }
    }

    private IEnumerator StartParticleBoom()
    {
        yield return new WaitForSeconds(0.7f);
        PizzaObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
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
