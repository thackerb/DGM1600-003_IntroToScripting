using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour
{
    int numDucks = 3;

	// Use this for initialization
	void Start ()
    {
	    for(int i = 0; i < numDucks; i++)
        {
            Debug.Log("Creating duck number: " + i);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
