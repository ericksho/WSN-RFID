class Articulo < ActiveRecord::Base
	has_many :lecturas
	has_many :atributos
	
	belongs_to :persona
	belongs_to :vehiculo

	def self.getRFIDList
		Articulo.uniq.pluck(:rfid).sort
	end

	def self.getUPRList
		Articulo.uniq.pluck(:upr).sort
	end
end
