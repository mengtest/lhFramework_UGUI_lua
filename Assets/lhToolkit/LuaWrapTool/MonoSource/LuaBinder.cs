﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using UnityEngine;
using LaoHan.Infrastruture.ulua;

public static class LuaBinder
{
	public static void Bind(LuaState L)
	{
		float t = Time.realtimeSinceStartup;
		L.BeginModule(null);
		L.BeginModule("LaoHan");
		L.BeginModule("Control");
		LaoHan_Control_lhControlNetworkWrap.Register(L);
		L.EndModule();
		L.BeginModule("Infrastruture");
		LaoHan_Infrastruture_lhDebugWrap.Register(L);
		LaoHan_Infrastruture_lhResourcesWrap.Register(L);
		LaoHan_Infrastruture_lhObjectManagerWrap.Register(L);
		LaoHan_Infrastruture_EPoolTypeWrap.Register(L);
		LaoHan_Infrastruture_lhSceneManagerWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("UnityEngine");
		UnityEngine_DebugWrap.Register(L);
		UnityEngine_ComponentWrap.Register(L);
		UnityEngine_MonoBehaviourWrap.Register(L);
		UnityEngine_GameObjectWrap.Register(L);
		UnityEngine_TransformWrap.Register(L);
		UnityEngine_TrackedReferenceWrap.Register(L);
		UnityEngine_ApplicationWrap.Register(L);
		UnityEngine_PhysicsWrap.Register(L);
		UnityEngine_ColliderWrap.Register(L);
		UnityEngine_TimeWrap.Register(L);
		UnityEngine_TextureWrap.Register(L);
		UnityEngine_Texture2DWrap.Register(L);
		UnityEngine_ShaderWrap.Register(L);
		UnityEngine_MaterialWrap.Register(L);
		UnityEngine_RendererWrap.Register(L);
		UnityEngine_WWWWrap.Register(L);
		UnityEngine_ScreenWrap.Register(L);
		UnityEngine_CameraWrap.Register(L);
		UnityEngine_CameraClearFlagsWrap.Register(L);
		UnityEngine_AudioClipWrap.Register(L);
		UnityEngine_AudioSourceWrap.Register(L);
		UnityEngine_AssetBundleWrap.Register(L);
		UnityEngine_ParticleSystemWrap.Register(L);
		UnityEngine_AsyncOperationWrap.Register(L);
		UnityEngine_LightWrap.Register(L);
		UnityEngine_LightTypeWrap.Register(L);
		UnityEngine_SleepTimeoutWrap.Register(L);
		UnityEngine_AnimatorWrap.Register(L);
		UnityEngine_InputWrap.Register(L);
		UnityEngine_KeyCodeWrap.Register(L);
		UnityEngine_SkinnedMeshRendererWrap.Register(L);
		UnityEngine_SpaceWrap.Register(L);
		UnityEngine_TextAssetWrap.Register(L);
		UnityEngine_RectTransformWrap.Register(L);
		L.BeginModule("SceneManagement");
		UnityEngine_SceneManagement_LoadSceneModeWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("System");
		L.RegFunction("Action", System_Action);
		L.RegFunction("Action_bool", System_Action_bool);
		L.RegFunction("Action_int_string_UnityEngine_Object", System_Action_int_string_UnityEngine_Object);
		L.RegFunction("Action_UnityEngine_Object", System_Action_UnityEngine_Object);
		L.RegFunction("Action_UnityEngine_GameObject", System_Action_UnityEngine_GameObject);
		L.RegFunction("Action_float", System_Action_float);
		L.EndModule();
		L.EndModule();
		L.BeginPreLoad();
		L.AddPreLoad("UnityEngine.MeshRenderer", LuaOpen_UnityEngine_MeshRendererWrap, typeof(UnityEngine.MeshRenderer));
		L.AddPreLoad("UnityEngine.ParticleEmitter", LuaOpen_UnityEngine_ParticleEmitterWrap, typeof(UnityEngine.ParticleEmitter));
		L.AddPreLoad("UnityEngine.ParticleAnimator", LuaOpen_UnityEngine_ParticleAnimatorWrap, typeof(UnityEngine.ParticleAnimator));
		L.AddPreLoad("UnityEngine.BoxCollider", LuaOpen_UnityEngine_BoxColliderWrap, typeof(UnityEngine.BoxCollider));
		L.AddPreLoad("UnityEngine.MeshCollider", LuaOpen_UnityEngine_MeshColliderWrap, typeof(UnityEngine.MeshCollider));
		L.AddPreLoad("UnityEngine.SphereCollider", LuaOpen_UnityEngine_SphereColliderWrap, typeof(UnityEngine.SphereCollider));
		L.AddPreLoad("UnityEngine.CapsuleCollider", LuaOpen_UnityEngine_CapsuleColliderWrap, typeof(UnityEngine.CapsuleCollider));
		L.AddPreLoad("UnityEngine.Animation", LuaOpen_UnityEngine_AnimationWrap, typeof(UnityEngine.Animation));
		L.AddPreLoad("UnityEngine.AnimationClip", LuaOpen_UnityEngine_AnimationClipWrap, typeof(UnityEngine.AnimationClip));
		L.AddPreLoad("UnityEngine.AnimationState", LuaOpen_UnityEngine_AnimationStateWrap, typeof(UnityEngine.AnimationState));
		L.AddPreLoad("UnityEngine.RenderTexture", LuaOpen_UnityEngine_RenderTextureWrap, typeof(UnityEngine.RenderTexture));
		L.AddPreLoad("UnityEngine.Rigidbody", LuaOpen_UnityEngine_RigidbodyWrap, typeof(UnityEngine.Rigidbody));
		L.EndPreLoad();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_bool(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<bool>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_int_string_UnityEngine_Object(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<int,string,UnityEngine.Object>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_UnityEngine_Object(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.Object>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_UnityEngine_GameObject(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.GameObject>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_float(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<float>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_MeshRendererWrap(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_MeshRendererWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_ParticleEmitterWrap(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_ParticleEmitterWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_ParticleAnimatorWrap(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_ParticleAnimatorWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_BoxColliderWrap(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_BoxColliderWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_MeshColliderWrap(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_MeshColliderWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_SphereColliderWrap(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_SphereColliderWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_CapsuleColliderWrap(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_CapsuleColliderWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_AnimationWrap(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_AnimationWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_AnimationClipWrap(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_AnimationClipWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_AnimationStateWrap(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_AnimationStateWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_RenderTextureWrap(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_RenderTextureWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_RigidbodyWrap(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_RigidbodyWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
