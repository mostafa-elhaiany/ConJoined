using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleTutorial : MonoBehaviour
{
    [SerializeField]
    Event[] events;

    int eventIdx = 0;
    bool activated = false;

    void handleActivation(GameObject[] objects, bool active)
    {
        foreach (GameObject gameObject in objects)
        {
            gameObject.SetActive(active);
        }
    }

    IEnumerator increment()
    {
        yield return new WaitForSeconds(events[eventIdx].timeToFinish);
        activated = false;
        eventIdx++;
    }

    public void triggerTaskDone()
    {
        activated = false;
        eventIdx++;
    }

    void Update()
    {
        if (eventIdx >= events.Length)
        {
            Destroy(this.gameObject);
            return;
        }

        if (!activated)
        {
            activated = true;
            Event currentEvent = events[eventIdx];
            handleActivation(currentEvent.activate, true);
            handleActivation(currentEvent.deactivate, false);

            if (currentEvent.timerBased)
            {
                StartCoroutine("increment");
            }
        }
    }
}