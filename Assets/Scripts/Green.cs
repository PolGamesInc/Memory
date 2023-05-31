using System.Collections;
using UnityEngine;

public class Green : MonoBehaviour
{
    [SerializeField] private Material[] GreenMaterial;

    private float LastClickTime;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = GreenMaterial[0];
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialGreen());
        if (gameObject.tag == "Green")
        {
            VariableKeeper.CountGreen++;
        }

        if(VariableKeeper.CountGreen == 1)
        {
            VariableKeeper.CountPink = 0;
            VariableKeeper.CountYellow = 0;
            VariableKeeper.CountOrange = 0;
            VariableKeeper.CountRed = 0;
            VariableKeeper.CountBlue = 0;
            VariableKeeper.CountViolet = 0;
            VariableKeeper.CountBlack = 0;
            VariableKeeper.CountBrown = 0;
        }
    }

    private IEnumerator ChangeMaterialGreen()
    {
        gameObject.GetComponent<Renderer>().material = GreenMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = GreenMaterial[0];
    }
}