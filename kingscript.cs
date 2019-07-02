
using TMPro;
using System.Collections;
using UnityEngine;



public class kingscript : MonoBehaviour
{

    public TextMeshProUGUI textbox;
    
     void Start()
    {
      
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence()
    {

        yield return new WaitForSecondsRealtime(2);
        Debug.Log("test");
        textbox.text= "The land of Vitlandia awaits you my son! ";
        yield return new WaitForSecondsRealtime(5);
    textbox.text= "Make us proud, shower the people with all love and respect.";
        yield return new WaitForSecondsRealtime(5);
    textbox.text= "Son, I am old man now and wish to rest and spend my life now in peace! ";
        yield return new WaitForSecondsRealtime(6);
    textbox.text= "I wish that you may carry the legacy of our forefathers. But first you must prove your worth and embrace who you are! .";
        yield return new WaitForSecondsRealtime(8);
    textbox.text= "As the old saying [And the he who is himself needs not the world outside, finds fire within] ";
        yield return new WaitForSecondsRealtime(7);

    textbox.text = "           ";
    }
}

       