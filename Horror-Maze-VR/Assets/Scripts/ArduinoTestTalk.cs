using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


public class ArduinoTestTalk : MonoBehaviour
{
   public SerialPort stream = new SerialPort("COM6", 9600);

    int sensorVal = 0;

    // Start is called before the first frame update
    void Start()
    {
        //stream.ReadTimeout = 50;
        stream.Open();
        
    }

    // Update is called once per frame
    void Update()
    {
        string value = stream.ReadLine();
        sensorVal = int.Parse(value);
    }

    void OnGUI()
    {
        string newString = "Connected: " + sensorVal;
        GUI.Label(new Rect(10, 10, 100, 200), newString);
    }
}
