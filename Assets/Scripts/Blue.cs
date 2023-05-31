using System.Collections;
using UnityEngine;

public class Blue : MonoBehaviour
{
    [SerializeField] private Material[] BlueMaterial;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = BlueMaterial[0];
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialBlue());
        if (gameObject.tag == "Blue")
        {
            VariableKeeper.CountBlue++;
        }

        if (VariableKeeper.CountBlue == 1)
        {
            VariableKeeper.CountGreen = 0;
            VariableKeeper.CountPink = 0;
            VariableKeeper.CountYellow = 0;
            VariableKeeper.CountOrange = 0;
            VariableKeeper.CountRed = 0;
            VariableKeeper.CountViolet = 0;
            VariableKeeper.CountBlack = 0;
            VariableKeeper.CountBrown = 0;
        }
    }

    private IEnumerator ChangeMaterialBlue()
    {
        gameObject.GetComponent<Renderer>().material = BlueMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = BlueMaterial[0];
    }
}
