using UnityEngine;

public class XRHand : MonoBehaviour
{
    [SerializeField] private MeshRenderer handMeshRenderer;
    [SerializeField] private Material handMaterial;
    [SerializeField] private Material gripMaterial;

    public void ToggleGrip()
    {
        handMeshRenderer.sharedMaterial = handMeshRenderer.sharedMaterial == handMaterial ? gripMaterial : handMaterial;
    }
}
