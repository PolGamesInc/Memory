using System.Collections;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    [SerializeField] private Material[] PizzaMaterial;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = PizzaMaterial[0];
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialPizza());
        if (gameObject.tag == "Pizza")
        {
            VariableKeeper.CountPizza++;
        }
    }

    private IEnumerator ChangeMaterialPizza()
    {
        gameObject.GetComponent<Renderer>().material = PizzaMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = PizzaMaterial[0];
    }
}