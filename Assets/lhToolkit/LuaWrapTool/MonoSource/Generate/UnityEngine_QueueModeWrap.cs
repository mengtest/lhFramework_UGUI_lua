﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LaoHan.Infrastruture.ulua;

public class UnityEngine_QueueModeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.QueueMode));
		L.RegVar("CompleteOthers", get_CompleteOthers, null);
		L.RegVar("PlayNow", get_PlayNow, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CompleteOthers(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.QueueMode.CompleteOthers);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PlayNow(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.QueueMode.PlayNow);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.QueueMode o = (UnityEngine.QueueMode)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

