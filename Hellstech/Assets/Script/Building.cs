using UnityEngine;
using System.Collections;

public enum buildingType
{
    건물1, 건물2
}

public class Building : MonoBehaviour {
    private bool valid;
    public buildingType type;
    public Sprite[] graphic;
    private string message;
    private string names;
    private Stat variation;
    private float time;

	// Use this for initialization
	void Start () {
        Init(type);
	}
	
	// Update is called once per frame
	void Update () {
        if (valid) gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        else gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);
	}


    public void Init(buildingType type)
    {
        SetType(type);
    }

    public void SetName(string names)
    {
        this.names = names;
    }

    public string GetName()
    {
        return names;
    }

    public string GetMessage()
    {
        return message;
    }

    public Stat GetVariation()
    {
        return variation;
    }

    public float GetTime()
    {
        return time;
    }

    public void SetType(buildingType type)
    {
        this.type = type;
        switch (type)
        {
            case buildingType.건물1:
                names = "건물1";
                message = "건물1이라고 합니다.";
                variation = new Stat(1, 2, 3);
                time = 10;
                valid = true;
                break;
            case buildingType.건물2:
                names = "건물2";
                message = "건물2라고 합니다.";
                variation = new Stat(3, 2, 1);
                time = 20;
                valid = false;
                break;
        }
        gameObject.GetComponent<SpriteRenderer>().sprite = graphic[(int)type];
    }

    public buildingType GetTypes()
    {
        return type;
    }
    public void SetValid(bool valid)
    {
        this.valid = valid;
    }
    public bool GetValid()
    {
        return valid;
    }
}
