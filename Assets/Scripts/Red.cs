using System.Collections;
using UnityEngine;

public class Red : MonoBehaviour
{
    [SerializeField] private Material[] RedMaterial;

    private BoxCollider BoxColliderRed;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = RedMaterial[0];
        BoxColliderRed = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if (VariableKeeper.CountRed == 0)
        {
            BoxColliderRed.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialRed());
        if (gameObject.tag == "Red")
        {
            VariableKeeper.CountRed++;
            BoxColliderRed.enabled = false;
        }

        if (VariableKeeper.CountRed == 1)
        {
            VariableKeeper.CountGreen = 0;
            VariableKeeper.CountPink = 0;
            VariableKeeper.CountYellow = 0;
            VariableKeeper.CountOrange = 0;
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

    private IEnumerator ChangeMaterialRed()
    {
        gameObject.GetComponent<Renderer>().material = RedMaterial[1];
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Renderer>().material = RedMaterial[0];
    }
}
