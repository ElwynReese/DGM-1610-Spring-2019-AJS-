using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Think of this class like a job board, a collection of tasks for passive processes to take care of... WIP
//This also serves as the proxy diagnostic class, it will report conflicts an issues with associated classes.
public class TheWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
	{
		if (frametime < 34)
		{
			print("Frame time / framerate dropping below stable 30fps");
		}
	}
}

