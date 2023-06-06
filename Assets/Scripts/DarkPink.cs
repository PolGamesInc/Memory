using System.Collections;
using UnityEngine;

public class DarkPink : MonoBehaviour
{
    [SerializeField] private Material[] DarkPinkMaterial;

    private BoxCollider BoxColliderDarkPink;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = DarkPinkMaterial[0];
        BoxColliderDarkPink = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if(VariableKeeper.CountDarkPink == 0)
        {
            BoxColliderDarkPink.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialDarkPink());
        if (gameObject.tag == "DarkPink")
        {
            VariableKeeper.CountDarkPink++;
            BoxColliderDarkPink.enabled = false;
        }

        if (VariableKeeper.CountDarkPink == 1)
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
            VariableKeeper.CountLightBlue = 0;
            VariableKeeper.CountSilver = 0;
            VariableKeeper.CountLightGreen = 0;
        }
    }

    private IEnumerator ChangeMaterialDarkPink()
    {
        gameObject.GetComponent<Renderer>().material = DarkPinkMaterial[1];
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<Renderer>().material = DarkPinkMaterial[0];
    }
}