using System.Collections;
using UnityEngine;

public class LightGreen : MonoBehaviour
{
    [SerializeField] private Material[] LightGreenMaterial;

    private BoxCollider BoxColliderLightGreen;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = LightGreenMaterial[0];
        BoxColliderLightGreen = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if(VariableKeeper.CountLightGreen == 0)
        {
            BoxColliderLightGreen.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialLightGreen());
        if (gameObject.tag == "LightGreen")
        {
            VariableKeeper.CountLightGreen++;
            BoxColliderLightGreen.enabled = false;
        }

        if (VariableKeeper.CountLightGreen == 1)
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
            VariableKeeper.CountLightBlue = 0;
            VariableKeeper.CountSilver = 0;
        }
    }

    private IEnumerator ChangeMaterialLightGreen()
    {
        gameObject.GetComponent<Renderer>().material = LightGreenMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = LightGreenMaterial[0];
    }
}