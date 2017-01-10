using UnityEngine;
using UnityEngine.UI;

public class EntersTrigger : MonoBehaviour
{

    public Text txt;
    public static string SelectedAnimal;
    void OnTriggerStay2D(Collider2D other)
    {
        SelectedAnimal = other.name;
        txt.text = other.name;
        //Debug.Log(other.name);
    }
}
