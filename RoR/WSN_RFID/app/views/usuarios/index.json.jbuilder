json.array!(@usuarios) do |usuario|
  json.extract! usuario, :id, :status, :password, :email, :nombre, :apellido
  json.url usuario_url(usuario, format: :json)
end
