using System.Collections;
using UnityEngine;

public class Pink : MonoBehaviour
{
    [SerializeField] private Material[] PinkMaterial;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = PinkMaterial[0];
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialPink());
        if (gameObject.tag == "Pizza")
        {
            VariableKeeper.CountPink++;
        }

        if(VariableKeeper.CountPink == 1)
        {
            VariableKeeper.CountGreen = 0; 
        }
    }

    private IEnumerator ChangeMaterialPink()
    {
        gameObject.GetComponent<Renderer>().material = PinkMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = PinkMaterial[0];
    }
}