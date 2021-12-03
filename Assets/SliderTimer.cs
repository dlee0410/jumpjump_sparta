using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTimer : MonoBehaviour
{
    Slider slTimer;
    public Text timeText;
    void Start()
    {
        slTimer = GetComponent<Slider>();
        timeText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (slTimer.value < 10f)
        {            
            slTimer.value += Time.deltaTime;
        }
        else
        {
            timeText.gameObject.SetActive(true);
            InputManager.Instance.ClearJumpFlag();
        }
    }
}