using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DisplayNurseCanvas : MonoBehaviour, IMixedRealityInputHandler
{
    private Vector3 StartPosition = new Vector3(-11.5f, 0f, 3f);
    private Vector3 DestinationPosition = new Vector3(-11.5f, 0f, 7f);
    private Vector3 IncreateVectorValue = new Vector3(0f, 0f, 0.5f);

    private Vector3 TurnAroundEulerAnglesRate = new Vector3(0f, 60f, 0f);
    private Vector3 TurnAroundEulerAngles = new Vector3(0.0f, 180.0f, 0.0f);
    private Vector3 TurnBackEulerAngles = new Vector3(0.0f, 1.0f, 0.0f);

    private bool TowardsToDestination = true;
    private bool IsTurnedAround = false;

    private GetQnAResponse getQnAResponse;
    //private DictationRecognizer dictationRecognizer;
    public void OnInputDown(InputEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    public void OnInputUp(InputEventData eventData)
    {
        GameObject.Find("NurseCanvas").GetComponent<Canvas>().enabled = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        //getQnAResponse = new GetQnAResponse();
        //dictationRecognizer = new DictationRecognizer();
        //dictationRecognizer.DictationResult += DictationRecognizer_DicationResult;
        //dictationRecognizer.Start();
    }

    // Update is called once per frame
    void Update()
    {
        // Move from start position
        if (TowardsToDestination)
        {
            if (Vector3.Distance(DestinationPosition, transform.position) > 0.3f)
            {
                transform.localPosition += IncreateVectorValue * Time.deltaTime;
            }
            else
            {
                if (!IsTurnedAround)
                {
                    //Debug.Log(transform.eulerAngles);
                    if (transform.eulerAngles.y < TurnAroundEulerAngles.y)
                    {
                        transform.eulerAngles += TurnAroundEulerAnglesRate * Time.deltaTime;
                    }
                    else
                    {
                        IsTurnedAround = true;
                    }
                        
                }

                if (IsTurnedAround)
                {
                    TowardsToDestination = false;
                }
            }
        }

        // Reached to the destination
        if (!TowardsToDestination)
        {
            if (Vector3.Distance(StartPosition, transform.position) > 0.3f)
            {
                transform.localPosition -= IncreateVectorValue * Time.deltaTime;
            }
            else
            {
                ///Debug.Log("Stop walking");
                if (IsTurnedAround)
                {
                    //Debug.Log(transform.eulerAngles);
                    if (transform.eulerAngles.y > TurnBackEulerAngles.y)
                    {
                        //Debug.Log("Start turning aruond");
                        transform.eulerAngles -= TurnAroundEulerAnglesRate * Time.deltaTime;
                    }
                    else
                    {
                        //Debug.Log("Stop turning aruond");
                        IsTurnedAround = false;
                    }

                }

                if (!IsTurnedAround)
                {
                    //Debug.Log("Start heading back to start position");
                    TowardsToDestination = true;
                }
            }
        }
    }

    //private void DictationRecognizer_DicationResult(string text, ConfidenceLevel confidence)
    //{
    //    Debug.Log(text);
    //}
}
