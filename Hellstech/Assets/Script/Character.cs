using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
    private int up;
    private int down;
    private int left;
    private int right;
    private float speed;
    private Stat stat;
    private Collider2D attach;
    private bool speeching;
    private bool choice;
    public Sprite[] graphic;

    void OnTriggerEnter2D(Collider2D other)
    {
        attach = other;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        attach = other;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        attach = null;
    }

    public IEnumerator UseItem(GameObject item)
    {
        Item itemScript = item.GetComponent<Item>();
        if (itemScript.GetConsumable() == 1)
        {
            yield return StartCoroutine(GameObject.Find("ChatWindow").GetComponent<ChatWindow>().Speech(itemScript.GetName(), "소비용 아이템입니다. 소비하시겠습니까?", true));
            if (choice == true)
            {
                stat.UpdateStat(itemScript.GetVariation());
                itemScript.Destroy();
            }
        }
        else if ((itemScript.GetConsumable() == 2 || itemScript.GetConsumable() == 3) && itemScript.GetWild())
        {
            yield return StartCoroutine(GameObject.Find("ChatWindow").GetComponent<ChatWindow>().Speech(itemScript.GetName(), "인벤토리에 넣겠습니까?", true));
            if (choice == true)
            {
                GameObject.Find("Inventory").GetComponent<Inventory>().AddItem(item);
            }
        }
        else if (itemScript.GetConsumable() == 2 && !itemScript.GetWild())
        {
            yield return StartCoroutine(GameObject.Find("ChatWindow").GetComponent<ChatWindow>().Speech(itemScript.GetName(), "소비하시겠습니까?", true));
            if (choice == true)
            {
                stat.UpdateStat(itemScript.GetVariation());
                GameObject.Find("Inventory").GetComponent<Inventory>().RemoveItem(item);
            }
        }
        else if (itemScript.GetConsumable() == 3 && !itemScript.GetWild()) {
            yield return StartCoroutine(GameObject.Find("ChatWindow").GetComponent<ChatWindow>().Speech(itemScript.GetName(), "소비할 수 없는 아이템입니다.", false));
        }
        attach = null;
    }

    public void Speech()
    {
        speeching = true;
    }

    public void Speeched(bool choice)
    {
        speeching = false;
        this.choice = choice; 
    }

    public Stat GetStat()
    {
        return stat;
    }

    IEnumerator UseBuilding(Building building)
    {
        if (building.GetValid())
        {
            yield return StartCoroutine(GameObject.Find("ChatWindow").GetComponent<ChatWindow>().Speech(building.GetName(), "입장할 수 있는 빌딩입니다. 입장 하시겠습니까?", true));
            if (choice == true)
            {
                GameObject.Find("InGameScript").GetComponent<InGame>().AddTime(building.GetTime());
                stat.UpdateStat(building.GetVariation());
            }
        }
        else
        {
            yield return StartCoroutine(GameObject.Find("ChatWindow").GetComponent<ChatWindow>().Speech(building.GetName(), "입장할 수 없는 빌딩입니다.", false));
        }

        attach = null;
    }

	// Use this for initialization
	void Start () {
        switch(GameObject.Find("CharacterSelectScript").GetComponent<CharacterSelect>().GetCharacter())
        {
            case character.새내기여자:
                stat = new Stat(0, 0, 0);
                gameObject.GetComponent<SpriteRenderer>().sprite = graphic[0];
                break;
            case character.새내기남자:
                stat = new Stat(1, 1, 1);
                gameObject.GetComponent<SpriteRenderer>().sprite = graphic[0];
                break;
            case character.헛내기여자:
                stat = new Stat(2, 2, 2);
                gameObject.GetComponent<SpriteRenderer>().sprite = graphic[1];
                break;
            case character.헛내기남자:
                stat = new Stat(3, 3, 3);
                gameObject.GetComponent<SpriteRenderer>().sprite = graphic[1];
                break;
        }
        speeching = false;
	}
	
	// Update is called once per frame

    void Update()
    {
        if (speeching == false)
        {
            if (attach != null)
            {

                if (attach.name.Contains("Item"))
                {
                    GameObject.Find("ChatWindow").GetComponent<ChatWindow>().Info(attach.GetComponent<Item>().GetName(), attach.GetComponent<Item>().GetMessage());
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        StartCoroutine(UseItem(attach.gameObject));
                    }
                }
                else if (attach.name.Contains("Building"))
                {
                    GameObject.Find("ChatWindow").GetComponent<ChatWindow>().Info(attach.GetComponent<Building>().GetName(), attach.GetComponent<Building>().GetMessage());
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        StartCoroutine(UseBuilding(attach.GetComponent<Building>()));
                    }
                }
                else if (attach.name.Contains("People"))
                {
                    GameObject.Find("ChatWindow").GetComponent<ChatWindow>().Info(attach.GetComponent<People>().GetName(), attach.GetComponent<People>().GetMessage());
                }
            }
            speed = 0.1f;
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                up = 1;
                down = 0;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                down = 1;
                up = 0;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                left = 1;
                right = 0;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                right = 1;
                left = 0;
            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                up = 0;
                if (Input.GetKey(KeyCode.DownArrow)) down = 1;
            }
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                down = 0;
                if (Input.GetKey(KeyCode.UpArrow)) up = 1;
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                left = 0;
                if (Input.GetKey(KeyCode.RightArrow)) right = 1;
            }
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                right = 0;
                if (Input.GetKey(KeyCode.LeftArrow)) left = 1;
            }
            if (up + down + left + right == 2) speed /= Mathf.Sqrt(2);

            if (up == 1) transform.Translate(0, speed, 0);
            if (down == 1) transform.Translate(0, -speed, 0);
            if (left == 1) transform.Translate(-speed, 0, 0);
            if (right == 1) transform.Translate(speed, 0, 0);
        }
    }
}
