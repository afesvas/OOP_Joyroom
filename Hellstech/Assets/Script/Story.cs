using UnityEngine;
using System.Collections;

public class Story : MonoBehaviour {

    IEnumerator FadeIn(GameObject obj, string prop, float speed)
    {
        Color color = new Color();
        if(prop == "text") {
            color = obj.GetComponent<TextMesh>().color;
        }
        color.a = 0;
        while (color.a < 1)
        {
            color.a += speed;
            if (prop == "text") obj.GetComponent<TextMesh>().color = color;
            yield return null;
        }
    }
    IEnumerator FadeOut(GameObject obj, string prop, float speed)
    {
        Color color = new Color();
        if (prop == "text")
        {
            color = obj.GetComponent<TextMesh>().color;
        }
        color.a = 1;
        while (color.a > 0)
        {
            color.a -= speed;
            if (prop == "text") obj.GetComponent<TextMesh>().color = color;
            yield return null;
        }
    }

	// Use this for initialization
	IEnumerator Start () {
        yield return StartCoroutine(FadeIn(GameObject.Find("StoryText1"), "text", 0.01f));
        yield return new WaitForSeconds(1);
        yield return StartCoroutine(FadeOut(GameObject.Find("StoryText1"), "text", 0.01f));
        Application.LoadLevel("InGame");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
