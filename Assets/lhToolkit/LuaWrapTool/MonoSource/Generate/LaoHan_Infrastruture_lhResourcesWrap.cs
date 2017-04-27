﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LaoHan.Infrastruture.ulua;

public class LaoHan_Infrastruture_lhResourcesWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LaoHan.Infrastruture.lhResources), typeof(System.Object));
		L.RegFunction("GetInstance", GetInstance);
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("LoadBytes", LoadBytes);
		L.RegFunction("LoadText", LoadText);
		L.RegFunction("LoadStream", LoadStream);
		L.RegFunction("CopyDirectory", CopyDirectory);
		L.RegFunction("DeleteDirectory", DeleteDirectory);
		L.RegFunction("CreateDirectory", CreateDirectory);
		L.RegFunction("DirectoryExits", DirectoryExits);
		L.RegFunction("DeleteFile", DeleteFile);
		L.RegFunction("CopyFile", CopyFile);
		L.RegFunction("FileExists", FileExists);
		L.RegFunction("WriteAllBytes", WriteAllBytes);
		L.RegFunction("WriteAllText", WriteAllText);
		L.RegFunction("Load", Load);
		L.RegFunction("Destroy", Destroy);
		L.RegFunction("GetFileRealPath", GetFileRealPath);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInstance(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			LaoHan.Infrastruture.lhResources o = LaoHan.Infrastruture.lhResources.GetInstance();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LaoHan.Infrastruture.lhResources obj = (LaoHan.Infrastruture.lhResources)ToLua.CheckObject(L, 1, typeof(LaoHan.Infrastruture.lhResources));
			obj.Dispose();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadBytes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			byte[] o = LaoHan.Infrastruture.lhResources.LoadBytes(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadText(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				string o = LaoHan.Infrastruture.lhResources.LoadText(arg0);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(System.Text.Encoding)))
			{
				string arg0 = ToLua.ToString(L, 1);
				System.Text.Encoding arg1 = (System.Text.Encoding)ToLua.ToObject(L, 2);
				string o = LaoHan.Infrastruture.lhResources.LoadText(arg0, arg1);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: LaoHan.Infrastruture.lhResources.LoadText");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadStream(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			string arg0 = ToLua.CheckString(L, 1);
			System.IO.FileMode arg1 = (System.IO.FileMode)ToLua.CheckObject(L, 2, typeof(System.IO.FileMode));
			System.IO.FileAccess arg2 = (System.IO.FileAccess)ToLua.CheckObject(L, 3, typeof(System.IO.FileAccess));
			System.IO.Stream o = LaoHan.Infrastruture.lhResources.LoadStream(arg0, arg1, arg2);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CopyDirectory(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			LaoHan.Infrastruture.lhResources.CopyDirectory(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DeleteDirectory(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			LaoHan.Infrastruture.lhResources.DeleteDirectory(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateDirectory(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			LaoHan.Infrastruture.lhResources.CreateDirectory(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DirectoryExits(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = LaoHan.Infrastruture.lhResources.DirectoryExits(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DeleteFile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			LaoHan.Infrastruture.lhResources.DeleteFile(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CopyFile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			LaoHan.Infrastruture.lhResources.CopyFile(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FileExists(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = LaoHan.Infrastruture.lhResources.FileExists(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteAllBytes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			byte[] arg1 = ToLua.CheckByteBuffer(L, 2);
			LaoHan.Infrastruture.lhResources.WriteAllBytes(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteAllText(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			LaoHan.Infrastruture.lhResources.WriteAllText(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Load(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(System.Action<UnityEngine.Object>)))
			{
				string arg0 = ToLua.ToString(L, 1);
				System.Action<UnityEngine.Object> arg1 = null;
				LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

				if (funcType2 != LuaTypes.LUA_TFUNCTION)
				{
					 arg1 = (System.Action<UnityEngine.Object>)ToLua.ToObject(L, 2);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 2);
					arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.Object>), func) as System.Action<UnityEngine.Object>;
				}

				LaoHan.Infrastruture.lhResources.Load(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(System.Action<UnityEngine.Object>), typeof(char)))
			{
				string arg0 = ToLua.ToString(L, 1);
				System.Action<UnityEngine.Object> arg1 = null;
				LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

				if (funcType2 != LuaTypes.LUA_TFUNCTION)
				{
					 arg1 = (System.Action<UnityEngine.Object>)ToLua.ToObject(L, 2);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 2);
					arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.Object>), func) as System.Action<UnityEngine.Object>;
				}

				char arg2 = (char)LuaDLL.lua_tonumber(L, 3);
				LaoHan.Infrastruture.lhResources.Load(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(string[]), typeof(System.Action<int,string,UnityEngine.Object>), typeof(System.Action)))
			{
				string[] arg0 = ToLua.CheckStringArray(L, 1);
				System.Action<int,string,UnityEngine.Object> arg1 = null;
				LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

				if (funcType2 != LuaTypes.LUA_TFUNCTION)
				{
					 arg1 = (System.Action<int,string,UnityEngine.Object>)ToLua.ToObject(L, 2);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 2);
					arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<int,string,UnityEngine.Object>), func) as System.Action<int,string,UnityEngine.Object>;
				}

				System.Action arg2 = null;
				LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

				if (funcType3 != LuaTypes.LUA_TFUNCTION)
				{
					 arg2 = (System.Action)ToLua.ToObject(L, 3);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 3);
					arg2 = DelegateFactory.CreateDelegate(typeof(System.Action), func) as System.Action;
				}

				LaoHan.Infrastruture.lhResources.Load(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(string), typeof(string), typeof(System.Action<UnityEngine.Object>)))
			{
				string arg0 = ToLua.ToString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				string arg2 = ToLua.ToString(L, 3);
				System.Action<UnityEngine.Object> arg3 = null;
				LuaTypes funcType4 = LuaDLL.lua_type(L, 4);

				if (funcType4 != LuaTypes.LUA_TFUNCTION)
				{
					 arg3 = (System.Action<UnityEngine.Object>)ToLua.ToObject(L, 4);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 4);
					arg3 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.Object>), func) as System.Action<UnityEngine.Object>;
				}

				LaoHan.Infrastruture.lhResources.Load(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: LaoHan.Infrastruture.lhResources.Load");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Destroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Object));
			LaoHan.Infrastruture.lhResources.DestroyReference(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFileRealPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = LaoHan.Infrastruture.lhResources.GetFileRealPath(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
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
}

