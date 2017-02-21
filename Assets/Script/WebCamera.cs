using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamera : MonoBehaviour
{
    public Material _mWebCamMaterial = null;

    private WebCamTexture _mTexture = null;

    private bool _mSelected = false;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        if (_mSelected)
        {
            return;
        }
        if (null == _mWebCamMaterial)
        {
            return;
        }
        WebCamDevice[] devices = WebCamTexture.devices;
        foreach (WebCamDevice device in devices)
        {
            if (GUILayout.Button(device.name, GUILayout.Width(200), GUILayout.Height(40)))
            {
                _mSelected = true;
                _mTexture = new WebCamTexture(device.name, 128, 128, 30);
                _mTexture.Play();
                _mWebCamMaterial.mainTexture = _mTexture;
            }
        }
    }
}
