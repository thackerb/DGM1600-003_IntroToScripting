using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{
    public double coffeTemperature = 85.0f;
    public double hotLimitTemperature = 70.0f;
    public double coldLimitTemperature = 40.0f;
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeTemperature -= Time.deltaTime * 5f;
	}

    void TemperatureTest()
    {
        if (coffeTemperature > hotLimitTemperature)
        {
            Debug.Log("Coffe is too hot.");
        }
        else if (coffeTemperature < coldLimitTemperature)
        {
            Debug.Log("Coffe is too cold.");
        }
        else
        {
            Debug.Log("Coffee is just right.");
        }
    }
}
