using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class RendererModify : MonoBehaviour
{
    private UniversalAdditionalCameraData _cameraData;
    // Start is called before the first frame update
    void Start()
    {
        _cameraData = GetComponent<UniversalAdditionalCameraData>();
        ForwardRenderer renderer = (ForwardRenderer)_cameraData.scriptableRenderer;
        //renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
