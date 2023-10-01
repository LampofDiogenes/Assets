using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject highlighter;
    
    void Update()
    {
        Vector2 objectPosition = transform.position;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //check if board is there (if not, do not allow move)
            // check if piece is there (if not, do not allow move)
                // if piece there, is piece behind? Is board there?
                // if not piece behind, take piece, and move up 3, left three
            // else: move up one, and left one

            transform.position = new Vector2(objectPosition.x - 1, objectPosition.y + 1);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //check if board is there (if not, do not allow move)
            // check if piece is there (if not, do not allow move)
                // if piece there, is piece behind? Is board there?
                // if not piece behind, take piece, and move up 3, right three
            // else: move up one, and right one

            transform.position = new Vector2(objectPosition.x + 1 ,objectPosition.y + 1);
        }
    }
    void OnClick()
    {
        
    }
}
