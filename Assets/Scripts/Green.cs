using System.Collections;
using UnityEngine;

public class Green : MonoBehaviour
{
    [SerializeField] private Material[] GreenMaterial;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = GreenMaterial[0];
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialGreen());
        if (gameObject.tag == "Hamburger")
        {
            VariableKeeper.CountGreen++;
        }

        if(VariableKeeper.CountGreen == 1)
        {
            VariableKeeper.CountPink = 0;
        }
    }

    private IEnumerator ChangeMaterialGreen()
    {
        gameObject.GetComponent<Renderer>().material = GreenMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = GreenMaterial[0];
    }
}