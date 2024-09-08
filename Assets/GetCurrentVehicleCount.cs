using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class GetCurrentVehicleCount : MonoBehaviour
{
    //public Text vehicleText;

    
    // Update is called once per frame
    void Update()
    {
        GameObject[] vehicles = GameObject.FindGameObjectsWithTag("vehicle");

        GetComponent<TextMeshProUGUI>().text = "Vehicle Count: " + (vehicles.Length - 2);
    }
}
