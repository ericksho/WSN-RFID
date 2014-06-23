class LectoresExtraInfo < ActiveRecord::Migration
	def change
		add_column :lectors, :nombre, :string
		Lector.each do |l|
			l.nombre = "lector-#{l.id}"
			l.save
		end
	end
end
