using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryControl : MonoBehaviour
{
	//PSEUDO CODE: Declare(Create) a public variable for an array, Type: GameObject
	//FUNCTION: Can Populate(Initialize) in Inspector Box and hold multiple Game Objects....

	//PSEUDO CODE: Declare(Create) and Initialize a public variable for counting
	//FUNCTION: Starts at 0, used to access array items in sequence....

    void Start()
    {
        
    }

    void Update()
    {
		//PSEUDO CODE: Check for Key input (RightArrow)
		{
			//PSEUDO CODE: as long as there are still game objects in array, increase counter by one
			//FUNCTION: To move up the array
			{

			}

			//PSEUDO CODE: if at the end of game objects, reset counter to go back to start of array
			//FUNCTION: to cycle the array
			{

			}
		}
		//PSEUDO CODE: Check for Key input (LeftArrow)
		{
			//PSEUDO CODE: as long as there are still game objects in array, decrease counter by one
			//FUNCTION: To move down the array
			{
				
			}
			//PSEUDO CODE: if at the beginning of game objects, reset counter to go back to end of array
			//FUNCTION: to cycle the array
			{
				//TIP: Don't forget Arrays start at 0!

			}

		}
		//PSEUDO CODE: Print to Console log the vaue of the counter
		//FUNCTION: To check the keys work accurately

		//PSEUDO CODE: Using the counter, loop through the Array to turn the Game Objects on and off as needed
		//FUNCTION: This displays and hide the items as controlled by the keys
		//TIP: , Check if each array item matches the counter, Use the Renderer or MeshRenderer Component of GameObjects to display/hide as needed 
        {
            {

            }

            {

            }
        }
	}
 }

