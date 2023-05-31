using System.Collections;
using UnityEngine;

public class Orange : MonoBehaviour
{
    [SerializeField] private Material[] OrangeMaterial;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = OrangeMaterial[0];
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialOrange());
        if (gameObject.tag == "Orange")
        {
            VariableKeeper.CountOrange++;
        }

        if (VariableKeeper.CountOrange == 1)
        {
            VariableKeeper.CountGreen = 0;
            VariableKeeper.CountPink = 0;
            VariableKeeper.CountYellow = 0;
            VariableKeeper.CountRed = 0;
            VariableKeeper.CountBlue = 0;
            VariableKeeper.CountViolet = 0;
            VariableKeeper.CountBlack = 0;
            VariableKeeper.CountBrown = 0;
            VariableKeeper.CountDarkGreen = 0;
            VariableKeeper.CountBurgundy = 0;
            VariableKeeper.CountDarkBlue = 0;
            VariableKeeper.CountDarkPink = 0;
            VariableKeeper.CountLightBlue = 0;
            VariableKeeper.CountSilver = 0;
            VariableKeeper.CountLightGreen = 0;
        }
    }

    private IEnumerator ChangeMaterialOrange()
    {
        gameObject.GetComponent<Renderer>().material = OrangeMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = OrangeMaterial[0];
    }
}