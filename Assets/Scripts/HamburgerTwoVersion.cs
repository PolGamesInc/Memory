using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamburgerTwoVersion : MonoBehaviour
{
    [SerializeField] private GameObject HamburgerOne;
    [SerializeField] Material[] HamburgerMaterial;

    private void OnMouseDown()
    { 

        if (GameManagerHamburger.NameObject == "HamburgerSTR")
        {
            if(gameObject.tag == "Hamburger")
            {
                gameObject.GetComponent<Hamburger>().StartCoroutine("WaitMaterialCloseSlot");
                gameObject.GetComponent<Renderer>().material = HamburgerMaterial[1];
                HamburgerOne.GetComponent<Renderer>().material = HamburgerMaterial[1];
            }
        }
    }
}
