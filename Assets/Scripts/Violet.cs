using System.Collections;
using UnityEngine;

public class Violet : MonoBehaviour
{
    [SerializeField] private Material[] VioletMaterial;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = VioletMaterial[0];
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialViolet());
        if (gameObject.tag == "Violet")
        {
            VariableKeeper.CountViolet++;
        }

        if (VariableKeeper.CountViolet == 1)
        {
            VariableKeeper.CountGreen = 0;
            VariableKeeper.CountPink = 0;
            VariableKeeper.CountYellow = 0;
            VariableKeeper.CountOrange = 0;
            VariableKeeper.CountRed = 0;
            VariableKeeper.CountBlue = 0;
            VariableKeeper.CountBlack = 0;
            VariableKeeper.CountBrown = 0;
        }
    }

    private IEnumerator ChangeMaterialViolet()
    {
        gameObject.GetComponent<Renderer>().material = VioletMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = VioletMaterial[0];
    }
}