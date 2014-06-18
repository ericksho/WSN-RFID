class Vehiculo < ActiveRecord::Base

	def self.getMarcaList
		Vehiculo.uniq.pluck(:marca).sort
	end

	def self.getColorList
		Vehiculo.uniq.pluck(:color).sort
	end

	def self.getTipoCombustibleList
		Vehiculo.uniq.pluck(:tipo_combustible).sort
	end

	def self.getCategoriaList
		Vehiculo.uniq.pluck(:categoria).sort
	end
end
