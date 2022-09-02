using UnityEngine;

public class ShapeGizmoExample : MonoBehaviour
{
    //Shapes are like a collider that were made for outer wilds, you can find them in several places,
    //like for the flashlight or for the geiser volumes
    public void OnRenderObject()
    {
        GizmosAPI gizmosAPI = new GizmosAPI();
        gizmosAPI.SetDefaultMaterialPass();

        if (Locator.GetPlayerTransform() == null)
            return;

        //The DrawShape method was made to work only inside DrawOnGlobalReference
        gizmosAPI.DrawOnGlobalReference(() =>
        {
            Shape shapeInPlayer = Locator.GetPlayerDetector().gameObject.GetComponent<Shape>();
            if (shapeInPlayer != null)
            {
                gizmosAPI.DrawShape(shapeInPlayer, Color.white);
                gizmosAPI.DrawShapeBoundingSphere(shapeInPlayer, Color.red);
                //Shapes use a sphere as its "bounding box"
            }
        });
    }
}