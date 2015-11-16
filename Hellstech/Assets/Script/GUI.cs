using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {
    public GameObject player;
    public GameObject inGame;
    public GameObject guiText;
    private string text;
    private Stat stat;
    private float time;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Character");
        inGame = GameObject.Find("InGameScript");
        guiText = GameObject.Find("GuiText");
	}
	
	// Update is called once per frame
    void Update()
    {
        stat = player.GetComponent<Character>().GetStat();
        time = inGame.GetComponent<InGame>().GetTime();

        text = "";
        text += "시간 : " + time + "\n매력 : " + stat.charm + "\n체력 : " + stat.health + "\n학점 : " + stat.gpa;
        guiText.GetComponent<TextMesh>().text = text;
	}
}
