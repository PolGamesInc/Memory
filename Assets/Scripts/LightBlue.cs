using System.Collections;
using UnityEngine;

public class LightBlue : MonoBehaviour
{
    [SerializeField] private Material[] LightBlueMaterial;

    private BoxCollider BoxColliderLightBlue;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = LightBlueMaterial[0];
        BoxColliderLightBlue = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if(VariableKeeper.CountLightBlue == 0)
        {
            BoxColliderLightBlue.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialLightBlue());
        if (gameObject.tag == "LightBlue")
        {
            VariableKeeper.CountLightBlue++;
            BoxColliderLightBlue.enabled = false;
        }

        if (VariableKeeper.CountLightBlue == 1)
        {
            VariableKeeper.CountGreen = 0;
            VariableKeeper.CountPink = 0;
            VariableKeeper.CountYellow = 0;
            VariableKeeper.CountOrange = 0;
            VariableKeeper.CountRed = 0;
            VariableKeeper.CountBlue = 0;
            VariableKeeper.CountViolet = 0;
            VariableKeeper.CountBlack = 0;
            VariableKeeper.CountBrown = 0;
            VariableKeeper.CountDarkGreen = 0;
            VariableKeeper.CountBurgundy = 0;
            VariableKeeper.CountDarkBlue = 0;
            VariableKeeper.CountDarkPink = 0;
            VariableKeeper.CountSilver = 0;
            VariableKeeper.CountLightGreen = 0;
        }
    }

    private IEnumerator ChangeMaterialLightBlue()
    {
        gameObject.GetComponent<Renderer>().material = LightBlueMaterial[1];
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<Renderer>().material = LightBlueMaterial[0];
    }
}
