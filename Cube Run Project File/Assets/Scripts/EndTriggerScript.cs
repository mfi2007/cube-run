/*using System.Collections;
using System.Collections.Generic;*/
using UnityEngine;

public class EndTriggerScript : MonoBehaviour
{
    public GameManagerScript gameManagerScriptVN;

    /*// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }*/

    void OnTriggerEnter()
    {
        gameManagerScriptVN.EndTriggerF();
    }
}
