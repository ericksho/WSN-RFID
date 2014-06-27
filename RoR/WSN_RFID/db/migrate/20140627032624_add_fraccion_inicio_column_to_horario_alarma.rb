class AddFraccionInicioColumnToHorarioAlarma < ActiveRecord::Migration
  def change
    add_column :horario_alarmas, :fraccion_inicio, :integer
  end
end
