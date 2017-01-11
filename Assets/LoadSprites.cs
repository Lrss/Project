using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSprites : MonoBehaviour
{
    private int showNumber;
    public Sprite[] sprites;
    private Image imageDisplayer;

    void OnEnable()
    {
        //sprites = (Sprite[])Resources.LoadAll(path, typeof(Sprite));
        showNumber = Random.Range(0, sprites.Length);
        imageDisplayer = gameObject.GetComponent<Image>();
        NewImage();
    }


    public void NewImage()
    {
        showNumber++;
        if (showNumber >= sprites.Length)
        {
            showNumber = 0;
        }
        imageDisplayer.overrideSprite = sprites[showNumber];
    }
}
