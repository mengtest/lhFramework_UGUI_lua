﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LaoHan.Infrastruture.ulua;

public class UnityEngine_TimeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Time), typeof(System.Object));
		L.RegFunction("New", _CreateUnityEngine_TimeWrap);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("time", get_time, null);
		L.RegVar("timeSinceLevelLoad", get_timeSinceLevelLoad, null);
		L.RegVar("deltaTime", get_deltaTime, null);
		L.RegVar("fixedTime", get_fixedTime, null);
		L.RegVar("unscaledTime", get_unscaledTime, null);
		L.RegVar("unscaledDeltaTime", get_unscaledDeltaTime, null);
		L.RegVar("fixedDeltaTime", get_fixedDeltaTime, set_fixedDeltaTime);
		L.RegVar("maximumDeltaTime", get_maximumDeltaTime, set_maximumDeltaTime);
		L.RegVar("smoothDeltaTime", get_smoothDeltaTime, null);
		L.RegVar("timeScale", get_timeScale, set_timeScale);
		L.RegVar("frameCount", get_frameCount, null);
		L.RegVar("renderedFrameCount", get_renderedFrameCount, null);
		L.RegVar("realtimeSinceStartup", get_realtimeSinceStartup, null);
		L.RegVar("captureFramerate", get_captureFramerate, set_captureFramerate);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_TimeWrap(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Time obj = new UnityEngine.Time();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Time.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_time(IntPtr L)
	{
		LuaDLL.lua_pushnumber(L, UnityEngine.Time.time);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_timeSinceLevelLoad(IntPtr L)
	{
		LuaDLL.lua_pushnumber(L, UnityEngine.Time.timeSinceLevelLoad);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_deltaTime(IntPtr L)
	{
		LuaDLL.lua_pushnumber(L, UnityEngine.Time.deltaTime);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fixedTime(IntPtr L)
	{
		LuaDLL.lua_pushnumber(L, UnityEngine.Time.fixedTime);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_unscaledTime(IntPtr L)
	{
		LuaDLL.lua_pushnumber(L, UnityEngine.Time.unscaledTime);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_unscaledDeltaTime(IntPtr L)
	{
		LuaDLL.lua_pushnumber(L, UnityEngine.Time.unscaledDeltaTime);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fixedDeltaTime(IntPtr L)
	{
		LuaDLL.lua_pushnumber(L, UnityEngine.Time.fixedDeltaTime);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maximumDeltaTime(IntPtr L)
	{
		LuaDLL.lua_pushnumber(L, UnityEngine.Time.maximumDeltaTime);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_smoothDeltaTime(IntPtr L)
	{
		LuaDLL.lua_pushnumber(L, UnityEngine.Time.smoothDeltaTime);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_timeScale(IntPtr L)
	{
		LuaDLL.lua_pushnumber(L, UnityEngine.Time.timeScale);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_frameCount(IntPtr L)
	{
		LuaDLL.lua_pushinteger(L, UnityEngine.Time.frameCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderedFrameCount(IntPtr L)
	{
		LuaDLL.lua_pushinteger(L, UnityEngine.Time.renderedFrameCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_realtimeSinceStartup(IntPtr L)
	{
		LuaDLL.lua_pushnumber(L, UnityEngine.Time.realtimeSinceStartup);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_captureFramerate(IntPtr L)
	{
		LuaDLL.lua_pushinteger(L, UnityEngine.Time.captureFramerate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fixedDeltaTime(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Time.fixedDeltaTime = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maximumDeltaTime(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Time.maximumDeltaTime = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_timeScale(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Time.timeScale = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_captureFramerate(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Time.captureFramerate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

