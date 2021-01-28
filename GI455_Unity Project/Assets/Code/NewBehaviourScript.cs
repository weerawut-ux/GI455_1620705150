using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public string[] ListData = {"Phone" , "Pepsi" , "Milk" , "Glade" , "Yakult" , "Pen"};
    public string inputName;
    public InputField inputField ;
    public Text textDisplay;
    

    public void CheckName(){
        
        inputName = inputField.text;

        if (ListData.Contains(inputName))
        {
            textDisplay.text = "<color=#337DFF>" + inputName + "</color> Is Found";
        }
        else
        {
            textDisplay.text = "<color=#CD5C5C>" + inputName + "</color> Is Not Found";
        }

    }
}

    

    

    