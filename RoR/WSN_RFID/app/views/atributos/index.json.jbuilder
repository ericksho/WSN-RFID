json.array!(@atributos) do |atributo|
  json.extract! atributo, :id, :nombre_at, :valor, :tipo_variable
  json.url atributo_url(atributo, format: :json)
end
