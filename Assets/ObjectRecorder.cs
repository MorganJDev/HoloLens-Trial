using System;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.InputModule.Utilities.Interactions;
using UnityEngine;

public class ObjectRecorder : MonoBehaviour
{
    public BuildController controller;

    void Start()
    {
        controller = FindObjectOfType<BuildController>();
    }

    public void OnManipulationCanceled(ManipulationEventData eventData)
    {
        throw new NotImplementedException();
    }

    public void OnManipulationCompleted(ManipulationEventData eventData)
    {
        throw new NotImplementedException();
    }

    public void OnManipulationStarted(ManipulationEventData eventData)
    {
        throw new NotImplementedException();
    }

    public void OnManipulationUpdated(ManipulationEventData eventData)
    {
        throw new NotImplementedException();
    }
}
