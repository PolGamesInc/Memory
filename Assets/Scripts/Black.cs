using System.Collections;
using UnityEngine;

public class Black : MonoBehaviour
{
    [SerializeField] private Material[] BlackMaterial;

    private BoxCollider BoxColliderBlack;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = BlackMaterial[0];
        BoxColliderBlack = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if(VariableKeeper.CountBlack == 0)
        {
            BoxColliderBlack.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialBlack());
        if (gameObject.tag == "Black")
        {
            VariableKeeper.CountBlack++;
            BoxColliderBlack.enabled = false;
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
            VariableKeeper.CountDarkGreen = 0;
            VariableKeeper.CountBurgundy = 0;
            VariableKeeper.CountDarkBlue = 0;
            VariableKeeper.CountDarkPink = 0;
            VariableKeeper.CountLightBlue = 0;
            VariableKeeper.CountSilver = 0;
            VariableKeeper.CountLightGreen = 0;
        }
    }

    private IEnumerator ChangeMaterialBlack()
    {
        gameObject.GetComponent<Renderer>().material = BlackMaterial[1];
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<Renderer>().material = BlackMaterial[0];
    }
}