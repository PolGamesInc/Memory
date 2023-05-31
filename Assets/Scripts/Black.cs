using System.Collections;
using UnityEngine;

public class Black : MonoBehaviour
{
    [SerializeField] private Material[] BlackMaterial;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = BlackMaterial[0];
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialBlack());
        if (gameObject.tag == "Black")
        {
            VariableKeeper.CountBlack++;
        }

        if (VariableKeeper.CountBlack == 1)
        {
            VariableKeeper.CountGreen = 0;
            VariableKeeper.CountPink = 0;
            VariableKeeper.CountYellow = 0;
            VariableKeeper.CountOrange = 0;
            VariableKeeper.CountRed = 0;
            VariableKeeper.CountBlue = 0;
            VariableKeeper.CountViolet = 0;
            VariableKeeper.CountBrown = 0;
        }
    }

    private IEnumerator ChangeMaterialBlack()
    {
        gameObject.GetComponent<Renderer>().material = BlackMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = BlackMaterial[0];
    }
}