using UnityEngine;

[ExecuteAlways]
public class FullScreenFXBehaviour : MonoBehaviour
{
    public Material fullscreenMat;
    
    
    void Update()
    {
        if (fullscreenMat == null)
        {
            return;
        }
        
        fullscreenMat.SetVector("_Origin", GetWorldPos());
    }

    private Vector3 GetWorldPos()
    {
        return this.gameObject.transform.position;
    }
}
