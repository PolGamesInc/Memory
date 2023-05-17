using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamburger : MonoBehaviour
{
    [SerializeField] Material[] HamburgerMaterial;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = HamburgerMaterial[0];
    }

    private void OnMouseDown()
    {
        gameObject.GetComponent<Renderer>().material = HamburgerMaterial[1];

        StartCoroutine(WaitMaterialCloseSlot());

        if (gameObject.tag == "Hamburger")
        {
            GameManagerHamburger.NameObject = "HamburgerSTR";    
        }
        
        if(GameManagerHamburger.NameObject == "HamburgerSTR")
        {
            print(GameManagerHamburger.NameObject);
        }
    }

    public IEnumerator WaitMaterialCloseSlot()
    {
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = HamburgerMaterial[0];
    }

}
