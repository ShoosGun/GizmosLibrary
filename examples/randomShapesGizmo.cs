using UnityEngine;

public class RandomShapeGizmoExample : MonoBehaviour
{
    //You can also just render random stuff with the gizmos
    public void OnRenderObject()
    {
        GizmosAPI gizmosAPI = new GizmosAPI();
        gizmosAPI.SetDefaultMaterialPass();

        if (Locator.GetPlayerTransform() == null)
            return;

        //This draws a hourglass on the world origin
        gizmosAPI.DrawOnGlobalReference(() =>
        {
            gizmosAPI.DrawWireframeCone(0f, 1f, Vector3.zero, Vector3.up, Color.yellow, 12);
            gizmosAPI.DrawWireframeCone(0f, 1f, Vector3.zero, -Vector3.up, Color.yellow, 12);
        });
        //The resolution is the amount of vertex that will be used to draw a circle, so the more the more accurate
        //Most of the methods that draw stuff like colliders and shapes use the resoluion of 12

        //This draws a small capsule always ahead of the player
        gizmosAPI.DrawWithReference(Locator.GetPlayerTransform(),() =>
        {
            gizmosAPI.DrawWireframeCapsule(0.1f, Vector3.forward + Vector3.up * 0.1f, Vector3.forward - Vector3.up * 0.1f, Color.cyan, 12);
        });
    }
}