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
    public AudioSource AnimalSoundPlayer;

    private bool didTurn;

	void Update () {

	    if (DragRigidbody.isTurning == false && didTurn)
	    {
            Debug.Log("Animal " + EntersTrigger.SelectedAnimal + " is selected!");

            string resourceSprite = "Sprites\\WheelGame\\" + EntersTrigger.SelectedAnimal;
            DisplayImage.overrideSprite = Resources.Load<Sprite>(resourceSprite);

            CanvasShowAnimal.SetActive(true);

            string resourceAudioClip = "Sound\\WheelGame\\Animals\\" + EntersTrigger.SelectedAnimal.ToLower();
            AnimalSoundPlayer.PlayOneShot(Resources.Load<AudioClip>(resourceAudioClip));

	        MyCanvas.SetActive(false);
	    }
	    didTurn = DragRigidbody.isTurning;
	}
}
