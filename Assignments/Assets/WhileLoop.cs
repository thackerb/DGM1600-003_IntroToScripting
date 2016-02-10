using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        int ducksInThePond = 4;

        while(ducksInThePond > 0)
        {
            Debug.Log("I've shot a duck!");
            ducksInThePond--;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
