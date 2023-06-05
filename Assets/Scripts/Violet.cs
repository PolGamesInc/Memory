using System.Collections;
using UnityEngine;

public class Violet : MonoBehaviour
{
    [SerializeField] private Material[] VioletMaterial;

    private BoxCollider BoxColliderViolet;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = VioletMaterial[0];
        BoxColliderViolet = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if(VariableKeeper.CountViolet == 0)
        {
            BoxColliderViolet.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialViolet());
        if (gameObject.tag == "Violet")
        {
            VariableKeeper.CountViolet++;
            BoxColliderViolet.enabled = false;
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
            VariableKeeper.CountDarkGreen = 0;
            VariableKeeper.CountBurgundy = 0;
            VariableKeeper.CountDarkBlue = 0;
            VariableKeeper.CountDarkPink = 0;
            VariableKeeper.CountLightBlue = 0;
            VariableKeeper.CountSilver = 0;
            VariableKeeper.CountLightGreen = 0;
        }
    }

    private IEnumerator ChangeMaterialViolet()
    {
        gameObject.GetComponent<Renderer>().material = VioletMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = VioletMaterial[0];
    }
}