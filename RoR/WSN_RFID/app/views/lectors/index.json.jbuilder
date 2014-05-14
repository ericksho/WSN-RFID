json.array!(@lectors) do |lector|
  json.extract! lector, :id, :posicion
  json.url lector_url(lector, format: :json)
end
