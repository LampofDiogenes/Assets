using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool canMove;
    public bool dragging;
    public Collider2D collider;

    void Start()
    {
        collider = GetComponent<Collider2D>();
        canMove = false;
        dragging = false;
    }
    void Update()
        {
            
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Input.GetMouseButtonDown(0))
            {
                // trying to see what exactly I am doing wrong
                Debug.Log("item clicked");

                // this is supposed to see whether or not 
                if (collider == Physics2D.OverlapPoint(mousePos))
                {
                    canMove = true;
                }
                else 
                {
                    canMove = false;
                }
                if (canMove == true)
                {
                    dragging = true;
                }
            }
           if (dragging == true)
           {
            this.transform.position = mousePos;
           }
           if (Input.GetMouseButtonUp(0))
           {
            canMove = false;
            dragging = false;
           }
        }
}


