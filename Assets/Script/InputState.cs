using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
public class ButtonState
{
    public bool value;
}


public class InputState : MonoBehaviour
{

    public Dictionary<Buttons,ButtonState> buttonsStates = new Dictionary<Buttons,ButtonState>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(KeyValuePair<Buttons,ButtonState> kvp in buttonsStates)
        {
            Debug.Log("Button State" + kvp.Key + " " + kvp.Value.value);
        }
    }

    public void SetButtonValue(Buttons key,bool value)
    {
        if (!buttonsStates.ContainsKey(key))
        {
           buttonsStates.Add(key, new ButtonState());

        }
        var state = buttonsStates[key];
        state.value = value;
    }
}
