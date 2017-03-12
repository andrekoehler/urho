// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Camera.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho
{
	/// <summary>
	/// %Camera component.
	/// </summary>
	public unsafe partial class Camera : Component
	{
		unsafe partial void OnCameraCreated ();

		[Preserve]
		public Camera (IntPtr handle) : base (handle)
		{
			OnCameraCreated ();
		}

		[Preserve]
		protected Camera (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnCameraCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Camera_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (Camera_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Camera_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Camera_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Camera_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(Camera));
			return new StringHash (Camera_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Camera_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(Camera));
			return Marshal.PtrToStringAnsi (Camera_GetTypeNameStatic ());
		}

		[Preserve]
		public Camera () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Camera_Camera (IntPtr context);

		[Preserve]
		public Camera (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(Camera));
			handle = Camera_Camera ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
			OnCameraCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(Camera));
			Camera_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_DrawDebugGeometry (IntPtr handle, IntPtr debug, bool depthTest);

		/// <summary>
		/// Visualize the component as debug geometry.
		/// </summary>
		public override void DrawDebugGeometry (DebugRenderer debug, bool depthTest)
		{
			Runtime.ValidateRefCounted (this);
			Camera_DrawDebugGeometry (handle, (object)debug == null ? IntPtr.Zero : debug.Handle, depthTest);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetNearClip (IntPtr handle, float nearClip);

		/// <summary>
		/// Set near clip distance.
		/// </summary>
		private void SetNearClip (float nearClip)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetNearClip (handle, nearClip);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetFarClip (IntPtr handle, float farClip);

		/// <summary>
		/// Set far clip distance.
		/// </summary>
		private void SetFarClip (float farClip)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetFarClip (handle, farClip);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetFov (IntPtr handle, float fov);

		/// <summary>
		/// Set vertical field of view in degrees.
		/// </summary>
		private void SetFov (float fov)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetFov (handle, fov);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetSkew (IntPtr handle, float skew);

		/// <summary>
		/// Set skew
		/// </summary>
		private void SetSkew (float skew)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetSkew (handle, skew);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetOrthoSize (IntPtr handle, float orthoSize);

		/// <summary>
		/// Set orthographic mode view uniform size.
		/// </summary>
		private void SetOrthoSize (float orthoSize)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetOrthoSize (handle, orthoSize);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetOrthoSize0 (IntPtr handle, ref Urho.Vector2 orthoSize);

		/// <summary>
		/// Set orthographic mode view non-uniform size. Disables the auto aspect ratio -mode.
		/// </summary>
		public void SetOrthoSize (Urho.Vector2 orthoSize)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetOrthoSize0 (handle, ref orthoSize);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetAspectRatio (IntPtr handle, float aspectRatio);

		/// <summary>
		/// Set aspect ratio manually. Disables the auto aspect ratio -mode.
		/// </summary>
		private void SetAspectRatio (float aspectRatio)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetAspectRatio (handle, aspectRatio);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetFillMode (IntPtr handle, FillMode mode);

		/// <summary>
		/// Set polygon fill mode to use when rendering a scene.
		/// </summary>
		private void SetFillMode (FillMode mode)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetFillMode (handle, mode);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetZoom (IntPtr handle, float zoom);

		/// <summary>
		/// Set zoom.
		/// </summary>
		private void SetZoom (float zoom)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetZoom (handle, zoom);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetLodBias (IntPtr handle, float bias);

		/// <summary>
		/// Set LOD bias.
		/// </summary>
		private void SetLodBias (float bias)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetLodBias (handle, bias);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetViewMask (IntPtr handle, uint mask);

		/// <summary>
		/// Set view mask. Will be and'ed with object's view mask to see if the object should be rendered.
		/// </summary>
		private void SetViewMask (uint mask)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetViewMask (handle, mask);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetViewOverrideFlags (IntPtr handle, uint flags);

		/// <summary>
		/// Set view override flags.
		/// </summary>
		private void SetViewOverrideFlags (uint flags)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetViewOverrideFlags (handle, flags);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetOrthographic (IntPtr handle, bool enable);

		/// <summary>
		/// Set orthographic mode enabled/disabled.
		/// </summary>
		private void SetOrthographic (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetOrthographic (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetAutoAspectRatio (IntPtr handle, bool enable);

		/// <summary>
		/// Set automatic aspect ratio based on viewport dimensions. Enabled by default.
		/// </summary>
		private void SetAutoAspectRatio (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetAutoAspectRatio (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetProjectionOffset (IntPtr handle, ref Urho.Vector2 offset);

		/// <summary>
		/// Set projection offset. It needs to be calculated as (offset in pixels) / (viewport dimensions.)
		/// </summary>
		private void SetProjectionOffset (Urho.Vector2 offset)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetProjectionOffset (handle, ref offset);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetUseReflection (IntPtr handle, bool enable);

		/// <summary>
		/// Set reflection mode.
		/// </summary>
		private void SetUseReflection (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetUseReflection (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetReflectionPlane (IntPtr handle, ref Urho.Plane plane);

		/// <summary>
		/// Set reflection plane in world space for reflection mode.
		/// </summary>
		private void SetReflectionPlane (Urho.Plane plane)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetReflectionPlane (handle, ref plane);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetUseClipping (IntPtr handle, bool enable);

		/// <summary>
		/// Set whether to use a custom clip plane.
		/// </summary>
		private void SetUseClipping (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetUseClipping (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetClipPlane (IntPtr handle, ref Urho.Plane plane);

		/// <summary>
		/// Set custom clipping plane in world space.
		/// </summary>
		private void SetClipPlane (Urho.Plane plane)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetClipPlane (handle, ref plane);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetFlipVertical (IntPtr handle, bool enable);

		/// <summary>
		/// Set vertical flipping mode. Called internally by View to resolve OpenGL / Direct3D9 rendertarget sampling differences.
		/// </summary>
		private void SetFlipVertical (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetFlipVertical (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetProjection (IntPtr handle, ref Urho.Matrix4 projection);

		/// <summary>
		/// Set custom projection matrix, which should be specified in D3D convention with depth range 0 - 1. Disables auto aspect ratio.
		/// Change any of the standard view parameters (FOV, far clip, zoom etc.) to revert to the standard projection.
		/// Note that the custom projection is not serialized or replicated through the network.
		/// </summary>
		public void SetProjection (Urho.Matrix4 projection)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetProjection (handle, ref projection);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Camera_GetFarClip (IntPtr handle);

		/// <summary>
		/// Return far clip distance. If a custom projection matrix is in use, is calculated from it instead of the value assigned with SetFarClip().
		/// </summary>
		private float GetFarClip ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetFarClip (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Camera_GetNearClip (IntPtr handle);

		/// <summary>
		/// Return near clip distance. If a custom projection matrix is in use, is calculated from it instead of the value assigned with SetNearClip().
		/// </summary>
		private float GetNearClip ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetNearClip (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Camera_GetSkew (IntPtr handle);

		/// <summary>
		/// Return skew.
		/// </summary>
		private float GetSkew ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetSkew (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Camera_GetFov (IntPtr handle);

		/// <summary>
		/// Return vertical field of view in degrees.
		/// </summary>
		private float GetFov ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetFov (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Camera_GetOrthoSize (IntPtr handle);

		/// <summary>
		/// Return orthographic mode size.
		/// </summary>
		private float GetOrthoSize ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetOrthoSize (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Camera_GetAspectRatio (IntPtr handle);

		/// <summary>
		/// Return aspect ratio.
		/// </summary>
		private float GetAspectRatio ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetAspectRatio (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Camera_GetZoom (IntPtr handle);

		/// <summary>
		/// Return zoom.
		/// </summary>
		private float GetZoom ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetZoom (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Camera_GetLodBias (IntPtr handle);

		/// <summary>
		/// Return LOD bias.
		/// </summary>
		private float GetLodBias ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetLodBias (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Camera_GetViewMask (IntPtr handle);

		/// <summary>
		/// Return view mask.
		/// </summary>
		private uint GetViewMask ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetViewMask (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Camera_GetViewOverrideFlags (IntPtr handle);

		/// <summary>
		/// Return view override flags.
		/// </summary>
		private uint GetViewOverrideFlags ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetViewOverrideFlags (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern FillMode Camera_GetFillMode (IntPtr handle);

		/// <summary>
		/// Return fill mode.
		/// </summary>
		private FillMode GetFillMode ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetFillMode (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Camera_IsOrthographic (IntPtr handle);

		/// <summary>
		/// Return orthographic flag.
		/// </summary>
		private bool IsOrthographic ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_IsOrthographic (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Camera_GetAutoAspectRatio (IntPtr handle);

		/// <summary>
		/// Return auto aspect ratio flag.
		/// </summary>
		private bool GetAutoAspectRatio ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetAutoAspectRatio (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Frustum Camera_GetFrustum (IntPtr handle);

		/// <summary>
		/// Return frustum in world space.
		/// </summary>
		private Urho.Frustum GetFrustum ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetFrustum (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Matrix4 Camera_GetProjection (IntPtr handle);

		/// <summary>
		/// Return projection matrix. It's in D3D convention with depth range 0 - 1.
		/// </summary>
		private Matrix4 GetProjection ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetProjection (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Matrix4 Camera_GetGPUProjection (IntPtr handle);

		/// <summary>
		/// Return projection matrix converted to API-specific format for use as a shader parameter.
		/// </summary>
		private Matrix4 GetGPUProjection ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetGPUProjection (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Matrix3x4 Camera_GetView (IntPtr handle);

		/// <summary>
		/// Return view matrix.
		/// </summary>
		private Urho.Matrix3x4 GetView ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetView (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Camera_GetHalfViewSize (IntPtr handle);

		/// <summary>
		/// Return half view size.
		/// </summary>
		private float GetHalfViewSize ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetHalfViewSize (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Frustum Camera_GetSplitFrustum (IntPtr handle, float nearClip, float farClip);

		/// <summary>
		/// Return frustum split by custom near and far clip distances.
		/// </summary>
		public Frustum GetSplitFrustum (float nearClip, float farClip)
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetSplitFrustum (handle, nearClip, farClip);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Frustum Camera_GetViewSpaceFrustum (IntPtr handle);

		/// <summary>
		/// Return frustum in view space.
		/// </summary>
		private Frustum GetViewSpaceFrustum ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetViewSpaceFrustum (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Frustum Camera_GetViewSpaceSplitFrustum (IntPtr handle, float nearClip, float farClip);

		/// <summary>
		/// Return split frustum in view space.
		/// </summary>
		public Frustum GetViewSpaceSplitFrustum (float nearClip, float farClip)
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetViewSpaceSplitFrustum (handle, nearClip, farClip);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Ray Camera_GetScreenRay (IntPtr handle, float x, float y);

		/// <summary>
		/// Return ray corresponding to normalized screen coordinates (0 - 1), with origin on the near clip plane.
		/// </summary>
		public Ray GetScreenRay (float x, float y)
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetScreenRay (handle, x, y);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Vector2 Camera_WorldToScreenPoint (IntPtr handle, ref Urho.Vector3 worldPos);

		/// <summary>
		/// Convert a world space point to normalized screen coordinates (0 - 1).
		/// </summary>
		public Vector2 WorldToScreenPoint (Urho.Vector3 worldPos)
		{
			Runtime.ValidateRefCounted (this);
			return Camera_WorldToScreenPoint (handle, ref worldPos);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Vector3 Camera_ScreenToWorldPoint (IntPtr handle, ref Urho.Vector3 screenPos);

		/// <summary>
		/// Convert normalized screen coordinates (0 - 1) and distance along view Z axis (in Z coordinate) to a world space point. The distance can not be closer than the near clip plane.
		/// Note that a HitDistance() from the camera screen ray is not the same as distance along the view Z axis, as under a perspective projection the ray is likely to not be Z-aligned.
		/// </summary>
		public Vector3 ScreenToWorldPoint (Urho.Vector3 screenPos)
		{
			Runtime.ValidateRefCounted (this);
			return Camera_ScreenToWorldPoint (handle, ref screenPos);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Vector2 Camera_GetProjectionOffset (IntPtr handle);

		/// <summary>
		/// Return projection offset.
		/// </summary>
		private Urho.Vector2 GetProjectionOffset ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetProjectionOffset (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Camera_GetUseReflection (IntPtr handle);

		/// <summary>
		/// Return whether is using reflection.
		/// </summary>
		private bool GetUseReflection ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetUseReflection (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Plane Camera_GetReflectionPlane (IntPtr handle);

		/// <summary>
		/// Return the reflection plane.
		/// </summary>
		private Urho.Plane GetReflectionPlane ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetReflectionPlane (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Camera_GetUseClipping (IntPtr handle);

		/// <summary>
		/// Return whether is using a custom clipping plane.
		/// </summary>
		private bool GetUseClipping ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetUseClipping (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Plane Camera_GetClipPlane (IntPtr handle);

		/// <summary>
		/// Return the custom clipping plane.
		/// </summary>
		private Urho.Plane GetClipPlane ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetClipPlane (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Camera_GetFlipVertical (IntPtr handle);

		/// <summary>
		/// Return vertical flipping mode.
		/// </summary>
		private bool GetFlipVertical ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetFlipVertical (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Camera_GetReverseCulling (IntPtr handle);

		/// <summary>
		/// Return whether to reverse culling; affected by vertical flipping and reflection.
		/// </summary>
		private bool GetReverseCulling ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetReverseCulling (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Camera_GetDistance (IntPtr handle, ref Urho.Vector3 worldPos);

		/// <summary>
		/// Return distance to position. In orthographic mode uses only Z coordinate.
		/// </summary>
		public float GetDistance (Urho.Vector3 worldPos)
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetDistance (handle, ref worldPos);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Camera_GetDistanceSquared (IntPtr handle, ref Urho.Vector3 worldPos);

		/// <summary>
		/// Return squared distance to position. In orthographic mode uses only Z coordinate.
		/// </summary>
		public float GetDistanceSquared (Urho.Vector3 worldPos)
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetDistanceSquared (handle, ref worldPos);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Camera_GetLodDistance (IntPtr handle, float distance, float scale, float bias);

		/// <summary>
		/// Return a scene node's LOD scaled distance.
		/// </summary>
		public float GetLodDistance (float distance, float scale, float bias)
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetLodDistance (handle, distance, scale, bias);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Quaternion Camera_GetFaceCameraRotation (IntPtr handle, ref Urho.Vector3 position, ref Urho.Quaternion rotation, FaceCameraMode mode, float minAngle);

		/// <summary>
		/// Return a world rotation for facing a camera on certain axes based on the existing world rotation.
		/// </summary>
		public Quaternion GetFaceCameraRotation (Urho.Vector3 position, Urho.Quaternion rotation, FaceCameraMode mode, float minAngle)
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetFaceCameraRotation (handle, ref position, ref rotation, mode, minAngle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Matrix3x4 Camera_GetEffectiveWorldTransform (IntPtr handle);

		/// <summary>
		/// Get effective world transform for matrix and frustum calculations including reflection but excluding node scaling.
		/// </summary>
		private Matrix3x4 GetEffectiveWorldTransform ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetEffectiveWorldTransform (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Camera_IsProjectionValid (IntPtr handle);

		/// <summary>
		/// Return if projection parameters are valid for rendering and raycasting.
		/// </summary>
		private bool IsProjectionValid ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_IsProjectionValid (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetAspectRatioInternal (IntPtr handle, float aspectRatio);

		/// <summary>
		/// Set aspect ratio without disabling the "auto aspect ratio" mode. Called internally by View.
		/// </summary>
		public void SetAspectRatioInternal (float aspectRatio)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetAspectRatioInternal (handle, aspectRatio);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetOrthoSizeAttr (IntPtr handle, float orthoSize);

		/// <summary>
		/// Set orthographic size attribute without forcing the aspect ratio.
		/// </summary>
		public void SetOrthoSizeAttr (float orthoSize)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetOrthoSizeAttr (handle, orthoSize);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetReflectionPlaneAttr (IntPtr handle, ref Urho.Vector4 value);

		/// <summary>
		/// Set reflection plane attribute.
		/// </summary>
		public void SetReflectionPlaneAttr (Urho.Vector4 value)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetReflectionPlaneAttr (handle, ref value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Vector4 Camera_GetReflectionPlaneAttr (IntPtr handle);

		/// <summary>
		/// Return reflection plane attribute.
		/// </summary>
		private Vector4 GetReflectionPlaneAttr ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetReflectionPlaneAttr (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Camera_SetClipPlaneAttr (IntPtr handle, ref Urho.Vector4 value);

		/// <summary>
		/// Set clipping plane attribute.
		/// </summary>
		public void SetClipPlaneAttr (Urho.Vector4 value)
		{
			Runtime.ValidateRefCounted (this);
			Camera_SetClipPlaneAttr (handle, ref value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Vector4 Camera_GetClipPlaneAttr (IntPtr handle);

		/// <summary>
		/// Return clipping plane attribute.
		/// </summary>
		private Vector4 GetClipPlaneAttr ()
		{
			Runtime.ValidateRefCounted (this);
			return Camera_GetClipPlaneAttr (handle);
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		[Preserve]
		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return near clip distance. If a custom projection matrix is in use, is calculated from it instead of the value assigned with SetNearClip().
		/// Or
		/// Set near clip distance.
		/// </summary>
		public float NearClip {
			get {
				return GetNearClip ();
			}
			set {
				SetNearClip (value);
			}
		}

		/// <summary>
		/// Return far clip distance. If a custom projection matrix is in use, is calculated from it instead of the value assigned with SetFarClip().
		/// Or
		/// Set far clip distance.
		/// </summary>
		public float FarClip {
			get {
				return GetFarClip ();
			}
			set {
				SetFarClip (value);
			}
		}

		/// <summary>
		/// Return vertical field of view in degrees.
		/// Or
		/// Set vertical field of view in degrees.
		/// </summary>
		public float Fov {
			get {
				return GetFov ();
			}
			set {
				SetFov (value);
			}
		}

		/// <summary>
		/// Return skew.
		/// Or
		/// Set skew
		/// </summary>
		public float Skew {
			get {
				return GetSkew ();
			}
			set {
				SetSkew (value);
			}
		}

		/// <summary>
		/// Return orthographic mode size.
		/// Or
		/// Set orthographic mode view uniform size.
		/// </summary>
		public float OrthoSize {
			get {
				return GetOrthoSize ();
			}
			set {
				SetOrthoSize (value);
			}
		}

		/// <summary>
		/// Return aspect ratio.
		/// Or
		/// Set aspect ratio manually. Disables the auto aspect ratio -mode.
		/// </summary>
		public float AspectRatio {
			get {
				return GetAspectRatio ();
			}
			set {
				SetAspectRatio (value);
			}
		}

		/// <summary>
		/// Return fill mode.
		/// Or
		/// Set polygon fill mode to use when rendering a scene.
		/// </summary>
		public FillMode FillMode {
			get {
				return GetFillMode ();
			}
			set {
				SetFillMode (value);
			}
		}

		/// <summary>
		/// Return zoom.
		/// Or
		/// Set zoom.
		/// </summary>
		public float Zoom {
			get {
				return GetZoom ();
			}
			set {
				SetZoom (value);
			}
		}

		/// <summary>
		/// Return LOD bias.
		/// Or
		/// Set LOD bias.
		/// </summary>
		public float LodBias {
			get {
				return GetLodBias ();
			}
			set {
				SetLodBias (value);
			}
		}

		/// <summary>
		/// Return view mask.
		/// Or
		/// Set view mask. Will be and'ed with object's view mask to see if the object should be rendered.
		/// </summary>
		public uint ViewMask {
			get {
				return GetViewMask ();
			}
			set {
				SetViewMask (value);
			}
		}

		/// <summary>
		/// Return view override flags.
		/// Or
		/// Set view override flags.
		/// </summary>
		public ViewOverrideFlags ViewOverrideFlags {
			get {
				return (ViewOverrideFlags)GetViewOverrideFlags ();
			}
			set {
				SetViewOverrideFlags ((uint)value);
			}
		}

		/// <summary>
		/// Return orthographic flag.
		/// Or
		/// Set orthographic mode enabled/disabled.
		/// </summary>
		public bool Orthographic {
			get {
				return IsOrthographic ();
			}
			set {
				SetOrthographic (value);
			}
		}

		/// <summary>
		/// Return auto aspect ratio flag.
		/// Or
		/// Set automatic aspect ratio based on viewport dimensions. Enabled by default.
		/// </summary>
		public bool AutoAspectRatio {
			get {
				return GetAutoAspectRatio ();
			}
			set {
				SetAutoAspectRatio (value);
			}
		}

		/// <summary>
		/// Return projection offset.
		/// Or
		/// Set projection offset. It needs to be calculated as (offset in pixels) / (viewport dimensions.)
		/// </summary>
		public Urho.Vector2 ProjectionOffset {
			get {
				return GetProjectionOffset ();
			}
			set {
				SetProjectionOffset (value);
			}
		}

		/// <summary>
		/// Return whether is using reflection.
		/// Or
		/// Set reflection mode.
		/// </summary>
		public bool UseReflection {
			get {
				return GetUseReflection ();
			}
			set {
				SetUseReflection (value);
			}
		}

		/// <summary>
		/// Return the reflection plane.
		/// Or
		/// Set reflection plane in world space for reflection mode.
		/// </summary>
		public Urho.Plane ReflectionPlane {
			get {
				return GetReflectionPlane ();
			}
			set {
				SetReflectionPlane (value);
			}
		}

		/// <summary>
		/// Return whether is using a custom clipping plane.
		/// Or
		/// Set whether to use a custom clip plane.
		/// </summary>
		public bool UseClipping {
			get {
				return GetUseClipping ();
			}
			set {
				SetUseClipping (value);
			}
		}

		/// <summary>
		/// Return the custom clipping plane.
		/// Or
		/// Set custom clipping plane in world space.
		/// </summary>
		public Urho.Plane ClipPlane {
			get {
				return GetClipPlane ();
			}
			set {
				SetClipPlane (value);
			}
		}

		/// <summary>
		/// Return vertical flipping mode.
		/// Or
		/// Set vertical flipping mode. Called internally by View to resolve OpenGL / Direct3D9 rendertarget sampling differences.
		/// </summary>
		public bool FlipVertical {
			get {
				return GetFlipVertical ();
			}
			set {
				SetFlipVertical (value);
			}
		}

		/// <summary>
		/// Return projection matrix. It's in D3D convention with depth range 0 - 1.
		/// </summary>
		public Matrix4 Projection {
			get {
				return GetProjection ();
			}
		}

		/// <summary>
		/// Return frustum in world space.
		/// </summary>
		public Urho.Frustum Frustum {
			get {
				return GetFrustum ();
			}
		}

		/// <summary>
		/// Return projection matrix converted to API-specific format for use as a shader parameter.
		/// </summary>
		public Matrix4 GPUProjection {
			get {
				return GetGPUProjection ();
			}
		}

		/// <summary>
		/// Return view matrix.
		/// </summary>
		public Urho.Matrix3x4 View {
			get {
				return GetView ();
			}
		}

		/// <summary>
		/// Return half view size.
		/// </summary>
		public float HalfViewSize {
			get {
				return GetHalfViewSize ();
			}
		}

		/// <summary>
		/// Return frustum in view space.
		/// </summary>
		public Frustum ViewSpaceFrustum {
			get {
				return GetViewSpaceFrustum ();
			}
		}

		/// <summary>
		/// Return whether to reverse culling; affected by vertical flipping and reflection.
		/// </summary>
		public bool ReverseCulling {
			get {
				return GetReverseCulling ();
			}
		}

		/// <summary>
		/// Get effective world transform for matrix and frustum calculations including reflection but excluding node scaling.
		/// </summary>
		public Matrix3x4 EffectiveWorldTransform {
			get {
				return GetEffectiveWorldTransform ();
			}
		}

		/// <summary>
		/// Return if projection parameters are valid for rendering and raycasting.
		/// </summary>
		public bool ProjectionValid {
			get {
				return IsProjectionValid ();
			}
		}

		/// <summary>
		/// Return reflection plane attribute.
		/// </summary>
		public Vector4 ReflectionPlaneAttr {
			get {
				return GetReflectionPlaneAttr ();
			}
		}

		/// <summary>
		/// Return clipping plane attribute.
		/// </summary>
		public Vector4 ClipPlaneAttr {
			get {
				return GetClipPlaneAttr ();
			}
		}
	}
}
