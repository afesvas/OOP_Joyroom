using UnityEngine;
using System.Collections;

enum seasons
{
    봄, 여름, 가을, 겨울
}

public class InGame : MonoBehaviour {
    private float time;
    private seasons season;
    private int date;
    private bool day;
    public GameObject building;
    public GameObject item;
    public GameObject people;
    private GameObject temp;


    public static bool ButtonHit(GameObject obj)
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return obj.GetComponent<Collider2D>().OverlapPoint(mousePosition);
    }

	// Use this for initialization
	void Start () {
        time = 0;
        day = true;
        temp = (GameObject)Instantiate(item, new Vector3(Random.value * 10f - 5, Random.value * 10 - 5, 0), Quaternion.identity);
        temp.GetComponent<Item>().Init(itemType.계란);
        temp = (GameObject)Instantiate(item, new Vector3(Random.value * 10f - 5, Random.value * 10 - 5, 0), Quaternion.identity);
        temp.GetComponent<Item>().Init(itemType.아이템2);
        temp = (GameObject)Instantiate(item, new Vector3(Random.value * 10f - 5, Random.value * 10 - 5, 0), Quaternion.identity);
        temp.GetComponent<Item>().Init(itemType.아이템3);
        temp = (GameObject)Instantiate(people, new Vector3(Random.value * 10f - 5, Random.value * 10 - 5, 0), Quaternion.identity);
        temp.GetComponent<People>().Init(peopleType.사람1);
        temp = (GameObject)Instantiate(people, new Vector3(Random.value * 10f - 5, Random.value * 10 - 5, 0), Quaternion.identity);
        temp.GetComponent<People>().Init(peopleType.사람2);
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
	}

    public bool IsDay()
    {
        return day;
    }

    public float GetTime()
    {
        return time;
    }

    public void AddTime(float time)
    {
        this.time += time;
    }

}
