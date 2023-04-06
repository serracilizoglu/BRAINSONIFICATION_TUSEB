using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Audio_Time_Bar : MonoBehaviour
{
    public string textValue;
    public Text textElement;
    string changing_variable;
    private AudioSource audioS;
    float variable;
 
    // Start is called before the first frame update
    void Start()
    {
       //textElement.text = "Emptyness"; 
       audioS = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
    
        variable = (int)audioS.time;
        changing_variable = variable.ToString()+"/60";
        textElement.text = changing_variable;
        
    }
}
