using System.Collections;
using UnityEngine;

public class DarkBlue : MonoBehaviour
{
    [SerializeField] private Material[] DarkBlueMaterial;

    private BoxCollider BoxColliderDarkBlue;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = DarkBlueMaterial[0];
        BoxColliderDarkBlue = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if(VariableKeeper.CountDarkBlue == 0)
        {
            BoxColliderDarkBlue.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialDarkBlue());
        if (gameObject.tag == "DarkBlue")
        {
            VariableKeeper.CountDarkBlue++;
            BoxColliderDarkBlue.enabled = false;
        }

        if (VariableKeeper.CountDarkBlue == 1)
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
            VariableKeeper.CountDarkPink = 0;
            VariableKeeper.CountLightBlue = 0;
            VariableKeeper.CountSilver = 0;
            VariableKeeper.CountLightGreen = 0;
        }
    }

    private IEnumerator ChangeMaterialDarkBlue()
    {
        gameObject.GetComponent<Renderer>().material = DarkBlueMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = DarkBlueMaterial[0];
    }
}