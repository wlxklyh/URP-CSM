using UnityEngine;
using UnityEngine.Rendering.Universal;

// 这个脚本挂相机上测试
[ExecuteAlways]
public class RendererModify : MonoBehaviour
{
    void OnDrawGizmosSelected()
    {
        UniversalAdditionalCameraData _cameraData = GetComponent<UniversalAdditionalCameraData>();
        ForwardRenderer renderer = (ForwardRenderer)_cameraData.scriptableRenderer;
        Vector3[] pos = new Vector3[] {
            new Vector3(renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[0].x,
            renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[0].y,
            renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[0].z),
            new Vector3(renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[1].x,
            renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[1].y,
            renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[1].z),
            new Vector3(renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[2].x,
                renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[2].y,
                renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[2].z),
            new Vector3(renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[3].x,
                renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[3].y,
                renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[3].z)
        };
        float[] r = new []
        {
            renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[0].w,
            renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[1].w,
            renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[2].w,
            renderer.m_MainLightShadowCasterPass.m_CascadeSplitDistances[3].w
        } ;
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(pos[0],r[0]);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(pos[1],r[1]);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(pos[2],r[2]);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(pos[3],r[3]);

    }
}
