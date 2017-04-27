--------------------------------------------------------------------------------
--      Copyright (c) 2015 , 蒙占志(topameng) topameng@gmail.com
--      All rights reserved.
--      Use, modification and distribution are subject to the "MIT License"
--------------------------------------------------------------------------------

local create = coroutine.create
local running = coroutine.running
local resume = coroutine.resume
local yield = coroutine.yield
local error = error

local comap = {}
coroutine={
    start=function(f, ...)	
	    local co = create(f)
	
	    if running() == nil then
		    local flag, msg = resume(co, ...)
	
		    if not flag then		
			    msg = debug.traceback(co, msg)					
			    error(msg)				
		    end					
	    else
		    local args = {...}
		    local timer = nil
		
		    local action = function()												
			    local flag, msg = resume(co, unpack(args))			
	
			    if not flag then				
				    timer:Stop()				
				    msg = debug.traceback(co, msg)				
				    error(msg)						
			    end		
		    end
			
		    timer = FrameTimer.new(action, 0, 1)
		    comap[co] = timer
		    timer:Start()		
	    end

	    return co
    end,
    wait=function(t, co, ...)
	    local args = {...}
	    co = co or running()		
	    local timer = nil
		
	    local action = function()				
		    local flag, msg = resume(co, unpack(args))
		
		    if not flag then	
			    timer:Stop()			
			    msg = debug.traceback(co, msg)							
			    error(msg)			
			    return
		    end
	    end
	
	    timer = CoTimer.new(action, t, 1)
	    comap[co] = timer	
	    timer:Start()
	    return yield()
    end,
    step=function(t, co, ...)
	    local args = {...}
	    co = co or running()		
	    local timer = nil
	
	    local action = function()						
		    local flag, msg = resume(co, unpack(args))
	
		    if not flag then							
			    timer:Stop()					
			    msg = debug.traceback(co, msg)					
			    error(msg)
			    return	
		    end		
	    end
				
	    timer = FrameTimer.new(action, t or 1, 1)
	    comap[co] = timer
	    timer:Start()
	    return yield()
    end,
    www=function(www, co)			
	    co = co or running()			
	    local timer = nil			
			
	    local action = function()				
		    if not www.isDone then		
			    return		
		    end		
				
		    timer:Stop()		
		    local flag, msg = resume(co)		
			
		    if not flag then						
			    msg = debug.traceback(co, msg)						
			    error(msg)			
			    return			
		    end				
	    end		
					
	    timer = FrameTimer.new(action, 1, -1)	
	    comap[co] = timer	
 	    timer:Start()
 	    return yield()
    end,
    stop=function(co)
 	    local timer = comap[co]

 	    if timer ~= nil then
 		    comap[co] = nil
 		    timer:Stop() 		
 	    end
    end

}