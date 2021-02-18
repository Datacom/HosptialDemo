using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DisplayNurseCanvas : MonoBehaviour, IMixedRealityInputHandler
{
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
        
    }

    //private void DictationRecognizer_DicationResult(string text, ConfidenceLevel confidence)
    //{
    //    Debug.Log(text);
    //}
}
