using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;
    public bool canRun;
    private WaitForSeconds wfsObj;
    public IntData counterNum;
    public float seconds;
    private WaitForFixedUpdate wffuObj;

    private void Start()
    {
        startEvent.Invoke();
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }

    private IEnumerator Counting()
    {
        startCountEvent.Invoke();
        yield return wfsObj;
        
        while (counterNum.value > 0)
        {
            Debug.Log(counterNum.value);
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
        }
        endCountEvent.Invoke();
    }

    private IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            yield return wfsObj;
            repeatUntilFalseEvent.Invoke();
        }
    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }
}
