json.array!(@permisos) do |permiso|
  json.extract! permiso, :id, :titulo
  json.url permiso_url(permiso, format: :json)
end
