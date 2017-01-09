using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntersTrigger : MonoBehaviour
{

    public Text txt;
    
    void OnTriggerStay2D(Collider2D other)
    {
        txt.text = other.name;
        Debug.Log(other.name);
    }
}
