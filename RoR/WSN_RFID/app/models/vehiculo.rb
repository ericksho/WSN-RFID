class Vehiculo < ActiveRecord::Base

	has_many :articulos

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

	def self.getNPuertasList
		Vehiculo.uniq.pluck(:n_puertas).sort
	end
end
