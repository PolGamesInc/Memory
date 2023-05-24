using UnityEngine;

public class GameManagerHamburger : MonoBehaviour
{
    [SerializeField] private Material[] HamburgerMaterial;
    [SerializeField] private GameObject HamburgerObject;

    private void OnMouseDown()
    {
      if(VariableKeeper.CountHamburger == 2)
      {
         HamburgerObject.GetComponent<Renderer>().material = HamburgerMaterial[1];
         gameObject.GetComponent<Renderer>().material = HamburgerMaterial[1];
         print("победа");
      }
    }
}
