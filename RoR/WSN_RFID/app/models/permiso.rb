class Permiso < ActiveRecord::Base
	has_many :usuarios, through: :permisos_usuarios
	has_many :permisos_usuarios
end
