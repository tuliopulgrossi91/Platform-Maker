using UnityEngine;

public class CursorManager : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = false;
        SpriteRenderer s = GetComponent<SpriteRenderer>();
        int r = Random.Range(0, 7); // cursor sprites 
        s.sprite = Resources.Load<Sprite>("Sprites/Cursor/" + r.ToString() + "");
    }

    void Update()
    {
        Vector2 cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursor;
    }
}