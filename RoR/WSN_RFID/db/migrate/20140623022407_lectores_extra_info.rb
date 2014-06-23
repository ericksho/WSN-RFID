class LectoresExtraInfo < ActiveRecord::Migration
	def change
		add_column :lectors, :nombre, :string
		Lectors.each do |L|
			L.nombre = "lector-#{L.id}"
			L.save
		end
	end
end
