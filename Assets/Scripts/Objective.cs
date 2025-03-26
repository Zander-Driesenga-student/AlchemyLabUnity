using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Objective : MonoBehaviour
{
    [SerializeField] private Text objectiveDisplay;

    [SerializeField] private string objectiveText = "I am an objective";
    private string completedText = "It me, Marlo. You did the thing";

    public UnityEvent OnCompleteObjective = new UnityEvent();

    private void OnEnable()
    {
        objectiveDisplay.text = objectiveText;
    }

    public void CompleteObjective()
    {
        if (gameObject.activeSelf)
        {
            objectiveDisplay.text = "";

            OnCompleteObjective.Invoke();

            gameObject.SetActive(false);
        }

    }
}
