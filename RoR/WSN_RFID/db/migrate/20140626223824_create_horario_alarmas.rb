class CreateHorarioAlarmas < ActiveRecord::Migration
  def change
    create_table :horario_alarmas do |t|
      t.integer :hora_inicio
      t.integer :hora_fin
      t.string :motivo

      t.timestamps
    end
  end
end
