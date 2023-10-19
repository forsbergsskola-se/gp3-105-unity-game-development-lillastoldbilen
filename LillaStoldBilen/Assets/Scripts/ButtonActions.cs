using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActions : MonoBehaviour
{
    public void DoExitGame() 
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
