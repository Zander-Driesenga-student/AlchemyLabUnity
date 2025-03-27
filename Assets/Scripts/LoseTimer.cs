using UnityEngine;
using UnityEngine.Events;

public class LoseTimer : MonoBehaviour
{
    public UnityEvent onInteract = new UnityEvent();
    public float targetTime = 60.0f;

    void Update()
    {

        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        onInteract.Invoke();
    }
}
