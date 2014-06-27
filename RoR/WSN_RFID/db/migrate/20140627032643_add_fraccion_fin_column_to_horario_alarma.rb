class AddFraccionFinColumnToHorarioAlarma < ActiveRecord::Migration
  def change
    add_column :horario_alarmas, :fraccion_fin, :integer
  end
end
