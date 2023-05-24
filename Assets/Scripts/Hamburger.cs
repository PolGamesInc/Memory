using System.Collections;
using UnityEngine;

public class Hamburger : MonoBehaviour
{
    [SerializeField] private Material[] HamburgerMaterial;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = HamburgerMaterial[0];
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialHamburger());
        if (gameObject.tag == "Hamburger")
        {
            VariableKeeper.CountHamburger++;
        }
    }

    private IEnumerator ChangeMaterialHamburger()
    {
        gameObject.GetComponent<Renderer>().material = HamburgerMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = HamburgerMaterial[0];
    }
}