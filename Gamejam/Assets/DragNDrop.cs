using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNDrop : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed;
    Vector3 offset;
    bool clickingOnObject = false;
    SpriteRenderer objectSpriteRenderer;
    public Color color1;
    public Color color2;

    public Rigidbody2D rb;

    private void Start()
    {
        objectSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0) && clickingOnObject == true) 
        {
            
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            offset = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)) - transform.position;
            transform.position = Vector2.Lerp(transform.position, mousePosition + offset, moveSpeed);
        }
    }
    private void OnMouseDown()
    {
        objectSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        clickingOnObject = true;
        objectSpriteRenderer.color = color1;

        rb.gravityScale = 0;

    }
    private void OnMouseUp()
    {
        objectSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        clickingOnObject = false;
        objectSpriteRenderer.color = color2;

        rb.gravityScale = 4.9f;
    }


}
