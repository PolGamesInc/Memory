using System.Collections;
using UnityEngine;

public class DarkGreen : MonoBehaviour
{
    [SerializeField] private Material[] DarkGreenMaterial;

    private BoxCollider BoxColliderDarkGreen;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = DarkGreenMaterial[0];
        BoxColliderDarkGreen = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if(VariableKeeper.CountDarkGreen == 0)
        {
            BoxColliderDarkGreen.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialDarkGreen());
        if (gameObject.tag == "DarkGreen")
        {
            VariableKeeper.CountDarkGreen++;
            BoxColliderDarkGreen.enabled = false;
        }

        if (VariableKeeper.CountDarkGreen == 1)
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
            VariableKeeper.CountBurgundy = 0;
            VariableKeeper.CountDarkBlue = 0;
            VariableKeeper.CountDarkPink = 0;
            VariableKeeper.CountLightBlue = 0;
            VariableKeeper.CountSilver = 0;
            VariableKeeper.CountLightGreen = 0;
        }
    }

    private IEnumerator ChangeMaterialDarkGreen()
    {
        gameObject.GetComponent<Renderer>().material = DarkGreenMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = DarkGreenMaterial[0];
    }
}