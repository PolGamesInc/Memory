using System.Collections;
using UnityEngine;

public class Green : MonoBehaviour
{
    [SerializeField] private Material[] GreenMaterial;

    private BoxCollider BoxColliderGreen;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = GreenMaterial[0];
        BoxColliderGreen = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if(VariableKeeper.CountGreen == 0)
        {
            BoxColliderGreen.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialGreen());
        if (gameObject.tag == "Green")
        {
            VariableKeeper.CountGreen++;
            BoxColliderGreen.enabled = false;
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
            VariableKeeper.CountDarkGreen = 0;
            VariableKeeper.CountBurgundy = 0;
            VariableKeeper.CountDarkBlue = 0;
            VariableKeeper.CountDarkPink = 0;
            VariableKeeper.CountLightBlue = 0;
            VariableKeeper.CountSilver = 0;
            VariableKeeper.CountLightGreen = 0;
        }
    }

    private IEnumerator ChangeMaterialGreen()
    {
        gameObject.GetComponent<Renderer>().material = GreenMaterial[1];
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<Renderer>().material = GreenMaterial[0];
    }
}