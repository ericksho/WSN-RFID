class Articulo < ActiveRecord::Base
	has_many :lecturas
	has_many :atributos
end
