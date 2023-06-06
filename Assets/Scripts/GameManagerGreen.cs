using System.Collections;
using UnityEngine;

public class GameManagerGreen : MonoBehaviour
{
    [SerializeField] private GameObject GreenObject;

    [SerializeField] private Material GreenMaterial;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
      if (VariableKeeper.CountGreen == 2)
      {
         StartCoroutine(StartParticleBoom());
         GreenObject.GetComponent<Renderer>().material = GreenMaterial;
      }
    }

    private IEnumerator StartParticleBoom()
    {
       yield return new WaitForSeconds(0.5f);
       GreenObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
       gameObject.transform.position = new Vector3(-100, transform.position.y, transform.position.z);
       for (int i = 0; i < CartoonBoom.Length; i++)
       {
          CartoonBoom[i].Play();
          Invoke("StopParticleBoom", 1f);
       }
    }

    private void StopParticleBoom()
    {
        for(int i = 0; i < CartoonBoom.Length; i++)
        {
            CartoonBoom[i].Stop();
        }
    }
}
