using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.InputModule.Utilities.Interactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour, ISpeechHandler
{
    public void OnSpeechKeywordRecognized(SpeechEventData eventData)
    {
        if (eventData.RecognizedText.Equals("Edit"))
        {
            gameObject.GetComponent<TwoHandManipulatable>().enabled = true;
        }
        else if (eventData.RecognizedText.Equals("Stop Editing"))
        {
            gameObject.GetComponent<TwoHandManipulatable>().enabled = false;
        }
        else if (eventData.RecognizedText.Equals("Delete"))
        {
            Destroy(this.gameObject);
        }
        else if (eventData.RecognizedText.Equals("Copy"))
        {
            GameObject x = Instantiate(this.gameObject, this.gameObject.transform.position, Quaternion.identity);
            x.GetComponent<TwoHandManipulatable>().enabled = false;
        }
        else
        {
            return;
        }

        eventData.Use();
    }
}
