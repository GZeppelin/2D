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
public enum Condition
{
    GreaterThan,
    LessThan
}
[System.Serializable]
public class InputAxisState
{
    public string axisName;
    public float offvlue;
    public Buttons button;
    public Condition condition;

    public bool value
    {
        get
        {
            var val = Input.GetAxis(axisName); 
            switch(condition)
            {
                case Condition.GreaterThan:
                    return val > offvlue;
                case Condition.LessThan: 
                    return val < offvlue;
            
            }
            return false;
        }
    }
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
        foreach (var input in inputs)
        {
            if (input.value)
            {
                Debug.Log("Input detected " + input.button);
            }
        }
    }
}
