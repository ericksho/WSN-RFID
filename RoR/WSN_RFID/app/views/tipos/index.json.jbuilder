json.array!(@tipos) do |tipo|
  json.extract! tipo, :id, :valor
  json.url tipo_url(tipo, format: :json)
end
