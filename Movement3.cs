using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3 : MonoBehaviour
{
    private bool canMove;
    private bool isDragging;
    private Vector3 initialPosition;

    void Start()
    {
        canMove = false;
        isDragging = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                canMove = true;
                initialPosition = transform.position;
            }
            else
            {
                canMove = false;
            }
        }

        if (canMove && Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
            isDragging = true;
        }

        if (isDragging && Input.GetMouseButtonUp(0))
        {
            canMove = false;
            isDragging = false;
        }
    }
}
