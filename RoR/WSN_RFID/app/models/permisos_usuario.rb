class PermisosUsuario < ActiveRecord::Base
	belongs_to :permiso
	belongs_to :usuario
end
