class Lectura < ActiveRecord::Base
	belongs_to :articulo
	belongs_to :lector
	has_many :alertas
	after_save { |record| record.revisarAlerta}

	def revisarAlerta
		horarios = HorarioAlarma.all
		time = Time.now

		horarios.each do |horario|
			within_day = true

			if horario.hora_inicio > horario.hora_fin
				within_day = false
			end

			if within_day 
				if time.hour > horario.hora_inicio && time.hour < horario.hora_fin
					alerta = Alerta.new(desconectada: false, lectura_id: self.id)
					alerta.save
				end
			else
				if  time.hour > horario.hora_inicio || time.hour < horario.hora_fin
					alerta = Alerta.new(desconectada: false, lectura_id: self.id)
					alerta.save
				end
			end
		end
	end
end
