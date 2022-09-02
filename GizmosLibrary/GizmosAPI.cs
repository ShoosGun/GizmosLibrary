using System;
using UnityEngine;

namespace GizmosLibrary
{
	public class GizmosAPI
	{
		//GLHelper
		public Material GetDefaultMaterial() => GLHelper.GetDefaultMaterial();
		public void SetDefaultMaterialPass(int pass = 0) => GLHelper.SetDefaultMaterialPass(pass);
		public void DrawWithReference(Transform reference, Action drawMethod) => GLHelper.DrawWithReference(reference, drawMethod);
		public void  DrawOnGlobalReference(Action drawMethod) => GLHelper.DrawOnGlobalReference(drawMethod);
		public void DrawWithOrthoProjection(Action drawMethod) => GLHelper.DrawWithOrthoProjection(drawMethod);
		public void DrawAxis(float headSize, Color color, Vector3 offset) => GLHelper.DrawAxis(headSize, color, offset);
		public void DrawTransform(Transform transform, float headSize, Color color) => GLHelper.DrawTransform(transform, headSize, color);
		public void DrawCollider(Collider collider, Color color) => GLHelper.DrawCollider(collider, color);
		public void DrawColliderBoundingBox(Collider collider, Color color) => GLHelper.DrawColliderBoundingBox(collider, color);
		public void DrawShape(Shape shape, Color color) => GLHelper.DrawShape(shape, color);
		public void DrawShapeBoundingSphere(Shape shape, Color color) => GLHelper.DrawShapeBoundingSphere(shape, color);
		//GLDraw
		public void DrawSimpleWireframeCube(Vector3 offset, Color color) => GLDraw.SimpleWireframeCube(offset, color);
		public void DrawWireframeCube(Vector3 foward, Vector3 up, Vector3 right, Vector3 offset, Color color) => GLDraw.WireframeCube(foward, up, right, offset, color);
		public void DrawWireframeCircle(float radius, Vector3 normal, Vector3 up, Vector3 offset, Color color, int resolution = 3, float startAngle = 0f, float endAngle = 2f * Mathf.PI, bool isWholeCircle = true) 
			=> GLDraw.WireframeCircle(radius, normal, up, offset, color, resolution, startAngle, endAngle, isWholeCircle);
		public void DrawSimpleWireframeSphere(float radius, Vector3 offset, Color color, int resolution)
			=> GLDraw.SimpleWireframeSphere(radius, offset, color, resolution);
		public void DrawWireframeSphere(float radius, Vector3 offset, Vector3 foward, Vector3 up, Color color, int resolution = 3)
			=> GLDraw.WireframeSphere(radius, offset, foward, up, color, resolution);
		public void DrawWireframeHemisphere(float radius, Vector3 offset, Vector3 foward, Vector3 up, Color color, int resolution = 3)
			=> GLDraw.WireframeHemisphere(radius, offset, foward, up, color, resolution);
		public void DrawWireframeCapsule(float radius, Vector3 startPoint, Vector3 endPoint, Color color, int resolution = 3)
			=> GLDraw.WireframeCapsule(radius, startPoint, endPoint, color, resolution);
		public void DrawSimpleWireframeCapsule(float radius, float height, Vector3 up, Vector3 offset, Color color, int resolution = 3)
			=> GLDraw.SimpleWireframeCapsule(radius, height, up, offset, color, resolution);
		public void DrawWireframeCone(float coneRadiusStart, float coneRadiusEnd, Vector3 coneStart, Vector3 coneEnd, Color color, int resolution = 3)
			=> GLDraw.WireframeCone(coneRadiusStart,coneRadiusEnd,coneStart,coneEnd,color,resolution);
		public void DrawVector(Vector3 vector, float headSize, Vector3 offset, Color color) => GLDraw.Vector(vector, headSize, offset, color);
	}
}
