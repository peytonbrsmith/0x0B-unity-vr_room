using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;

public class doorconsole : MonoBehaviour
{
    public Animator door;
    public Grabbable console;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UnlockDoor()
    {
        door.SetBool("console_on", true);
    }

    public void PowerConsole()
    {
        console.enabled = true;
    }
}
