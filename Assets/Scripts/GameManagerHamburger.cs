using System.Collections;
using UnityEngine;

public class GameManagerHamburger : MonoBehaviour
{
    [SerializeField] private Material[] HamburgerMaterial;
    [SerializeField] private GameObject HamburgerObject;
    [SerializeField] private ParticleSystem[] CartoonBoom;

    private void OnMouseDown()
    {
      StartCoroutine(WaitHamburgerSC());
      if(VariableKeeper.CountHamburger == 2)
      {
         HamburgerObject.GetComponent<Renderer>().material = HamburgerMaterial[1];
         print("победа");
      }
    }

    private IEnumerator WaitHamburgerSC()
    {
        if(VariableKeeper.CountHamburger == 2)
        {
            yield return new WaitForSeconds(0.7f);
            HamburgerObject.SetActive(false);
            gameObject.SetActive(false);
            for(int i = 0; i < CartoonBoom.Length; i++)
            {
                CartoonBoom[i].Play();
            }
        }
    }
}
