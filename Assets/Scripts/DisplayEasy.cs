using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DisplayEasy : MonoBehaviour, IPointerClickHandler
{

    public GameObject Displayer;
    public GameObject Cards;
    public String ResourcePath;//Sprites\OnTripGame\PlaygroundGame
    // Use this for initialization

    public void OnPointerClick(PointerEventData eventData)
    {
        Displayer.SetActive(true);
        var imageComp = Displayer.GetComponent<Image>();
        string spritename = gameObject.GetComponent<Image>().sprite.name;
        string resourcefile = ResourcePath + spritename.Substring(0, 2) + "1";
        Debug.Log(resourcefile);
        imageComp.overrideSprite = Resources.Load<Sprite>(resourcefile);
        Cards.SetActive(false);
    }
}
