using System.Collections;
using UnityEngine;

public class Burgundy : MonoBehaviour
{
    [SerializeField] private Material[] BurgundyMaterial;

    private BoxCollider BoxColliderBurgundy;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = BurgundyMaterial[0];
        BoxColliderBurgundy = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if(VariableKeeper.CountBurgundy == 0)
        {
            BoxColliderBurgundy.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialBurgundy());
        if (gameObject.tag == "Burgundy")
        {
            VariableKeeper.CountBurgundy++;
            BoxColliderBurgundy.enabled = false;
        }

        if (VariableKeeper.CountBurgundy == 1)
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
            VariableKeeper.CountDarkBlue = 0;
            VariableKeeper.CountDarkPink = 0;
            VariableKeeper.CountLightBlue = 0;
            VariableKeeper.CountSilver = 0;
            VariableKeeper.CountLightGreen = 0;
        }
    }

    private IEnumerator ChangeMaterialBurgundy()
    {
        gameObject.GetComponent<Renderer>().material = BurgundyMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = BurgundyMaterial[0];
    }
}