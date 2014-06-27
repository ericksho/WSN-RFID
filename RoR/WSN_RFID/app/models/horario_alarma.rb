class HorarioAlarma < ActiveRecord::Base
	validates :hora_inicio, :hora_fin, :fraccion_inicio, :fraccion_fin, :presence => {:message =>'Debe completar este campo'}
end
