using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowModeBoot : MonoBehaviour
{

    void Update()
    {
        Screen.SetResolution(800, 600, false);
        Screen.fullScreen = false;
    }
}
