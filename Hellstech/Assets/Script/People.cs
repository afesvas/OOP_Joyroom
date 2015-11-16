using UnityEngine;
using System.Collections;

public enum peopleType
{
    사람1, 사람2
}

public class People : MonoBehaviour
{
    private peopleType type;
    private string names;
    private string message;
    private float speed;
    private float diraction;
    public Sprite[] graphic;
    private int time;

    // Use this for initialization
    void Start()
    {
        time = 0;
        SetSpeed(0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        transform.Translate(speed * Mathf.Cos(diraction / 180f * Mathf.PI), speed * Mathf.Sin(diraction / 180f * Mathf.PI), 0);
        if (time % 30 == 0) SetDiraction(-1);
    }

    public string GetName()
    {
        return names;
    }

    public string GetMessage()
    {
        return message;
    }

    public void Init(peopleType type)
    {
        SetType(type);
    }

    public void SetType(peopleType type)
    {
        this.type = type;
        switch (type)
        {
            case peopleType.사람1:
                names = "사람1";
                message = "사람1이라고 한다.";
                SetDiraction(-1);
                break;
            case peopleType.사람2:
                names = "사람2";
                message = "사람2이라고 한다.";
                SetDiraction(-1);
                break;
        }
        gameObject.GetComponent<SpriteRenderer>().sprite = graphic[(int)type];
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    public void SetDiraction(float rotation)
    {
        if (rotation != -1) diraction = rotation;
        else diraction = Random.value * 360;
    }

    public peopleType GetTypes()
    {
        return type;
    }

    public void SetMessage(string message)
    {
        this.message = message;
    }
}
