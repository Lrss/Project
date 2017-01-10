using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

public class SelectAnimal : MonoBehaviour
{
    public GameObject MyCanvas;
    public GameObject CanvasShowAnimal;
    public Image DisplayImage;
    public string ResourcePath;

    private bool didTurn;

	void Update () {

	    if (DragRigidbody.isTurning == false && didTurn)
	    {
            Debug.Log("Animal " + EntersTrigger.SelectedAnimal + " is selected!");

            string resourcefile = ResourcePath + EntersTrigger.SelectedAnimal;
            DisplayImage.overrideSprite = Resources.Load<Sprite>(resourcefile);

            CanvasShowAnimal.SetActive(true);
	        MyCanvas.SetActive(false);
	    }
	    didTurn = DragRigidbody.isTurning;
	}
}
