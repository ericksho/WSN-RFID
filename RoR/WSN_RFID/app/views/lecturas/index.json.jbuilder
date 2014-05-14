json.array!(@lecturas) do |lectura|
  json.extract! lectura, :id, :fecha
  json.url lectura_url(lectura, format: :json)
end
