obs = obslua
local OnStart
local OnFinish
function on_event(event)
	if event == obs.OBS_FRONTEND_EVENT_STREAMING_STARTED and OnStart then
		os.execute("start WebhookSenderForOBS.exe start")
	elseif event == obs.OBS_FRONTEND_EVENT_STREAMING_STOPPED and OnFinish then
		os.execute("start WebhookSenderForOBS.exe stop")
	end
end

function script_description()
	return "При старте стрима, оповестит дискорд"
end

function script_load(settings)
	obs.obs_frontend_add_event_callback(on_event)
end

function script_defaults(settings)
	obs.obs_data_set_default_bool(settings, "OnStart", true)
	obs.obs_data_set_default_bool(settings, "OnStop", false)
  end
  
  function script_properties()
	props = obs.obs_properties_create()
	obs.obs_properties_add_bool(props, "OnStart", "Уведомление в начале")
	obs.obs_properties_add_bool(props, "OnStop", "Уведомление в конце")
	return props
  end
  
  function script_update(settings)
	OnStart = obs.obs_data_get_bool(settings, "OnStart")
	OnFinish = obs.obs_data_get_bool(settings, "OnFinish")
  end