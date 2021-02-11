using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;
using UnityEngine.XR;

public class SetPosition : MonoBehaviour
{
    Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        //transform.position = -InputTracking.GetLocalPosition(XRNode.CenterEye);
        //transform.localRotation = Quaternion.Inverse(InputTracking.GetLocalRotation(XRNode.CenterEye));

        //InputDevice.TryGetFeatureValue(CommonUsages.devicePosition);
        //Camera camera = (Camera)GameObject.FindGameObjectWithTag("MainCamera");

        // XRDevice.DisableAutoXRCameraTracking(camera, true);
        InputTracking.disablePositionalTracking = true;
    }
}
