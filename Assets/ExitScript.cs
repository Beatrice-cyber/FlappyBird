using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public GameObject panel;

    public void enable_confirmation()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }
}
