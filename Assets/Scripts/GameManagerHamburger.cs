using System.Collections;
using UnityEngine;

public class GameManagerHamburger : MonoBehaviour
{
    [SerializeField] private GameObject HamburgerObject;

    [SerializeField] private Material[] HamburgerMaterial;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
      if (VariableKeeper.CountHamburger == 2)
      {
         StartCoroutine(StartParticleBoom());
         HamburgerObject.GetComponent<Renderer>().material = HamburgerMaterial[1];
      }
    }

    private IEnumerator StartParticleBoom()
    {
       yield return new WaitForSeconds(0.7f);
       HamburgerObject.transform.position = new Vector3(-8, transform.position.y, transform.position.z);
       gameObject.transform.position = new Vector3(-8, transform.position.y, transform.position.z);
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
