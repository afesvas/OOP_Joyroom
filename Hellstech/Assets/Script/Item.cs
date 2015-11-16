using UnityEngine;
using System.Collections;

public enum itemType {
    계란, 아이템2, 아이템3
}

public class Item : MonoBehaviour {
    private itemType type;
    private Stat variation;
    private bool isWild;
    private string names;
    private string message;
    public Sprite[] graphic;
    private int consumable;

	// Use this for initialization
	void Start () {
        isWild = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if (isWild == false)
            {
                if (InGame.ButtonHit(gameObject))
                {
                    StartCoroutine(GameObject.Find("Character").GetComponent<Character>().UseItem(gameObject));
                }
            }
        }
	}

    public Stat GetVariation()
    {
        return variation;
    }

    public void Init(itemType type)
    {
        SetType(type);
    }

    public string GetName()
    {
        return names;
    }

    public string GetMessage()
    {
        return message;
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    public void SetType(itemType type)
    {
        this.type = type;
        switch (type)
        {
            case itemType.계란:
                variation = new Stat(1, 2, 3);
                names = "계란";
                message = "무슨 계란인지 모르겠다.";
                consumable = 1;
                break;
            case itemType.아이템2:
                variation = new Stat(3, 2, 1);
                names = "아이템2";
                message = "아이템 2라고 한다.";
                consumable = 2;
                break;
            case itemType.아이템3:
                variation = new Stat(3, 3, 3);
                names = "아이템3";
                message = "아이템 3이라고 한다.";
                consumable = 3;
                break;
        }
        gameObject.GetComponent<SpriteRenderer>().sprite = graphic[(int)type];
    }

    public itemType GetTypes()
    {
        return type;
    }

    public void SetInventory()
    {
        isWild = false;
    }

    public int GetConsumable()
    {
        return consumable;
    }

    public bool GetWild()
    {
        return isWild;
    }
}
