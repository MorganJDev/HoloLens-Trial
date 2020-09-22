using System;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.InputModule.Utilities.Interactions;
using UnityEngine;
using UnityEngine.Video;

/// <summary>
/// GestureAction performs custom actions based on
/// which gesture is being performed.
/// </summary>
namespace Academy
{
    public class ScaleController : MonoBehaviour, ISpeechHandler
    {
        public string itemName;

        VideoPlayer videoPlayer;
        AudioSource audioSource;

        private void Start()
        {
            videoPlayer = gameObject.GetComponentInChildren<VideoPlayer>();
            audioSource = gameObject.GetComponentInChildren<AudioSource>();
            gameObject.GetComponent<TwoHandManipulatable>().enabled = false;
        }

        private string RecogniseCommand(string x)
        {
            // Editing
            if (x.Equals("Edit " + itemName) || x.Equals("Change " + itemName) || x.Equals("Move") || x.Equals("Rotate") || x.Equals("Change Size"))
            {
                return "Edit";
            }
            else if (x.Equals("Stop Editing") || x.Equals("Stop Moving") || x.Equals("Cancel") || x.Equals("View " + itemName))
            {
                return "Stop Editing";
            }
            else if (x.Equals("Play Video") || x.Equals("Watch Video") || x.Equals("Start Video") || x.Equals("TV On"))
            {
                return "Play Video";
            }
            else if (x.Equals("Stop Video") || x.Equals("Pause Video") || x.Equals("TV Off") || x.Equals("End Video"))
            {
                return "Pause Video";
            }
            else if (x.Equals("Read Text") || x.Equals("Speak Text") || x.Equals("Play Text") || x.Equals("Help Me Read"))
            {
                return "Read Text";
            }
            else if (x.Equals("Stop Reading") || x.Equals("Stop Listening") || x.Equals("Stop Playing") || x.Equals("End Voice"))
            {
                return "Stop Reading";
            }
            else
            {
                return "null";
            }
        }

        void ISpeechHandler.OnSpeechKeywordRecognized(SpeechEventData eventData)
        {
            string x = RecogniseCommand(eventData.RecognizedText);

            if (x.Equals("Play Video"))
            {
                audioSource.Play();
                videoPlayer.Play();
            }
            else if (x.Equals("Pause Video"))
            {
                audioSource.Pause();
                videoPlayer.Pause();
            }
            else if (x.Equals("Read Text"))
            {
                audioSource.Play();
            }
            else if (x.Equals("Stop Reading"))
            {
                audioSource.Pause();
            }
            else if (x.Equals("Edit"))
            {
                gameObject.GetComponent<TwoHandManipulatable>().enabled = true;
            }
            else if (x.Equals("Stop Editing"))
            {
                gameObject.GetComponent<TwoHandManipulatable>().enabled = false;
            }
            else
            {
                return;
            }

            eventData.Use();
        }
    }
}