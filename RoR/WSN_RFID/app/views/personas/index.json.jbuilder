json.array!(@personas) do |persona|
  json.extract! persona, :id, :nombre, :apellido, :rut, :email, :celular, :fecha_nacimiento, :cargo
  json.url persona_url(persona, format: :json)
end
