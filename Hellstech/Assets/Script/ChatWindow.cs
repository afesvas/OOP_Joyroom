using UnityEngine;
using System.Collections;

public class ChatWindow : MonoBehaviour {
    public GameObject message;
    public GameObject speecher;
    public GameObject selectButton;
    public GameObject noButton;
    private int choice;
    private float delay;

	// Use this for initialization
	void Start () {
        delay = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (delay > 0) delay--;
        else
        {
            speecher.SetActive(false);
            message.SetActive(false);
        }
	}

    public IEnumerator Speech(string who, string text, bool select)
    {
        if (who == "") speecher.SetActive(false);
        else
        {
            speecher.SetActive(true);
            speecher.GetComponent<TextMesh>().text = who;
        }
        message.SetActive(true);
        message.GetComponent<TextMesh>().text = text;
        choice = -1;
        selectButton.SetActive(true);
        if (select == false) noButton.SetActive(false);
        else noButton.SetActive(true);
        GameObject.Find("Character").GetComponent<Character>().Speech();
        while (true)
        {
            delay = 5;
            if (choice != -1) break;
            yield return null;
        }
        GameObject.Find("Character").GetComponent<Character>().Speeched(choice == 1 ? true : false);
        selectButton.SetActive(false);
        speecher.SetActive(false);
        message.SetActive(false);
    }

    public void Info(string who, string text)
    {
        if (who == "") speecher.SetActive(false);
        else
        {
            speecher.SetActive(true);
            speecher.GetComponent<TextMesh>().text = who;
        }
        message.SetActive(true);
        message.GetComponent<TextMesh>().text = text;
        delay = 5;
    }

    public void SelectedYes()
    {
        choice = 1;
    }

    public void SelectedNo()
    {
        choice = 0;
    }
}
