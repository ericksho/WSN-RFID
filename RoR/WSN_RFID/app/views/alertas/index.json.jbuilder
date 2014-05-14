json.array!(@alertas) do |alerta|
  json.extract! alerta, :id, :desconectada
  json.url alerta_url(alerta, format: :json)
end
