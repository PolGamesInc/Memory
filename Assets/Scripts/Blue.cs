using System.Collections;
using UnityEngine;

public class Blue : MonoBehaviour
{
    [SerializeField] private Material[] BlueMaterial;

    private BoxCollider BoxColliderBlue;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = BlueMaterial[0];
        BoxColliderBlue = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if(VariableKeeper.CountBlue == 0)
        {
            BoxColliderBlue.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        StartCoroutine(ChangeMaterialBlue());
        if (gameObject.tag == "Blue")
        {
            VariableKeeper.CountBlue++;
            BoxColliderBlue.enabled = false;
        }

        if (VariableKeeper.CountBlue == 1)
        {
            VariableKeeper.CountGreen = 0;
            VariableKeeper.CountPink = 0;
            VariableKeeper.CountYellow = 0;
            VariableKeeper.CountOrange = 0;
            VariableKeeper.CountRed = 0;
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

    private IEnumerator ChangeMaterialBlue()
    {
        gameObject.GetComponent<Renderer>().material = BlueMaterial[1];
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<Renderer>().material = BlueMaterial[0];
    }
}
