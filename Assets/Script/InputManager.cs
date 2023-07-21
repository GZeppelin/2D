using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Buttons
{
    Right,
    Left, 
    Top, 
    Bottom
}
[System.Serializable]
public class InputAxisState
{
    public string axisName;
    public float offvlue;
    public Buttons button;
}
public class InputManager : MonoBehaviour
{
    public InputAxisState[] inputs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
