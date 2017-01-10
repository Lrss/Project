using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelClick : MonoBehaviour
{
    private AudioSource myPlayer;
    // Use this for initialization
    void Start () {
        myPlayer = GetComponent<AudioSource>();

    }

    private string preName;

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log(coll.gameObject.name);
        if (preName != coll.gameObject.name)
            myPlayer.Play();

        preName = coll.gameObject.name;
    }
}
