class Articulo < ActiveRecord::Base
	has_many :lecturas
	has_many :atributos
	
	belongs_to :persona
	belongs_to :vehiculo
end
