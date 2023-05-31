using System.Collections;
using UnityEngine;

public class Brown : MonoBehaviour
{
    [SerializeField] private Material[] BrownMaterial;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = BrownMaterial[0];
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialBrown());
        if (gameObject.tag == "Brown")
        {
            VariableKeeper.CountBrown++;
        }

        if (VariableKeeper.CountBrown == 1)
        {
            VariableKeeper.CountGreen = 0;
            VariableKeeper.CountPink = 0;
            VariableKeeper.CountYellow = 0;
            VariableKeeper.CountOrange = 0;
            VariableKeeper.CountRed = 0;
            VariableKeeper.CountBlue = 0;
            VariableKeeper.CountViolet = 0;
            VariableKeeper.CountBlack = 0;
            VariableKeeper.CountDarkGreen = 0;
            VariableKeeper.CountBurgundy = 0;
            VariableKeeper.CountDarkBlue = 0;
            VariableKeeper.CountDarkPink = 0;
            VariableKeeper.CountLightBlue = 0;
            VariableKeeper.CountSilver = 0;
            VariableKeeper.CountLightGreen = 0;
        }
    }

    private IEnumerator ChangeMaterialBrown()
    {
        gameObject.GetComponent<Renderer>().material = BrownMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = BrownMaterial[0];
    }
}