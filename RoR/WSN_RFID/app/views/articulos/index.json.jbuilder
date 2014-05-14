json.array!(@articulos) do |articulo|
  json.extract! articulo, :id, :rfid, :estado
  json.url articulo_url(articulo, format: :json)
end
