json.array!(@alerta) do |alertum|
  json.extract! alertum, :id, :desconectada
  json.url alertum_url(alertum, format: :json)
end
