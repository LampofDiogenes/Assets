using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this is similar to the chess board program, with some mild adjustments
public class Spawn_white_pieces : MonoBehaviour
{
    // black pieces
    public GameObject Piece0;

    // white pieces
    public GameObject Piece1;

    // defining the board lengths, so that the 
    // pieces are put only inside the board
    public int desired_width = 8;
    public int desired_height = 8;
    // boolean to determine if the pieces have been made
    public bool pieces_made = false;
    // Start is called before the first frame update
    void Start()
{
    if (pieces_made == false)
    {
        // determining the boundaries of the board that we made in a previous program
        for(int current_height = 0; current_height < desired_height; current_height++)
        {
            
            for(int current_width = 0; current_width < desired_width; current_width += 1)
            {  
            
            // If on an odd square, maybe print a piece
            if ((current_height + current_width)%2 == 0)
            {
                // place all black pieces on "black" squares on the top 3 rows
                if (current_height < 3)
                {
                    Instantiate(Piece0,new Vector2(current_width, -current_height),Quaternion.identity);
                }
                // place all white pieces on "black" squares at the bottom 3 rows
                else if (current_height >=5 && current_height < 9)
                {
                    Instantiate(Piece1,new Vector2(current_width, -current_height),Quaternion.identity);
                }
            }

            }  

        }
        // the pieces will not spawn again after this program runs
        pieces_made = true;
    }
  }
}
