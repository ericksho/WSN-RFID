class Lector < ActiveRecord::Base
	has_many :lecturas

	def self.getNombreList
		Lector.uniq.pluck(:nombre).sort
	end
end
