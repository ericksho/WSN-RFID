json.array!(@paquetes) do |paquete|
  json.extract! paquete, :id, :nombre, :valores_dez, :tipo
  json.url paquete_url(paquete, format: :json)
end
