using TMPro;
using System.Collections;
using UnityEngine;



public class script2scene : MonoBehaviour
{

    public TextMeshProUGUI textbox;

    void Start()
    {

        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence()
    {

        yield return new WaitForSecondsRealtime(2);
        Debug.Log("test1");
        textbox.text = "COMMANDER IN CHIEF:             What is the weather there? ";
        yield return new WaitForSecondsRealtime(5);
        textbox.text = "SERVENT:                        Peaks will see the tempest, clouds assured thunder.Crop will not be good";
        yield return new WaitForSecondsRealtime(5);
        textbox.text = "COMMANDER IN CHIEF:              Ah! when the bamboo's will be ready?";
        yield return new WaitForSecondsRealtime(8);
        textbox.text = "SERVENT:                        Stars are falling, damp is the air, uprooted fall the trees, order stands nowhere! ";
        yield return new WaitForSecondsRealtime(7);

        textbox.text = "           ";
    }
}
