json.array!(@vehiculos) do |vehiculo|
  json.extract! vehiculo, :id, :patente, :marca, :modelo, :anho, :color, :chasis, :n_motor, :kilometraje, :tipo_combustible, :es_4x4, :categoria, :n_puertas, :a_c, :gps, :disponible, :costo
  json.url vehiculo_url(vehiculo, format: :json)
end
