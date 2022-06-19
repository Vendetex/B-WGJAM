using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using TMPro;

public class TypewriterEffect : MonoBehaviour {
    public float delay = .1f;

    string currTxt = "";
    string currSpeaker = "";

    public IEnumerator typeWriter(string speakerName, string txt) {
        currSpeaker = speakerName;

        print(currSpeaker);
        //transform.parent.parent.Find("SpeakerFrame").Find("Header").GetComponent<TextMeshProUGUI>().text = currSpeaker;
        for (int i = 0; i < txt.Length; i++) {
            currTxt += txt[i];
            if (txt[i] != ' ') {
                FindObjectOfType<AudioManager>().Play("DialogBeep");
            }
            yield return new WaitForSeconds(delay);
        }
    }

    void Start() {
        StartCoroutine(typeWriter("Narrator", "Hello, my name is John."));
    }

    private void Update() {
        GetComponent<TextMeshProUGUI>().text = currTxt;
    }



}