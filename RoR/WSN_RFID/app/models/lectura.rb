class Lectura < ActiveRecord::Base
	belongs_to :articulo
	belongs_to :lector
	has_many :alertas
end
