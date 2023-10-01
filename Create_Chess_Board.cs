using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CreateBoard : MonoBehaviour 
{
    // these are the two squares that I am alternating back and forth to try build a grid with
public GameObject Square0;
public GameObject Square1;

    // this describes how big the grid will be
public int desired_width = 8;
public int desired_height = 8;

    // I am using this to determine if the board has been made (so I don't make it again)
public bool board_made = false;
void Start() 
{
    if (board_made == false)
    {
        // This loop will iterate until it hits the desired height. In each loop, it will have a second loop that will
        // loop until it hits the desired width. Then, it moved down one, and repeats the process until it reached the desired
        // height
        for(int current_height = 0; current_height < desired_height; current_height++)
        {
            
            for(int current_width = 0; current_width < desired_width; current_width++)
            {  
            
            // if the tile created is even, it will print a white tile
            if((current_height + current_width)%2 == 0)
                {
                Instantiate(Square0,new Vector2(current_width, -current_height),Quaternion.identity);
                }

            // if the tile created is odd, it will print a black tile
            else if((current_height + current_width)%2 == 1)
                {
                Instantiate(Square1,new Vector2(current_width, -current_height),Quaternion.identity);
                }            
            }  

        }
        // the board will not be made again after this program runs
        board_made = true;
    }
  }
}
