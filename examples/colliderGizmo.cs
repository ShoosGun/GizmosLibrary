using UnityEngine;

public class ColliderGizmoExample : MonoBehaviour
{
    public void OnRenderObject()
    {
        GizmosAPI gizmosAPI = new GizmosAPI();
        gizmosAPI.SetDefaultMaterialPass();
        

        if (Locator.GetPlayerCollider() == null)
            return;

        //For drawing the collider bounding box, using the global reference frame is recommended
        gizmosAPI.DrawOnGlobalReference(() =>
        {
            gizmosAPI.DrawColliderBoundingBox(Locator.GetPlayerCollider(), Color.yellow);
        });
        //While for the actual collider, to account for the rotation and the scale, you DrawWithReference
        gizmosAPI.DrawWithReference(Locator.GetPlayerTransform(), () =>
        {
            gizmosAPI.DrawCollider(Locator.GetPlayerCollider(), Color.blue);
        });
    }
}