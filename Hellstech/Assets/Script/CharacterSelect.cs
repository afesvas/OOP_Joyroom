using UnityEngine;
using System.Collections;

public enum character
{
    새내기여자, 새내기남자, 헛내기여자, 헛내기남자
}

public class CharacterSelect : MonoBehaviour {
    private character playable;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public character GetCharacter()
    {
        return playable;
    }

    public void GameStart(int playable)
    {
        this.playable = (character)playable;
        Application.LoadLevel("Story");
    }
}
