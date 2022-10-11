obs = obslua

function on_event(event)
	if event == obs.OBS_FRONTEND_EVENT_STREAMING_STARTED then
		os.execute("start WebhookSenderForOBS.exe start")
	elseif event == obs.OBS_FRONTEND_EVENT_STREAMING_STOPPED then
		os.execute("start WebhookSenderForOBS.exe stop")
	end
end

function script_description()
	return "При старте/окончании стрима, об этом узнает дискорд"
end

function script_load(settings)
	obs.obs_frontend_add_event_callback(on_event)
end