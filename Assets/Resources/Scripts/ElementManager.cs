using UnityEngine;

public class ElementManager : MonoBehaviour
{
    private Vector3 pos;
    private float x, y;
    private Rigidbody2D rb;
    private bool g;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        g = false;
    }

    void Update()
    {
        GetMouseButton();
    }

    #region OnMouse
    void OnMouseOver()
    {

    }

    void OnMouseDown()
    {
        pos = Camera.main.WorldToScreenPoint(transform.position);
        x = Input.mousePosition.x - pos.x;
        y = Input.mousePosition.y - pos.y;
    }

    void OnMouseDrag()
    {
        Vector2 l = new Vector2(Input.mousePosition.x - x, Input.mousePosition.y - y);
        Vector2 w = Camera.main.ScreenToWorldPoint(l);
        transform.position = w;
    }

    void OnMouseEnter()
    {

    }

    void OnMouseExit()
    {

    }

    void OnMouseUp()
    {

    }

    void OnMouseUpAsButton()
    {

    }
    #endregion

    #region GetMouseButton
    void GetMouseButton()
    {
        // Pressed left click
        if (Input.GetMouseButton(0))
        {
            g = true;

            if (g == true)
            {
                rb.gravityScale = 1;
            }
        }
        // Pressed right click
        if (Input.GetMouseButton(1))
        {

        }
        // Pressed middle click
        if (Input.GetMouseButton(2))
        {

        }
    }

    void GetMouseButtonDown()
    {
        // Pressed primary button
        if (Input.GetMouseButtonDown(0))
        {

        }
        // Pressed secondary button
        if (Input.GetMouseButtonDown(1))
        {

        }
        // Pressed middle click
        if (Input.GetMouseButtonDown(2))
        {

        }
    }

    void GetMouseButtonUp()
    {
        // Pressed left click
        if (Input.GetMouseButtonUp(0))
        {

        }
        // Pressed right click
        if (Input.GetMouseButtonUp(1))
        {

        }
        // Pressed middle click
        if (Input.GetMouseButtonUp(2))
        {

        }
    }
    #endregion

    #region Collision
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Cursor")
        {
            Debug.Log("Colidiu com Cursor!");
        }
    }
    #endregion
}