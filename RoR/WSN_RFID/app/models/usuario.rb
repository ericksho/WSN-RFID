class Usuario < ActiveRecord::Base
	has_many :permisos, through: :permisos_usuarios
	has_many :permisos_usuarios
end
